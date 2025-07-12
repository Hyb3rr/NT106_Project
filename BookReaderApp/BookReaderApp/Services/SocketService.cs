using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BookReaderApp.Models;

namespace BookReaderApp.Services
{
    public class SocketService
    {
        private TcpClient? _client;
        private NetworkStream? _stream;
        private readonly string _serverAddress;
        private readonly int _serverPort;
        private bool _isConnected = false;

        public event Action<string>? OnMessageReceived;
        public event Action<string>? OnConnectionStatusChanged;

        public SocketService(string serverAddress = "localhost", int serverPort = 8080)
        {
            _serverAddress = serverAddress;
            _serverPort = serverPort;
        }

        public async Task ConnectAsync()
        {
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(_serverAddress, _serverPort);
                _stream = _client.GetStream();
                _isConnected = true;

                OnConnectionStatusChanged?.Invoke($"Kết nối thành công đến server: {_serverAddress}:{_serverPort}");

                // Bắt đầu lắng nghe tin nhắn từ server
                _ = Task.Run(ListenForMessagesAsync);
            }
            catch (Exception ex)
            {
                _isConnected = false;
                OnConnectionStatusChanged?.Invoke($"Không thể kết nối server: {ex.Message}");
                throw new Exception($"Không thể kết nối server: {ex.Message}");
            }
        }

        private async Task ListenForMessagesAsync()
        {
            var buffer = new byte[4096];

            try
            {
                while (_client != null && _client.Connected)
                {
                    var bytesRead = await _stream!.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    var message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    OnMessageReceived?.Invoke(message);
                }
            }
            catch (Exception ex)
            {
                OnConnectionStatusChanged?.Invoke($"Mất kết nối: {ex.Message}");
            }
            finally
            {
                _isConnected = false;
            }
        }

        public async Task SendBookAddedAsync(Book book)
        {
            var message = new
            {
                Type = "BookAdded",
                Data = new
                {
                    book.BookId,
                    book.Title,
                    book.Author,
                    book.CategoryId,
                    book.FilePath,
                    book.CoverImage
                }
            };

            await SendMessageAsync(JsonSerializer.Serialize(message));
        }

        public async Task SendUserLibraryUpdatedAsync(int userId, int bookId, string action = "Added")
        {
            var message = new
            {
                Type = "LibraryUpdated",
                Data = new
                {
                    UserId = userId,
                    BookId = bookId,
                    Action = action,
                    Timestamp = DateTime.Now
                }
            };

            await SendMessageAsync(JsonSerializer.Serialize(message));
        }

        public async Task SendBookmarkUpdatedAsync(int userId, int bookId, int pageNumber)
        {
            var message = new
            {
                Type = "BookmarkUpdated",
                Data = new
                {
                    UserId = userId,
                    BookId = bookId,
                    PageNumber = pageNumber,
                    Timestamp = DateTime.Now
                }
            };

            await SendMessageAsync(JsonSerializer.Serialize(message));
        }

        public async Task SendRatingUpdatedAsync(int userId, int bookId, int rating)
        {
            var message = new
            {
                Type = "RatingUpdated",
                Data = new
                {
                    UserId = userId,
                    BookId = bookId,
                    Rating = rating,
                    Timestamp = DateTime.Now
                }
            };

            await SendMessageAsync(JsonSerializer.Serialize(message));
        }

        public async Task SendChatMessageAsync(int userId, string username, string message, int? roomId = null)
        {
            var chatMessage = new
            {
                Type = "ChatMessage",
                Data = new
                {
                    UserId = userId,
                    Username = username,
                    Message = message,
                    RoomId = roomId,
                    Timestamp = DateTime.Now
                }
            };

            await SendMessageAsync(JsonSerializer.Serialize(chatMessage));
        }

        private async Task SendMessageAsync(string message)
        {
            if (_stream != null && _isConnected)
            {
                try
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    await _stream.WriteAsync(data, 0, data.Length);
                }
                catch (Exception ex)
                {
                    OnConnectionStatusChanged?.Invoke($"Lỗi gửi tin nhắn: {ex.Message}");
                    _isConnected = false;
                }
            }
        }

        public bool IsConnected => _isConnected && _client != null && _client.Connected;

        public void Disconnect()
        {
            try
            {
                _isConnected = false;
                _stream?.Close();
                _client?.Close();
                OnConnectionStatusChanged?.Invoke("Đã ngắt kết nối");
            }
            catch (Exception ex)
            {
                OnConnectionStatusChanged?.Invoke($"Lỗi ngắt kết nối: {ex.Message}");
            }
        }

        public void Dispose()
        {
            Disconnect();
        }
    }
}
