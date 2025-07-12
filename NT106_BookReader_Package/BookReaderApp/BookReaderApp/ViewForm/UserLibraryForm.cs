using BookReaderApp.Data;
using BookReaderApp.Models;
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

namespace BookReaderApp.ViewForm
{
    public partial class UserLibraryForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private readonly int _userId; // ID của người dùng hiện tại
        public UserLibraryForm(BookReaderDbContext context, int userId)
        {
            InitializeComponent();
            _context = context;
            _userId = userId;
        }
        private void LoadLibrary()
        {
            kryptonDataGridViewLibrary.DataSource = _context.UserLibraries
                .Where(ul => ul.UserId == _userId)
                .Select(ul => new
                {
                    ul.Book.BookId,
                    ul.Book.Title,
                    ul.Book.Author,
                    Category = ul.Book.Category != null ? ul.Book.Category.CategoryName : "Unknown",
                    ul.AddedDate
                })
                .ToList();
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

        private void UserLibraryForm_Load(object sender, EventArgs e)
        {
            LoadLibrary();
        }

        private void btnReadBook_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null && !string.IsNullOrEmpty(book.FilePath))
                {
                    var bookReaderForm = new BookReaderForm(book.FilePath, _context, book, _userId);
                    bookReaderForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để đọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;

                var libraryEntry = _context.UserLibraries
                    .FirstOrDefault(ul => ul.UserId == _userId && ul.BookId == bookId);

                if (libraryEntry != null)
                {
                    _context.UserLibraries.Remove(libraryEntry);
                    _context.SaveChanges();

                    MessageBox.Show("Đã xóa sách khỏi thư viện.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLibrary(); // Làm mới danh sách
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {

        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;

                var reviewForm = new ReviewForm(_context, _userId, bookId);
                var result = reviewForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Đánh giá đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để đánh giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null && !string.IsNullOrEmpty(book.FilePath))
                {
                    var bookReaderForm = new BookReaderForm(book.FilePath, _context, book, _userId);
                    bookReaderForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để đọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;

                var libraryEntry = _context.UserLibraries
                    .FirstOrDefault(ul => ul.UserId == _userId && ul.BookId == bookId);

                if (libraryEntry != null)
                {
                    _context.UserLibraries.Remove(libraryEntry);
                    _context.SaveChanges();

                    MessageBox.Show("Đã xóa sách khỏi thư viện.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLibrary(); // Làm mới danh sách
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridViewLibrary.SelectedRows.Count > 0)
            {
                int bookId = (int)kryptonDataGridViewLibrary.SelectedRows[0].Cells["BookId"].Value;

                var reviewForm = new ReviewForm(_context, _userId, bookId);
                var result = reviewForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Đánh giá đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để đánh giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kryptonDataGridViewLibrary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
