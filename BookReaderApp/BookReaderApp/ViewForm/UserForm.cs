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
namespace BookReaderApp.ViewForm
{
    public partial class UserForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private readonly int _userId;
        public UserForm(BookReaderDbContext context, int userId)
        {
            InitializeComponent();
            _context = context;
            _userId = userId;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // Initialize ComboBox for search
            kryptonComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            kryptonComboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //cmbSearchType.Items.Add("Tiêu đề"); // Title
            //cmbSearchType.Items.Add("Tác giả"); // Author
            //cmbSearchType.Items.Add("Thể loại"); // Category

            //// Set the default selected item if needed
            //cmbSearchType.SelectedIndex = 0;  // Default to "Tiêu đề"
            LoadBooks();
        }
        private void LoadBooks()
        {
            dgvBooks.DataSource = _context.Books
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
                dgvBooks.DataSource = null;
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

            dgvBooks.DataSource = filteredBooks
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


        private string DownloadBookFromGoogleDrive(string driveUrl, string bookTitle)
        {
            try
            {
                // Lấy fileId từ URL Google Drive
                string fileId = GetFileIdFromDriveUrl(driveUrl);

                // Đường dẫn lưu file cục bộ
                string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{bookTitle}.pdf");

                // Tải file từ Google Drive
                var driveHelper = new GoogleDriveHelper("credentials.json", "BookReaderApp");
                driveHelper.DownloadFile(fileId, savePath);

                MessageBox.Show($"File đã được tải xuống: {savePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            var uri = new Uri(driveUrl);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            return query["id"] ?? throw new InvalidOperationException("The 'id' parameter is missing in the Google Drive URL.");
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
            try
            {
                var bookReaderForm = new BookReaderForm(filePath, _context, book, _userId);
                bookReaderForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi đọc sách offline: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonButtonReadBook(object sender, EventArgs e)
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
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    // Kiểm tra xem người dùng muốn đọc online hay offline
                    var result = MessageBox.Show("Bạn muốn đọc sách online hay offline?", "Chọn chế độ đọc",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        // Đọc online
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
                        // Đọc offline
                        if (!string.IsNullOrEmpty(book.FilePath) && File.Exists(book.FilePath))
                        {
                            OpenBookOffline(book.FilePath, book);
                        }
                        else
                        {
                            // Hỏi người dùng có muốn tải sách về không
                            var downloadResult = MessageBox.Show("File sách chưa được tải về. Bạn có muốn tải sách về không?", "Tải sách",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (downloadResult == DialogResult.Yes)
                            {
                                if (!string.IsNullOrEmpty(book.DriveUrl))
                                {
                                    string savePath = DownloadBookFromGoogleDrive(book.DriveUrl, book.Title);
                                    OpenBookOffline(savePath, book);
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

        private void kryptonButtonAddToLib(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;

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
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;
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
    }
}
