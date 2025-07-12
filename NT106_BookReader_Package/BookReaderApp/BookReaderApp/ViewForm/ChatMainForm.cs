using BookReaderApp.Data;
using BookReaderApp.Models;
using BookReaderApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookReaderApp.ViewForm
{
    public partial class ChatMainForm : Form
    {
        private readonly ChatService _chatService;
        private readonly int _currentUserId;
        private readonly DbContextOptions<BookReaderDbContext> _dbOptions;
        private ChatRoom? _currentChatRoom;
        private System.Windows.Forms.Timer _messageRefreshTimer;

        public ChatMainForm(BookReaderDbContext context, int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
            _dbOptions = context.Database.GetDbConnection().ConnectionString != null ?
                new DbContextOptionsBuilder<BookReaderDbContext>()
                    .UseSqlServer(context.Database.GetDbConnection().ConnectionString)
                    .Options : throw new InvalidOperationException("Cannot get connection string");

            // Initialize ChatService
            _chatService = new ChatService(_dbOptions);

            // Setup timer to refresh messages
            _messageRefreshTimer = new System.Windows.Forms.Timer();
            _messageRefreshTimer.Interval = 3000; // 3 seconds
            _messageRefreshTimer.Tick += MessageRefreshTimer_Tick;
        }

        private async void ChatMainForm_Load(object sender, EventArgs e)
        {
            await LoadChatRooms();
            UpdateUI();
        }

        private async Task LoadChatRooms()
        {
            try
            {
                var chatRooms = await _chatService.GetActiveChatRoomsAsync();
                listBoxChatRooms.DataSource = chatRooms;
                listBoxChatRooms.DisplayMember = "Name";
                listBoxChatRooms.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phòng chat: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void listBoxChatRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxChatRooms.SelectedItem is ChatRoom selectedRoom)
            {
                await JoinChatRoom(selectedRoom);
            }
        }

        private async Task JoinChatRoom(ChatRoom chatRoom)
        {
            try
            {
                // Join the room (silently handle duplicates)
                await _chatService.JoinChatRoomAsync(chatRoom.Id, _currentUserId);

                _currentChatRoom = chatRoom;

                // Update room label with more info
                if (chatRoom.BookId != null)
                {
                    lblCurrentRoom.Text = $"Phòng: {chatRoom.Name} (Thảo luận về sách)";
                }
                else
                {
                    lblCurrentRoom.Text = $"Phòng: {chatRoom.Name} (Chat chung)";
                }

                // Load book image if this is a book-specific room
                await LoadBookImage();

                // Load messages and members
                await LoadMessages();
                await LoadMembers();

                UpdateUI();

                // Start message refresh timer
                _messageRefreshTimer.Start();
            }
            catch (Exception ex)
            {
                // Only show error if it's not a join-related error
                if (!ex.Message.Contains("saving the entity changes"))
                {
                    MessageBox.Show($"Lỗi khi tham gia phòng chat: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Still proceed with loading the room even if join failed
                    _currentChatRoom = chatRoom;
                    lblCurrentRoom.Text = $"Phòng: {chatRoom.Name}";

                    await LoadMessages();
                    await LoadMembers();

                    UpdateUI();
                    _messageRefreshTimer.Start();
                }
            }
        }

        private async Task LoadMessages()
        {
            if (_currentChatRoom == null) return;

            try
            {
                var messages = await _chatService.GetLatestMessagesAsync(_currentChatRoom.Id, 50);
                richTextBoxMessages.Clear();

                foreach (var message in messages)
                {
                    AppendMessage(message);
                }

                // Scroll to bottom
                richTextBoxMessages.SelectionStart = richTextBoxMessages.Text.Length;
                richTextBoxMessages.ScrollToCaret();
            }
            catch (Exception ex)
            {
                // Only show error if it's not a temporary database issue
                if (!ex.Message.Contains("A second operation") && !ex.Message.Contains("saving the entity changes"))
                {
                    MessageBox.Show($"Lỗi khi tải tin nhắn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task LoadMembers()
        {
            if (_currentChatRoom == null) return;

            try
            {
                var members = await _chatService.GetChatRoomMembersAsync(_currentChatRoom.Id);
                listBoxMembers.DataSource = members.Select(m => m.User.Username).ToList();
            }
            catch (Exception ex)
            {
                // Only show error if it's not a temporary database issue
                if (!ex.Message.Contains("A second operation") && !ex.Message.Contains("saving the entity changes"))
                {
                    MessageBox.Show($"Lỗi khi tải danh sách thành viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AppendMessage(ChatMessage message)
        {
            var timestamp = message.SentAt.ToString("HH:mm:ss");
            var formattedMessage = $"[{timestamp}] {message.User.Username}: {message.Content}\n";
            richTextBoxMessages.AppendText(formattedMessage);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await SendMessage();
        }

        private async void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await SendMessage();
                e.SuppressKeyPress = true;
            }
        }

        private async Task SendMessage()
        {
            if (_currentChatRoom == null || string.IsNullOrWhiteSpace(textBoxMessage.Text))
                return;

            try
            {
                var message = await _chatService.SendMessageAsync(_currentChatRoom.Id, _currentUserId, textBoxMessage.Text.Trim());
                textBoxMessage.Clear();

                // Add message to display immediately
                AppendMessage(message);

                // Scroll to bottom
                richTextBoxMessages.SelectionStart = richTextBoxMessages.Text.Length;
                richTextBoxMessages.ScrollToCaret();
            }
            catch (Exception ex)
            {
                // Only show error if it's not a temporary database issue
                if (!ex.Message.Contains("saving the entity changes") && !ex.Message.Contains("A second operation"))
                {
                    MessageBox.Show($"Lỗi khi gửi tin nhắn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // If it's a temporary error, just clear the textbox and continue
                textBoxMessage.Clear();
            }
        }

        private async void MessageRefreshTimer_Tick(object? sender, EventArgs e)
        {
            if (_currentChatRoom != null)
            {
                try
                {
                    // Simple refresh - in a real app, you'd want to only load new messages
                    await LoadMessages();
                }
                catch (Exception)
                {
                    // Ignore timer refresh errors silently
                }
            }
        }

        private async void btnRefreshRooms_Click(object sender, EventArgs e)
        {
            await LoadChatRooms();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            using var context = new BookReaderDbContext(_dbOptions);
            var createRoomForm = new CreateChatRoomForm(context, _currentUserId);
            if (createRoomForm.ShowDialog() == DialogResult.OK)
            {
                _ = LoadChatRooms(); // Refresh room list
            }
        }

        private async void btnLeaveRoom_Click(object sender, EventArgs e)
        {
            if (_currentChatRoom == null) return;

            var result = MessageBox.Show($"Bạn có chắc muốn rời khỏi phòng '{_currentChatRoom.Name}'?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    await _chatService.LeaveChatRoomAsync(_currentChatRoom.Id, _currentUserId);

                    _currentChatRoom = null;
                    lblCurrentRoom.Text = "Chọn phòng để chat";
                    richTextBoxMessages.Clear();
                    listBoxMembers.DataSource = null;
                    pictureBoxBook.Visible = false; // Hide book image

                    _messageRefreshTimer.Stop();
                    UpdateUI();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi rời phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateUI()
        {
            bool hasRoom = _currentChatRoom != null;
            btnSend.Enabled = hasRoom;
            textBoxMessage.Enabled = hasRoom;
            btnLeaveRoom.Enabled = hasRoom;
        }

        private async Task LoadBookImage()
        {
            try
            {
                if (_currentChatRoom?.BookId != null)
                {
                    using var context = new BookReaderDbContext(_dbOptions);
                    var book = await context.Books.FindAsync(_currentChatRoom.BookId);

                    if (book != null && !string.IsNullOrEmpty(book.CoverImage))
                    {
                        // Load image from file path
                        if (System.IO.File.Exists(book.CoverImage))
                        {
                            pictureBoxBook.Image = Image.FromFile(book.CoverImage);
                            pictureBoxBook.Visible = true;

                            // Add tooltip with book info
                            var toolTip = new ToolTip();
                            toolTip.SetToolTip(pictureBoxBook, $"Sách: {book.Title}\nTác giả: {book.Author}");
                        }
                        else
                        {
                            // Use default book image if file doesn't exist
                            SetDefaultBookImage();
                        }
                    }
                    else
                    {
                        // Use default book image if no cover path
                        SetDefaultBookImage();
                    }
                }
                else
                {
                    // Hide picture box for general chat rooms
                    pictureBoxBook.Visible = false;
                }
            }
            catch (Exception)
            {
                // On error, use default image or hide
                SetDefaultBookImage();
            }
        }

        private void SetDefaultBookImage()
        {
            try
            {
                // Try to use a default book image from resources
                if (Properties.Resources.catbook != null)
                {
                    pictureBoxBook.Image = Properties.Resources.catbook;
                    pictureBoxBook.Visible = true;
                }
                else
                {
                    pictureBoxBook.Visible = false;
                }
            }
            catch
            {
                pictureBoxBook.Visible = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _messageRefreshTimer?.Stop();
            _messageRefreshTimer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
