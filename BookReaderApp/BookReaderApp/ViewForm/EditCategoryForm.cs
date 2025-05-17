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
    public partial class EditCategoryForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private readonly Category _category;
        public EditCategoryForm(BookReaderDbContext context, Category category)
        {
            InitializeComponent();
            _context = context;
            _category = category;

            // Hiển thị thông tin thể loại
            kryptonTextBoxCategory.Text = _category.CategoryName;
            kryptonTextBoxDescription.Text = _category.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBoxCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin thể loại
            _category.CategoryName = kryptonTextBoxCategory.Text;
            _category.Description = kryptonTextBoxDescription.Text;

            _context.SaveChanges();
            DialogResult = DialogResult.OK; // Trả về kết quả OK
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Hủy bỏ
            Close();
        }

        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBoxCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin thể loại
            _category.CategoryName = kryptonTextBoxCategory.Text;
            _category.Description = kryptonTextBoxDescription.Text;

            _context.SaveChanges();
            DialogResult = DialogResult.OK; // Trả về kết quả OK
            Close();
        }

        private void kryptonButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Hủy bỏ
            Close();
        }
    }
}
