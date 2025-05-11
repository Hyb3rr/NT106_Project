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
    public partial class EditBookForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private readonly Book _book;
        public EditBookForm(BookReaderDbContext context, Book book)
        {
            InitializeComponent();
            _context = context;
            _book = book;

            // Load thông tin sách
            kryptonTextBoxTitle.Text = _book.Title;
            kryptonTextBoxAuthor.Text = _book.Author;
            kryptonTextBoxFilePath.Text = _book.FilePath;
            kryptonDateTimePicker1.Value = _book.PublishedDate;

            // Load danh sách thể loại vào ComboBox
            kryptonComboBoxRole.DataSource = _context.Categories.ToList();
            kryptonComboBoxRole.DisplayMember = "CategoryName";
            kryptonComboBoxRole.ValueMember = "CategoryId";
            kryptonComboBoxRole.SelectedValue = _book.CategoryId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBoxTitle.Text) || string.IsNullOrWhiteSpace(kryptonTextBoxAuthor.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin sách
            _book.Title = kryptonTextBoxTitle.Text;
            _book.Author = kryptonTextBoxAuthor.Text;

            // Fix for CS8605: Ensure SelectedValue is not null before unboxing
            if (kryptonComboBoxRole.SelectedValue is int selectedCategoryId)
            {
                _book.CategoryId = selectedCategoryId;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _book.PublishedDate = kryptonDateTimePicker1.Value;
            _book.FilePath = kryptonTextBoxFilePath.Text;

            _context.SaveChanges();
            DialogResult = DialogResult.OK; // Trả về kết quả OK
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Hủy bỏ
            Close();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Chọn file sách",
                Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                kryptonTextBoxTitle.Text = openFileDialog.FileName;
            }
        }

        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBoxTitle.Text) || string.IsNullOrWhiteSpace(kryptonTextBoxAuthor.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin sách
            _book.Title = kryptonTextBoxTitle.Text;
            _book.Author = kryptonTextBoxAuthor.Text;

            // Fix for CS8605: Ensure SelectedValue is not null before unboxing
            if (kryptonComboBoxRole.SelectedValue is int selectedCategoryId)
            {
                _book.CategoryId = selectedCategoryId;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _book.PublishedDate = kryptonDateTimePicker1.Value;
            _book.FilePath = kryptonTextBoxFilePath.Text;

            _context.SaveChanges();
            DialogResult = DialogResult.OK; // Trả về kết quả OK
            Close();
        }

        private void kryptonButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Hủy bỏ
            Close();
        }

        private void kryptonButtonBrowse_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Chọn file sách",
                Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                kryptonTextBoxFilePath.Text = openFileDialog.FileName;
            }
        }

        private void kryptonTextBoxAuthor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
