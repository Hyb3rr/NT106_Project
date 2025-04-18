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

namespace BookReaderApp.ViewForm
{
    public partial class LoginForm : Form
    {
        private readonly BookReaderDbContext _context;
        // Property to hold the logged-in Admin's ID
        public int CurrentAdminId { get; private set; }
        public LoginForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;

            // Kiểm tra dữ liệu ghi nhớ từ Settings và hiển thị
            var rememberedUsername = Properties.Settings.Default.UsernameOrEmail;
            if (!string.IsNullOrWhiteSpace(rememberedUsername))
            {
                txtUsernameOrEmail.Text = rememberedUsername;
                chkRememberMe.Checked = true; // Đánh dấu checkbox "Remember Me"
            }

            lblMessage.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usernameOrEmail = txtUsernameOrEmail.Text.Trim();
            var password = txtPassword.Text;

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
            {
                ShowMessage("Vui lòng nhập đầy đủ thông tin.", false);
                return;
            }

            // Tìm user theo tên đăng nhập hoặc email
            var user = _context.Users
                .FirstOrDefault(u => u.Username == usernameOrEmail || u.Email == usernameOrEmail);

            if (user == null)
            {
                ShowMessage("Tài khoản không tồn tại.", false);
                return;
            }

            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                ShowMessage("Mật khẩu không đúng.", false);
                return;
            }

            // Lưu hoặc xóa thông tin ghi nhớ dựa trên trạng thái checkbox
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UsernameOrEmail = usernameOrEmail;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UsernameOrEmail = string.Empty;
                Properties.Settings.Default.Save();
            }

            // Ghi log đăng nhập (tùy thuộc vào vai trò)
            var log = new AdminLog
            {
                AdminId = user.UserId,
                Action = $"Đăng nhập với vai trò: {user.Role}",
                Timestamp = DateTime.Now
            };
            _context.AdminLogs.Add(log);
            _context.SaveChanges();

            ShowMessage($"Chào mừng {user.Username}!", true);

            // Chuyển hướng đến giao diện chính dựa trên vai trò
            if (user.Role == "Admin")
            {
                var adminForm = new AdminForm(_context, user.UserId); // Truyền UserId làm currentAdminId
                adminForm.Show();
            }
            else if (user.Role == "User")
            {
                var userForm = new MainForm();
                userForm.Show();
            }
            else
            {
                ShowMessage("Vai trò của bạn không được hỗ trợ.", false);
                return;
            }

            this.Hide(); // Ẩn LoginForm sau khi đăng nhập thành công
        }
        private void ShowMessage(string message, bool isSuccess)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = isSuccess ? Color.Green : Color.Red;
            lblMessage.Visible = true;
        }
    }
}
