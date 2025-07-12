@echo off
title Demo Internet - TCP Tunnel
color 0A

echo =====================================
echo    DEMO INTERNET - TCP TUNNEL
echo =====================================
echo.

echo [1/4] Building server...
dotnet build BookReaderServer --configuration Release
if %errorlevel% neq 0 (
    echo ❌ Server build failed!
    pause
    exit /b 1
)

echo [2/4] Starting TCP Server...
start "TCP Server" cmd /k "title TCP Server (Port 8080) && cd /d %~dp0 && dotnet run --project BookReaderServer"

timeout /t 5 /nobreak >nul

echo [3/4] Setting up Internet tunnel...
echo.
echo 🌐 TCP TUNNEL OPTIONS:
echo.
echo ✅ 1. Pinggy TCP (Khuyến nghị - Free)
echo ✅ 2. Ngrok TCP (nếu có sẵn)
echo ✅ 3. Bore TCP (GitHub)
echo ✅ 4. Serveo TCP (SSH)
echo ❌ 5. LocalTunnel (HTTP only)
echo.

echo 🔧 SETUP PINGGY TCP (Khuyến nghị):
echo.
echo [Option 1] Pinggy TCP Tunnel:
set /p usepinggy="Use Pinggy TCP tunnel? (y/n): "
if /i "%usepinggy%"=="y" (
    echo Starting Pinggy TCP tunnel...
    echo.
    echo ⚠️  IMPORTANT: Pinggy may ask for password, just press Enter
    echo.
    start "Pinggy TCP" cmd /k "title Pinggy TCP Tunnel && echo Starting Pinggy TCP tunnel on port 8080... && echo Just press Enter if asked for password && ssh -o StrictHostKeyChecking=no -p 443 -R0:localhost:8080 a.pinggy.io"
    echo.
    echo ✅ Pinggy tunnel starting!
    echo 📍 Check Pinggy window for your public URL
    echo 📍 Example: tcp://tct.a.pinggy.io:12345
    echo 📍 Client config: serverAddress = "tct.a.pinggy.io", port = 12345
    goto :config_client
)

echo.
echo 🔧 SETUP ALTERNATIVE TCP TUNNELS:
echo.
echo [Option 2] Ngrok TCP:
set /p usengrok="Use Ngrok TCP tunnel? (y/n): "
if /i "%usengrok%"=="y" (
    echo Checking for ngrok.exe...
    if exist "ngrok.exe" (
        echo Starting Ngrok TCP tunnel...
        start "Ngrok TCP" cmd /k "title Ngrok TCP Tunnel && echo Starting Ngrok TCP tunnel... && ngrok.exe tcp 8080"
        echo ✅ Ngrok tunnel started!
        echo 📍 Check Ngrok window for your public URL
        echo 📍 Example: tcp://4.tcp.ngrok.io:12345
        goto :config_client
    ) else (
        echo ❌ ngrok.exe not found!
        echo 📥 Download from: https://ngrok.com/download
        echo 📁 Place ngrok.exe in project folder
        echo 💳 Note: May require credit card for TCP tunnels
    )
)

echo.
echo [Option 3] Bore TCP:
set /p usebore="Use Bore TCP tunnel? (y/n): "
if /i "%usebore%"=="y" (
    echo Download Bore from: https://github.com/ekzhang/bore/releases
    echo Place bore.exe in project folder
    echo.
    if exist "bore.exe" (
        echo Starting Bore TCP tunnel...
        start "Bore TCP" cmd /k "title Bore TCP Tunnel && bore local 8080 --to bore.pub"
        echo ✅ Bore tunnel started!
        echo 📍 Check Bore window for your public URL
        echo 📍 Example: bore.pub:54321
        goto :config_client
    ) else (
        echo ❌ bore.exe not found! Please download first.
    )
)

echo.
echo [Option 4] Serveo TCP:
set /p useserveo="Use Serveo TCP tunnel? (y/n): "
if /i "%useserveo%"=="y" (
    echo Testing SSH connection...
    ssh -o ConnectTimeout=5 -o BatchMode=yes serveo.net exit 2>nul
    if %errorlevel% equ 0 (
        echo Starting Serveo TCP tunnel...
        start "Serveo TCP" cmd /k "title Serveo TCP Tunnel && ssh -R 8080:localhost:8080 serveo.net"
        echo ✅ Serveo tunnel started!
        echo 📍 Check Serveo window for your public URL
        echo 📍 Example: abc123.serveo.net:8080
        goto :config_client
    ) else (
        echo ❌ SSH not available or Serveo not accessible!
    )
)

echo.
echo 🔧 MANUAL SETUP:
echo.
echo Install one of these tools:
echo.
echo 1️⃣ LocalTunnel:
echo    npm install -g localtunnel
echo    lt --port 8080
echo.
echo 2️⃣ Bore:
echo    Download: https://github.com/ekzhang/bore
echo    bore local 8080 --to bore.pub
echo.
echo 3️⃣ Pinggy:
echo    ssh -p 443 -R0:localhost:8080 a.pinggy.io
echo.

:config_client
echo [4/4] Client configuration needed...
echo.
echo � TO TEST INTERNET CONNECTION:
echo.
echo 1️⃣ Get your public URL from tunnel window
echo 2️⃣ Edit BookReaderApp\BookReaderApp\Services\SocketService.cs:
echo     - Change: serverAddress = "localhost" 
echo     - To: serverAddress = "your-tunnel-url"
echo     - Change port if needed (usually 80 for HTTP tunnels)
echo.
echo 3️⃣ Build client: dotnet build BookReaderApp
echo 4️⃣ Test locally first
echo 5️⃣ Send client to friends to test from other machines
echo.
echo 🎯 REAL INTERNET TEST:
echo ✅ Server running locally
echo ✅ TCP tunnel exposing to Internet  
echo ✅ Friends can connect from other networks
echo ✅ Real-time chat across Internet
echo.
echo 💡 This is REAL Internet demo, not just local network!
echo.
pause
