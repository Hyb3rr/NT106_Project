using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class UserLibrary
    {
        [Key]
        public int LibraryId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? LastReadDate { get; set; }
        public int CurrentPage { get; set; }

        public User? User { get; set; }
        public Book? Book { get; set; }
    }

}
