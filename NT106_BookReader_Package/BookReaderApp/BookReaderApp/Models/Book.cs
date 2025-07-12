using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookReaderApp.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; } = "";

        public string? Description { get; set; }

        [Required]
        public string Author { get; set; } = "";

        public DateTime PublishedDate { get; set; }

        public string? CoverImage { get; set; }

        public string? FilePath { get; set; }
        public string? DriveUrl { get; set; }

        // Quan hệ 1-nhiều với Category
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        public int UploaderId { get; set; }
        public User Uploader { get; set; } = null!;

        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
        public ICollection<Note> Notes { get; set; } = new List<Note>();
        public ICollection<UserLibrary> UserLibraries { get; set; } = new List<UserLibrary>();
    }
}