using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Email { get; set; } = "";
        public string FullName { get; set; } = "";
        public string? Avatar { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; } = true;
        public string Role { get; set; } = "User";

        // Navigation
        public ICollection<Book> UploadedBooks { get; set; } = new List<Book>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
        public ICollection<Note> Notes { get; set; } = new List<Note>();
        public ICollection<UserLibrary> UserLibraries { get; set; } = new List<UserLibrary>();
    }
}
