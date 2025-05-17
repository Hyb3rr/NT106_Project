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
            var connectionString = "Server=localhost;Database=BookReaderDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);

            return new BookReaderDbContext(optionsBuilder.Options);
        }
    }
}