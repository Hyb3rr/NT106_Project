using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookReaderApp.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public int Score { get; set; } // 1 đến 5
        public string Comment { get; set; } = "";
        public DateTime RatingDate { get; set; } = DateTime.Now;
    }
}
