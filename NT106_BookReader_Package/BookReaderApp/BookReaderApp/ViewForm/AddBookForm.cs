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
    public partial class AddBookForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        public AddBookForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string categoryName = cmbCategory.Text.Trim();
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra và thêm thể loại mới nếu cần
            var category = _context.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
            if (category == null)
            {
                category = new Category { CategoryName = categoryName };
                _context.Categories.Add(category);
                _context.SaveChanges();
            }

            var book = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                CategoryId = category.CategoryId, // Sử dụng CategoryId của thể loại vừa tìm hoặc thêm

                PublishedDate = dtpPublishedDate.Value,
                FilePath = txtFilePath.Text,
                UploaderId = 1 // Thay 1 bằng ID của người dùng hợp lệ
            };

            _context.Books.Add(book);
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
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Tải danh sách thể loại vào ComboBox
                var categories = _context.Categories.ToList();
                kryptonComboBoxCategory.DataSource = categories;
                kryptonComboBoxCategory.DisplayMember = "CategoryName";
                kryptonComboBoxCategory.ValueMember = "CategoryId";
                kryptonComboBoxCategory.SelectedIndex = -1; // Không chọn mặc định
                kryptonComboBoxCategory.DropDownStyle = ComboBoxStyle.DropDown; // Cho phép nhập liệu
                // Tải danh sách người dùng vào ComboBox
                var users = _context.Users.ToList();
                kryptonComboBoxUploader.DataSource = users;
                kryptonComboBoxUploader.DisplayMember = "Username";
                kryptonComboBoxUploader.ValueMember = "UserId";
                kryptonComboBoxUploader.SelectedIndex = -1; // Không chọn mặc định
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(kryptonTextBoxTitle.Text) || string.IsNullOrWhiteSpace(kryptonTextBoxAuthor.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //string categoryName = kryptonComboBoxCategory.Text.Trim();
            //if (string.IsNullOrWhiteSpace(categoryName))
            //{
            //    MessageBox.Show("Vui lòng nhập hoặc chọn thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Kiểm tra và thêm thể loại mới nếu cần
            //var category = _context.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
            //if (category == null)
            //{
            //    category = new Category { CategoryName = categoryName };
            //    _context.Categories.Add(category);
            //    _context.SaveChanges();
            //}

            //var book = new Book
            //{
            //    Title = kryptonTextBoxTitle.Text,
            //    Author = kryptonTextBoxAuthor.Text,
            //    CategoryId = category.CategoryId, // Sử dụng CategoryId của thể loại vừa tìm hoặc thêm
            //    PublishedDate = kryptonDateTimePicker1.Value,
            //    FilePath = kryptonTextBoxFilePath.Text,
            //    UploaderId = 1 // Thay 1 bằng ID của người dùng hợp lệ
            //};

            //_context.Books.Add(book);
            //_context.SaveChanges();
            //DialogResult = DialogResult.OK; // Trả về kết quả OK
            //Close();
            if (string.IsNullOrWhiteSpace(kryptonTextBoxTitle.Text) || string.IsNullOrWhiteSpace(kryptonTextBoxAuthor.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string categoryName = kryptonComboBoxCategory.Text.Trim();
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Kiểm tra và thêm thể loại mới nếu cần
                var category = _context.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
                if (category == null)
                {
                    category = new Category { CategoryName = categoryName };
                    _context.Categories.Add(category);
                    _context.SaveChanges();
                }

                // Tìm một admin user trong database
                var admin = _context.Users.FirstOrDefault(u => u.Username == "admin");

                if (admin == null)
                {
                    MessageBox.Show("Không tìm thấy admin user. Hãy khởi tạo dữ liệu trước.",
                                  "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Handle cover image - copy to a permanent location if needed
                string coverImagePath = kryptonTextBoxCoverPath.Text;
                string permanentImagePath = coverImagePath;

                if (!string.IsNullOrEmpty(coverImagePath) && File.Exists(coverImagePath))
                {
                    // Create a directory for book covers if it doesn't exist
                    string coverDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BookReaderCovers");
                    Directory.CreateDirectory(coverDirectory);

                    // Create a unique filename
                    string fileName = $"{Guid.NewGuid()}_{Path.GetFileName(coverImagePath)}";
                    permanentImagePath = Path.Combine(coverDirectory, fileName);

                    // Copy the file to the permanent location
                    File.Copy(coverImagePath, permanentImagePath);
                }

                var book = new Book
                {
                    Title = kryptonTextBoxTitle.Text,
                    Author = kryptonTextBoxAuthor.Text,
                    CategoryId = category.CategoryId, // Sử dụng CategoryId của thể loại vừa tìm hoặc thêm
                    PublishedDate = kryptonDateTimePicker1.Value,
                    FilePath = kryptonTextBoxFilePath.Text,
                    UploaderId = admin.UserId, // Sử dụng ID của admin user
                    CoverImage = permanentImagePath // Đường dẫn đến ảnh bìa
                };

                _context.Books.Add(book);
                _context.SaveChanges();
                DialogResult = DialogResult.OK; // Trả về kết quả OK
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void kryptonButtonBrowseCover_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh bìa sách",
                Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                kryptonTextBoxCoverPath.Text = openFileDialog.FileName;

                // Preview the selected image
                try
                {
                    kryptonPictureBoxCover.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể hiển thị ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
