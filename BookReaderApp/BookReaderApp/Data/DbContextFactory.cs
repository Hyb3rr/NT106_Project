using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Data
{
    public class BookReaderDbContextFactory : IDesignTimeDbContextFactory<BookReaderDbContext>
    {
        public BookReaderDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookReaderDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-DB0G7EJ;Database=BookReaderDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new BookReaderDbContext(optionsBuilder.Options);
        }
    }
}
