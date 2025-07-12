@echo off
title Load Balancing Demo
color 0A

echo =====================================
echo    LOAD BALANCING DEMO
echo =====================================
echo.

echo [1/5] Building Load Balancer...
dotnet build LoadBalancer
if %errorlevel% neq 0 (
    echo ❌ Load Balancer build failed!
    pause
    exit /b 1
)

echo [2/5] Starting Server 1 on port 8081...
start "Server 1" cmd /k "title Server 1 (Port 8081) && cd /d %~dp0 && dotnet run --project BookReaderServer -- 8081 Server1"

timeout /t 3 /nobreak >nul

echo [3/5] Starting Server 2 on port 8082...
start "Server 2" cmd /k "title Server 2 (Port 8082) && cd /d %~dp0 && dotnet run --project BookReaderServer -- 8082 Server2"

timeout /t 3 /nobreak >nul

echo [4/5] Starting Load Balancer on port 8080...
start "Load Balancer" cmd /k "title Load Balancer (Port 8080) && cd /d %~dp0 && dotnet run --project LoadBalancer"

timeout /t 5 /nobreak >nul

echo [5/5] Starting Clients...
start "Client 1" cmd /k "title Client 1 && cd /d %~dp0 && dotnet run --project BookReaderApp/BookReaderApp"

timeout /t 3 /nobreak >nul

start "Client 2" cmd /k "title Client 2 && cd /d %~dp0 && dotnet run --project BookReaderApp/BookReaderApp"

timeout /t 3 /nobreak >nul

start "Client 3" cmd /k "title Client 3 && cd /d %~dp0 && dotnet run --project BookReaderApp/BookReaderApp"

echo.
echo ✅ LOAD BALANCING DEMO STARTED!
echo.
echo 🎯 KIỂM TRA:
echo 1. Load Balancer window - "Load Balancer đang chạy trên port 8080"
echo 2. Server 1 window - "Server đang chạy trên port 8081"
echo 3. Server 2 window - "Server đang chạy trên port 8082"
echo 4. Client windows - Login screens
echo 5. Load Balancer console - "Routing Client → Server1/Server2"
echo.
echo 📊 KIỂM TRA LOAD BALANCING:
echo - Mỗi client sẽ được route đến server khác nhau
echo - Xem Load Balancer console để theo dõi routing
echo - Clients có thể chat với nhau qua các server khác nhau
echo.
pause
