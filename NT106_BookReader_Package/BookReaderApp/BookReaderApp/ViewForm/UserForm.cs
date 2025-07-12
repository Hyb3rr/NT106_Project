using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookReaderApp.Data;
using BookReaderApp.Models;
using BookReaderApp.Services;
using Krypton.Toolkit;
using System.IO;
using System.Text.Json;

namespace BookReaderApp.ViewForm
{
    public partial class UserForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private readonly int _userId;
        private readonly SocketService _socketService;

        public UserForm(BookReaderDbContext context, int userId)
        {
            InitializeComponent();
            _context = context;
            _userId = userId;
            _socketService = new SocketService();

            // Đăng ký sự kiện
            _socketService.OnMessageReceived += HandleServerMessage;
            _socketService.OnConnectionStatusChanged += HandleConnectionStatusChanged;
        }

        private void HandleServerMessage(string message)
        {
            // Xử lý tin nhắn từ server trong UI thread
            if (InvokeRequired)
            {
                Invoke(new Action<string>(HandleServerMessage), message);
                return;
            }

            try
            {
                var jsonDoc = JsonDocument.Parse(message);
                var messageType = jsonDoc.RootElement.GetProperty("Type").GetString();

                switch (messageType)
                {
                    case "BookAddedNotification":
                        HandleBookAddedNotification(jsonDoc.RootElement.GetProperty("Data"));
                        break;
                    case "LibraryUpdateNotification":
                        HandleLibraryUpdateNotification(jsonDoc.RootElement.GetProperty("Data"));
                        break;
                    case "BookmarkUpdateNotification":
                        HandleBookmarkUpdateNotification(jsonDoc.RootElement.GetProperty("Data"));
                        break;
                    case "RatingUpdateNotification":
                        HandleRatingUpdateNotification(jsonDoc.RootElement.GetProperty("Data"));
                        break;
                    case "ChatMessageNotification":
                        HandleChatMessageNotification(jsonDoc.RootElement.GetProperty("Data"));
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error handling server message: {ex.Message}");
            }
        }

        private void HandleBookAddedNotification(JsonElement data)
        {
            var title = data.GetProperty("Title").GetString();
            var author = data.GetProperty("Author").GetString();

            // Refresh book list
            LoadBooks();

            // Show notification
            MessageBox.Show($"Sách mới được thêm: {title} - {author}", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HandleLibraryUpdateNotification(JsonElement data)
        {
            var userId = data.GetProperty("UserId").GetInt32();
            var bookId = data.GetProperty("BookId").GetInt32();
            var action = data.GetProperty("Action").GetString();

            if (userId != _userId) // Chỉ hiển thị thông báo từ user khác
            {
                var book = _context.Books.Find(bookId);
                if (book != null)
                {
                    Console.WriteLine($"User {userId} {action} sách: {book.Title}");
                }
            }
        }

        private void HandleBookmarkUpdateNotification(JsonElement data)
        {
            var userId = data.GetProperty("UserId").GetInt32();
            var bookId = data.GetProperty("BookId").GetInt32();
            var pageNumber = data.GetProperty("PageNumber").GetInt32();

            if (userId != _userId)
            {
                var book = _context.Books.Find(bookId);
                if (book != null)
                {
                    Console.WriteLine($"User {userId} đánh dấu trang {pageNumber} trong sách: {book.Title}");
                }
            }
        }

        private void HandleRatingUpdateNotification(JsonElement data)
        {
            var userId = data.GetProperty("UserId").GetInt32();
            var bookId = data.GetProperty("BookId").GetInt32();
            var rating = data.GetProperty("Rating").GetInt32();

            if (userId != _userId)
            {
                var book = _context.Books.Find(bookId);
                if (book != null)
                {
                    Console.WriteLine($"User {userId} đánh giá {rating} sao cho sách: {book.Title}");
                }
            }
        }

        private void HandleChatMessageNotification(JsonElement data)
        {
            var username = data.GetProperty("Username").GetString();
            var message = data.GetProperty("Message").GetString();

            // Có thể hiển thị trong chat panel hoặc thông báo
            Console.WriteLine($"Chat từ {username}: {message}");
        }

        private void HandleConnectionStatusChanged(string status)
        {
            // Xử lý trong UI thread
            if (InvokeRequired)
            {
                Invoke(new Action<string>(HandleConnectionStatusChanged), status);
                return;
            }

            // Cập nhật status bar hoặc hiển thị thông báo
            Console.WriteLine($"Socket Status: {status}");
        }

        private async void ConnectToServer()
        {
            try
            {
                await _socketService.ConnectAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối server: {ex.Message}", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // Initialize ComboBox for search
            kryptonComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            kryptonComboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            LoadBooks();
            LoadUserAvatar();

            // Kết nối socket
            ConnectToServer();
        }
        private void LoadUserAvatar()
        {
            try
            {
                // Tìm thông tin người dùng từ database
                var user = _context.Users.Find(_userId);

                if (user != null)
                {
                    // Hiển thị avatar người dùng
                    if (!string.IsNullOrEmpty(user.Avatar) && File.Exists(user.Avatar))
                    {
                        kryptonPictureAvatar.Image = Image.FromFile(user.Avatar);
                        kryptonPictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                        //kryptonPictureAvatar.BorderStyle = BorderStyle.FixedSingle;
                        //kryptonPictureAvatar.BackColor = Color.Transparent; // Đặt nền trong suốt
                    }
                    //else
                    //{
                    //    // Hiển thị avatar mặc định nếu không có ảnh
                    //    // Giả sử bạn đã thêm ảnh mặc định vào Resources
                    //    kryptonPictureAvatar.Image = Properties.Resources.default_avatar;
                    //    kryptonPictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    //}
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine($"Error loading avatar: {ex.Message}");
            }
        }
        private void LoadBooks()
        {
            kryptonDataGridViewLibrary.DataSource = _context.Books
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Author,
                    Category = b.Category != null ? b.Category.CategoryName : "Unknown",
                    b.PublishedDate
                })
                .ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = kryptonTextBox1.Text.Trim().ToLower();
            string searchType = kryptonComboBox1.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(searchType))
            {
                // If no search type is selected, do nothing or handle accordingly
                kryptonDataGridViewLibrary.DataSource = null;
                return;
            }

            var filteredBooks = _context.Books.AsQueryable();

            switch (searchType)
            {
                case "Tiêu đề":
                    filteredBooks = filteredBooks.Where(b => b.Title.ToLower().Contains(keyword));
                    break;
                case "Tác giả":
                    filteredBooks = filteredBooks.Where(b => b.Author.ToLower().Contains(keyword));
                    break;
                case "Thể loại":
                    filteredBooks = filteredBooks.Where(b => b.Category != null && b.Category.CategoryName.ToLower().Contains(keyword));
                    break;
            }

            kryptonDataGridViewLibrary.DataSource = filteredBooks
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Author,
                    Category = b.Category != null ? b.Category.CategoryName : "Unknown",
                    b.PublishedDate
                })
                .ToList();
        }

        private void kryptonSearch_TextChanged(object sender, EventArgs e)
        {
            //string keyword = kryptonTextBox1.Text.Trim().ToLower();
            //string searchType = kryptonComboBox1.SelectedItem?.ToString() ?? "Tiêu đề";

            //var filteredBooks = _context.Books.AsQueryable();

            //if (!string.IsNullOrWhiteSpace(keyword))
            //{
            //    switch (searchType)
            //    {
            //        case "Tiêu đề":
            //            filteredBooks = filteredBooks.Where(b => b.Title.ToLower().Contains(keyword));
            //            break;
            //        case "Tác giả":
            //            filteredBooks = filteredBooks.Where(b => b.Author.ToLower().Contains(keyword));
            //            break;
            //        case "Thể loại":
            //            filteredBooks = filteredBooks.Where(b => b.Category != null && b.Category.CategoryName.ToLower().Contains(keyword));
            //            break;
            //    }
            //}

            //kryptonDataGridViewLibrary.DataSource = filteredBooks
            //    .Select(b => new
            //    {
            //        b.BookId,
            //        b.Title,
            //        b.Author,
            //        Category = b.Category != null ? b.Category.CategoryName : "Unknown",
            //        b.PublishedDate
            //    })
            //    .ToList();
            string keyword = kryptonTextBox1.Text.Trim().ToLower();

            var filteredBooks = _context.Books.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                filteredBooks = filteredBooks.Where(b =>
                    b.Title.ToLower().Contains(keyword) ||
                    b.Author.ToLower().Contains(keyword) ||
                    (b.Category != null && b.Category.CategoryName.ToLower().Contains(keyword)) ||
                    b.PublishedDate.ToString().ToLower().Contains(keyword)
                );
            }

            kryptonDataGridViewLibrary.DataSource = filteredBooks
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Author,
                    Category = b.Category != null ? b.Category.CategoryName : "Unknown",
                    b.PublishedDate
                })
                .ToList();
            // After binding, change the column headers
            if (kryptonDataGridViewLibrary.Columns.Contains("BookId"))
            {
                kryptonDataGridViewLibrary.Columns["BookId"].HeaderText = "ID";
            }
            if (kryptonDataGridViewLibrary.Columns.Contains("Title"))
            {
                kryptonDataGridViewLibrary.Columns["Title"].HeaderText = "Tựa sách";
            }
            if (kryptonDataGridViewLibrary.Columns.Contains("Author"))
            {
                kryptonDataGridViewLibrary.Columns["Author"].HeaderText = "Tác giả";
            }
            if (kryptonDataGridViewLibrary.Columns.Contains("Category"))
            {
                kryptonDataGridViewLibrary.Columns["Category"].HeaderText = "Thể loại";
            }
            if (kryptonDataGridViewLibrary.Columns.Contains("PublishedDate"))
            {
                kryptonDataGridViewLibrary.Columns["PublishedDate"].HeaderText = "Ngày phát hành";
            }
        }
        // Thêm hàm kiểm tra file PDF hợp lệ
        private bool IsValidPdfFile(string filePath)
        {
            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // Kiểm tra 4 byte đầu của file PDF (%PDF)
                    byte[] header = new byte[4];
                    fileStream.Read(header, 0, 4);

                    string headerString = System.Text.Encoding.ASCII.GetString(header);
                    return headerString == "%PDF";
                }
            }
            catch
            {
                return false;
            }
        }


        private async Task<string> DownloadBookFromGoogleDrive(string driveUrl, string bookTitle)
        {
            // try
            // {
            //     // Lấy fileId từ URL Google Drive
            //     string fileId = GetFileIdFromDriveUrl(driveUrl);

            //     // Đường dẫn lưu file cục bộ
            //     string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{bookTitle}.pdf");

            //     // Tải file từ Google Drive
            //     var driveHelper = new GoogleDriveHelper("credentials.json", "BookReaderApp");
            //      driveHelper.DownloadFile(fileId, savePath);

            //     MessageBox.Show($"File đã được tải xuống: {savePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //     return savePath;
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show($"Đã xảy ra lỗi khi tải file từ Google Drive: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     return string.Empty;
            // }
            try
            {
                // Lấy fileId từ URL Google Drive
                string fileId = GetFileIdFromDriveUrl(driveUrl);

                // Đường dẫn lưu file cục bộ
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "book");

                // Tạo thư mục nếu chưa tồn tại
                Directory.CreateDirectory(downloadsPath);

                // Làm sạch tên file (loại bỏ ký tự không hợp lệ)
                string cleanTitle = string.Join("_", bookTitle.Split(Path.GetInvalidFileNameChars()));
                string savePath = Path.Combine(downloadsPath, $"{cleanTitle}.pdf");

                // Xóa file cũ nếu tồn tại
                if (File.Exists(savePath))
                {
                    File.Delete(savePath);
                }

                // Tải file từ Google Drive
                var driveHelper = new DriveServiceHelper();
                await driveHelper.DownloadFileAsync(fileId, savePath);

                // Kiểm tra file đã được tải thành công chưa
                if (!File.Exists(savePath))
                {
                    throw new Exception("File không được tải xuống thành công.");
                }

                // Kiểm tra kích thước file
                var fileInfo = new FileInfo(savePath);
                if (fileInfo.Length == 0)
                {
                    File.Delete(savePath);
                    throw new Exception("File tải về có kích thước 0 byte.");
                }

                // Kiểm tra file PDF hợp lệ
                if (!IsValidPdfFile(savePath))
                {
                    File.Delete(savePath);
                    throw new Exception("File tải về không phải PDF hợp lệ.");
                }

                MessageBox.Show($"File đã được tải xuống thành công: {savePath}\nKích thước: {fileInfo.Length / 1024} KB", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return savePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải file từ Google Drive: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        private string GetFileIdFromDriveUrl(string driveUrl)
        {
            // var uri = new Uri(driveUrl);
            // var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            // return query["id"] ?? throw new InvalidOperationException("The 'id' parameter is missing in the Google Drive URL.");

            // // Dạng 1: https://drive.google.com/file/d/FILE_ID/view
            // var match = System.Text.RegularExpressions.Regex.Match(driveUrl, @"\/file\/d\/([a-zA-Z0-9_-]+)");
            // if (match.Success)
            //     return match.Groups[1].Value;

            // // Dạng 2: https://drive.google.com/open?id=FILE_ID
            // var uri = new Uri(driveUrl);
            // var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            // if (!string.IsNullOrEmpty(query["id"]))
            //     return query["id"];

            // throw new InvalidOperationException("Không thể xác định fileId từ URL Google Drive.");
            try
            {
                Console.WriteLine($"Input URL: {driveUrl}");

                // Dạng 1: https://drive.google.com/file/d/FILE_ID/view
                var match = System.Text.RegularExpressions.Regex.Match(driveUrl, @"\/file\/d\/([a-zA-Z0-9_-]+)");
                if (match.Success)
                {
                    var fileId = match.Groups[1].Value;
                    Console.WriteLine($"Extracted fileId (pattern 1): {fileId}");
                    return fileId;
                }

                // Dạng 2: https://drive.google.com/open?id=FILE_ID
                var uri = new Uri(driveUrl);
                var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
                if (!string.IsNullOrEmpty(query["id"]))
                {
                    var fileId = query["id"];
                    Console.WriteLine($"Extracted fileId (pattern 2): {fileId}");
                    return fileId ?? throw new InvalidOperationException($"FileId is null from URL: {driveUrl}");
                }

                throw new InvalidOperationException($"Không thể xác định fileId từ URL: {driveUrl}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error extracting fileId: {ex.Message}");
                throw;
            }
        }
        private void OpenBookOnline(string driveUrl)
        {
            try
            {
                var onlineReaderForm = new OnlineReaderForm(driveUrl);
                onlineReaderForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi đọc sách online: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenBookOffline(string filePath, Book book)
        {
            // try
            // {
            //     var bookReaderForm = new BookReaderForm(filePath, _context, book, _userId);
            //     bookReaderForm.ShowDialog();
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show($"Đã xảy ra lỗi khi đọc sách offline: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
            try
            {
                // Kiểm tra file có tồn tại và có thể đọc được không
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra file có phải PDF hợp lệ không
                if (!IsValidPdfFile(filePath))
                {
                    MessageBox.Show("File PDF không hợp lệ hoặc bị hỏng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo form mới mỗi lần (không tái sử dụng)
                using (var bookReaderForm = new BookReaderForm(filePath, _context, book, _userId))
                {
                    bookReaderForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi đọc sách offline: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void kryptonButtonReadBook(object sender, EventArgs e)
        {
            //if (dgvBooks.SelectedRows.Count > 0)
            //{
            //    int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;
            //    var book = _context.Books.Find(bookId);

            //    if (book != null && !string.IsNullOrEmpty(book.FilePath))
            //    {
            //        var bookReaderForm = new BookReaderForm(book.FilePath);
            //        bookReaderForm.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không tìm thấy file sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn một sách để đọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            // if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            // {
            //     int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;
            //     var book = _context.Books.Find(bookId);

            //     if (book != null)
            //     {
            //         // Kiểm tra xem người dùng muốn đọc online hay offline
            //         var result = MessageBox.Show("Bạn muốn đọc sách online hay offline?", "Chọn chế độ đọc",
            //             MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //         if (result == DialogResult.Yes)
            //         {
            //             // Đọc online
            //             if (!string.IsNullOrEmpty(book.DriveUrl))
            //             {
            //                 OpenBookOnline(book.DriveUrl);
            //             }
            //             else
            //             {
            //                 MessageBox.Show("Không tìm thấy URL Google Drive của sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //             }
            //         }
            //         else if (result == DialogResult.No)
            //         {
            //             // Đọc offline
            //             if (!string.IsNullOrEmpty(book.FilePath) && File.Exists(book.FilePath))
            //             {
            //                 OpenBookOffline(book.FilePath, book);
            //             }
            //             else
            //             {
            //                 // Hỏi người dùng có muốn tải sách về không
            //                 var downloadResult = MessageBox.Show("File sách chưa được tải về. Bạn có muốn tải sách về không?", "Tải sách",
            //                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //                 if (downloadResult == DialogResult.Yes)
            //                 {
            //                     if (!string.IsNullOrEmpty(book.DriveUrl))
            //                     {
            //                         string savePath = DownloadBookFromGoogleDrive(book.DriveUrl, book.Title);
            //                         OpenBookOffline(savePath, book);
            //                     }
            //                     else
            //                     {
            //                         MessageBox.Show("Không tìm thấy URL Google Drive của sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                     }
            //                 }
            //             }
            //         }
            //     }
            //     else
            //     {
            //         MessageBox.Show("Không tìm thấy thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     }
            // }
            // else
            // {
            //     MessageBox.Show("Vui lòng chọn một sách để đọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // }
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    var result = MessageBox.Show("Bạn muốn đọc sách online hay offline?", "Chọn chế độ đọc",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        if (!string.IsNullOrEmpty(book.DriveUrl))
                        {
                            OpenBookOnline(book.DriveUrl);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy URL Google Drive của sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        if (!string.IsNullOrEmpty(book.FilePath) && File.Exists(book.FilePath))
                        {
                            OpenBookOffline(book.FilePath, book);
                        }
                        else
                        {
                            var downloadResult = MessageBox.Show("File sách chưa được tải về. Bạn có muốn tải sách về không?", "Tải sách",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (downloadResult == DialogResult.Yes)
                            {
                                if (!string.IsNullOrEmpty(book.DriveUrl))
                                {
                                    // SỬA: Thêm await vì hàm đã thành async
                                    string savePath = await DownloadBookFromGoogleDrive(book.DriveUrl, book.Title);
                                    if (!string.IsNullOrEmpty(savePath))
                                    {
                                        OpenBookOffline(savePath, book);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy URL Google Drive của sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để đọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void kryptonButtonAddToLib(object sender, EventArgs e)
        {
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;

                // Kiểm tra xem UserId có hợp lệ không
                if (!_context.Users.Any(u => u.UserId == _userId))
                {
                    MessageBox.Show("Người dùng không tồn tại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem sách đã có trong thư viện chưa
                var existingEntry = _context.UserLibraries
                    .FirstOrDefault(ul => ul.UserId == _userId && ul.BookId == bookId);

                if (existingEntry != null)
                {
                    MessageBox.Show("Sách này đã có trong thư viện của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Thêm sách vào thư viện
                _context.UserLibraries.Add(new UserLibrary
                {
                    UserId = _userId,
                    BookId = bookId,
                    AddedDate = DateTime.Now
                });

                try
                {
                    _context.SaveChanges();

                    // Gửi thông báo đến server
                    if (_socketService.IsConnected)
                    {
                        await _socketService.SendUserLibraryUpdatedAsync(_userId, bookId, "Added");
                    }

                    MessageBox.Show("Đã thêm sách vào thư viện của bạn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi thêm sách vào thư viện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để thêm vào thư viện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kryptonButtonViewDetailsClick(object sender, EventArgs e)
        {
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    var bookDetailForm = new BookDetailForm(book, _context, _userId);
                    bookDetailForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kryptonButtonOpenLib(object sender, EventArgs e)
        {
            var userLibraryForm = new UserLibraryForm(_context, _userId);
            userLibraryForm.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }


        private bool textCleared = false; // Step 1: Declare the flag

        private void kryptonTextBox1_Enter(object sender, EventArgs e) // Step 2: Use Enter event
        {
            if (!textCleared)
            {
                kryptonTextBox1.Text = "";
                textCleared = true; // Step 3: Set the flag to true
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Tìm LoginForm trong các form đang mở
            LoginForm? existingLoginForm = null;

            foreach (Form form in Application.OpenForms)
            {
                if (form is LoginForm)
                {
                    existingLoginForm = (LoginForm)form;
                    break;
                }
            }

            if (existingLoginForm != null)
            {
                // Nếu đã có LoginForm, hiển thị nó
                existingLoginForm.Show();
            }
            else
            {
                // Nếu chưa có, tạo mới
                var loginForm = new LoginForm(_context);
                loginForm.Show();
            }

            // Đóng form hiện tại
            this.Hide();
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
            var chatMainForm = new ChatMainForm(_context, _userId);
            chatMainForm.Show();
        }

        private void kryptonDataGridViewLibrary_SelectionChanged(object sender, EventArgs e)
        {
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                try
                {
                    // Lấy BookId của dòng được chọn
                    int bookId = Convert.ToInt32(kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value);

                    // Tìm sách trong database
                    var book = _context.Books.Find(bookId);

                    if (book != null && !string.IsNullOrEmpty(book.CoverImage) && File.Exists(book.CoverImage))
                    {
                        // Hiển thị ảnh bìa sách
                        pictureBox2.Image = Image.FromFile(book.CoverImage);
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        //pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                    }
                    //else
                    //{
                    //    // Hiển thị ảnh mặc định nếu có
                    //    pictureBox2.Image = Properties.Resources.default_book_cover;
                    //    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    //}
                }
                catch (Exception)
                {
                    // Xóa ảnh trong trường hợp lỗi
                    pictureBox2.Image = null;
                }
            }
            else
            {
                // Xóa ảnh khi không có dòng nào được chọn
                pictureBox2.Image = null;
            }
        }

        private void kryptonPictureBox2_Click(object sender, EventArgs e)
        {
            // Tìm LoginForm trong các form đang mở
            LoginForm? existingLoginForm = null;

            foreach (Form form in Application.OpenForms)
            {
                if (form is LoginForm)
                {
                    existingLoginForm = (LoginForm)form;
                    break;
                }
            }

            if (existingLoginForm != null)
            {
                // Nếu đã có LoginForm, hiển thị nó
                existingLoginForm.Show();
            }
            else
            {
                // Nếu chưa có, tạo mới
                var loginForm = new LoginForm(_context);
                loginForm.Show();
            }

            // Đóng form hiện tại
            this.Hide();
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Ngắt kết nối socket khi đóng form
            _socketService?.Disconnect();
            base.OnFormClosing(e);
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cleanup resources
            _socketService?.Dispose();
        }
    }
}
