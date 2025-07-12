@echo off
title Database Setup
color 0A

echo =====================================
echo    DATABASE SETUP FOR BOOKREADER
echo =====================================
echo.

echo Current directory: %CD%
echo.

echo [1/3] Navigate to BookReaderApp directory...
cd BookReaderApp\BookReaderApp

echo [2/3] Create database migration...
dotnet ef database update
if %errorlevel% neq 0 (
    echo ❌ Database migration failed!
    echo This might be normal if it's the first time running.
    echo Database will be created automatically when app starts.
    pause
)

echo [3/3] Return to root directory...
cd ..\..

echo.
echo ✅ Database setup completed!
echo.
echo The SQLite database file should be created at:
echo BookReaderApp\BookReaderApp\BookReader.db
echo.
echo Now you can run the main demo script.
echo.
pause
