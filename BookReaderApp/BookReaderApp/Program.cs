using BookReaderApp.Data;
using BookReaderApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReaderApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var optionsBuilder = new DbContextOptionsBuilder<BookReaderDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-DB0G7EJ;Database=BookReaderDB;Trusted_Connection=True;TrustServerCertificate=True;");
            var dbContext = new BookReaderDbContext(optionsBuilder.Options);
            ApplicationConfiguration.Initialize();
            Application.Run(new ViewForm.LoginForm(dbContext));
        }
    }
}