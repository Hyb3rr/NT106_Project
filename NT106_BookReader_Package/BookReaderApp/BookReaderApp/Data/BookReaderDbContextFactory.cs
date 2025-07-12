using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookReaderApp.Data
{
    public class BookReaderDbContextFactory : IDesignTimeDbContextFactory<BookReaderDbContext>
    {
        public BookReaderDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookReaderDbContext>();

            // SQLite connection string
            var connectionString = "Data Source=BookReader.db";
            optionsBuilder.UseSqlite(connectionString);

            return new BookReaderDbContext(optionsBuilder.Options);
        }
    }
}