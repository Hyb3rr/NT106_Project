using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public bool IsDisplayed { get; set; } = true; // Thuộc tính mới: Trạng thái hiển thị mặc định là true
        public string Description { get; set; } = "";
        public string CoverImage { get; set; } = "";
        public string DriveFileId { get; set; } = "";
        public string FileType { get; set; } = "PDF";
        public int UploadedBy { get; set; }
        public DateTime UploadDate { get; set; }
        public int CategoryId { get; set; }

        public User? Uploader { get; set; }
        public Category? Category { get; set; }

        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<UserLibrary> UserLibraries { get; set; } = new List<UserLibrary>();
        public ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
        public ICollection<Note> Notes { get; set; } = new List<Note>();
    }

}
