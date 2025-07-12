@echo off
title Clean Project
color 0A

echo =====================================
echo    CLEANING UNNECESSARY FILES
echo =====================================
echo.

echo [1/7] Cleaning Visual Studio cache...
rmdir /s /q ".vs" 2>nul
rmdir /s /q "BookReaderApp\.vs" 2>nul
rmdir /s /q "BookReaderApp\BookReaderApp\.vs" 2>nul
rmdir /s /q "BookReaderServer\.vs" 2>nul
rmdir /s /q "LoadBalancer\.vs" 2>nul

echo [2/7] Cleaning build outputs...
rmdir /s /q "BookReaderApp\bin" 2>nul
rmdir /s /q "BookReaderApp\obj" 2>nul
rmdir /s /q "BookReaderApp\BookReaderApp\bin" 2>nul
rmdir /s /q "BookReaderApp\BookReaderApp\obj" 2>nul
rmdir /s /q "BookReaderServer\bin" 2>nul
rmdir /s /q "BookReaderServer\obj" 2>nul
rmdir /s /q "LoadBalancer\bin" 2>nul
rmdir /s /q "LoadBalancer\obj" 2>nul

echo [3/7] Cleaning database temporary files...
del "BookReaderApp\BookReaderApp\*.db-shm" 2>nul
del "BookReaderApp\BookReaderApp\*.db-wal" 2>nul

echo [4/7] Cleaning temporary files...
del "*.tmp" 2>nul
del "*.temp" 2>nul
del "*.log" 2>nul

echo [5/7] Cleaning WebView2 cache...
rmdir /s /q "BookReaderApp\BookReaderApp\bin\Debug\net8.0-windows\*.exe.WebView2" 2>nul

echo [6/7] Cleaning package caches...
rmdir /s /q "packages" 2>nul

echo [7/7] Cleaning user-specific files...
del "*.user" 2>nul
del "*.suo" 2>nul

echo.
echo ✅ CLEANUP COMPLETED!
echo.
echo 📁 KEPT FILES:
echo - Source code (.cs files)
echo - Project files (.csproj, .sln)
echo - Database (BookReader.db)
echo - Scripts (.bat files)
echo - Documentation (.md files)
echo - Resources and images
echo.
echo 📦 REMOVED FILES:
echo - Build outputs (bin/, obj/)
echo - Visual Studio cache (.vs/)
echo - Temporary files (.tmp, .temp, .log)
echo - User-specific files (.user, .suo)
echo.
pause
