using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int PageNumber { get; set; }
        public string NoteText { get; set; } = "";
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public User? User { get; set; }
        public Book? Book { get; set; }
    }

}
