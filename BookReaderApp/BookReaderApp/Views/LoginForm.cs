using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookReaderApp.Utils;
using BookReaderApp.Data;
using BookReaderApp.Models;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using PasswordHelper = BookReaderApp.Utils.PasswordHelper;
namespace BookReaderApp.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox_UserAccount.Select();
        }

        private void linkLabel_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassForm resetPassForm = new ResetPassForm();
            resetPassForm.ShowDialog();
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
        Modify modify = new Modify();
        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_UserAccount.Text;
            string password = textBox_PasswordAccount.Text;

            if (username.IsNullOrEmpty() && password.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (username.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (password.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string query = "SELECT * FROM Users WHERE Username = '" + username + "'";
            List<Account> accounts = modify.Accounts(query);

            if (accounts.Count > 0)
            {
                string storedHash = accounts[0].Passwordhash;
                if (PasswordHelper.VerifyPassword(password, storedHash))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HomeForm homeForm = new HomeForm();
                    homeForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UserEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_PasswordAccount.Focus();
                e.SuppressKeyPress = true; // ngăn xuống dòng
            }
        }

        private void PassEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Login_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
