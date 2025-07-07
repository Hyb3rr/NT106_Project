using BookReaderApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReaderApp.Data
{
    public class BookReaderDbContext : DbContext
    {
        public BookReaderDbContext(DbContextOptions<BookReaderDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Rating> Ratings { get; set; } = null!;
        public DbSet<Bookmark> Bookmarks { get; set; } = null!;
        public DbSet<Note> Notes { get; set; } = null!;
        public DbSet<UserLibrary> UserLibraries { get; set; } = null!;
        public DbSet<AdminLog> AdminLogs { get; set; } = null!;
        public DbSet<ChatRoom> ChatRooms { get; set; } = null!;
        public DbSet<ChatMessage> ChatMessages { get; set; } = null!;
        public DbSet<ChatRoomMember> ChatRoomMembers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Unique Index for Email in User
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Index for Book Title
            modelBuilder.Entity<Book>()
                .HasIndex(b => b.Title);

            // Required and MaxLength Constraints
            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasConversion<string>(); // Lưu enum dưới dạng chuỗi
            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Uploader)
                .WithMany(u => u.UploadedBooks)
                .HasForeignKey(b => b.UploaderId);


            modelBuilder.Entity<Rating>()
                .Property(r => r.Score)
                .IsRequired(false);
                //.HasDefaultValue(0);

            // Relationships
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Ratings)
                .HasForeignKey(r => r.BookId);

            modelBuilder.Entity<Bookmark>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookmarks)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Bookmark>()
                .HasOne(b => b.Book)
                .WithMany(bk => bk.Bookmarks)
                .HasForeignKey(b => b.BookId);

            modelBuilder.Entity<Note>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notes)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Note>()
                .HasOne(n => n.Book)
                .WithMany(b => b.Notes)
                .HasForeignKey(n => n.BookId);

            modelBuilder.Entity<UserLibrary>()
                .HasOne(ul => ul.User)
                .WithMany(u => u.UserLibraries)
                .HasForeignKey(ul => ul.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserLibrary>()
                .HasOne(ul => ul.Book)
                .WithMany(b => b.UserLibraries)
                .HasForeignKey(ul => ul.BookId);

            modelBuilder.Entity<AdminLog>()
                .HasOne(al => al.Admin)
                .WithMany()
                .HasForeignKey(al => al.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            // Chat Room Relationships
            modelBuilder.Entity<ChatRoom>()
                .HasOne(cr => cr.Book)
                .WithMany()
                .HasForeignKey(cr => cr.BookId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ChatMessage>()
                .HasOne(cm => cm.ChatRoom)
                .WithMany(cr => cr.Messages)
                .HasForeignKey(cm => cm.ChatRoomId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChatMessage>()
                .HasOne(cm => cm.User)
                .WithMany()
                .HasForeignKey(cm => cm.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChatRoomMember>()
                .HasOne(crm => crm.ChatRoom)
                .WithMany(cr => cr.Members)
                .HasForeignKey(crm => crm.ChatRoomId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChatRoomMember>()
                .HasOne(crm => crm.User)
                .WithMany()
                .HasForeignKey(crm => crm.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Unique constraint for ChatRoomMember
            modelBuilder.Entity<ChatRoomMember>()
                .HasIndex(crm => new { crm.ChatRoomId, crm.UserId })
                .IsUnique();
        }
    }
}