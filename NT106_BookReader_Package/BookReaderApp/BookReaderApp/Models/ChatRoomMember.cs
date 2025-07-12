using System.ComponentModel.DataAnnotations;

namespace BookReaderApp.Models
{
    public class ChatRoomMember
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int ChatRoomId { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        public DateTime JoinedAt { get; set; } = DateTime.Now;
        
        public bool IsActive { get; set; } = true;
        
        // Navigation properties
        public virtual ChatRoom ChatRoom { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
