@echo off
title Quick Test
color 0A

echo ================================
echo    QUICK BUILD TEST
echo ================================

echo Testing paths...
echo Current directory: %CD%
echo.

echo [1/4] Test Server path...
dir BookReaderServer\*.csproj
if %errorlevel% neq 0 (
    echo ERROR: Server project not found!
    pause
    exit /b 1
)

echo [2/4] Test Client path...
dir BookReaderApp\BookReaderApp\*.csproj
if %errorlevel% neq 0 (
    echo ERROR: Client project not found!
    pause
    exit /b 1
)

echo [3/4] Build Server...
dotnet build BookReaderServer --configuration Release
if %errorlevel% neq 0 (
    echo ERROR: Server build failed!
    pause
    exit /b 1
)

echo [4/4] Build Client...
dotnet build BookReaderApp\BookReaderApp --configuration Release
if %errorlevel% neq 0 (
    echo ERROR: Client build failed!
    pause
    exit /b 1
)

echo.
echo ✅ ALL BUILDS SUCCESSFUL!
echo.
echo Now starting applications...
echo.

echo Starting Server...
start "BookReader Server" cmd /k "title BookReader Server && echo [SERVER] Starting BookReader Server... && cd /d %~dp0 && dotnet run --project BookReaderServer --configuration Release"

timeout /t 8 /nobreak >nul

echo Starting Client 1...
start "Client 1" cmd /k "title Client 1 && echo [CLIENT 1] Starting BookReader Client... && cd /d %~dp0 && dotnet run --project BookReaderApp\BookReaderApp --configuration Release"

timeout /t 4 /nobreak >nul

echo Starting Client 2...
start "Client 2" cmd /k "title Client 2 && echo [CLIENT 2] Starting BookReader Client... && cd /d %~dp0 && dotnet run --project BookReaderApp\BookReaderApp --configuration Release"

echo.
echo ✅ APPLICATIONS STARTED!
echo.
echo Check the opened windows:
echo 1. "BookReader Server" - should show server running on port 8080
echo 2. "Client 1" and "Client 2" - should show WinForms login screen
echo.
echo 🎯 Test Instructions:
echo 1. Login to each client with different users
echo 2. Add books to library in one client
echo 3. Check if other client receives notification
echo.
pause
