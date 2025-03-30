using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class Note
    {
        public int NoteID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public int PageNumber { get; set; }
        public string NoteText { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}