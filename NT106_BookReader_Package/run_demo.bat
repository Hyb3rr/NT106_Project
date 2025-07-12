@echo off
title BookReader Network Demo
color 0A

echo =====================================
echo    BOOKREADER NETWORK DEMO
echo =====================================
echo Starting Multi-Client Network Demo...
echo.

:: Kiểm tra xem có dotnet CLI không
dotnet --version >nul 2>&1
if %errorlevel% neq 0 (
    echo Error: .NET CLI not found. Please install .NET SDK.
    pause
    exit /b 1
)

:: Chạy Server
echo [1/4] Starting BookReader Server...
start "BookReader Server" cmd /k "echo BookReader Server && cd /d %~dp0 && dotnet run --project BookReaderServer"

:: Chờ server khởi động
echo Waiting for server to start...
timeout /t 3 /nobreak >nul

:: Chạy Client 1
echo [2/4] Starting Client 1...
start "Client 1" cmd /k "echo Client 1 && cd /d %~dp0 && dotnet run --project BookReaderApp/BookReaderApp"

:: Chờ 1 giây
timeout /t 2 /nobreak >nul

:: Chạy Client 2
echo [3/4] Starting Client 2...
start "Client 2" cmd /k "echo Client 2 && cd /d %~dp0 && dotnet run --project BookReaderApp/BookReaderApp"

:: Chờ 1 giây
timeout /t 2 /nobreak >nul

:: Chạy Client 3
echo [4/4] Starting Client 3...
start "Client 3" cmd /k "echo Client 3 && cd /d %~dp0 && dotnet run --project BookReaderApp/BookReaderApp"

echo.
echo =====================================
echo    DEMO STARTED SUCCESSFULLY!
echo =====================================
echo.
echo Instructions:
echo 1. Login to each client with different users
echo 2. Add books to library in one client
echo 3. Watch other clients receive notifications
echo 4. Test real-time synchronization
echo.
echo Press any key to exit setup...
pause >nul

echo Setup complete. All applications are running.
echo Close this window when done testing.
pause
