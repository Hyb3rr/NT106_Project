using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookReaderServer
{
    public class BookReaderServer
    {
        private TcpListener? _listener;
        private readonly List<ClientInfo> _clients = new();
        private readonly int _port;
        private readonly string _serverName;
        private bool _isRunning = false;

        public class ClientInfo
        {
            public required TcpClient Client { get; set; }
            public required string ClientId { get; set; }
            public required string EndPoint { get; set; }
            public DateTime ConnectedAt { get; set; }
            public int? UserId { get; set; }
            public string? Username { get; set; }
        }

        public BookReaderServer(int port = 8080, string serverName = "BookReaderServer")
        {
            _port = port;
            _serverName = serverName;
        }

        public async Task StartAsync()
        {
            _listener = new TcpListener(IPAddress.Any, _port);
            _listener.Start();
            _isRunning = true;

            Console.WriteLine($"[{_serverName}] Server đang chạy trên port {_port}");
            Console.WriteLine($"[{_serverName}] Thời gian khởi động: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine("=====================================");

            while (_isRunning)
            {
                try
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    var clientInfo = new ClientInfo
                    {
                        Client = client,
                        ClientId = Guid.NewGuid().ToString("N")[..8],
                        EndPoint = client.Client.RemoteEndPoint?.ToString(),
                        ConnectedAt = DateTime.Now
                    };

                    _clients.Add(clientInfo);
                    Console.WriteLine($"[{_serverName}] Client mới kết nối:");
                    Console.WriteLine($"  ID: {clientInfo.ClientId}");
                    Console.WriteLine($"  Endpoint: {clientInfo.EndPoint}");
                    Console.WriteLine($"  Thời gian: {clientInfo.ConnectedAt:HH:mm:ss}");
                    Console.WriteLine($"  Tổng clients: {_clients.Count}");
                    Console.WriteLine("-------------------------------------");

                    // Xử lý client trong task riêng
                    _ = Task.Run(() => HandleClientAsync(clientInfo));
                }
                catch (Exception ex) when (_isRunning)
                {
                    Console.WriteLine($"[{_serverName}] Lỗi chấp nhận client: {ex.Message}");
                }
            }
        }

        private async Task HandleClientAsync(ClientInfo clientInfo)
        {
            var stream = clientInfo.Client.GetStream();
            var buffer = new byte[4096];

            try
            {
                while (clientInfo.Client.Connected && _isRunning)
                {
                    var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    var message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"[{_serverName}] Nhận từ {clientInfo.ClientId}: {message}");

                    // Xử lý tin nhắn
                    await ProcessMessageAsync(clientInfo, message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{_serverName}] Lỗi xử lý client {clientInfo.ClientId}: {ex.Message}");
            }
            finally
            {
                _clients.Remove(clientInfo);
                clientInfo.Client.Close();
                Console.WriteLine($"[{_serverName}] Client {clientInfo.ClientId} đã ngắt kết nối");
                Console.WriteLine($"  Tổng clients còn lại: {_clients.Count}");
                Console.WriteLine("-------------------------------------");
            }
        }

        private async Task ProcessMessageAsync(ClientInfo sender, string message)
        {
            try
            {
                var jsonDoc = JsonDocument.Parse(message);
                var messageType = jsonDoc.RootElement.GetProperty("Type").GetString();
                var data = jsonDoc.RootElement.GetProperty("Data");

                switch (messageType)
                {
                    case "BookAdded":
                        await HandleBookAddedAsync(sender, data);
                        break;
                    case "LibraryUpdated":
                        await HandleLibraryUpdatedAsync(sender, data);
                        break;
                    case "BookmarkUpdated":
                        await HandleBookmarkUpdatedAsync(sender, data);
                        break;
                    case "RatingUpdated":
                        await HandleRatingUpdatedAsync(sender, data);
                        break;
                    case "ChatMessage":
                        await HandleChatMessageAsync(sender, data);
                        break;
                    default:
                        Console.WriteLine($"[{_serverName}] Loại tin nhắn không xác định: {messageType}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{_serverName}] Lỗi xử lý tin nhắn: {ex.Message}");
            }
        }

        private async Task HandleBookAddedAsync(ClientInfo sender, JsonElement data)
        {
            var bookId = data.GetProperty("BookId").GetInt32();
            var title = data.GetProperty("Title").GetString();
            var author = data.GetProperty("Author").GetString();

            Console.WriteLine($"[{_serverName}] Sách mới được thêm: {title} - {author}");

            var notification = new
            {
                Type = "BookAddedNotification",
                Data = new
                {
                    BookId = bookId,
                    Title = title,
                    Author = author,
                    AddedBy = sender.ClientId,
                    Timestamp = DateTime.Now
                }
            };

            await BroadcastMessageAsync(JsonSerializer.Serialize(notification), sender);
        }

        private async Task HandleLibraryUpdatedAsync(ClientInfo sender, JsonElement data)
        {
            var userId = data.GetProperty("UserId").GetInt32();
            var bookId = data.GetProperty("BookId").GetInt32();
            var action = data.GetProperty("Action").GetString();

            Console.WriteLine($"[{_serverName}] Thư viện cập nhật: User {userId} {action} sách {bookId}");

            var notification = new
            {
                Type = "LibraryUpdateNotification",
                Data = new
                {
                    UserId = userId,
                    BookId = bookId,
                    Action = action,
                    UpdatedBy = sender.ClientId,
                    Timestamp = DateTime.Now
                }
            };

            await BroadcastMessageAsync(JsonSerializer.Serialize(notification), sender);
        }

        private async Task HandleBookmarkUpdatedAsync(ClientInfo sender, JsonElement data)
        {
            var userId = data.GetProperty("UserId").GetInt32();
            var bookId = data.GetProperty("BookId").GetInt32();
            var pageNumber = data.GetProperty("PageNumber").GetInt32();

            Console.WriteLine($"[{_serverName}] Bookmark cập nhật: User {userId} đánh dấu trang {pageNumber} sách {bookId}");

            var notification = new
            {
                Type = "BookmarkUpdateNotification",
                Data = new
                {
                    UserId = userId,
                    BookId = bookId,
                    PageNumber = pageNumber,
                    UpdatedBy = sender.ClientId,
                    Timestamp = DateTime.Now
                }
            };

            await BroadcastMessageAsync(JsonSerializer.Serialize(notification), sender);
        }

        private async Task HandleRatingUpdatedAsync(ClientInfo sender, JsonElement data)
        {
            var userId = data.GetProperty("UserId").GetInt32();
            var bookId = data.GetProperty("BookId").GetInt32();
            var rating = data.GetProperty("Rating").GetInt32();

            Console.WriteLine($"[{_serverName}] Đánh giá mới: User {userId} đánh giá {rating} sao cho sách {bookId}");

            var notification = new
            {
                Type = "RatingUpdateNotification",
                Data = new
                {
                    UserId = userId,
                    BookId = bookId,
                    Rating = rating,
                    UpdatedBy = sender.ClientId,
                    Timestamp = DateTime.Now
                }
            };

            await BroadcastMessageAsync(JsonSerializer.Serialize(notification), sender);
        }

        private async Task HandleChatMessageAsync(ClientInfo sender, JsonElement data)
        {
            var userId = data.GetProperty("UserId").GetInt32();
            var username = data.GetProperty("Username").GetString();
            var messageText = data.GetProperty("Message").GetString();
            var roomId = data.TryGetProperty("RoomId", out var roomIdProp) ? roomIdProp.GetInt32() : (int?)null;

            Console.WriteLine($"[{_serverName}] Chat: {username} ({userId}): {messageText}");

            var notification = new
            {
                Type = "ChatMessageNotification",
                Data = new
                {
                    UserId = userId,
                    Username = username,
                    Message = messageText,
                    RoomId = roomId,
                    SenderId = sender.ClientId,
                    Timestamp = DateTime.Now
                }
            };

            await BroadcastMessageAsync(JsonSerializer.Serialize(notification), sender);
        }

        private async Task BroadcastMessageAsync(string message, ClientInfo sender)
        {
            var data = Encoding.UTF8.GetBytes(message);
            var clientsToRemove = new List<ClientInfo>();

            foreach (var clientInfo in _clients.ToList())
            {
                if (clientInfo != sender && clientInfo.Client.Connected)
                {
                    try
                    {
                        await clientInfo.Client.GetStream().WriteAsync(data, 0, data.Length);
                    }
                    catch
                    {
                        clientsToRemove.Add(clientInfo);
                    }
                }
            }

            // Xóa client bị ngắt kết nối
            foreach (var clientInfo in clientsToRemove)
            {
                _clients.Remove(clientInfo);
                Console.WriteLine($"[{_serverName}] Loại bỏ client bị ngắt kết nối: {clientInfo.ClientId}");
            }
        }

        public void Stop()
        {
            _isRunning = false;
            _listener?.Stop();

            foreach (var clientInfo in _clients.ToList())
            {
                clientInfo.Client.Close();
            }
            _clients.Clear();

            Console.WriteLine($"[{_serverName}] Server đã dừng");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"\n=== {_serverName} Status ===");
            Console.WriteLine($"Port: {_port}");
            Console.WriteLine($"Clients hiện tại: {_clients.Count}");
            Console.WriteLine($"Thời gian: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

            if (_clients.Any())
            {
                Console.WriteLine("\nDanh sách clients:");
                foreach (var client in _clients)
                {
                    var duration = DateTime.Now - client.ConnectedAt;
                    Console.WriteLine($"  {client.ClientId} - {client.EndPoint} ({duration.TotalMinutes:F0}m)");
                }
            }
            Console.WriteLine("=======================\n");
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            var port = args.Length > 0 ? int.Parse(args[0]) : 8080;
            var serverName = args.Length > 1 ? args[1] : "BookReaderServer";

            var server = new BookReaderServer(port, serverName);

            Console.WriteLine("BookReader Server Starting...");
            Console.WriteLine("Press 'q' to quit, 's' to show status");

            // Bắt đầu server trong task riêng
            _ = Task.Run(() => server.StartAsync());

            // Xử lý input từ console
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.KeyChar == 'q' || key.KeyChar == 'Q')
                {
                    server.Stop();
                    break;
                }
                else if (key.KeyChar == 's' || key.KeyChar == 'S')
                {
                    server.ShowStatus();
                }
            }
        }
    }
}
