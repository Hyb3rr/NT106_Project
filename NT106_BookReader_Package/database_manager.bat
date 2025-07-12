@echo off
title Database Manager
color 0A

echo =====================================
echo    SQLITE DATABASE MANAGER
echo =====================================
echo.

cd BookReaderApp\BookReaderApp

if not exist BookReader.db (
    echo ❌ Database file not found!
    echo Please run create_database.bat first.
    pause
    exit /b 1
)

echo Database file: BookReader.db
echo Size: 
dir BookReader.db | findstr BookReader.db

echo.
echo Choose an option:
echo 1. View database with DB Browser (if installed)
echo 2. Show tables using sqlite3 CLI
echo 3. Show Users table
echo 4. Show Books table
echo 5. Create admin user
echo 6. Exit
echo.

set /p choice="Enter your choice (1-6): "

if "%choice%"=="1" (
    echo Opening DB Browser for SQLite...
    start "" "C:\Program Files\DB Browser for SQLite\DB Browser for SQLite.exe" BookReader.db
    if %errorlevel% neq 0 (
        echo DB Browser not found. Download from: https://sqlitebrowser.org/
        echo Opening with default SQLite viewer...
        start BookReader.db
    )
)

if "%choice%"=="2" (
    echo Showing database schema...
    sqlite3 BookReader.db ".tables"
    echo.
    sqlite3 BookReader.db ".schema"
    pause
)

if "%choice%"=="3" (
    echo Users in database:
    sqlite3 BookReader.db "SELECT UserId, Username, Email, Role FROM Users;"
    pause
)

if "%choice%"=="4" (
    echo Books in database:
    sqlite3 BookReader.db "SELECT BookId, Title, Author FROM Books;"
    pause
)

if "%choice%"=="5" (
    echo Creating admin user...
    set /p username="Enter admin username: "
    set /p email="Enter admin email: "
    
    sqlite3 BookReader.db "INSERT INTO Users (Username, Email, PasswordHash, Role, CreatedDate) VALUES ('%username%', '%email%', '$2a$11$dummy.hash.for.testing', 'Admin', datetime('now'));"
    
    if %errorlevel% == 0 (
        echo ✅ Admin user created successfully!
        echo Username: %username%
        echo Email: %email%
        echo Password: admin123 (default)
    ) else (
        echo ❌ Failed to create admin user.
    )
    pause
)

if "%choice%"=="6" (
    echo Goodbye!
    cd ..\..
    exit /b 0
)

cd ..\..
echo.
pause
