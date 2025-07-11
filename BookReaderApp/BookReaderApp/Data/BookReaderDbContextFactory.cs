using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookReaderApp.Data
{
    public class BookReaderDbContextFactory : IDesignTimeDbContextFactory<BookReaderDbContext>
    {
        public BookReaderDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookReaderDbContext>();

            // Connection string (replace with your actual connection string)
<<<<<<< Updated upstream
            var connectionString = "Server=HOPE\\SQLEXPRESS01;Database=BookReaderDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
=======
            var connectionString = "Server=LAPTOP-9OHA4A21\\GL;Database=BookReaderDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
>>>>>>> Stashed changes
            optionsBuilder.UseSqlServer(connectionString);

            return new BookReaderDbContext(optionsBuilder.Options);
        }
    }
}