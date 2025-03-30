using BookReaderApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookReaderApp.Utils;
using BookReaderApp.Models;
using Microsoft.IdentityModel.Tokens;
using PasswordHelper = BookReaderApp.Utils.PasswordHelper;
namespace BookReaderApp.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public bool CheckAccount(string ac) // Kiem tra tai khoan va mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$"); // Kiem tra ky tu
        }
        public bool CheckEmail(string em) // Kiem tra email
        {
            return Regex.IsMatch(em, "^([a-zA-Z0-9_\\.]+)@([a-zA-Z0-9_\\.]+)\\.([a-zA-Z]{2,5})$"); // Kiem tra email
        }
        Modify modify = new Modify();
        public void ClearALL()
        {
            textBox_FullName.Clear();
            textBox_UserName.Clear();
            textBox_PassWord.Clear();
            textBox_ConfirmPassword.Clear();
            textBox_Email.Clear();
            textBox_FullName.Select();
        }
        private void button_Register_Click(object sender, EventArgs e)
        {
            string username = textBox_UserName.Text;
            string password = textBox_PassWord.Text;
            string confirm = textBox_ConfirmPassword.Text;
            string email = textBox_Email.Text;
            string fullname = textBox_FullName.Text;
            if (username.IsNullOrEmpty() && password.IsNullOrEmpty() && email.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fullname.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (confirm.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (email.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckAccount(username))
            {
                MessageBox.Show("Tên tài khoản không hợp lệ: Tên tài khoản dài 6-24 ký tự. Vui lòng nhập chữ và số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearALL();
                return;
            }
            if (!CheckAccount(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ: Mật khẩu dài 6-24 ký tự. Vui lòng nhập các ký tự, chữ, số, chữ hoa và thường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_PassWord.Clear();
                return;
            }
            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_ConfirmPassword.Clear();
                return;
            }

            if (!CheckEmail(email))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Email.Clear();
                return;
            }
            if (modify.Accounts("SELECT * FROM Users WHERE Username = '" + username + "'").Count != 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_UserName.Clear();
                textBox_UserName.Select();
                return;
            }
            if (modify.Accounts("SELECT * FROM Users WHERE Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email đã tồn tại. Đăng kí Email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Email.Clear();
                textBox_Email.Select();
                return;
            }
            string hashedPassword = PasswordHelper.HashPassword(password);
            try
            {
                string query = "INSERT INTO Users (Username, PasswordHash, Email, FullName) VALUES ('" + username + "', '" + hashedPassword + "', '" + email + "','" + fullname + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            textBox_FullName.Select();
        }

        private void textBox_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_PassWord.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_ConfirmPassword.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_ConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_Email.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Register.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_FullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_UserName.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
