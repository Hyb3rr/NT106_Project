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
using BookReaderApp.Models;
namespace BookReaderApp.ViewForm
{
    public partial class AddUserForm : Form
    {
        private readonly BookReaderDbContext _context;
        public AddUserForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;

            // Khởi tạo vai trò trong ComboBox
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("User");
            cmbRole.SelectedIndex = 0; // Mặc định chọn "Admin"
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text;
            var fullName = txtFullName.Text.Trim();
            var role = cmbRole.SelectedItem?.ToString(); // Use null conditional operator

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_context.Users.Any(u => u.Username == username || u.Email == email))
            {
                MessageBox.Show("Tên đăng nhập hoặc email đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Băm mật khẩu
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Tạo người dùng mới
            var newUser = new User
            {
                Username = username,
                Email = email,
                PasswordHash = hashedPassword,
                FullName = fullName,
                Role = role,
                CreatedDate = DateTime.Now,
                IsActive = true
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng form
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form nếu người dùng hủy bỏ thao tác
        }
    }
}
