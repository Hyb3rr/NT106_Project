using System;
using System.ComponentModel.DataAnnotations;

namespace BookReaderApp.Models
{
    public class AdminLog
    {
        public int AdminLogId { get; set; }

        [Required]
        public int AdminId { get; set; }

        [Required]
        public string Action { get; set; } = "";

        public DateTime Timestamp { get; set; } = DateTime.Now;

        public User Admin { get; set; } = null!;
    }
}