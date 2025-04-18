using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class AdminLog
    {
        [Key]
        public int LogId { get; set; }
        public int AdminId { get; set; }
        public string Action { get; set; } = "";
        public DateTime Timestamp { get; set; }

        public User? Admin { get; set; }
    }

}
