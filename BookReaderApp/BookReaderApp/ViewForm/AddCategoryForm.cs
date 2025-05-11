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
    public partial class AddCategoryForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        public AddCategoryForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var category = new Category
            {
                CategoryName = txtCategoryName.Text,
                Description = txtDescription.Text
            };

            _context.Categories.Add(category);
            _context.SaveChanges();
            DialogResult = DialogResult.OK; // Trả về kết quả OK
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Hủy bỏ
            Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBoxCategoryName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var category = new Category
            {
                CategoryName = kryptonTextBoxCategoryName.Text,
                Description = kryptonRichTextBox1.Text
            };

            _context.Categories.Add(category);
            _context.SaveChanges();
            DialogResult = DialogResult.OK; // Trả về kết quả OK
            Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Hủy bỏ
            Close();
        }
    }
}
