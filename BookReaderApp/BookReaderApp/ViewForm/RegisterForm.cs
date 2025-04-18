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
using BCrypt.Net;

namespace BookReaderApp.ViewForm
{
    public partial class RegisterForm : Form
    {
        private readonly BookReaderDbContext _context;
        public RegisterForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;
            lblMessage.Visible = false;
        }
        private void ShowMessage(string msg, bool isSuccess)
        {
            lblMessage.Text = msg;
            lblMessage.ForeColor = isSuccess ? Color.Green : Color.Red;
            lblMessage.Visible = true;
        }
        private void ClearForm()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            //List<TextBox> textBoxes = new List<TextBox> { txtUserName, txtEmail, txtFullName, txtPassword, txtConfirmPassword };
            //foreach (var textBox in textBoxes)
            //{
            //    textBox.BackColor = Color.White;
            //}
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text.Trim();
            var email = txtEmail.Text.Trim();
            var fullName = txtFullName.Text.Trim();
            var password = txtPassword.Text;
            var confirmPassword = txtConfirmPassword.Text;
            
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                ShowMessage("Vui lòng nhập đầy đủ thông tin.", false);
                return;
            }
            if(password != confirmPassword)
            {
                ShowMessage("Mật khẩu không khớp.", false);
                return;
            }
            if (_context.Users.Any(u => u.Username == username))
            {
                ShowMessage("Tên đăng nhập đã tồn tại.", false);
                return;
            }
            if (!new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(email))
            {
                ShowMessage("Email không hợp lệ.", false);
                return;
            }
            if (_context.Users.Any(u => u.Email == email))
            {
                ShowMessage("Email đã tồn tại.", false);
                return;
            }
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            var user = new User
            {
                Email = email,
                FullName = fullName,
                Username = username,
                PasswordHash = hashedPassword,
                Role = "User",
                CreatedDate = DateTime.Now,
                IsActive = true
            };
            _context.Users.Add(user);
            try
            {
                _context.SaveChanges();
                ShowMessage("Đăng ký thành công.", true);
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowMessage("Đăng ký thất bại: " + ex.Message, false);
            }
        }
    }
}
