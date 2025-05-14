using System.ComponentModel.DataAnnotations;

namespace BookReaderApp.Models
{
    public class UserLibrary
    {
        public int UserLibraryId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }
        public int CurrentPage { get; set; }
        public DateTime LastReadDate { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.UtcNow;

        public User User { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}