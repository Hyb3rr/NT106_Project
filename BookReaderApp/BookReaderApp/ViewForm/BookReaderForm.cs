using BookReaderApp.Data;
using BookReaderApp.Models;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using System.Drawing.Drawing2D;
using BookReaderApp.Services;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BookReaderApp.ViewForm
{
    public partial class BookReaderForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private readonly Book _book;
        private readonly int _userId;
        private PdfViewer _pdfViewer = null!; // Initialize with null-forgiving operator  
        private int _lastKnownPage = -1;
        private System.Windows.Forms.Timer _pageCheckTimer = null!;

        public BookReaderForm(string filePath, BookReaderDbContext context, Book book, int userId)
        {
            InitializeComponent();
            _context = context;
            _book = book;
            _userId = userId;
            panel2.Visible = true;
            // Kiểm tra file có tồn tại không  
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Tạo PdfViewer và thêm vào form  
            _pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill,
                ZoomMode = PdfViewerZoomMode.FitWidth
            };

            _pageCheckTimer = new System.Windows.Forms.Timer();
            _pageCheckTimer.Interval = 200; // Check every 200 ms (adjust as needed)
            _pageCheckTimer.Tick += PageCheckTimer_Tick;
            _pageCheckTimer.Start();

            //this.Controls.Add(_pdfViewer);
            kryptonPanel1.Controls.Add(_pdfViewer); // Thay đổi từ this.Controls.Add sang panel1.Controls.Add

            // Xử lý tất cả các trường hợp mở sách
            OpenBookWithFallback();
            ShowRandomImage();
            MakeRoundedPictureBox(kryptonPictureBox1);
        }


        private void MakeRoundedPictureBox(KryptonPictureBox picBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBox.Width - 1, picBox.Height - 1);
            picBox.Region = new Region(path);
        }

        private void ShowRandomImage()
        {
            // Create an array of only the specific images you want
            Image[] bannerImages = new Image[]
            {
                Properties.Resources.catread1,
                Properties.Resources.catread2,
                Properties.Resources.catread3,
                Properties.Resources.catread4,
                Properties.Resources.catread5,
                Properties.Resources.catread6,
                Properties.Resources.catread7
            };

            // Pick one at random
            Random rand = new Random();
            int index = rand.Next(bannerImages.Length);

            // Assign it to the PictureBox
            kryptonPictureBox1.Image = bannerImages[index];
        }

        private void PageCheckTimer_Tick(object? sender, EventArgs e)
        {
            if (_pdfViewer?.Document != null)
            {
                int currentPage = _pdfViewer.Renderer.Page;
                if (currentPage != _lastKnownPage)
                {
                    _lastKnownPage = currentPage;
                    UpdatePageLabel();
                }
            }
        }

        private void OpenBookWithFallback()
        {
            try
            {
                // TRƯỜNG HỢP 1 & 2: Có filepath
                if (!string.IsNullOrEmpty(_book.FilePath))
                {
                    if (File.Exists(_book.FilePath))
                    {
                        // TRƯỜNG HỢP 1: File tồn tại tại đường dẫn -> Mở trực tiếp
                        LoadPdf(_book.FilePath);
                        return;
                    }
                    else
                    {
                        // TRƯỜNG HỢP 2: Có filepath nhưng file không tồn tại -> Tải từ Drive
                        if (!string.IsNullOrEmpty(_book.DriveUrl))
                        {
                            MessageBox.Show("Sách không tồn tại tại đường dẫn ban đầu. Hệ thống sẽ tải từ đám mây.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DownloadBookFromCloud(_book.FilePath);
                            return;
                        }
                    }
                }

                // TRƯỜNG HỢP 3: Không có filepath hoặc có nhưng không có DriveUrl
                if (string.IsNullOrEmpty(_book.DriveUrl))
                {
                    // Trường hợp không có cả filepath và DriveUrl
                    MessageBox.Show("Không có thông tin về đường dẫn sách trong đám mây!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                // TRƯỜNG HỢP 3 với DriveUrl: Tạo đường dẫn mới và tải từ Drive
                string defaultFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BookReaderBooks");
                Directory.CreateDirectory(defaultFolder); // Đảm bảo thư mục tồn tại

                // Extract filename from DriveUrl or use title with .pdf extension
                string fileName = Path.GetFileName(_book.FilePath) ??
                                 (_book.Title?.Replace(" ", "_") + ".pdf") ??
                                 $"{_book.BookId}_book.pdf";

                string newFilePath = Path.Combine(defaultFolder, fileName);

                MessageBox.Show("Sách chưa có trên máy. Hệ thống sẽ tải sách từ đám mây.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật FilePath mới
                _book.FilePath = newFilePath;
                _context.SaveChanges();

                // Tải sách với đường dẫn mới
                DownloadBookFromCloud(newFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        // Sửa lại phương thức LoadPdf
        private void LoadPdf(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("File không tồn tại tại đường dẫn này", filePath);
                }

                var pdfDocument = PdfDocument.Load(filePath);
                _pdfViewer.Document = pdfDocument;

                // Đặt trang hiện tại nếu đã lưu bookmark
                int? savedPage = GetSavedBookmark();
                if (savedPage.HasValue)
                {
                    _pdfViewer.Renderer.Page = savedPage.Value;
                }

                UpdatePageLabel();
            }
            catch (Exception ex)
            {
                throw new Exception($"Không thể mở file PDF: {ex.Message}", ex);
            }
        }

        // Thêm phương thức để tải sách từ đám mây
        private async void DownloadBookFromCloud(string localFilePath)
        {
            Form? loadingForm = null;
            ProgressBar? progressBar = null;

            try
            {
                // Hiển thị thông báo đang tải
                loadingForm = new Form
                {
                    Text = "Đang tải sách...",
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(400, 150),
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ControlBox = false
                };

                var label = new Label
                {
                    Text = "Đang tải sách từ đám mây, vui lòng chờ...",
                    AutoSize = true,
                    Location = new Point(100, 30)
                };

                progressBar = new ProgressBar
                {
                    Width = 350,
                    Height = 20,
                    Location = new Point(25, 70),
                    Minimum = 0,
                    Maximum = 100,
                    Value = 0
                };

                loadingForm.Controls.Add(label);
                loadingForm.Controls.Add(progressBar);
                loadingForm.Show(this);
                Application.DoEvents(); // Để UI kịp cập nhật

                // Lấy thông tin file từ cơ sở dữ liệu
                var driveUrl = _book.DriveUrl;

                if (string.IsNullOrEmpty(driveUrl))
                {
                    MessageBox.Show("Không tìm thấy đường dẫn file trên đám mây!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadingForm.Close();
                    this.Close();
                    return;
                }

                // Debug: Show the Drive URL
                Debug.WriteLine($"DriveURL: {driveUrl}");

                // Lấy ID file từ DriveUrl
                string fileId = ExtractFileIdFromUrl(driveUrl);

                // Debug: Show the extracted file ID
                Debug.WriteLine($"Extracted FileID: {fileId}");

                if (string.IsNullOrEmpty(fileId))
                {
                    // Show the actual URL in the error message
                    MessageBox.Show($"Không thể xác định ID file từ đường dẫn Google Drive!\nURL: {driveUrl}",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadingForm.Close();
                    this.Close();
                    return;
                }

                // Tạo thư mục nếu chưa tồn tại
                var directory = Path.GetDirectoryName(localFilePath);
                if (!Directory.Exists(directory) && directory != null)
                {
                    Directory.CreateDirectory(directory);
                }

                // Tiến trình tải
                var progress = new Progress<double>(p =>
                {
                    if (progressBar != null && !progressBar.IsDisposed)
                        progressBar.Value = (int)(p * 100);
                });

                // Sử dụng helper đã có để tải file
                var driveServiceHelper = new DriveServiceHelper();
                await driveServiceHelper.DownloadFileAsync(fileId, localFilePath, progress);

                // Kiểm tra thành công
                if (File.Exists(localFilePath))
                {
                    // Cập nhật đường dẫn vào database
                    _book.FilePath = localFilePath;
                    _context.SaveChanges();

                    loadingForm.Close();
                    loadingForm = null;

                    try
                    {
                        LoadPdf(localFilePath);
                    }
                    catch (Exception pdfEx)
                    {
                        MessageBox.Show($"Đã tải file thành công nhưng không mở được file PDF: {pdfEx.Message}",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể tải sách từ đám mây!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sách từ đám mây: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally
            {
                loadingForm?.Close();
            }
        }


        // Phương thức để trích xuất ID file từ Google Drive URL
        private string ExtractFileIdFromUrl(string driveUrl)
        {
            try
            {
                // Handle standard Google Drive sharing URL formats
                if (driveUrl.Contains("/file/d/"))
                {
                    // Format: https://drive.google.com/file/d/[fileId]/view
                    int startIndex = driveUrl.IndexOf("/file/d/") + 9;
                    int endIndex = driveUrl.IndexOf("/", startIndex);
                    if (endIndex == -1)
                        endIndex = driveUrl.Length;

                    return driveUrl.Substring(startIndex, endIndex - startIndex);
                }
                else if (driveUrl.Contains("id="))
                {
                    // Format: https://drive.google.com/open?id=[fileId]
                    int startIndex = driveUrl.IndexOf("id=") + 3;
                    int endIndex = driveUrl.IndexOf("&", startIndex);
                    if (endIndex == -1)
                        endIndex = driveUrl.Length;

                    return driveUrl.Substring(startIndex, endIndex - startIndex);
                }
                else if (driveUrl.Contains("drive.google.com"))
                {
                    // Try to find any alphanumeric sequence that looks like a Drive ID
                    // Drive IDs are typically long alphanumeric strings
                    string pattern = @"[-\w]{25,}";
                    Match match = Regex.Match(driveUrl, pattern);
                    if (match.Success)
                    {
                        return match.Value;
                    }
                }

                // If we get here, we couldn't extract the ID
                MessageBox.Show($"Không thể xác định ID file từ đường dẫn: {driveUrl}\n\nHãy đảm bảo URL có dạng: https://drive.google.com/file/d/YOUR_FILE_ID/view",
                    "Lỗi URL Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý URL Drive: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void LoadBookmarks()
        {
            var bookmarks = _context.Bookmarks
                .Where(b => b.UserId == _userId && b.BookId == _book.BookId)
                .Select(b => b.PageNumber)
                .OrderBy(p => p)
                .ToList();

            kryptonListBoxBookMark.Items.Clear();

            foreach (var page in bookmarks)
            {
                kryptonListBoxBookMark.Items.Add($"Trang {page + 1}");
            }
        }

        private void LoadNotes()
        {
            var notes = _context.Notes
            .Where(n => n.UserId == _userId && n.BookId == _book.BookId)
            .OrderBy(n => n.PageNumber)
            .ToList();

            kryptonListBoxNotes.Items.Clear();

            foreach (var note in notes)
            {
                // Hiển thị trang và một phần nội dung note
                string displayText = $"Trang {note.PageNumber + 1}: {note.Content.Substring(0, Math.Min(note.Content.Length, 30))}...";
                kryptonListBoxNotes.Items.Add(displayText);
            }
        }

        private void checkBox_ChangeTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ChangeTheme.Checked)
            {
                this.BackColor = Color.FromArgb(244, 236, 216); // Sepia background
                _pdfViewer.BackColor = Color.FromArgb(244, 236, 216);
                _pdfViewer.ForeColor = Color.FromArgb(91, 70, 54); // Dark brown text
            }
            else
            {
                this.BackColor = SystemColors.Control;
                _pdfViewer.BackColor = SystemColors.Window;
                _pdfViewer.ForeColor = SystemColors.ControlText;
            }
        }
        private void BookReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên PDF khi form đóng  
            _pageCheckTimer?.Stop();
            _pageCheckTimer?.Dispose();
            _pdfViewer?.Dispose();

        }
        private void SaveBookmark(int page)
        {
            if (page < 0 || page >= _pdfViewer.Document.PageCount)
            {
                MessageBox.Show("Số trang không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem trang đã được đánh dấu chưa
            var existingBookmark = _context.Bookmarks
                .FirstOrDefault(b => b.UserId == _userId && b.BookId == _book.BookId && b.PageNumber == page);

            if (existingBookmark != null)
            {
                MessageBox.Show($"Trang {page + 1} đã được đánh dấu trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thêm bookmark mới
            var newBookmark = new Bookmark
            {
                UserId = _userId,
                BookId = _book.BookId,
                PageNumber = page
            };

            _context.Bookmarks.Add(newBookmark);
            _context.SaveChanges();

            MessageBox.Show($"Đã lưu đánh dấu trang: {page + 1}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBookmarks();
        }

        private int? GetSavedBookmark()
        {
            var bookmark = _context.Bookmarks
                .Where(b => b.UserId == _userId && b.BookId == _book.BookId)
                .OrderByDescending(b => b.PageNumber) // Lấy trang đánh dấu cao nhất (nếu có nhiều)
                .FirstOrDefault();

            if (bookmark == null)
            {
                MessageBox.Show("Không tìm thấy thông tin đánh dấu trang!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return bookmark.PageNumber;
        }

        private void SaveNoteForPage(int page, string content)
        {
            if (page < 0 || page >= _pdfViewer.Document.PageCount)
            {
                throw new ArgumentException("Số trang không hợp lệ!");
            }

            var note = _context.Notes
                .FirstOrDefault(n => n.UserId == _userId && n.BookId == _book.BookId && n.PageNumber == page);

            if (note == null)
            {
                _context.Notes.Add(new Note
                {
                    UserId = _userId,
                    BookId = _book.BookId,
                    PageNumber = page,
                    Content = content
                });
            }
            else
            {
                note.Content = content;
            }

            _context.SaveChanges();
        }

        private void UpdatePageLabel()
        {
            if (_pdfViewer?.Document != null)
            {
                lblPageInfo.Text = $"Trang {_pdfViewer.Renderer.Page + 1}/{_pdfViewer.Document.PageCount}";
            }
            else
            {
                lblPageInfo.Text = "Không có tài liệu.";
            }
        }

        private void btnBookmark_Click(object sender, EventArgs e)
        {
            int currentPage = _pdfViewer.Renderer.Page;
            SaveBookmark(currentPage);
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            int currentPage = _pdfViewer.Renderer.Page;
            var txtNote = this.Controls.Find("txtNote", true)[0] as TextBox;

            if (txtNote != null && !string.IsNullOrWhiteSpace(txtNote.Text))
            {
                SaveNoteForPage(currentPage, txtNote.Text);
                MessageBox.Show($"Đã lưu ghi chú cho trang: {currentPage + 1}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNote.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ghi chú trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGoToPage_Click(object sender, EventArgs e)
        {
            var txtPageNumber = this.Controls.Find("txtPageNumber", true)[0] as TextBox;

            if (txtPageNumber != null && int.TryParse(txtPageNumber.Text, out int pageNumber))
            {
                if (pageNumber > 0 && pageNumber <= _pdfViewer.Document.PageCount)
                {
                    _pdfViewer.Renderer.Page = pageNumber - 1;
                    UpdatePageLabel();
                }
                else
                {
                    MessageBox.Show("Số trang không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số trang hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BookReaderForm_Load(object sender, EventArgs e)
        {
            LoadBookmarks();
            LoadNotes();
        }

        private void listBoxBookmarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (kryptonListBoxBookMark.SelectedItem != null)
            //{
            //    var selectedText = kryptonListBoxBookMark.SelectedItem.ToString();
            //    if (int.TryParse(selectedText?.Replace("Trang ", ""), out int pageNumber))
            //    {
            //        if (pageNumber > 0 && pageNumber <= _pdfViewer.Document.PageCount)
            //        {
            //            _pdfViewer.Renderer.Page = pageNumber - 1;
            //            UpdatePageLabel();
            //        }
            //    }
            //}
        }

        private void KryptonlistBoxBookmarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kryptonListBoxBookMark.SelectedItem != null)
            {
                var selectedText = kryptonListBoxBookMark.SelectedItem.ToString();
                if (int.TryParse(selectedText?.Replace("Trang ", ""), out int pageNumber))
                {
                    if (pageNumber > 0 && pageNumber <= _pdfViewer.Document.PageCount)
                    {
                        _pdfViewer.Renderer.Page = pageNumber - 1;
                        UpdatePageLabel();
                    }
                }
            }
        }

        private void kryptonButtonSaveNote_Click(object sender, EventArgs e)
        {
            int currentPage = _pdfViewer.Renderer.Page;
            var kryptonTextBoxNote = this.Controls.Find("kryptonTextBoxNote", true)[0] as KryptonTextBox;

            if (kryptonTextBoxNote != null && !string.IsNullOrWhiteSpace(kryptonTextBoxNote.Text))
            {
                SaveNoteForPage(currentPage, kryptonTextBoxNote.Text);
                MessageBox.Show($"Đã lưu ghi chú cho trang: {currentPage + 1}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kryptonTextBoxNote.Clear();
                LoadNotes();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ghi chú trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kryptonButtonGoToPage_Click(object sender, EventArgs e)
        {
            var kryptonTextBoxPageNumber = this.Controls.Find("kryptonTextBoxPageNumber", true)[0] as KryptonTextBox;

            if (kryptonTextBoxPageNumber != null && int.TryParse(kryptonTextBoxPageNumber.Text, out int pageNumber))
            {
                if (pageNumber > 0 && pageNumber <= _pdfViewer.Document.PageCount)
                {
                    _pdfViewer.Renderer.Page = pageNumber - 1;
                    UpdatePageLabel();
                }
                else
                {
                    MessageBox.Show("Số trang không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số trang hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kryptonButtonBookmark_Click(object sender, EventArgs e)
        {
            int currentPage = _pdfViewer.Renderer.Page;
            SaveBookmark(currentPage);
        }

        private bool textCleared = false; // Step 1: Declare the flag
        private void kryptonTextBox1_Enter(object sender, EventArgs e) // Step 2: Use Enter event
        {
            if (!textCleared)
            {
                kryptonTextBoxNote.Text = "";
                textCleared = true; // Step 3: Set the flag to true
            }
        }

        private bool textCleared1 = false; // Step 1: Declare the flag
        private void kryptonTextBox2_Enter(object sender, EventArgs e) // Step 2: Use Enter event
        {
            if (!textCleared1)
            {
                kryptonTextBoxPageNumber.Text = "";
                textCleared1 = true; // Step 3: Set the flag to true
            }
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // Thêm method để hiển thị chi tiết note
        private void ShowNoteDetails(int pageNumber)
        {
            var note = _context.Notes
                .FirstOrDefault(n => n.UserId == _userId && n.BookId == _book.BookId && n.PageNumber == pageNumber);

            if (note != null)
            {
                MessageBox.Show($"Ghi chú trang {pageNumber + 1}:\n\n{note.Content}",
                    "Chi tiết ghi chú", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void kryptonListBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kryptonListBoxNotes.SelectedItem != null)
            {
                var selectedText = kryptonListBoxNotes.SelectedItem.ToString();

                // Extract page number từ text "Trang X: ..."
                if (selectedText.StartsWith("Trang "))
                {
                    var colonIndex = selectedText.IndexOf(":");
                    if (colonIndex > 0)
                    {
                        var pageText = selectedText.Substring(6, colonIndex - 6); // "Trang " = 6 chars
                        if (int.TryParse(pageText, out int pageNumber))
                        {
                            if (pageNumber > 0 && pageNumber <= _pdfViewer.Document.PageCount)
                            {
                                _pdfViewer.Renderer.Page = pageNumber - 1;
                                UpdatePageLabel();

                                // Hiển thị full note content trong MessageBox hoặc TextBox
                                ShowNoteDetails(pageNumber - 1);
                            }
                        }
                    }
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;

            // Optionally, change the button text based on the panel's visibility
            if (panel2.Visible)
            {
                panel2.Text = "Hide Area";
            }
            else
            {
                panel2.Text = "Show Area";
            }
        }
    }
}       
