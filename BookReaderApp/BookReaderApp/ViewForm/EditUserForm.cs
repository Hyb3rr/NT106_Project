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
    public partial class EditUserForm : Form
    {
        private readonly BookReaderDbContext _context;
        private readonly int _userId;
        private readonly int _currentAdminId; // ID của Admin đang đăng nhập
        public EditUserForm(BookReaderDbContext context, int userId, int currentAdminId)
        {
            InitializeComponent();
            _context = context;
            _userId = userId;
            _currentAdminId = currentAdminId;
            LoadUserDetails(); // Tải thông tin người dùng lên giao diện
        }
        private void LoadUserDetails()
        {

            var user = _context.Users.Find(_userId);

            if (user == null)
            {
                MessageBox.Show("Không tìm thấy người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Hiển thị thông tin người dùng
            txtUsername.Text = user.Username;
            txtEmail.Text = user.Email;
            txtFullName.Text = user.FullName;

            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("User");
            cmbRole.SelectedItem = user.Role; // Chọn vai trò hiện tại

            chkIsActive.Checked = user.IsActive; // Đánh dấu trạng thái kích hoạt
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var email = txtEmail.Text.Trim();
            var fullName = txtFullName.Text.Trim();
            var role = cmbRole.SelectedItem?.ToString();
            var isActive = chkIsActive.Checked;

            // Check if role is null
            if (role == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email hợp lệ
            if (!new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(email))
            {
                MessageBox.Show("Email không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng lặp username/email với user khác
            if (_context.Users.Any(u => u.UserId != _userId && (u.Email == email || u.Username == username)))
            {
                MessageBox.Show("Tên đăng nhập hoặc email đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác thực quyền Admin
            if (string.IsNullOrWhiteSpace(txtAdminPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu Admin để xác nhận.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var currentAdmin = _context.Users.Find(_currentAdminId);
            if (currentAdmin == null)
            {
                MessageBox.Show("Không tìm thấy Admin hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!BCrypt.Net.BCrypt.Verify(txtAdminPassword.Text, currentAdmin.PasswordHash))
            {
                MessageBox.Show("Mật khẩu Admin không đúng. Không thể lưu thay đổi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu Admin hạ cấp chính mình
            if (_userId == _currentAdminId && role != "Admin")
            {
                MessageBox.Show("Bạn không thể hạ cấp chính mình xuống User.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _context.Users.Find(_userId);
            if (user == null)
            {
                MessageBox.Show("Không tìm thấy người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin người dùng
            user.Username = username;
            user.Email = email;
            user.FullName = fullName;
            user.Role = role;
            user.IsActive = isActive;

            // Nếu có nhập mật khẩu mới, băm mật khẩu mới
            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                var newPassword = txtNewPassword.Text;
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
            }

            // Lưu thay đổi vào database
            _context.SaveChanges();
            MessageBox.Show("Cập nhật thông tin người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Đóng form sau khi lưu
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form nếu người dùng hủy bỏ thao tác
        }
    }
}
