using BookReaderApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class RegisterForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        public RegisterForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;
            lblMessage.Visible = false;
        }
        private bool IsPasswordStrong(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            TextBox tb = kryptonTextBox4.TextBox;
            tb.PasswordChar = checkBox1.Checked ? '\0' : '*';
            TextBox tb1 = kryptonTextBox5.TextBox;
            tb1.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }
        private async void ShowMsg(string m, bool ok)
        {
            lblMessage.Text = m;
            lblMessage.ForeColor = ok ? Color.Green : Color.Red;
            lblMessage.Visible = true;

            // Ẩn thông báo sau 5 giây
            await Task.Delay(5000);
            lblMessage.Visible = false;
        }
        // Dictionary để lưu trữ CancellationTokenSource cho từng TextBox
        //private Dictionary<TextBox, CancellationTokenSource> _textBoxTokenSources = new Dictionary<TextBox, CancellationTokenSource>();
        private Dictionary<Control, CancellationTokenSource> _textBoxTokenSources = new Dictionary<Control, CancellationTokenSource>();

        // Đánh dấu TextBox lỗi với viền màu đỏ và tự động reset sau một khoảng thời gian
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
        /*
         * private async void MarkTextBoxError(TextBox textBox, int durationMs = 3000)
        {
            // Hủy timer cũ nếu có
            if (_textBoxTokenSources.ContainsKey(textBox))
            {
                _textBoxTokenSources[textBox].Cancel();
                _textBoxTokenSources.Remove(textBox);
            }

            // Tạo CancellationTokenSource mới
            var cts = new CancellationTokenSource();
            _textBoxTokenSources[textBox] = cts;
            var token = cts.Token;

            // Đánh dấu lỗi
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Color.MistyRose; // Màu nền hồng nhạt
            textBox.ForeColor = Color.Red; // Màu chữ đỏ

            try
            {
                // Chờ trong khoảng thời gian xác định
                await Task.Delay(durationMs, token);

                // Reset trạng thái TextBox nếu không bị hủy
                if (!token.IsCancellationRequested)
                {
                    ResetTextBoxState(textBox);
                }
            }
            catch (TaskCanceledException)
            {
                // Bỏ qua nếu task bị hủy
            }
            finally
            {
                // Xóa khỏi dictionary nếu vẫn còn
                if (_textBoxTokenSources.ContainsKey(textBox))
                {
                    _textBoxTokenSources.Remove(textBox);
                }
            }
        }
        */
        // Đặt lại trạng thái bình thường cho TextBox
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
        /*
        private void ResetTextBoxState(TextBox textBox)
        {
            // Hủy timer hiện tại nếu có
            if (_textBoxTokenSources.ContainsKey(textBox))
            {
                _textBoxTokenSources[textBox].Cancel();
                _textBoxTokenSources.Remove(textBox);
            }

            // Reset về trạng thái bình thường
            textBox.BorderStyle = BorderStyle.Fixed3D;
            textBox.BackColor = SystemColors.Window; // Màu nền mặc định
            textBox.ForeColor = SystemColors.WindowText; // Màu chữ mặc định
        }
        */
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var u = kryptonTextBox1.Text.Trim();
            var em = kryptonTextBox2.Text.Trim();
            var fn = kryptonTextBox3.Text.Trim();
            var p = kryptonTextBox4.Text;
            var cp = kryptonTextBox5.Text;
            KryptonTextBox[] textBoxes = { kryptonTextBox1, kryptonTextBox2, kryptonTextBox3, kryptonTextBox4, kryptonTextBox5 };
            if (!_context.Database.CanConnect())
            {
                ShowMsg("Không thể kết nối đến cơ sở dữ liệu. Vui lòng thử lại sau.", false);
                return;
            }
            if (new[] { u, em, fn, p, cp }.Any(string.IsNullOrEmpty))
            {
                foreach (var textBox in textBoxes)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MarkTextBoxError(textBox, 3000);
                    }
                }
                ShowMsg("Nhập đầy đủ thông tin.", false);
                return;
            }

            if (u.Length < 3 || u.Length > 50)
            {
                MarkTextBoxError(kryptonTextBox1, 3000);
                ShowMsg("Username phải từ 3 đến 50 ký tự.", false);
                return;
            }

            if (em.Length > 255 || !new EmailAddressAttribute().IsValid(em))
            {
                MarkTextBoxError(kryptonTextBox2, 3000);
                ShowMsg("Email không hợp lệ hoặc vượt quá 255 ký tự.", false);
                return;
            }

            if (p.Length > 100)
            {
                MarkTextBoxError(kryptonTextBox4, 3000);
                ShowMsg("Mật khẩu không được vượt quá 100 ký tự.", false);
                return;
            }

            if (!IsPasswordStrong(p))
            {
                MarkTextBoxError(kryptonTextBox4, 3000);
                ShowMsg("Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt.", false);
                return;
            }

            if (p != cp)
            {
                MarkTextBoxError(kryptonTextBox5, 3000);
                ShowMsg("Mật khẩu không khớp.", false);
                return;
            }

            if (_context.Users.Any(x => x.Username == u))
            {
                MarkTextBoxError(kryptonTextBox1, 3000);
                ShowMsg("Username đã tồn tại.", false);
                return;
            }

            if (_context.Users.Any(x => x.Email == em))
            {
                MarkTextBoxError(kryptonTextBox2, 3000);
                ShowMsg("Email đã tồn tại.", false);
                return;
            }

            var user = new User
            {
                Username = u,
                Email = em,
                FullName = fn,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(p),
                Role = User.UserRole.User,
                CreatedDate = DateTime.Now,
                IsActive = true
            };

            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                ShowMsg("Đăng ký thành công!", true);
                ResetFields();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ShowMsg("Đã xảy ra lỗi trong quá trình đăng ký. Vui lòng thử lại sau.", false);
            }
        }
        private void ResetFields()
        {
            kryptonTextBox1.Clear();
            kryptonTextBox2.Clear();
            kryptonTextBox3.Clear();
            kryptonTextBox4.Clear();
            kryptonTextBox5.Clear();
            kryptonTextBoxAvatarPath.Clear();
            kryptonPictureBoxAvatar.Image = null;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            var u = kryptonTextBox1.Text.Trim();
            var em = kryptonTextBox2.Text.Trim();
            var fn = kryptonTextBox3.Text.Trim();
            var p = kryptonTextBox4.Text;
            var cp = kryptonTextBox5.Text;
            KryptonTextBox[] textBoxes = { kryptonTextBox1, kryptonTextBox2, kryptonTextBox3, kryptonTextBox4, kryptonTextBox5 };
            if (!_context.Database.CanConnect())
            {
                ShowMsg("Không thể kết nối đến cơ sở dữ liệu. Vui lòng thử lại sau.", false);
                return;
            }
            if (new[] { u, em, fn, p, cp }.Any(string.IsNullOrEmpty))
            {
                foreach (var textBox in textBoxes)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MarkTextBoxError(textBox, 3000);
                    }
                }
                ShowMsg("Nhập đầy đủ thông tin.", false);
                return;
            }

            if (u.Length < 3 || u.Length > 50)
            {
                MarkTextBoxError(kryptonTextBox1, 3000);
                ShowMsg("Username phải từ 3 đến 50 ký tự.", false);
                return;
            }

            if (em.Length > 255 || !new EmailAddressAttribute().IsValid(em))
            {
                MarkTextBoxError(kryptonTextBox2, 3000);
                ShowMsg("Email không hợp lệ hoặc vượt quá 255 ký tự.", false);
                return;
            }

            if (p.Length > 100)
            {
                MarkTextBoxError(kryptonTextBox4, 3000);
                ShowMsg("Mật khẩu không được vượt quá 100 ký tự.", false);
                return;
            }

            if (!IsPasswordStrong(p))
            {
                MarkTextBoxError(kryptonTextBox4, 3000);
                ShowMsg("Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt.", false);
                return;
            }

            if (p != cp)
            {
                MarkTextBoxError(kryptonTextBox5, 3000);
                ShowMsg("Mật khẩu không khớp.", false);
                return;
            }

            if (_context.Users.Any(x => x.Username == u))
            {
                MarkTextBoxError(kryptonTextBox1, 3000);
                ShowMsg("Username đã tồn tại.", false);
                return;
            }

            if (_context.Users.Any(x => x.Email == em))
            {
                MarkTextBoxError(kryptonTextBox2, 3000);
                ShowMsg("Email đã tồn tại.", false);
                return;
            }
            // Xử lý ảnh đại diện
            string avatarPath = kryptonTextBoxAvatarPath.Text;
            string? permanentAvatarPath = null;

            if (!string.IsNullOrEmpty(avatarPath) && File.Exists(avatarPath))
            {
                try
                {
                    // Tạo thư mục lưu avatar nếu chưa tồn tại
                    string avatarDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BookReaderAvatars");
                    Directory.CreateDirectory(avatarDirectory);

                    // Tạo tên file duy nhất
                    string fileName = $"{Guid.NewGuid()}_{Path.GetFileName(avatarPath)}";
                    permanentAvatarPath = Path.Combine(avatarDirectory, fileName);

                    // Sao chép file vào vị trí cố định
                    File.Copy(avatarPath, permanentAvatarPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu ảnh đại diện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            var user = new User
            {
                Username = u,
                Email = em,
                FullName = fn,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(p),
                Role = User.UserRole.User,
                CreatedDate = DateTime.Now,
                IsActive = true,
                Avatar = permanentAvatarPath
            };

            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                ShowMsg("Đăng ký thành công!", true);
                ResetFields();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ShowMsg("Đã xảy ra lỗi trong quá trình đăng ký. Vui lòng thử lại sau.", false);
            }
        }

        private void kryptonButtonBrowseAvatar_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
                Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                kryptonTextBoxAvatarPath.Text = openFileDialog.FileName;

                try
                {
                    kryptonPictureBoxAvatar.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể hiển thị ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TextBox textBox = kryptonTextBox4.TextBox;
            textBox.PasswordChar = checkBox1.Checked ? '\0' : '*';

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TextBox textBox = kryptonTextBox5.TextBox;
            textBox.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }
    }
}
