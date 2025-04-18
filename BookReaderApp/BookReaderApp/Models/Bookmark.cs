using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class Bookmark
    {
        public int BookmarkId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int PageNumber { get; set; }
        public DateTime CreatedDate { get; set; }

        public User? User { get; set; }
        public Book? Book { get; set; }
    }

}
