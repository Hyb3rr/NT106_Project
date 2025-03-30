using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BookReaderApp.Models
{
    public class ReadingSession
    {
        public int SessionID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int? ReadDuration { get; set; } // Đơn vị: phút
    }
}
