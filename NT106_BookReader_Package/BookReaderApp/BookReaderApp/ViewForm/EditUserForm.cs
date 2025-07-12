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
using Krypton.Toolkit;

namespace BookReaderApp.ViewForm
{
    public partial class EditUserForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private readonly User _user;
        public EditUserForm(BookReaderDbContext context, User user)
        {
            InitializeComponent();
            _context = context;
            _user = user;
            // Hiển thị thông tin người dùng
            kryptonTextBoxUsrname.Text = _user.Username;
            kryptonTextBoxEmail.Text = _user.Email;
            // Đặt source là enum
            kryptonComboBoxRole.DataSource = Enum.GetValues(typeof(User.UserRole));

            // Gán đúng giá trị enum
            kryptonComboBoxRole.SelectedItem = _user.Role;
            chkIsActive.Checked = _user.IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBoxUsrname.Text) || string.IsNullOrWhiteSpace(kryptonTextBoxEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin người dùng
            _user.Username = kryptonTextBoxUsrname.Text;
            _user.Email = kryptonTextBoxEmail.Text;
            _user.Role = (User.UserRole)kryptonComboBoxRole.SelectedIndex;
            _user.IsActive = chkIsActive.Checked;

            _context.SaveChanges();
            DialogResult = DialogResult.OK; // Trả về kết quả OK
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Hủy bỏ
            Close();
        }
        private bool IsPasswordStrong(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBoxUsrname.Text) || string.IsNullOrWhiteSpace(kryptonTextBoxEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Nếu có nhập mật khẩu mới thì hash và lưu
            if (!string.IsNullOrWhiteSpace(kryptonTextBoxPassword.Text))
            {
                if (!IsPasswordStrong(kryptonTextBoxPassword.Text))
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(kryptonTextBoxPassword.Text);
            }
            // Cập nhật thông tin người dùng
            _user.Username = kryptonTextBoxUsrname.Text;
            _user.Email = kryptonTextBoxEmail.Text;
#pragma warning disable CS8605 // Unboxing a possibly null value.
            _user.Role = (User.UserRole)kryptonComboBoxRole.SelectedItem;
#pragma warning restore CS8605 // Unboxing a possibly null value.
            _user.IsActive = chkIsActive.Checked;

            _context.SaveChanges();
            DialogResult = DialogResult.OK; // Trả về kết quả OK
            Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Hủy bỏ
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
