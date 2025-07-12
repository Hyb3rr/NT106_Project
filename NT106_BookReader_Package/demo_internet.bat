@echo off
title Internet Demo Setup
color 0A

echo =====================================
echo    INTERNET DEMO WITH NGROK
echo =====================================
echo.

echo [1/4] Download ngrok if not exists...
if not exist ngrok.exe (
    echo ❌ Ngrok not found!
    echo.
    echo 📝 HƯỚNG DẪN TẢI NGROK:
    echo 1. Truy cập: https://ngrok.com/download
    echo 2. Tải file ngrok.exe
    echo 3. Giải nén và đặt ngrok.exe vào thư mục này
    echo 4. Chạy lại script này
    echo.
    pause
    exit /b 1
)

echo [2/4] Starting BookReader Server...
start "BookReader Server" cmd /k "title BookReader Server && cd /d %~dp0 && dotnet run --project BookReaderServer"

timeout /t 5 /nobreak >nul

echo [3/4] Starting ngrok tunnel...
start "Ngrok Tunnel" cmd /k "title Ngrok Tunnel && ngrok tcp 8080"

echo [4/4] Waiting for tunnel to establish...
timeout /t 10 /nobreak >nul

echo.
echo ✅ INTERNET DEMO READY!
echo.
echo 🌐 HƯỚNG DẪN DEMO INTERNET:
echo 1. Xem ngrok window để lấy public URL
echo 2. Ví dụ: 0.tcp.ngrok.io:12345
echo 3. Sửa file SocketService.cs:
echo    _serverAddress = "0.tcp.ngrok.io"
echo    _serverPort = 12345
echo 4. Build lại client: dotnet build BookReaderApp
echo 5. Gửi client cho bạn bè để test từ máy khác
echo.
echo 🎯 KIỂM TRA:
echo - Bạn bè có thể kết nối từ máy khác qua Internet
echo - Chat real-time qua Internet
echo - Đồng bộ dữ liệu giữa nhiều máy
echo.
echo ⚠️  LƯU Ý:
echo - Ngrok free có giới hạn 2 hours/session
echo - Cần account ngrok để sử dụng lâu dài
echo - URL sẽ thay đổi mỗi lần restart
echo.
pause
