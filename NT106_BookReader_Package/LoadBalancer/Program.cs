using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace LoadBalancer
{
    public class LoadBalancer
    {
        private readonly List<ServerInfo> _servers;
        private int _currentIndex = 0;
        private readonly TcpListener _listener;
        private readonly object _lock = new object();
        private bool _isRunning = false;

        public LoadBalancer()
        {
            _servers = new List<ServerInfo>
            {
                new ServerInfo { Host = "127.0.0.1", Port = 8081, Name = "Server1" },
                new ServerInfo { Host = "127.0.0.1", Port = 8082, Name = "Server2" },
                new ServerInfo { Host = "127.0.0.1", Port = 8083, Name = "Server3" }
            };
            _listener = new TcpListener(IPAddress.Any, 8080);
        }

        public async Task StartAsync()
        {
            _listener.Start();
            _isRunning = true;
            
            Console.WriteLine("=====================================");
            Console.WriteLine("    LOAD BALANCER STARTING");
            Console.WriteLine("=====================================");
            Console.WriteLine($"Load Balancer đang chạy trên port 8080");
            Console.WriteLine($"Thời gian khởi động: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine("Danh sách Backend Servers:");
            foreach (var server in _servers)
            {
                Console.WriteLine($"  - {server.Name}: {server.Host}:{server.Port}");
            }
            Console.WriteLine("=====================================");
            Console.WriteLine();

            while (_isRunning)
            {
                try
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    var clientEndpoint = client.Client.RemoteEndPoint?.ToString() ?? "Unknown";
                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Client connected: {clientEndpoint}");
                    
                    // Handle client in background
                    _ = Task.Run(() => HandleClientAsync(client, clientEndpoint));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error accepting client: {ex.Message}");
                }
            }
        }

        private async Task HandleClientAsync(TcpClient client, string clientEndpoint)
        {
            ServerInfo? selectedServer = null;
            TcpClient? serverClient = null;
            
            try
            {
                selectedServer = GetNextServer();
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Routing {clientEndpoint} → {selectedServer.Name} ({selectedServer.Host}:{selectedServer.Port})");
                
                serverClient = new TcpClient();
                await serverClient.ConnectAsync(selectedServer.Host, selectedServer.Port);
                
                var clientStream = client.GetStream();
                var serverStream = serverClient.GetStream();
                
                // Proxy data bidirectionally
                var task1 = ProxyDataAsync(clientStream, serverStream, $"{clientEndpoint} → {selectedServer.Name}");
                var task2 = ProxyDataAsync(serverStream, clientStream, $"{selectedServer.Name} → {clientEndpoint}");
                
                await Task.WhenAny(task1, task2);
                
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Connection closed: {clientEndpoint} ↔ {selectedServer.Name}");
            }
            catch (Exception ex)
            {
                var serverName = selectedServer?.Name ?? "Unknown";
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Error routing {clientEndpoint} → {serverName}: {ex.Message}");
            }
            finally
            {
                client.Close();
                serverClient?.Close();
            }
        }

        private async Task ProxyDataAsync(NetworkStream from, NetworkStream to, string direction)
        {
            try
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                
                while ((bytesRead = await from.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await to.WriteAsync(buffer, 0, bytesRead);
                    await to.FlushAsync();
                    
                    // Optional: Log data transfer
                    // Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Proxied {bytesRead} bytes: {direction}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Proxy error ({direction}): {ex.Message}");
            }
        }

        private ServerInfo GetNextServer()
        {
            lock (_lock)
            {
                var server = _servers[_currentIndex];
                _currentIndex = (_currentIndex + 1) % _servers.Count;
                return server;
            }
        }

        public void Stop()
        {
            _isRunning = false;
            _listener?.Stop();
        }
    }

    public class ServerInfo
    {
        public required string Host { get; set; }
        public required int Port { get; set; }
        public required string Name { get; set; }
        public bool IsHealthy { get; set; } = true;
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            var loadBalancer = new LoadBalancer();
            
            // Handle Ctrl+C gracefully
            Console.CancelKeyPress += (sender, e) =>
            {
                e.Cancel = true;
                Console.WriteLine("\nStopping Load Balancer...");
                loadBalancer.Stop();
                Environment.Exit(0);
            };

            try
            {
                await loadBalancer.StartAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fatal error: {ex.Message}");
                Environment.Exit(1);
            }
        }
    }
}
