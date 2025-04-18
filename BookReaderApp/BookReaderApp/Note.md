dotnet build
dotnet clean
Step by step to create a new project with EF Core and SQLite

dotnet ef migrations remove

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package BCrypt.Net-Next


dotnet ef migrations add InitDb
dotnet ef database update

dotnet ef database update

Lưu ý debug nhiều lần phải  tắt hết thread đang hoạt động trước đó
taskkill /f /im BookReaderApp.exe 


Update thuộc tính 
dotnet ef migrations add AddIsDisplayedToBooks
dotnet ef database update
