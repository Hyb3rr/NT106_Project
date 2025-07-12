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
    public partial class AddUserForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        public AddUserForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn vai trò người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User
            {
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(txtFullName.Text),
                Role = (User.UserRole)cmbRole.SelectedIndex,
                IsActive = chkIsActive.Checked,
                CreatedDate = DateTime.Now,
                FullName = txtFullName.Text, // Assuming you have a FullName field
                //Avatar = txtAvatar.Text      // Assuming you have an Avatar field
            };

            _context.Users.Add(user);
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
            if (string.IsNullOrWhiteSpace(kryptonTextBoxUsrname.Text) || string.IsNullOrWhiteSpace(kryptonTextBoxEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (kryptonComboBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn vai trò người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User
            {
                Username = kryptonTextBoxUsrname.Text,
                Email = kryptonTextBoxEmail.Text,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(kryptonTextBoxPassword.Text),
                Role = (User.UserRole)kryptonComboBoxRole.SelectedIndex,
                IsActive = chkIsActive.Checked,
                CreatedDate = DateTime.Now,
                FullName = kryptonTextBoxFullName.Text, // Assuming you have a FullName field
                //Avatar = txtAvatar.Text      // Assuming you have an Avatar field
            };

            _context.Users.Add(user);
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
