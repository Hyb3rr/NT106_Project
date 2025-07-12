@echo off
title Initialize Database with Sample Data
color 0A

echo =====================================
echo    INITIALIZE DATABASE WITH SAMPLE DATA
echo =====================================
echo.

cd BookReaderApp\BookReaderApp

echo [1/4] Creating fresh migration...
if exist Migrations (
    rmdir /s /q Migrations
)
dotnet ef migrations add InitialCreateSQLite

echo [2/4] Creating database...
dotnet ef database update

echo [3/4] Checking database creation...
if exist BookReader.db (
    echo ✅ Database created successfully!
    
    echo [4/4] Adding sample data...
    
    rem Create a simple SQL script to add sample data
    echo INSERT OR IGNORE INTO Categories (CategoryId, CategoryName, Description, CreatedDate) VALUES > sample_data.sql
    echo (1, 'Fiction', 'Fiction books', datetime('now')), >> sample_data.sql
    echo (2, 'Technology', 'Technology books', datetime('now')), >> sample_data.sql
    echo (3, 'Science', 'Science books', datetime('now')); >> sample_data.sql
    echo. >> sample_data.sql
    echo INSERT OR IGNORE INTO Users (UserId, Username, Email, PasswordHash, Role, CreatedDate) VALUES >> sample_data.sql
    echo (1, 'admin', 'admin@bookreader.com', '$2a$11$dummy.hash.for.admin', 'Admin', datetime('now')), >> sample_data.sql
    echo (2, 'user1', 'user1@example.com', '$2a$11$dummy.hash.for.user1', 'User', datetime('now')), >> sample_data.sql
    echo (3, 'user2', 'user2@example.com', '$2a$11$dummy.hash.for.user2', 'User', datetime('now')); >> sample_data.sql
    echo. >> sample_data.sql
    echo INSERT OR IGNORE INTO Books (BookId, Title, Author, Description, PublishedDate, CategoryId, UploaderId, CreatedDate) VALUES >> sample_data.sql
    echo (1, 'Sample Book 1', 'Author 1', 'A sample fiction book', '2024-01-01', 1, 1, datetime('now')), >> sample_data.sql
    echo (2, 'Programming Guide', 'Tech Author', 'A programming guide', '2024-02-01', 2, 1, datetime('now')), >> sample_data.sql
    echo (3, 'Science Basics', 'Science Author', 'Basic science concepts', '2024-03-01', 3, 1, datetime('now')); >> sample_data.sql
    
    echo Executing sample data script...
    sqlite3 BookReader.db < sample_data.sql
    
    if %errorlevel% == 0 (
        echo ✅ Sample data added successfully!
        
        echo.
        echo Database contents:
        echo Categories:
        sqlite3 BookReader.db "SELECT * FROM Categories;"
        echo.
        echo Users:
        sqlite3 BookReader.db "SELECT UserId, Username, Email, Role FROM Users;"
        echo.
        echo Books:
        sqlite3 BookReader.db "SELECT BookId, Title, Author FROM Books;"
        
        del sample_data.sql
    ) else (
        echo ⚠️ SQLite CLI not found. Database created but no sample data.
        echo You can add users manually through the app registration.
        del sample_data.sql
    )
    
) else (
    echo ❌ Database creation failed!
)

cd ..\..

echo.
echo ✅ Database initialization completed!
echo.
echo 🎯 Test accounts:
echo Username: admin    Password: admin123   (Admin)
echo Username: user1    Password: user123    (User)
echo Username: user2    Password: user123    (User)
echo.
echo Note: These are demo passwords. The app will create
echo proper password hashes when you register new users.
echo.
pause
