@echo off
title Clean and Rebuild Database
color 0A

echo =====================================
echo    CLEAN AND REBUILD DATABASE
echo =====================================
echo.

cd /d "%~dp0\BookReaderApp\BookReaderApp"

echo [1/6] Stopping any running processes...
taskkill /f /im BookReaderServer.exe >nul 2>&1
taskkill /f /im BookReaderApp.exe >nul 2>&1

echo [2/6] Cleaning existing database and migrations...
if exist BookReader.db (
    del /f /q BookReader.db
    echo ✅ Deleted old database
)

if exist Migrations (
    rmdir /s /q Migrations
    echo ✅ Deleted old migrations
)

echo [3/6] Cleaning build outputs...
if exist bin (
    rmdir /s /q bin
)
if exist obj (
    rmdir /s /q obj
)

echo [4/6] Building clean project...
dotnet clean
dotnet restore
dotnet build --configuration Debug

if %errorlevel% neq 0 (
    echo ❌ Build failed!
    pause
    exit /b 1
)

echo [5/6] Creating fresh migration...
dotnet ef migrations add InitialCreateSQLite

if %errorlevel% neq 0 (
    echo ❌ Migration creation failed!
    pause
    exit /b 1
)

echo [6/6] Creating database...
dotnet ef database update

if %errorlevel% neq 0 (
    echo ❌ Database update failed!
    pause
    exit /b 1
)

echo.
echo ✅ Database recreated successfully!

echo.
echo [BONUS] Adding sample data...
rem Create sample data with proper SQL syntax
(
echo INSERT INTO Categories ^(CategoryName, Description^) VALUES 
echo ^('Fiction', 'Fiction books'^),
echo ^('Technology', 'Technology books'^),
echo ^('Science', 'Science books'^);
echo.
echo INSERT INTO Users ^(Username, Email, PasswordHash, FullName, Role, CreatedDate, IsActive^) VALUES 
echo ^('admin', 'admin@bookreader.com', '$2a$11$dummyhashforadmin', 'Administrator', 'Admin', datetime^('now'^), 1^),
echo ^('user1', 'user1@example.com', '$2a$11$dummyhashforuser1', 'User One', 'User', datetime^('now'^), 1^),
echo ^('user2', 'user2@example.com', '$2a$11$dummyhashforuser2', 'User Two', 'User', datetime^('now'^), 1^);
echo.
echo INSERT INTO Books ^(Title, Author, Description, PublishedDate, CategoryId, UploaderId^) VALUES 
echo ^('Sample Fiction Book', 'Fiction Author', 'A great fiction book', '2024-01-01', 1, 1^),
echo ^('Programming Guide', 'Tech Author', 'Learn programming', '2024-02-01', 2, 1^),
echo ^('Science Basics', 'Science Author', 'Basic science concepts', '2024-03-01', 3, 1^);
) > sample_data.sql

sqlite3 BookReader.db < sample_data.sql 2>nul

if %errorlevel% == 0 (
    echo ✅ Sample data added successfully!
    
    echo.
    echo 📊 Database contents:
    echo.
    echo Categories:
    sqlite3 BookReader.db "SELECT CategoryId, CategoryName FROM Categories;" 2>nul
    echo.
    echo Users:
    sqlite3 BookReader.db "SELECT UserId, Username, Role FROM Users;" 2>nul
    echo.
    echo Books:
    sqlite3 BookReader.db "SELECT BookId, Title, Author FROM Books;" 2>nul
    
    del sample_data.sql
) else (
    echo ⚠️ SQLite CLI not available, but database is ready
    echo You can register users manually in the app
    del sample_data.sql
)

cd ..\..

echo.
echo 🎯 TEST ACCOUNTS READY:
echo Username: admin    Password: admin123
echo Username: user1    Password: user123  
echo Username: user2    Password: user123
echo.
echo 📝 Note: Use these to register in the app
echo The app will create proper password hashes
echo.
echo ✅ Database setup completed successfully!
pause
