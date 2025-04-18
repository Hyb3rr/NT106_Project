using BookReaderApp.Data;
using BookReaderApp.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddBookForm : Form
    {
        private readonly BookReaderDbContext _context;
        public AddBookForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadCategories(); // Tải danh sách thể loại khi mở form
        }
        private void LoadCategories()
        {
            var categories = _context.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName"; // Hiển thị tên thể loại
            cmbCategory.ValueMember = "CategoryId";    // Lấy giá trị ID
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text.Trim();
            var author = txtAuthor.Text.Trim();
            var description = txtDescription.Text.Trim();
            var categoryId = cmbCategory.SelectedValue as int?;
            var uploadDate = dtpUploadDate.Value;
            var isDisplayed = chkIsDisplayed.Checked;

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (categoryId == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng Book
            var newBook = new Book
            {
                Title = title,
                Author = author,
                Description = description,
                CategoryId = categoryId.Value,
                UploadDate = uploadDate,
                IsDisplayed = isDisplayed
            };

            // Lưu vào database
            _context.Books.Add(newBook);
            _context.SaveChanges();

            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Đóng form sau khi lưu
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }
    }
}
