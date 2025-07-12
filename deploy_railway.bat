@echo off
title Deploy to Railway Cloud
color 0A

echo =====================================
echo    DEPLOY TO RAILWAY CLOUD
echo =====================================
echo.

echo 🚀 HƯỚNG DẪN DEPLOY LÊN RAILWAY:
echo.
echo [Bước 1] Tạo tài khoản Railway
echo 1. Truy cập: https://railway.app
echo 2. Đăng ký bằng GitHub account
echo 3. Verify email
echo.
echo [Bước 2] Chuẩn bị project
echo 1. Tạo Dockerfile cho server
echo 2. Tạo railway.json config
echo 3. Push code lên GitHub
echo.
echo [Bước 3] Deploy
echo 1. New Project → Deploy from GitHub
echo 2. Chọn repository NT106_Project
echo 3. Chọn BookReaderServer folder
echo 4. Deploy tự động
echo.

echo 📝 Đang tạo files cần thiết...

REM Tạo Dockerfile cho BookReaderServer
(
echo FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
echo WORKDIR /app
echo EXPOSE 8080
echo.
echo FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
echo WORKDIR /src
echo COPY ["BookReaderServer.csproj", "."]
echo RUN dotnet restore "./BookReaderServer.csproj"
echo COPY . .
echo WORKDIR "/src/."
echo RUN dotnet build "BookReaderServer.csproj" -c Release -o /app/build
echo.
echo FROM build AS publish
echo RUN dotnet publish "BookReaderServer.csproj" -c Release -o /app/publish
echo.
echo FROM base AS final
echo WORKDIR /app
echo COPY --from=publish /app/publish .
echo ENTRYPOINT ["dotnet", "BookReaderServer.dll"]
) > "BookReaderServer\Dockerfile"

REM Tạo railway.json
(
echo {
echo   "$schema": "https://railway.app/railway.schema.json",
echo   "build": {
echo     "builder": "DOCKERFILE",
echo     "dockerfilePath": "Dockerfile"
echo   },
echo   "deploy": {
echo     "startCommand": "dotnet BookReaderServer.dll",
echo     "restartPolicyType": "ON_FAILURE",
echo     "restartPolicyMaxRetries": 10
echo   }
echo }
) > "BookReaderServer\railway.json"

REM Tạo .dockerignore
(
echo bin/
echo obj/
echo .git/
echo .vs/
echo *.user
echo *.tmp
) > "BookReaderServer\.dockerignore"

echo.
echo ✅ Files deploy đã tạo:
echo - BookReaderServer\Dockerfile
echo - BookReaderServer\railway.json
echo - BookReaderServer\.dockerignore
echo.
echo 🌐 DEPLOY STEPS:
echo 1. Push code lên GitHub
echo 2. Railway → New Project → Deploy from GitHub
echo 3. Chọn NT106_Project repository
echo 4. Chọn BookReaderServer folder
echo 5. Railway sẽ auto-deploy
echo.
echo 📊 RAILWAY FREE LIMITS:
echo - 500 hours/month execution time
echo - Public URL provided
echo - Auto-sleep after 30 min idle
echo - Perfect cho demo project!
echo.
echo 🔗 Sau khi deploy:
echo - Lấy URL từ Railway dashboard
echo - Update client config với URL mới
echo - Test từ Internet
echo.
pause
