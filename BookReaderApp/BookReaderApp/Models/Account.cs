using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Models
{
    class Account
    {
        private string username;
        private string passwordhash;
        public Account()
        {
            this.username = "";
            this.passwordhash = "";
        }
        public Account(string username, string passwordhash)
        {
            this.username = username;
            this.passwordhash = passwordhash;
        }

        public string Username { get => username; set => username = value; }
        public string Passwordhash { get => passwordhash; set => passwordhash = value; }
    }
}
