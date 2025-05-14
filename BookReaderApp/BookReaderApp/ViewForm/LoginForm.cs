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
using Krypton.Toolkit;
namespace BookReaderApp.ViewForm
{
    public partial class LoginForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private int _failedLoginAttempts = 0;
        private const int MaxFailedAttempts = 5;

        public LoginForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;

            // Load saved username/email if "Remember Me" was checked
            var savedData = Properties.Settings.Default.UsernameOrEmail;
            if (!string.IsNullOrWhiteSpace(savedData))
            {
                kryptonTextBox1.Text = Decrypt(savedData);
                chkRememberMe.Checked = true;
            }
        }
        private CancellationTokenSource? _cts;
        private async void ShowMessage(string msg, bool isSuccess)
        {
            _cts?.Cancel();
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            lblMessage.Text = msg;
            lblMessage.ForeColor = isSuccess ? Color.Green : Color.Red;
            lblMessage.BringToFront(); // Make sure it's on top
            lblMessage.Visible = true;
            this.Refresh(); // Force UI refresh

            try
            {
                await Task.Delay(3000, token);
                if (!token.IsCancellationRequested)
                    lblMessage.Visible = false;
            }
            catch (TaskCanceledException)
            {
                // Ignore
            }
        }
        //private void MarkTextBoxError(TextBox textBox)
        //{
        //    textBox.BorderStyle = BorderStyle.FixedSingle;
        //    textBox.BackColor = Color.MistyRose; // Màu nền hồng nhạt
        //    textBox.ForeColor = Color.Red; // Màu chữ đỏ
        //}
        // Dictionary để lưu trữ CancellationTokenSource cho từng TextBox
        //private Dictionary<TextBox, CancellationTokenSource> _textBoxTokenSources = new Dictionary<TextBox, CancellationTokenSource>();

        // Đánh dấu TextBox lỗi với viền màu đỏ và tự động reset sau một khoảng thời gian
        //Cho textbox
        //private async void MarkTextBoxError(TextBox textBox, int durationMs = 3000)
        //{
        //    // Hủy timer cũ nếu có
        //    if (_textBoxTokenSources.ContainsKey(textBox))
        //    {
        //        _textBoxTokenSources[textBox].Cancel();
        //        _textBoxTokenSources.Remove(textBox);
        //    }

        //    // Tạo CancellationTokenSource mới
        //    var cts = new CancellationTokenSource();
        //    _textBoxTokenSources[textBox] = cts;
        //    var token = cts.Token;

        //    // Đánh dấu lỗi
        //    textBox.BorderStyle = BorderStyle.FixedSingle;
        //    textBox.BackColor = Color.MistyRose; // Màu nền hồng nhạt
        //    textBox.ForeColor = Color.Red; // Màu chữ đỏ

        //    try
        //    {
        //        // Chờ trong khoảng thời gian xác định
        //        await Task.Delay(durationMs, token);

        //        // Reset trạng thái TextBox nếu không bị hủy
        //        if (!token.IsCancellationRequested)
        //        {
        //            ResetTextBoxState(textBox);
        //        }
        //    }
        //    catch (TaskCanceledException)
        //    {
        //        // Bỏ qua nếu task bị hủy
        //    }
        //    finally
        //    {
        //        // Xóa khỏi dictionary nếu vẫn còn
        //        if (_textBoxTokenSources.ContainsKey(textBox))
        //        {
        //            _textBoxTokenSources.Remove(textBox);
        //        }
        //    }
        //}
        //Cho krypton txtbox
        private Dictionary<Control, CancellationTokenSource> _textBoxTokenSources = new Dictionary<Control, CancellationTokenSource>();
        private async void MarkTextBoxError(KryptonTextBox kryptonTextBox, int durationMs = 3000)
        {
            var cts = new CancellationTokenSource();
            _textBoxTokenSources[kryptonTextBox] = cts;
            var token = cts.Token;

            // Highlight the error using KryptonTextBox's StateCommon properties
            kryptonTextBox.StateCommon.Border.Color1 = Color.Red;
            kryptonTextBox.StateCommon.Back.Color1 = Color.MistyRose;
            kryptonTextBox.StateCommon.Content.Color1 = Color.Red;

            try
            {
                await Task.Delay(durationMs, token);
                if (!token.IsCancellationRequested)
                    ResetTextBoxState(kryptonTextBox);  // Reset for KryptonTextBox
            }
            catch (TaskCanceledException)
            {
                // Ignore task cancellation
            }
            finally
            {
                if (_textBoxTokenSources.ContainsKey(kryptonTextBox))
                    _textBoxTokenSources.Remove(kryptonTextBox);
            }
        }

        // Đặt lại trạng thái bình thường cho TextBox
        //private void ResetTextBoxState(TextBox textBox)
        //{
        //    // Hủy timer hiện tại nếu có
        //    if (_textBoxTokenSources.ContainsKey(textBox))
        //    {
        //        _textBoxTokenSources[textBox].Cancel();
        //        _textBoxTokenSources.Remove(textBox);
        //    }

        //    // Reset về trạng thái bình thường
        //    textBox.BorderStyle = BorderStyle.Fixed3D;
        //    textBox.BackColor = SystemColors.Window; // Màu nền mặc định
        //    textBox.ForeColor = SystemColors.WindowText; // Màu chữ mặc định
        //}
        private void ResetTextBoxState(Control control)
        {
            if (control is KryptonTextBox kryptonTextBox)
            {
                // Reset KryptonTextBox styles
                kryptonTextBox.StateCommon.Border.Color1 = SystemColors.ControlDark;
                kryptonTextBox.StateCommon.Back.Color1 = SystemColors.Window;
                kryptonTextBox.StateCommon.Content.Color1 = SystemColors.ControlText;
            }
            else if (control is TextBox textBox)
            {
                // Reset standard TextBox styles
                textBox.BorderStyle = BorderStyle.Fixed3D;
                textBox.BackColor = SystemColors.Window;
                textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void ResetInputFields()
        {
            txtPassword.Clear();
            txtPassword.Focus();
        }
        /// <summary>
        /// Mã hóa chuỗi bằng Base64.
        /// </summary>
        private string Encrypt(string plainText)
        {
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainBytes);
        }

        /// <summary>
        /// Giải mã chuỗi từ Base64.
        /// </summary>
        private string Decrypt(string encryptedText)
        {
            try
            {
                var encryptedBytes = Convert.FromBase64String(encryptedText);
                return Encoding.UTF8.GetString(encryptedBytes);
            }
            catch
            {
                return ""; // Trả về chuỗi rỗng nếu giải mã thất bại
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            _failedLoginAttempts = 0;
            lblMessage.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!_context.Database.CanConnect())
            {
                ShowMessage("Không thể kết nối đến cơ sở dữ liệu. Vui lòng thử lại sau.", false);
                return;
            }
            if (_failedLoginAttempts >= MaxFailedAttempts)
            {
                ShowMessage("Bạn đã nhập sai quá nhiều lần. Vui lòng thử lại sau.", false);
                return;
            }

            var usernameOrEmail = kryptonTextBox1.Text.Trim();
            var password = kryptonTextBox2.Text;

            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
            {
                MarkTextBoxError(kryptonTextBox1, 3000);
                MarkTextBoxError(kryptonTextBox2, 3000);
                ShowMessage("Vui lòng nhập đầy đủ thông tin.", false);
                return;
            }

            // Tìm người dùng theo username hoặc email
            var user = _context.Users
                .FirstOrDefault(u => u.Username == usernameOrEmail || u.Email == usernameOrEmail);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                MarkTextBoxError(kryptonTextBox1, 3000);
                MarkTextBoxError(kryptonTextBox2, 3000);
                _failedLoginAttempts++;
                ShowMessage("Sai thông tin đăng nhập.", false);
                ResetInputFields();
                return;
            }

            // Reset số lần đăng nhập sai nếu thành công
            _failedLoginAttempts = 0;

            // Lưu thông tin "Remember Me" nếu được chọn
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UsernameOrEmail = Encrypt(usernameOrEmail);
            }
            else
            {
                Properties.Settings.Default.UsernameOrEmail = "";
            }
            Properties.Settings.Default.Save();

            // Điều hướng dựa trên vai trò của người dùng
            if (user.Role == User.UserRole.Admin)
            {
                ShowMessage("Đăng nhập thành công! Chào mừng Admin.", true);
                // Mở form quản trị (AdminForm)
                //var adminForm = new AdminForm();
                //adminForm.Show();
                //this.Close();
                var adminForm = new AdminForm(_context);
                this.Hide();
                adminForm.FormClosed += (s, args) => this.Close(); // đảm bảo app không bị đóng sớm
                adminForm.Show();
            }
            else
            {
                ShowMessage("Đăng nhập thành công! Chào mừng bạn.", true);
                // Mở form người dùng (UserForm)
                //var userForm = new UserForm(user);
                //userForm.Show();
                //this.Close();
                var userForm = new UserForm(_context, user.UserId);
                this.Hide();
                userForm.FormClosed += (s, args) => this.Close();
                userForm.Show();
            }
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm(_context);
            var result = registerForm.ShowDialog(); // chờ RegisterForm xử lý

            if (result == DialogResult.OK)
            {
                ShowMessage("Đăng ký thành công! Vui lòng đăng nhập.", true);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (!_context.Database.CanConnect())
            {
                ShowMessage("Không thể kết nối đến cơ sở dữ liệu. Vui lòng thử lại sau.", false);
                return;
            }
            if (_failedLoginAttempts >= MaxFailedAttempts)
            {
                ShowMessage("Bạn đã nhập sai quá nhiều lần. Vui lòng thử lại sau.", false);
                return;
            }

            var usernameOrEmail = kryptonTextBox1.Text.Trim();
            var password = kryptonTextBox2.Text;

            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
            {
                MarkTextBoxError(kryptonTextBox1, 3000);
                MarkTextBoxError(kryptonTextBox2, 3000);
                ShowMessage("Vui lòng nhập đầy đủ thông tin.", false);
                return;
            }

            // Tìm người dùng theo username hoặc email
            var user = _context.Users
                .FirstOrDefault(u => u.Username == usernameOrEmail || u.Email == usernameOrEmail);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                MarkTextBoxError(kryptonTextBox1, 3000);
                MarkTextBoxError(kryptonTextBox2, 3000);
                _failedLoginAttempts++;
                ShowMessage("Sai thông tin đăng nhập.", false);
                ResetInputFields();
                return;
            }

            // Reset số lần đăng nhập sai nếu thành công
            _failedLoginAttempts = 0;

            // Lưu thông tin "Remember Me" nếu được chọn
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UsernameOrEmail = Encrypt(usernameOrEmail);
            }
            else
            {
                Properties.Settings.Default.UsernameOrEmail = "";
            }
            Properties.Settings.Default.Save();

            // Điều hướng dựa trên vai trò của người dùng
            if (user.Role == User.UserRole.Admin)
            {
                ShowMessage("Đăng nhập thành công! Chào mừng Admin.", true);
                // Mở form quản trị (AdminForm)
                //var adminForm = new AdminForm();
                //adminForm.Show();
                //this.Close();
                var adminForm = new AdminForm(_context);
                this.Hide();
                adminForm.FormClosed += (s, args) => this.Close(); // đảm bảo app không bị đóng sớm
                adminForm.Show();
            }
            else
            {
                ShowMessage("Đăng nhập thành công! Chào mừng bạn.", true);
                // Mở form người dùng (UserForm)
                //var userForm = new UserForm(user);
                //userForm.Show();
                //this.Close();
                var userForm = new UserForm(_context, user.UserId);
                this.Hide();
                userForm.FormClosed += (s, args) => this.Close();
                userForm.Show();
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_context);
            var result = registerForm.ShowDialog(); // chờ RegisterForm xử lý

            if (result == DialogResult.OK)
            {
                ShowMessage("Đăng ký thành công! Vui lòng đăng nhập.", true);
            }
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
