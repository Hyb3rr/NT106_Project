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

            // Mở file PDF  
            LoadPdf(filePath);
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


        private void LoadPdf(string filePath)
        {
            try
            {
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
                MessageBox.Show($"Không thể mở file PDF: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
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
        
    }
}       
