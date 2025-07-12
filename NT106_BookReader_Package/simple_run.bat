@echo off
title Simple Build and Run
color 0A

echo ========================================
echo    SIMPLE BUILD AND RUN TEST
echo ========================================

echo Current directory: %CD%
echo.

echo [Step 1] Building Server...
dotnet build BookReaderServer --configuration Debug
if %errorlevel% neq 0 (
    echo ❌ Server build failed!
    pause
    exit /b 1
)

echo [Step 2] Building Client...
cd BookReaderApp
dotnet build --configuration Debug
if %errorlevel% neq 0 (
    echo ❌ Client build failed!
    cd ..
    pause
    exit /b 1
)
cd ..

echo ✅ Build successful!
echo.

echo [Step 3] Starting Server...
start "BookReader Server" cmd /k "title BookReader Server && cd /d %~dp0 && dotnet run --project BookReaderServer"

echo Waiting for server to start...
timeout /t 5 /nobreak >nul

echo [Step 4] Starting Client...
start "BookReader Client" cmd /k "title BookReader Client && cd /d %~dp0\BookReaderApp\BookReaderApp && dotnet run"

echo.
echo ✅ Applications started!
echo.
echo 📋 Check the opened windows:
echo 1. "BookReader Server" - Should show "Server đang chạy trên port 8080"
echo 2. "BookReader Client" - Should show WinForms login screen
echo.
echo 🎯 Test steps:
echo 1. Login to the client
echo 2. Try adding a book to library
echo 3. Check server console for messages
echo.
echo Press any key to close this window...
pause >nul
