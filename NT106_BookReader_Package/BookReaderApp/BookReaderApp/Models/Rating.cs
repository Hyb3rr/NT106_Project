using System.ComponentModel.DataAnnotations;

namespace BookReaderApp.Models
{
    public class Rating
    {
        public int RatingId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        [Range(1, 5)]
        public int? Score { get; set; }
        [MaxLength(1000)]
        public string? Comment { get; set; }

        public User User { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}