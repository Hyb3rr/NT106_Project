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
    public partial class AdminForm : Form
    {
        private readonly BookReaderDbContext _context;
        private readonly int _currentAdminId; // ID của Admin đang đăng nhập

        public AdminForm(BookReaderDbContext context, int currentAdminId)
        {
            InitializeComponent();
            _context = context;
            _currentAdminId = currentAdminId; // Lưu ID của Admin đang đăng nhập
            LoadUsers();
            LoadBooks();
            LoadLogs();
        }
        private void LoadUsers()
        {
            var users = _context.Users
                .Select(u => new
                {
                    u.UserId,
                    u.Username,
                    u.Email,
                    u.Role,
                    u.IsActive,
                    u.CreatedDate
                })
                .ToList();

            dataGridViewUsers.DataSource = users;
        }

        private void LoadBooks()
        {
            var books = _context.Books
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Author,
                    b.CategoryId,
                    b.UploadDate
                })
                .ToList();

            dataGridViewBooks.DataSource = books;
        }

        private void LoadLogs()
        {
            var logs = _context.AdminLogs
                .Select(log => new
                {
                    log.LogId,
                    log.AdminId,
                    log.Action,
                    log.Timestamp
                })
                .ToList();

            dataGridViewLogs.DataSource = logs;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm(_context);
            addUserForm.ShowDialog(); // Mở form thêm người dùng
            LoadUsers(); // Refresh danh sách sau khi thêm
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var userId = (int)dataGridViewUsers.SelectedRows[0].Cells["UserId"].Value;
                var editUserForm = new EditUserForm(_context, userId, _currentAdminId); // Truyền _currentAdminId
                editUserForm.ShowDialog(); // Mở form sửa thông tin người dùng
                LoadUsers(); // Refresh danh sách người dùng sau khi sửa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var userId = (int)dataGridViewUsers.SelectedRows[0].Cells["UserId"].Value;
                var user = _context.Users.Find(userId);

                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    MessageBox.Show("Xóa người dùng thành công!");
                    LoadUsers(); // Refresh danh sách người dùng
                }
            }
        }
    }
}
