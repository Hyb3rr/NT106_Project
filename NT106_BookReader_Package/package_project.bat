@echo off
title Package Project
color 0A

echo =====================================
echo    PACKAGING PROJECT FOR SHARING
echo =====================================
echo.

echo [1/6] Cleaning first...
call clean_project.bat

echo [2/6] Creating package directory...
rmdir /s /q "NT106_BookReader_Package" 2>nul
mkdir "NT106_BookReader_Package"

echo [3/6] Copying source files...
xcopy "BookReaderApp" "NT106_BookReader_Package\BookReaderApp" /E /I /H /Y /Q
xcopy "BookReaderServer" "NT106_BookReader_Package\BookReaderServer" /E /I /H /Y /Q
xcopy "LoadBalancer" "NT106_BookReader_Package\LoadBalancer" /E /I /H /Y /Q

echo [4/6] Copying scripts and documentation...
copy "*.bat" "NT106_BookReader_Package\" >nul
copy "*.md" "NT106_BookReader_Package\" >nul

echo [5/6] Cleaning package...
rmdir /s /q "NT106_BookReader_Package\BookReaderApp\.vs" 2>nul
rmdir /s /q "NT106_BookReader_Package\BookReaderApp\BookReaderApp\.vs" 2>nul
rmdir /s /q "NT106_BookReader_Package\BookReaderServer\.vs" 2>nul
rmdir /s /q "NT106_BookReader_Package\LoadBalancer\.vs" 2>nul
rmdir /s /q "NT106_BookReader_Package\BookReaderApp\bin" 2>nul
rmdir /s /q "NT106_BookReader_Package\BookReaderApp\obj" 2>nul
rmdir /s /q "NT106_BookReader_Package\BookReaderApp\BookReaderApp\bin" 2>nul
rmdir /s /q "NT106_BookReader_Package\BookReaderApp\BookReaderApp\obj" 2>nul
rmdir /s /q "NT106_BookReader_Package\BookReaderServer\bin" 2>nul
rmdir /s /q "NT106_BookReader_Package\BookReaderServer\obj" 2>nul
rmdir /s /q "NT106_BookReader_Package\LoadBalancer\bin" 2>nul
rmdir /s /q "NT106_BookReader_Package\LoadBalancer\obj" 2>nul

echo [6/6] Creating documentation...
(
echo # BookReader Network Project - NT106
echo.
echo ## 📋 Yêu cầu hệ thống
echo - Windows 10/11
echo - .NET 8.0 SDK
echo - Visual Studio 2022 ^(khuyến nghị^)
echo.
echo ## 🚀 Cách chạy:
echo.
echo ### Demo cơ bản:
echo ```
echo setup_and_run.bat
echo ```
echo.
echo ### Demo Load Balancing:
echo ```
echo demo_load_balancing.bat
echo ```
echo.
echo ### Demo Internet ^(cần ngrok^):
echo ```
echo demo_internet.bat
echo ```
echo.
echo ## ✅ Tính năng đã hoàn thành:
echo - Socket programming với TCP
echo - Multi-client real-time communication
echo - Load balancing với round-robin
echo - SQLite database integration
echo - Google Drive integration
echo - Real-time chat system
echo.
echo ## 🔧 Test accounts:
echo - admin / admin123 ^(Admin^)
echo - user1 / user123 ^(User^)
echo - user2 / user123 ^(User^)
echo.
echo ## 📊 Đánh giá dự án:
echo - App + Socket logic: ✅ Hoàn thành
echo - Multi Client: ✅ Hoàn thành
echo - Multi Server: ✅ Hoàn thành
echo - Demo LAN: ✅ Hoàn thành
echo - Load Balancing: ✅ Hoàn thành
echo - Demo Internet: ⚠️ Cần ngrok
echo - Deploy: ⚠️ Có thể deploy lên cloud
echo.
echo ## 📞 Hỗ trợ:
echo Nếu gặp lỗi, chạy: clean_project.bat rồi thử lại
) > "NT106_BookReader_Package\HOW_TO_RUN.txt"

echo.
echo ✅ PACKAGE CREATED!
echo.
echo 📦 Package location: NT106_BookReader_Package\
echo 📝 Package contents:
dir "NT106_BookReader_Package" /W
echo.
echo 🚀 READY TO SHARE:
echo 1. Zip the NT106_BookReader_Package folder
echo 2. Upload to Google Drive / OneDrive
echo 3. Share the link with instructions from HOW_TO_RUN.txt
echo.
echo 💡 TIP: File size khoảng 10-20MB sau khi zip
echo.
pause
