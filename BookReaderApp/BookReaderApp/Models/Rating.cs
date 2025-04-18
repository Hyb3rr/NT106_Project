﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Score { get; set; }
        public string? Comment { get; set; }
        public DateTime RatingDate { get; set; }

        public User? User { get; set; }
        public Book? Book { get; set; }
    }

}
