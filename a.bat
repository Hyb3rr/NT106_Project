@echo off
title Internet Demo Setup
color 0A

echo =====================================
echo    INTERNET DEMO WITH NGROK
echo =====================================
echo.

echo [1/6] Kiểm tra ngrok...
if not exist ngrok.exe (
    echo ❌ Ngrok not found!
    echo.
    echo 📝 HƯỚNG DẪN TẢI NGROK:
    echo 1. Chạy: setup_ngrok.bat
    echo 2. Hoặc tải từ: https://ngrok.com/download
    echo 3. Giải nén ngrok.exe vào thư mục này
    echo.
    pause
    exit /b 1
)

echo [2/6] Building server...
dotnet build BookReaderServer --configuration Release
if %errorlevel% neq 0 (
    echo ❌ Server build failed!
    pause
    exit /b 1
)

echo [3/6] Starting BookReader Server...
start "BookReader Server" cmd /k "title BookReader Server && cd /d %~dp0 && dotnet run --project BookReaderServer"

timeout /t 5 /nobreak >nul

echo [4/6] Starting ngrok tunnel...
start "Ngrok Tunnel" cmd /k "title Ngrok Tunnel && echo Starting tunnel... && ngrok http 8080"

echo [5/6] Waiting for tunnel to establish...
timeout /t 10 /nobreak >nul

echo [6/6] Creating client for Internet demo...
call :CreateInternetClient

echo.
echo ✅ INTERNET DEMO READY!
echo.
echo 🌐 HƯỚNG DẪN DEMO INTERNET:
echo.
echo 📍 BƯỚC 1: Lấy public URL
echo 1. Xem ngrok window để lấy public URL
echo 2. Ví dụ: 0.tcp.ngrok.io:12345
echo 3. Copy URL này
echo.
echo 📍 BƯỚC 2: Sửa client config
echo 1. Mở file: BookReaderApp\BookReaderApp\Services\SocketService.cs
echo 2. Sửa dòng: _serverAddress = "0.tcp.ngrok.io"
echo 3. Sửa dòng: _serverPort = 12345
echo 4. Build lại: dotnet build BookReaderApp
echo.
echo 📍 BƯỚC 3: Test Internet
echo 1. Chạy client trên máy này
echo 2. Gửi client cho bạn bè
echo 3. Bạn bè chạy client từ máy khác
echo 4. Chat real-time qua Internet!
echo.
echo 🎯 KIỂM TRA THÀNH CÔNG:
echo ✅ Server chạy local
echo ✅ Ngrok tạo public tunnel
echo ✅ Clients có thể kết nối từ Internet
echo ✅ Chat real-time qua Internet
echo ✅ Đồng bộ dữ liệu giữa nhiều máy từ xa
echo.
echo ⚠️  LƯU Ý:
echo - Ngrok free: 2 hours/session, 1 tunnel
echo - Cần account ngrok để sử dụng lâu dài
echo - URL sẽ thay đổi mỗi lần restart
echo - Firewall có thể chặn, cần allow
echo.
pause
exit /b 0

:CreateInternetClient
echo Creating Internet client configuration...
mkdir "InternetClient" 2>nul
copy "BookReaderApp\BookReaderApp\Services\SocketService.cs" "InternetClient\SocketService_backup.cs" >nul
echo.
echo 💡 TIP: Backup SocketService.cs đã tạo tại InternetClient\
echo Sau khi demo xong, có thể restore lại config cũ
echo.
exit /b 0
