using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BookReaderHttpBridge
{
    public class HttpToTcpBridge
    {
        private readonly HttpListener _httpListener;
        private readonly string _tcpServerHost;
        private readonly int _tcpServerPort;
        private readonly int _httpPort;

        public HttpToTcpBridge(int httpPort = 3000, string tcpHost = "localhost", int tcpPort = 8080)
        {
            _httpPort = httpPort;
            _tcpServerHost = tcpHost;
            _tcpServerPort = tcpPort;
            _httpListener = new HttpListener();
            _httpListener.Prefixes.Add($"http://localhost:{_httpPort}/");
        }

        public async Task StartAsync()
        {
            _httpListener.Start();
            Console.WriteLine($"HTTP Bridge running on http://localhost:{_httpPort}");
            Console.WriteLine($"Bridging to TCP server: {_tcpServerHost}:{_tcpServerPort}");
            Console.WriteLine("=====================================");

            while (_httpListener.IsListening)
            {
                try
                {
                    var context = await _httpListener.GetContextAsync();
                    _ = Task.Run(() => HandleRequestAsync(context));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private async Task HandleRequestAsync(HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;

            // Enable CORS
            response.Headers.Add("Access-Control-Allow-Origin", "*");
            response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
            response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");

            if (request.HttpMethod == "OPTIONS")
            {
                response.StatusCode = 200;
                response.Close();
                return;
            }

            try
            {
                // Forward request to TCP server
                using var tcpClient = new TcpClient();
                await tcpClient.ConnectAsync(_tcpServerHost, _tcpServerPort);
                var tcpStream = tcpClient.GetStream();

                // Read HTTP request body
                string requestBody = "";
                if (request.HasEntityBody)
                {
                    using var reader = new StreamReader(request.InputStream, request.ContentEncoding);
                    requestBody = await reader.ReadToEndAsync();
                }

                // Send to TCP server
                var requestBytes = Encoding.UTF8.GetBytes(requestBody);
                await tcpStream.WriteAsync(requestBytes, 0, requestBytes.Length);

                // Read response from TCP server
                var buffer = new byte[4096];
                var bytesRead = await tcpStream.ReadAsync(buffer, 0, buffer.Length);
                var responseText = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // Send HTTP response
                response.ContentType = "application/json";
                response.StatusCode = 200;
                var responseBytes = Encoding.UTF8.GetBytes(responseText);
                await response.OutputStream.WriteAsync(responseBytes, 0, responseBytes.Length);
                response.Close();

                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Bridged request: {request.HttpMethod} {request.Url?.AbsolutePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bridge error: {ex.Message}");
                response.StatusCode = 500;
                response.Close();
            }
        }

        public void Stop()
        {
            _httpListener?.Stop();
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            var httpPort = args.Length > 0 ? int.Parse(args[0]) : 3000;
            var tcpHost = args.Length > 1 ? args[1] : "localhost";
            var tcpPort = args.Length > 2 ? int.Parse(args[2]) : 8080;

            var bridge = new HttpToTcpBridge(httpPort, tcpHost, tcpPort);

            Console.CancelKeyPress += (sender, e) =>
            {
                e.Cancel = true;
                Console.WriteLine("\nStopping HTTP Bridge...");
                bridge.Stop();
                Environment.Exit(0);
            };

            try
            {
                await bridge.StartAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fatal error: {ex.Message}");
                Environment.Exit(1);
            }
        }
    }
}
