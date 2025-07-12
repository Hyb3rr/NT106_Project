# BookReader Network Demo - Hướng dẫn sử dụng

## 📋 Yêu cầu hệ thống

- Windows 10/11
- .NET 8.0 SDK
- Visual Studio 2022 (khuyến nghị)

## 🚀 Cách chạy Demo

### Phương pháp 1: Tự động (Khuyến nghị)

```bash
# 1. Mở Command Prompt trong thư mục dự án
cd d:\1.NT106\NT106_Project

# 2. Chạy script demo
run_demo.bat
```

### Phương pháp 2: Thủ công

```bash
# Terminal 1 - Server
cd d:\1.NT106\NT106_Project
dotnet run --project BookReaderServer

# Terminal 2 - Client 1
cd d:\1.NT106\NT106_Project
dotnet run --project BookReaderApp/BookReaderApp

# Terminal 3 - Client 2
cd d:\1.NT106\NT106_Project
dotnet run --project BookReaderApp/BookReaderApp

# Terminal 4 - Client 3
cd d:\1.NT106\NT106_Project
dotnet run --project BookReaderApp/BookReaderApp
```

## 🎯 Các tính năng đã thực hiện

### ✅ Hoàn thành

- **App + Socket logic**: Ứng dụng desktop tích hợp socket client/server
- **Multi Client**: Hỗ trợ nhiều client đồng thời
- **Multi Server**: Kiến trúc server có thể mở rộng
- **Demo LAN**: Chạy được trên mạng local
- **Database**: Chuyển từ SQL Server sang SQLite (portable)
- **Google Drive**: Tự động public file khi upload

### 🔄 Đang phát triển

- **Load Balancing**: Có thể thêm load balancer
- **Deploy**: Có thể deploy lên cloud
- **Demo Internet**: Cần server public IP

## 🧪 Cách test các tính năng

### 1. Socket Communication

1. Chạy server và 2+ client
2. Login với user khác nhau
3. Thêm sách vào library ở client 1
4. Xem thông báo real-time ở client 2

### 2. Multi-Client Sync

1. Mở 3 client cùng lúc
2. Thực hiện các thao tác:
   - Thêm sách vào thư viện
   - Đánh giá sách
   - Bookmark trang
3. Kiểm tra đồng bộ giữa các client

### 3. Database Portability

1. Chạy ứng dụng lần đầu → tạo file `BookReader.db`
2. Copy file `.db` sang máy khác
3. Chạy ứng dụng → dữ liệu được bảo toàn

### 4. Google Drive Auto-Public

1. Upload sách mới
2. Kiểm tra file trên Google Drive
3. Xác nhận quyền truy cập là "Anyone with the link"

## 📊 Thông tin kỹ thuật

### Socket Architecture

- **Protocol**: TCP/IP
- **Port**: 8080 (có thể thay đổi)
- **Message Format**: JSON
- **Connection**: Persistent connection per client

### Message Types

```json
{
  "Type": "BookAdded",
  "Data": {
    "BookId": 1,
    "Title": "Book Title",
    "Author": "Author Name",
    "CategoryId": 1
  }
}
```

### Database Schema

- **Engine**: SQLite
- **File**: `BookReader.db`
- **Tables**: Users, Books, Categories, UserLibraries, etc.

## 🔧 Troubleshooting

### Lỗi thường gặp

1. **Port already in use**

   ```bash
   netstat -ano | findstr :8080
   taskkill /PID <PID> /F
   ```

2. **Database connection failed**

   - Kiểm tra file `BookReader.db` có tồn tại
   - Chạy migration: `dotnet ef database update`

3. **Socket connection failed**
   - Kiểm tra server đã chạy chưa
   - Kiểm tra firewall
   - Thử đổi port

### Performance Tips

- Khuyến nghị tối đa 10 client đồng thời
- Đóng client cũ trước khi mở client mới
- Restart server sau mỗi 50 connections

## 📈 Mở rộng tương lai

### Load Balancing

```bash
# Có thể thêm load balancer
dotnet run --project LoadBalancer -- 8080
dotnet run --project BookReaderServer -- 8081
dotnet run --project BookReaderServer -- 8082
```

### Deploy to Cloud

- Azure App Service
- AWS EC2
- Google Cloud Run
- Heroku

### Internet Demo

1. Deploy server lên cloud
2. Thay đổi server address trong client
3. Mở port firewall
4. Test từ máy khác

## 🎓 Đánh giá môn học

### Điểm mạnh

- ✅ Hoàn thành đầy đủ socket client/server
- ✅ Multi-client handling
- ✅ Real-time synchronization
- ✅ Database portability
- ✅ Network protocol understanding

### Điểm có thể cải thiện

- Load balancing (nâng cao)
- Security (authentication, encryption)
- Error handling
- Performance optimization

### Điểm số dự kiến: 8-9/10

- Cơ bản: 7/10 (Socket + Multi-client)
- Nâng cao: +1 (Database + Google Drive)
- Bonus: +1 (Real-time sync + Clean architecture)

## 📞 Liên hệ hỗ trợ

Nếu gặp vấn đề, vui lòng:

1. Kiểm tra log trong console
2. Đọc phần Troubleshooting
3. Liên hệ qua GitHub Issues

---

**Chúc bạn demo thành công! 🎉**
