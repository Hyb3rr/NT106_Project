using System.ComponentModel.DataAnnotations;

namespace BookReaderApp.Models
{
    public class ChatMessage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int ChatRoomId { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [Required]
        [MaxLength(1000)]
        public string Content { get; set; } = string.Empty;
        
        public DateTime SentAt { get; set; } = DateTime.Now;
        
        public bool IsDeleted { get; set; } = false;
        
        // Navigation properties
        public virtual ChatRoom ChatRoom { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
