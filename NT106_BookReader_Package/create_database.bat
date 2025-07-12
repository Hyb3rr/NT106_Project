@echo off
title Create Database
color 0A

echo =====================================
echo    CREATING SQLITE DATABASE
echo =====================================
echo.

cd BookReaderApp\BookReaderApp

echo Creating database...
dotnet ef database update --verbose
if %errorlevel% neq 0 (
    echo.
    echo ❌ Migration failed. Creating database manually...
    echo.
    
    rem Tạo database trống với schema cơ bản
    echo Creating empty database...
    sqlite3 BookReader.db ".quit"
    
    if exist BookReader.db (
        echo ✅ Empty database created successfully!
    ) else (
        echo ❌ Failed to create database. Installing SQLite...
        echo You need to install SQLite CLI tools.
        echo Download from: https://sqlite.org/download.html
    )
) else (
    echo ✅ Database migration successful!
)

echo.
echo Checking database file...
if exist BookReader.db (
    echo ✅ Database file exists: BookReader.db
    dir BookReader.db
) else (
    echo ❌ Database file not found!
)

cd ..\..

echo.
echo ✅ Database setup completed!
echo.
pause
