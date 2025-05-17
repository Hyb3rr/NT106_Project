using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookReaderApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = "";

        [Required]
        public string PasswordHash { get; set; } = "";

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string Email { get; set; } = "";

        public string FullName { get; set; } = "";

        public string? Avatar { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? LastLogin { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public UserRole Role { get; set; } = UserRole.User;
        public enum UserRole
        {
            User,
            Admin
        }
        public ICollection<Book> UploadedBooks { get; set; } = new List<Book>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
        public ICollection<Note> Notes { get; set; } = new List<Note>();
        public ICollection<UserLibrary> UserLibraries { get; set; } = new List<UserLibrary>();
    }
}