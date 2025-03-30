using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BookReaderApp.Models
{
    public class UserLibrary
    {
        public int LibraryID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime? LastReadDate { get; set; }
        public int CurrentPage { get; set; } = 0;
        public bool IsDownloaded { get; set; } = false;
        public bool IsFavorite { get; set; } = false;
    }
}
