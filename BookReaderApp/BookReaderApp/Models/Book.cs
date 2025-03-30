using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class Book
    {
        public int BookID { get; set; } // Primary Key
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Description { get; set; } = "";
        public string CoverImage { get; set; } = "";
        public string FilePath { get; set; } = "";
        public int FileSize { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
        public int UploadedBy { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.Now;
        public int CategoryID { get; set; }
        public bool IsPublic { get; set; } = true;
        public int DownloadCount { get; set; } = 0;
        public float Rating { get; set; } = 0;
    }
}
