using BookReaderApp.Data;
using BookReaderApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReaderApp.Services
{
    public class ChatService
    {
        private readonly DbContextOptions<BookReaderDbContext> _options;

        public ChatService(DbContextOptions<BookReaderDbContext> options)
        {
            _options = options;
        }

        private BookReaderDbContext CreateContext()
        {
            return new BookReaderDbContext(_options);
        }

        // Chat Room Management
        public async Task<ChatRoom> CreateChatRoomAsync(string name, string? description = null, int? bookId = null)
        {
            using var context = CreateContext();
            var chatRoom = new ChatRoom
            {
                Name = name,
                Description = description,
                BookId = bookId,
                CreatedAt = DateTime.Now,
                IsActive = true
            };

            context.ChatRooms.Add(chatRoom);
            await context.SaveChangesAsync();
            return chatRoom;
        }

        public async Task<List<ChatRoom>> GetActiveChatRoomsAsync()
        {
            using var context = CreateContext();
            return await context.ChatRooms
                .Where(cr => cr.IsActive)
                .Include(cr => cr.Book)
                .Include(cr => cr.Members)
                .ThenInclude(m => m.User)
                .OrderBy(cr => cr.Name)
                .ToListAsync();
        }

        public async Task<List<ChatRoom>> GetChatRoomsByBookAsync(int bookId)
        {
            using var context = CreateContext();
            return await context.ChatRooms
                .Where(cr => cr.BookId == bookId && cr.IsActive)
                .Include(cr => cr.Book)
                .Include(cr => cr.Members)
                .ThenInclude(m => m.User)
                .OrderBy(cr => cr.Name)
                .ToListAsync();
        }

        public async Task<ChatRoom?> GetChatRoomByIdAsync(int chatRoomId)
        {
            using var context = CreateContext();
            return await context.ChatRooms
                .Include(cr => cr.Book)
                .Include(cr => cr.Members)
                .ThenInclude(m => m.User)
                .FirstOrDefaultAsync(cr => cr.Id == chatRoomId);
        }

        // Chat Room Member Management
        public async Task<bool> JoinChatRoomAsync(int chatRoomId, int userId)
        {
            using var context = CreateContext();
            try
            {
                var existingMember = await context.ChatRoomMembers
                    .FirstOrDefaultAsync(crm => crm.ChatRoomId == chatRoomId && crm.UserId == userId);

                if (existingMember != null)
                {
                    if (!existingMember.IsActive)
                    {
                        existingMember.IsActive = true;
                        existingMember.JoinedAt = DateTime.Now;
                        await context.SaveChangesAsync();
                    }
                    return true;
                }

                var newMember = new ChatRoomMember
                {
                    ChatRoomId = chatRoomId,
                    UserId = userId,
                    JoinedAt = DateTime.Now,
                    IsActive = true
                };

                context.ChatRoomMembers.Add(newMember);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                // Ignore duplicate entry errors - user is already in the room
                return true;
            }
        }

        public async Task<bool> LeaveChatRoomAsync(int chatRoomId, int userId)
        {
            using var context = CreateContext();
            var member = await context.ChatRoomMembers
                .FirstOrDefaultAsync(crm => crm.ChatRoomId == chatRoomId && crm.UserId == userId);

            if (member != null)
            {
                member.IsActive = false;
                await context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<List<ChatRoomMember>> GetChatRoomMembersAsync(int chatRoomId)
        {
            using var context = CreateContext();
            return await context.ChatRoomMembers
                .Where(crm => crm.ChatRoomId == chatRoomId && crm.IsActive)
                .Include(crm => crm.User)
                .OrderBy(crm => crm.User.Username)
                .ToListAsync();
        }

        // Message Management
        public async Task<ChatMessage> SendMessageAsync(int chatRoomId, int userId, string content)
        {
            using var context = CreateContext();
            var message = new ChatMessage
            {
                ChatRoomId = chatRoomId,
                UserId = userId,
                Content = content,
                SentAt = DateTime.Now,
                IsDeleted = false
            };

            context.ChatMessages.Add(message);
            await context.SaveChangesAsync();

            // Load navigation properties
            await context.Entry(message)
                .Reference(m => m.User)
                .LoadAsync();

            return message;
        }

        public async Task<List<ChatMessage>> GetMessagesAsync(int chatRoomId, int pageSize = 50, int pageNumber = 1)
        {
            using var context = CreateContext();
            return await context.ChatMessages
                .Where(cm => cm.ChatRoomId == chatRoomId && !cm.IsDeleted)
                .Include(cm => cm.User)
                .OrderByDescending(cm => cm.SentAt)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<List<ChatMessage>> GetLatestMessagesAsync(int chatRoomId, int count = 20)
        {
            using var context = CreateContext();
            return await context.ChatMessages
                .Where(cm => cm.ChatRoomId == chatRoomId && !cm.IsDeleted)
                .Include(cm => cm.User)
                .OrderByDescending(cm => cm.SentAt)
                .Take(count)
                .OrderBy(cm => cm.SentAt)
                .ToListAsync();
        }

        public async Task<bool> DeleteMessageAsync(int messageId, int userId)
        {
            using var context = CreateContext();
            var message = await context.ChatMessages
                .FirstOrDefaultAsync(cm => cm.Id == messageId && cm.UserId == userId);

            if (message != null)
            {
                message.IsDeleted = true;
                await context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        // User's Chat Rooms
        public async Task<List<ChatRoom>> GetUserChatRoomsAsync(int userId)
        {
            using var context = CreateContext();
            return await context.ChatRoomMembers
                .Where(crm => crm.UserId == userId && crm.IsActive)
                .Include(crm => crm.ChatRoom)
                .ThenInclude(cr => cr.Book)
                .Select(crm => crm.ChatRoom)
                .OrderBy(cr => cr.Name)
                .ToListAsync();
        }

        public async Task<bool> IsUserInChatRoomAsync(int chatRoomId, int userId)
        {
            using var context = CreateContext();
            return await context.ChatRoomMembers
                .AnyAsync(crm => crm.ChatRoomId == chatRoomId && crm.UserId == userId && crm.IsActive);
        }
    }
}
