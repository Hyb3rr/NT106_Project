using BookReaderApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookReaderApp.ViewForm
{
    public partial class BookManagementForm : Form
    {
        private readonly BookReaderDbContext _context;
        public BookManagementForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadBooks(); // Tải danh sách sách khi mở form
        }
        private void LoadBooks(string keyword = "", string filter = "Tiêu đề")
        {
            var books = _context.Books.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                switch (filter)
                {
                    case "Tiêu đề":
                        books = books.Where(b => b.Title.Contains(keyword));
                        break;
                    case "Tác giả":
                        books = books.Where(b => b.Author.Contains(keyword));
                        break;
                    case "Thể loại":
                        books = books.Where(b => b.Category != null && b.Category.CategoryName.Contains(keyword));
                        break;
                }
            }

            var bookList = books.Select(b => new
            {
                b.BookId,
                b.Title,
                b.Author,
                b.Category,
                b.UploadDate
            }).ToList();

            dataGridViewBooks.DataSource = bookList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text.Trim();
            var filter = cmbFilter.SelectedItem?.ToString() ?? "Tiêu đề"; // Ensure filter is not null
            LoadBooks(keyword, filter); // Tìm kiếm với từ khóa và bộ lọc
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm(_context);
            addBookForm.ShowDialog();
            LoadBooks(); // Refresh danh sách sau khi thêm
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                var bookId = (int)dataGridViewBooks.SelectedRows[0].Cells["BookId"].Value;
                var editBookForm = new EditBookForm(_context, bookId);
                editBookForm.ShowDialog();
                LoadBooks(); // Refresh danh sách sau khi sửa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                var bookId = (int)dataGridViewBooks.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    _context.Books.Remove(book);
                    _context.SaveChanges();
                    MessageBox.Show("Xóa sách thành công!");
                    LoadBooks(); // Refresh danh sách sau khi xóa
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
