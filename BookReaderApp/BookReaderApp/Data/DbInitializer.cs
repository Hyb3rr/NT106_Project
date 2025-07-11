using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookReaderApp.Models;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;
namespace BookReaderApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(BookReaderDbContext context)
        {
            // Đảm bảo database được tạo
            context.Database.EnsureCreated();

            // Kiểm tra đã có dữ liệu chưa
            if (context.Users.Any())
            {
                // Xóa dữ liệu cũ nếu có
                ClearAllData(context);
            }

            SeedUsers(context);
            SeedCategories(context);
            SeedBooks(context);
            SeedUserLibraries(context);
            SeedRatings(context);
            SeedBookmarks(context);
            SeedNotes(context);
        }

        // Thêm phương thức xóa toàn bộ dữ liệu
        private static void ClearAllData(BookReaderDbContext context)
        {
            // Xóa theo thứ tự để tránh vi phạm khóa ngoại
            try
            {
                context.Database.ExecuteSqlRaw("DELETE FROM Notes");
                context.Database.ExecuteSqlRaw("DELETE FROM Bookmarks");
                context.Database.ExecuteSqlRaw("DELETE FROM Ratings");
                context.Database.ExecuteSqlRaw("DELETE FROM UserLibraries");
                context.Database.ExecuteSqlRaw("DELETE FROM Books");
                context.Database.ExecuteSqlRaw("DELETE FROM Categories");
                context.Database.ExecuteSqlRaw("DELETE FROM Users");
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clearing data: {ex.Message}");
                // Có thể xử lý thêm nếu cần
            }
        }

        private static void SeedUsers(BookReaderDbContext context)
        {
            var users = new List<User>
            {
                new User
                {
                    Username = "admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
                    Email = "admin@bookreader.com",
                    FullName = "Administrator",
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Role = User.UserRole.Admin,
<<<<<<< Updated upstream
                    Avatar = @"C:\Users\rinch\OneDrive\Máy tính\newBE\NT106_Project\BookReaderApp\BookReaderApp\Resources\male-female-profile-avatar-user-avatars-gender-icons.jpg",
=======
                    Avatar = @"C:\Users\LENOVO\Documents\GitHub\NT106_Project\BookReaderApp\BookReaderApp\Resources\male-female-profile-avatar-user-avatars-gender-icons.jpg",
>>>>>>> Stashed changes
                },
                new User
                {
                    Username = "user1",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User@123"),
                    Email = "user1@example.com",
                    FullName = "Nguyễn Văn A",
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Role = User.UserRole.User,
<<<<<<< Updated upstream
                    Avatar = @"C:\Users\rinch\OneDrive\Máy tính\newBE\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Female1.PNG"
=======
                    Avatar = @"C:\Users\LENOVO\Documents\GitHub\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Female1.PNG"
>>>>>>> Stashed changes
                },
                new User
                {
                    Username = "user2",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User@123"),
                    Email = "user2@example.com",
                    FullName = "Trần Thị B",
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Role = User.UserRole.User,
<<<<<<< Updated upstream
                    Avatar = @"C:\Users\rinch\OneDrive\Máy tính\newBE\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Male1.PNG"
=======
                    Avatar = @"C:\Users\LENOVO\Documents\GitHub\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Male1.PNG"
>>>>>>> Stashed changes
                },
                new User
                {
                    Username = "user3",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User@123"),
                    Email = "user3@example.com",
                    FullName = "Lê Văn C",
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Role = User.UserRole.User,
<<<<<<< Updated upstream
                    Avatar = @"C:\Users\rinch\OneDrive\Máy tính\newBE\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Male2.PNG"
=======
                    Avatar = @"C:\Users\LENOVO\Documents\GitHub\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Male2.PNG"
>>>>>>> Stashed changes
                },
                new User
                {
                    Username = "user4",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User@123"),
                    Email = "user4@example.com",
                    FullName = "Dương Văn D",
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Role = User.UserRole.User,
<<<<<<< Updated upstream
                    Avatar = @"C:\Users\rinch\OneDrive\Máy tính\newBE\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Male4.PNG"
=======
                    Avatar = @"C:\Users\LENOVO\Documents\GitHub\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Male4.PNG"
>>>>>>> Stashed changes
                },
                new User
                {
                    Username = "user5",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User@123"),
                    Email = "user5@example.com",
                    FullName = "Trần Thị E",
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Role = User.UserRole.User,
<<<<<<< Updated upstream
                    Avatar = @"C:\Users\rinch\OneDrive\Máy tính\newBE\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Male6.PNG"
=======
                    Avatar = @"C:\Users\LENOVO\Documents\GitHub\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Male6.PNG"
>>>>>>> Stashed changes
                },
                new User
                {
                    Username = "user6",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("User@123"),
                    Email = "user6@example.com",
                    FullName = "Trần Thị F",
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Role = User.UserRole.User,
<<<<<<< Updated upstream
                    Avatar = @"C:\Users\rinch\OneDrive\Máy tính\newBE\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Female6.PNG"
=======
                    Avatar = @"C:\Users\LENOVO\Documents\GitHub\NT106_Project\BookReaderApp\BookReaderApp\Resources\Avatar_Female6.PNG"
>>>>>>> Stashed changes
                }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }

        private static void SeedCategories(BookReaderDbContext context)
        {
            var categories = new List<Category>
            {
                new Category { CategoryName = "Văn học", Description = "Sách văn học trong và ngoài nước" },
                new Category { CategoryName = "Khoa học", Description = "Sách về khoa học tự nhiên và xã hội" },
                new Category { CategoryName = "Công nghệ", Description = "Sách về công nghệ thông tin" },
                new Category { CategoryName = "Kinh doanh", Description = "Sách về kinh tế và kinh doanh" },
                new Category { CategoryName = "Tâm lý học", Description = "Sách về tâm lý học và phát triển bản thân" }
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }

        private static void SeedBooks(BookReaderDbContext context)
        {
            var admin = context.Users.FirstOrDefault(u => u.Username == "admin");
            if (admin == null)
            {
                Console.WriteLine("Admin user not found");
                return; // Không tìm thấy admin, không thể tiếp tục
            }

            var categories = context.Categories.ToList();
            if (!categories.Any())
            {
                Console.WriteLine("No categories found");
                return; // Không có thể loại nào, không thể tiếp tục
            }

            var vanHocCategory = categories.FirstOrDefault(c => c.CategoryName == "Văn học");
            var khoaHocCategory = categories.FirstOrDefault(c => c.CategoryName == "Khoa học");
            var congNgheCategory = categories.FirstOrDefault(c => c.CategoryName == "Công nghệ");
            var kinhDoanhCategory = categories.FirstOrDefault(c => c.CategoryName == "Kinh doanh");
            var tamLyHocCategory = categories.FirstOrDefault(c => c.CategoryName == "Tâm lý học");

            if (vanHocCategory == null || khoaHocCategory == null || congNgheCategory == null ||
                kinhDoanhCategory == null || tamLyHocCategory == null)
            {
                Console.WriteLine("One or more categories not found");
                return;
            }

            var books = new List<Book>
            {
                new Book
                {
                    Title = "Đắc Nhân Tâm",
                    Author = "Dale Carnegie",
                    Description = "Đắc nhân tâm là quyển sách nổi tiếng nhất, bán chạy nhất của tác giả Dale Carnegie.",

                    PublishedDate = new DateTime(1936, 1, 1),
                    CategoryId = tamLyHocCategory.CategoryId,
                    UploaderId = admin.UserId,
<<<<<<< Updated upstream
                    FilePath = @"C:\Users\rinch\Downloads\book\Đắc Nhân Tâm.pdf",
                    DriveUrl = "https://drive.google.com/file/d/1SEFKLsAHgJd35q7yo-usIzOz59ZQK3sw/view?usp=drive_link",
                    CoverImage = @"C:\Users\rinch\Downloads\book\Bia\Đắc Nhân Tâm.PNG"
=======
                    FilePath = @"C:\Users\LENOVO\Downloads\book\Đắc Nhân Tâm.pdf",
                    DriveUrl = "https://drive.google.com/file/d/1SEFKLsAHgJd35q7yo-usIzOz59ZQK3sw/view?usp=drive_link",
                    CoverImage = @"C:\Users\LENOVO\Downloads\book\Bia\Đắc Nhân Tâm.PNG"
>>>>>>> Stashed changes
                },
                new Book
                {
                    Title = "Clean Code",
                    Author = "Robert C. Martin",
                    Description = "Cuốn sách kinh điển về cách viết mã sạch.",
                    PublishedDate = new DateTime(2008, 8, 1),
                    CategoryId = congNgheCategory.CategoryId,
                    UploaderId = admin.UserId,
<<<<<<< Updated upstream
                    FilePath = @"C:\Users\rinch\Downloads\book\clean_code.pdf",
                    DriveUrl = "https://drive.google.com/file/d/1q0G-6vdeeaRWfbdpgQrkPqlrnZtFEqd9/view?usp=drive_link",
                    CoverImage = @"C:\Users\rinch\Downloads\book\Bia\Clean_code.PNG"
=======
                    FilePath = @"C:\Users\LENOVO\Downloads\book\clean_code.pdf",
                    DriveUrl = "https://drive.google.com/file/d/1q0G-6vdeeaRWfbdpgQrkPqlrnZtFEqd9/view?usp=drive_link",
                    CoverImage = @"C:\Users\LENOVO\Downloads\book\Bia\Clean_code.PNG"
>>>>>>> Stashed changes
                },
                new Book
                {
                    Title = "Nhà Giả Kim",
                    Author = "Paulo Coelho",
                    Description = "Tiểu thuyết kể về Santiago, một người chăn cừu trẻ từ xứ Andalusia.",
                    PublishedDate = new DateTime(1988, 1, 1),
                    CategoryId = vanHocCategory.CategoryId,
                    UploaderId = admin.UserId,
<<<<<<< Updated upstream
                    FilePath = @"C:\Users\rinch\Downloads\book\Nha-gia-kim.pdf",
                    DriveUrl = "https://drive.google.com/file/d/1jGzKuxo3xICYL17xKvYZU4IDGzTdD0l9/view?usp=drive_link",
                    CoverImage = @"C:\Users\rinch\Downloads\book\Bia\Nhà giả kim.PNG"
=======
                    FilePath = @"C:\Users\LENOVO\Downloads\book\Nha-gia-kim.pdf",
                    DriveUrl = "https://drive.google.com/file/d/1jGzKuxo3xICYL17xKvYZU4IDGzTdD0l9/view?usp=drive_link",
                    CoverImage = @"C:\Users\LENOVO\Downloads\book\Bia\Nhà giả kim.PNG"
>>>>>>> Stashed changes
                },
                new Book
                {
                    Title = "Bí Mật Vũ Trụ",
                    Author = "Stephen Hawking",
                    Description = "Khám phá các bí mật của vũ trụ qua lăng kính của Stephen Hawking.",
                    PublishedDate = new DateTime(2010, 9, 1),
                    CategoryId = khoaHocCategory.CategoryId,
                    UploaderId = admin.UserId,
<<<<<<< Updated upstream
                    FilePath = @"C:\Users\rinch\Downloads\book\Bi-mat-vu-tru.pdf",
                    DriveUrl = "https://drive.google.com/file/d/1s0TrfAIOrmYmdXt-pvsDuOhemM0iZyUO/view?usp=drive_link",
                    CoverImage = @"C:\Users\rinch\Downloads\book\Bia\Bí mật vũ trụ.PNG"
=======
                    FilePath = @"C:\Users\LENOVO\Downloads\book\Bi-mat-vu-tru.pdf",
                    DriveUrl = "https://drive.google.com/file/d/1s0TrfAIOrmYmdXt-pvsDuOhemM0iZyUO/view?usp=drive_link",
                    CoverImage = @"C:\Users\LENOVO\Downloads\book\Bia\Bí mật vũ trụ.PNG"
>>>>>>> Stashed changes
                },
                new Book
                {
                    Title = "Khởi Nghiệp Tinh Gọn",
                    Author = "Eric Ries",
                    Description = "Phương pháp khởi nghiệp thành công.",
                    PublishedDate = new DateTime(2011, 1, 1),
                    CategoryId = kinhDoanhCategory.CategoryId,
                    UploaderId = admin.UserId,
<<<<<<< Updated upstream
                    FilePath = @"C:\Users\rinch\Downloads\book\Khoi nghiep tinh gon - Eric Ries.pdf",
                    DriveUrl = "https://drive.google.com/file/d/14YOKwKgm4NDnAOxLHCc5m6c5wJakGk_f/view?usp=drive_link",
                    CoverImage = @"C:\Users\rinch\Downloads\book\Bia\Khởi nghiệp tinh gọn.PNG"
=======
                    FilePath = @"C:\Users\LENOVO\Downloads\book\Khoi nghiep tinh gon - Eric Ries.pdf",
                    DriveUrl = "https://drive.google.com/file/d/14YOKwKgm4NDnAOxLHCc5m6c5wJakGk_f/view?usp=drive_link",
                    CoverImage = @"C:\Users\LENOVO\Downloads\book\Bia\Khởi nghiệp tinh gọn.PNG"
>>>>>>> Stashed changes
                }
            };

            context.Books.AddRange(books);
            context.SaveChanges();
        }

        private static void SeedUserLibraries(BookReaderDbContext context)
        {
            var user1 = context.Users.FirstOrDefault(u => u.Username == "user1");
            var user2 = context.Users.FirstOrDefault(u => u.Username == "user2");
            var books = context.Books.ToList();

            if (user1 == null || user2 == null || books.Count < 4)
            {
                Console.WriteLine($"Missing data for UserLibraries. User1: {user1 != null}, User2: {user2 != null}, Books count: {books.Count}");
                return; // Kiểm tra các điều kiện
            }

            var userLibraries = new List<UserLibrary>
            {
                new UserLibrary
                {
                    UserId = user1.UserId,
                    BookId = books[0].BookId,
                    CurrentPage = 15,
                    LastReadDate = DateTime.Now.AddDays(-5),
                    AddedDate = DateTime.Now.AddDays(-10)
                },
                new UserLibrary
                {
                    UserId = user1.UserId,
                    BookId = books[2].BookId,
                    CurrentPage = 30,
                    LastReadDate = DateTime.Now.AddDays(-2),
                    AddedDate = DateTime.Now.AddDays(-7)
                },
                new UserLibrary
                {
                    UserId = user2.UserId,
                    BookId = books[1].BookId,
                    CurrentPage = 50,
                    LastReadDate = DateTime.Now.AddDays(-3),
                    AddedDate = DateTime.Now.AddDays(-9)
                },
                new UserLibrary
                {
                    UserId = user2.UserId,
                    BookId = books[3].BookId,
                    CurrentPage = 25,
                    LastReadDate = DateTime.Now.AddDays(-1),
                    AddedDate = DateTime.Now.AddDays(-6)
                }
            };

            context.UserLibraries.AddRange(userLibraries);
            context.SaveChanges();
        }

        private static void SeedRatings(BookReaderDbContext context)
        {
            var user1 = context.Users.FirstOrDefault(u => u.Username == "user1");
            var user2 = context.Users.FirstOrDefault(u => u.Username == "user2");
            var books = context.Books.ToList();

            if (user1 == null || user2 == null || books.Count < 4)
            {
                Console.WriteLine($"Missing data for Ratings. User1: {user1 != null}, User2: {user2 != null}, Books count: {books.Count}");
                return; // Kiểm tra các điều kiện
            }

            var ratings = new List<Rating>
            {
                new Rating
                {
                    UserId = user1.UserId,
                    BookId = books[0].BookId,
                    Score = 5,
                    Comment = "Sách rất hay và bổ ích!"
                },
                new Rating
                {
                    UserId = user1.UserId,
                    BookId = books[2].BookId,
                    Score = 4,
                    Comment = "Nội dung cuốn hút, nhưng dịch chưa thật sự hay."
                },
                new Rating
                {
                    UserId = user2.UserId,
                    BookId = books[1].BookId,
                    Score = 5,
                    Comment = "Sách hay dành cho lập trình viên."
                },
                new Rating
                {
                    UserId = user2.UserId,
                    BookId = books[0].BookId,
                    Score = 4,
                    Comment = "Cuốn sách cổ điển với nhiều bài học giá trị."
                }
            };

            context.Ratings.AddRange(ratings);
            context.SaveChanges();
        }

        private static void SeedBookmarks(BookReaderDbContext context)
        {
            var user1 = context.Users.FirstOrDefault(u => u.Username == "user1");
            var user2 = context.Users.FirstOrDefault(u => u.Username == "user2");
            var books = context.Books.ToList();

            if (user1 == null || user2 == null || books.Count < 4)
            {
                Console.WriteLine($"Missing data for Bookmarks. User1: {user1 != null}, User2: {user2 != null}, Books count: {books.Count}");
                return; // Kiểm tra các điều kiện
            }

            var bookmarks = new List<Bookmark>
            {
                new Bookmark
                {
                    UserId = user1.UserId,
                    BookId = books[0].BookId,
                    PageNumber = 10
                },
                new Bookmark
                {
                    UserId = user1.UserId,
                    BookId = books[0].BookId,
                    PageNumber = 25
                },
                new Bookmark
                {
                    UserId = user2.UserId,
                    BookId = books[1].BookId,
                    PageNumber = 42
                },
                new Bookmark
                {
                    UserId = user2.UserId,
                    BookId = books[3].BookId,
                    PageNumber = 15
                }
            };

            context.Bookmarks.AddRange(bookmarks);
            context.SaveChanges();
        }

        private static void SeedNotes(BookReaderDbContext context)
        {
            var user1 = context.Users.FirstOrDefault(u => u.Username == "user1");
            var user2 = context.Users.FirstOrDefault(u => u.Username == "user2");
            var books = context.Books.ToList();

            if (user1 == null || user2 == null || books.Count < 4)
            {
                Console.WriteLine($"Missing data for Notes. User1: {user1 != null}, User2: {user2 != null}, Books count: {books.Count}");
                return; // Kiểm tra các điều kiện
            }

            var notes = new List<Note>
            {
                new Note
                {
                    UserId = user1.UserId,
                    BookId = books[0].BookId,
                    PageNumber = 15,
                    Content = "Đây là ý chính về cách giao tiếp hiệu quả."
                },
                new Note
                {
                    UserId = user1.UserId,
                    BookId = books[2].BookId,
                    PageNumber = 30,
                    Content = "Đoạn văn này rất hay, cần đọc lại."
                },
                new Note
                {
                    UserId = user2.UserId,
                    BookId = books[1].BookId,
                    PageNumber = 45,
                    Content = "Ghi nhớ nguyên tắc SOLID trong lập trình OOP."
                },
                new Note
                {
                    UserId = user2.UserId,
                    BookId = books[3].BookId,
                    PageNumber = 20,
                    Content = "Lý thuyết về lỗ đen rất thú vị."
                }
            };

            context.Notes.AddRange(notes);
            context.SaveChanges();
        }
    }
}
