﻿using System.ComponentModel.DataAnnotations;

namespace BookReaderApp.Models
{
    public class Bookmark
    {
        public int BookmarkId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Page number must be greater than 0.")]
        public int PageNumber { get; set; }

        public User User { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}