using BookReaderApp.Data;
using BookReaderApp.Models;
using BookReaderApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookReaderApp.ViewForm
{
    public partial class CreateChatRoomForm : Form
    {
        private readonly ChatService _chatService;
        private readonly DbContextOptions<BookReaderDbContext> _dbOptions;
        private readonly int _currentUserId;

        public CreateChatRoomForm(BookReaderDbContext context, int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
            
            // Get DbContextOptions from existing context
            _dbOptions = context.Database.GetDbConnection().ConnectionString != null ? 
                new DbContextOptionsBuilder<BookReaderDbContext>()
                    .UseSqlServer(context.Database.GetDbConnection().ConnectionString)
                    .Options : throw new InvalidOperationException("Cannot get connection string");
            
            _chatService = new ChatService(_dbOptions);
        }

        private async void CreateChatRoomForm_Load(object sender, EventArgs e)
        {
            await LoadBooks();
        }

        private async Task LoadBooks()
        {
            try
            {
                using var context = new BookReaderDbContext(_dbOptions);
                var books = await context.Books.OrderBy(b => b.Title).ToListAsync();
                comboBoxBooks.DataSource = books;
                comboBoxBooks.DisplayMember = "Title";
                comboBoxBooks.ValueMember = "BookId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxBookSpecific_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxBooks.Enabled = checkBoxBookSpecific.Checked;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRoomName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRoomName.Focus();
                return;
            }

            try
            {
                int? bookId = null;
                if (checkBoxBookSpecific.Checked && comboBoxBooks.SelectedValue != null)
                {
                    if (int.TryParse(comboBoxBooks.SelectedValue.ToString(), out int selectedBookId))
                    {
                        bookId = selectedBookId;
                    }
                }

                var chatRoom = await _chatService.CreateChatRoomAsync(
                    textBoxRoomName.Text.Trim(),
                    string.IsNullOrWhiteSpace(textBoxDescription.Text) ? null : textBoxDescription.Text.Trim(),
                    bookId
                );

                // Automatically join the creator to the room
                await _chatService.JoinChatRoomAsync(chatRoom.Id, _currentUserId);

                MessageBox.Show("Tạo phòng chat thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo phòng chat: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Don't dispose _context as it's shared from parent form
            base.OnFormClosing(e);
        }
    }
}
