using System.ComponentModel.DataAnnotations;

namespace BookReaderApp.Models
{
    public class ChatRoom
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [MaxLength(500)]
        public string? Description { get; set; }
        
        public int? BookId { get; set; }  // Null nếu là room chung, có giá trị nếu là room thảo luận về sách cụ thể
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public bool IsActive { get; set; } = true;
        
        // Navigation properties
        public virtual Book? Book { get; set; }
        public virtual ICollection<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
        public virtual ICollection<ChatRoomMember> Members { get; set; } = new List<ChatRoomMember>();
    }
}
