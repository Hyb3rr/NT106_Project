using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    public class Download
    {
        public int DownloadID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime DownloadDate { get; set; } = DateTime.Now;
        public string DeviceInfo { get; set; } = "";
    }
}
