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
using BookReaderApp.Utils;
using BookReaderApp.Models;
using PasswordHelper = BookReaderApp.Utils.PasswordHelper;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BookReaderApp.Views
{
    public partial class ResetPassForm : Form
    {
        private bool emailVerified = false; // Biến để kiểm tra trạng thái email
        public ResetPassForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        Modify modify = new Modify();
        public bool CheckPassword(string ac) // Kiem tra tai khoan va mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$"); // Kiem tra ky tu
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text;
            string newPassword = textBox_NewPassword.Text;
            string confirm = textBox_ConfirmPassword.Text;
            if (!emailVerified) // Bước 1: Kiểm tra email trước
            {
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                int count = 0;

                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    count = (int)command.ExecuteScalar();
                    connection.Close();
                }

                if (count > 0)
                {
                    //MessageBox.Show("Email hợp lệ! Nhập mật khẩu mới để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_NewPassword.Enabled = true;
                    emailVerified = true; // Đánh dấu đã kiểm tra email
                    return;
                }
                else
                {
                    MessageBox.Show("Email không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TextBox[] textBoxes = { textBox_Email, textBox_NewPassword, textBox_ConfirmPassword };
                    foreach (TextBox textBox in textBoxes)
                    {
                        textBox.Clear();
                        //textBox.Enabled = false;
                        textBox_Email.Select();
                    }
                    return;
                }
            }

            // Bước 2: Cập nhật mật khẩu sau khi email đã xác thực
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckPassword(newPassword))
            {
                MessageBox.Show("Mật khẩu không hợp lệ! Yêu cầu 6-24 ký tự, gồm chữ và số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirm)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_ConfirmPassword.Clear();
                return;
            }

            string hashedPassword = PasswordHelper.HashPassword(newPassword);

            string updateQuery = "UPDATE Users SET PasswordHash = @NewPass WHERE Email = @Email";

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@NewPass", hashedPassword);
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Mật khẩu đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_NewPassword.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_NewPassword_KeyDown(object sender, KeyEventArgs e)
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
                button_Reset.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
