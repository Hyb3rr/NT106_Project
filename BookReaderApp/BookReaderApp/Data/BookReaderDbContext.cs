using BookReaderApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Data
{
    public class BookReaderDbContext : DbContext
    {
        public BookReaderDbContext(DbContextOptions<BookReaderDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<UserLibrary> UserLibraries => Set<UserLibrary>();
        public DbSet<Note> Notes => Set<Note>();
        public DbSet<Bookmark> Bookmarks => Set<Bookmark>();
        public DbSet<Rating> Ratings => Set<Rating>();
        public DbSet<AdminLog> AdminLogs => Set<AdminLog>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Unique email
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Quan hệ Book → User (Uploader)
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Uploader)
                .WithMany(u => u.UploadedBooks)
                .HasForeignKey(b => b.UploadedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // Book → Category
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId);

            modelBuilder.Entity<Book>().HasIndex(b => b.Title);

            // UserLibrary
            modelBuilder.Entity<UserLibrary>()
                .HasOne(ul => ul.User)
                .WithMany(u => u.UserLibraries)
                .HasForeignKey(ul => ul.UserId);

            modelBuilder.Entity<UserLibrary>()
                .HasOne(ul => ul.Book)
                .WithMany(b => b.UserLibraries)
                .HasForeignKey(ul => ul.BookId);

            // Bookmark
            modelBuilder.Entity<Bookmark>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookmarks)
                .HasForeignKey(b => b.UserId);

            modelBuilder.Entity<Bookmark>()
                .HasOne(b => b.Book)
                .WithMany(bk => bk.Bookmarks)
                .HasForeignKey(b => b.BookId);

            // Note
            modelBuilder.Entity<Note>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notes)
                .HasForeignKey(n => n.UserId);

            modelBuilder.Entity<Note>()
                .HasOne(n => n.Book)
                .WithMany(b => b.Notes)
                .HasForeignKey(n => n.BookId);

            // Rating
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Ratings)
                .HasForeignKey(r => r.BookId);

            // AdminLog
            modelBuilder.Entity<AdminLog>()
                .HasOne(log => log.Admin)
                .WithMany()
                .HasForeignKey(log => log.AdminId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
