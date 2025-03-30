using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookReaderApp.Models
{
    public class Bookmark
    {
        public int BookmarkID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public int PageNumber { get; set; }
        public string BookmarkName { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}