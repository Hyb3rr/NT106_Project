@echo off
title BookReader Network Demo - Setup
color 0A

echo =====================================
echo    BOOKREADER NETWORK DEMO SETUP
echo =====================================
echo.

echo [1/5] Checking .NET SDK...
dotnet --version
if %errorlevel% neq 0 (
    echo Error: .NET SDK not found!
    pause
    exit /b 1
)

echo [2/5] Restoring packages...
echo Restoring BookReaderServer...
dotnet restore BookReaderServer
if %errorlevel% neq 0 (
    echo Error: Failed to restore BookReaderServer packages!
    pause
    exit /b 1
)

echo Restoring BookReaderApp...
dotnet restore BookReaderApp\BookReaderApp
if %errorlevel% neq 0 (
    echo Error: Failed to restore BookReaderApp packages!
    pause
    exit /b 1
)

echo [3/5] Building projects...
echo Building BookReaderServer...
dotnet build BookReaderServer
if %errorlevel% neq 0 (
    echo Error: Failed to build BookReaderServer!
    pause
    exit /b 1
)

echo Building BookReaderApp...
dotnet build BookReaderApp\BookReaderApp
if %errorlevel% neq 0 (
    echo Error: Failed to build BookReaderApp!
    pause
    exit /b 1
)

echo [4/5] Setting up database...
cd BookReaderApp\BookReaderApp
dotnet ef database update
if %errorlevel% neq 0 (
    echo Warning: Database migration failed. Will create automatically.
)
cd ..\..

echo [5/5] Starting applications...
echo.
echo Starting BookReader Server...
start "BookReader Server" cmd /k "echo [SERVER] Starting... && cd /d %~dp0 && dotnet run --project BookReaderServer"

echo Waiting for server to start...
timeout /t 5 /nobreak >nul

echo Starting Client 1...
start "Client 1" cmd /k "echo [CLIENT 1] Starting... && cd /d %~dp0 && dotnet run --project BookReaderApp\BookReaderApp"

timeout /t 3 /nobreak >nul

echo Starting Client 2...
start "Client 2" cmd /k "echo [CLIENT 2] Starting... && cd /d %~dp0 && dotnet run --project BookReaderApp\BookReaderApp"

timeout /t 3 /nobreak >nul

echo Starting Client 3...
start "Client 3" cmd /k "echo [CLIENT 3] Starting... && cd /d %~dp0 && dotnet run --project BookReaderApp\BookReaderApp"

echo.
echo =====================================
echo    DEMO STARTED SUCCESSFULLY!
echo =====================================
echo.
echo NEXT STEPS:
echo 1. Check each window for errors
echo 2. If server shows "Server đang chạy trên port 8080" - SUCCESS!
echo 3. If clients show login screen - SUCCESS!
echo 4. Login with different users and test
echo.
echo Press any key to close setup...
pause >nul
