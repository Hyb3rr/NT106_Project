@echo off
title BookReader Network Demo - Fixed
color 0A

echo =====================================
echo    BOOKREADER NETWORK DEMO - FIXED
echo =====================================
echo.

echo [1/4] Cleaning previous builds...
dotnet clean BookReaderServer
dotnet clean BookReaderApp

echo [2/4] Restoring packages...
dotnet restore BookReaderServer
dotnet restore BookReaderApp

echo [3/4] Building projects...
dotnet build BookReaderServer --configuration Release
if %errorlevel% neq 0 (
    echo ERROR: Server build failed!
    pause
    exit /b 1
)

dotnet build BookReaderApp --configuration Release
if %errorlevel% neq 0 (
    echo ERROR: Client build failed!
    pause
    exit /b 1
)

echo [4/4] Starting applications...
echo.
echo ✅ BUILD SUCCESSFUL!
echo.
echo Starting BookReader Server...
start "BookReader Server" cmd /k "title BookReader Server && echo [SERVER] BookReader Server Starting... && cd /d %~dp0 && dotnet run --project BookReaderServer --configuration Release"

echo Waiting for server to initialize...
timeout /t 8 /nobreak >nul

echo Starting Client 1...
start "Client 1" cmd /k "title Client 1 && echo [CLIENT 1] BookReader Client Starting... && cd /d %~dp0\BookReaderApp\BookReaderApp && dotnet run"

timeout /t 4 /nobreak >nul

echo Starting Client 2...
start "Client 2" cmd /k "title Client 2 && echo [CLIENT 2] BookReader Client Starting... && cd /d %~dp0\BookReaderApp\BookReaderApp && dotnet run"

timeout /t 4 /nobreak >nul

echo Starting Client 3...
start "Client 3" cmd /k "title Client 3 && echo [CLIENT 3] BookReader Client Starting... && cd /d %~dp0\BookReaderApp\BookReaderApp && dotnet run"

echo.
echo =====================================
echo    ALL APPLICATIONS STARTED!
echo =====================================
echo.
echo 🎯 NEXT STEPS:
echo 1. Check "BookReader Server" window - should show "Server đang chạy trên port 8080"
echo 2. Check Client windows - should show WinForms login screen
echo 3. Login each client with different users
echo 4. Test adding books to library
echo 5. Watch real-time notifications
echo.
echo ❌ IF YOU SEE ERRORS:
echo - Check that all windows opened successfully
echo - Server window should NOT show build errors
echo - Client windows should show GUI, not console errors
echo.
echo Press any key to finish setup...
pause >nul

echo.
echo ✅ Setup completed successfully!
echo All applications are now running.
echo.
echo 📝 Test Instructions:
echo 1. Login to each client with different users
echo 2. Add a book to library in Client 1
echo 3. Check if Client 2 and Client 3 receive notifications
echo 4. Verify real-time synchronization
echo.
echo 🔧 Troubleshooting:
echo - If server shows port errors, change port in code
echo - If database errors, check BookReader.db file creation
echo - If socket errors, restart server first
echo.
echo Good luck with your demo! 🚀
pause
