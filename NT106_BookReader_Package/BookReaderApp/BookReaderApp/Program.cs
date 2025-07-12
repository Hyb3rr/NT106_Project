using BookReaderApp.Data;
using BookReaderApp.ViewForm;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
            // Tự động cấu hình ứng dụng (High DPI, Visual Styles, v.v.)
            ApplicationConfiguration.Initialize();

            // Cấu hình Dependency Injection
            var serviceProvider = ConfigureServices();

            // Tạo phạm vi dịch vụ (scope) để quản lý vòng đời của các đối tượng
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<BookReaderDbContext>();
            var loginForm = scope.ServiceProvider.GetRequiredService<LoginForm>();

            // Đóng ứng dụng khi form chính đóng
            loginForm.FormClosed += (s, e) => Application.Exit();

            // Chạy ứng dụng
            Application.Run(loginForm);
        }

        /// <summary>
        /// Cấu hình Dependency Injection container.
        /// </summary>
        /// <returns>Đối tượng IServiceProvider.</returns>
        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Thêm DbContext với cấu hình SQL Server
            services.AddDbContext<BookReaderDbContext>(options =>
            {
                var connectionString = "Server=.;Database=BookReaderDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
                options.UseSqlServer(connectionString);
            });

            // Đăng ký các form
            services.AddTransient<LoginForm>();
            services.AddTransient<UserForm>();
            services.AddTransient<UserLibraryForm>();
            services.AddTransient<BookReaderForm>();

            return services.BuildServiceProvider();
        }
    }
}