@echo off
title Fix Database Migration
color 0A

echo =====================================
echo    FIX DATABASE MIGRATION
echo =====================================
echo.

cd BookReaderApp\BookReaderApp

echo [1/3] Removing old migrations...
if exist Migrations (
    rmdir /s /q Migrations
    echo ✅ Old migrations removed
)

echo [2/3] Creating new migration...
dotnet ef migrations add InitialCreateSQLite --verbose
if %errorlevel% neq 0 (
    echo ❌ Migration creation failed!
    pause
    cd ..\..
    exit /b 1
)

echo [3/3] Updating database...
dotnet ef database update --verbose
if %errorlevel% neq 0 (
    echo ❌ Database update failed!
    pause
    cd ..\..
    exit /b 1
)

echo.
echo ✅ Database migration successful!
echo.

echo Checking database file...
if exist BookReader.db (
    echo ✅ Database file created: BookReader.db
    dir BookReader.db
) else (
    echo ❌ Database file still not found!
)

cd ..\..

echo.
echo ✅ Migration completed!
echo You can now run the demo.
echo.
pause
