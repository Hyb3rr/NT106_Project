# NT106_Project - BookReader Network Application

## 📋 Tổng quan dự án

**BookReader Network Application** là một ứng dụng desktop đọc sách tích hợp tính năng mạng, được phát triển cho môn **Lập trình mạng căn bản (NT106)**.

## ✅ Tính năng đã hoàn thành

### 🔌 Socket Programming
- **TCP Client**: SocketService trong BookReaderApp
- **TCP Server**: Multi-client server trong BookReaderServer
- **Real-time Communication**: Messaging và synchronization

### 🌐 Multi-Client Architecture
- Hỗ trợ nhiều client đồng thời
- Broadcast messages giữa clients
- Real-time chat system

### ⚖️ Load Balancing
- Round-robin load balancer
- Phân phối client giữa nhiều servers
- Automatic failover

### 🖥️ Multi-Server Support
- Chạy nhiều server instances
- Load balancer routing
- High availability

### 🏠 LAN Demo
- Server bind tất cả network interfaces
- Demo scripts tự động
- Multi-client testing

## 🚀 Cách chạy

### Quick Start
```bash
# Demo cơ bản
setup_and_run.bat

# Demo Load Balancing (Khuyến nghị)
demo_load_balancing.bat

# Demo Internet (cần ngrok)
demo_internet.bat

# Demo toàn bộ tính năng
final_demo.bat
```

### Requirements
- Windows 10/11
- .NET 8.0 SDK
- Visual Studio 2022 (khuyến nghị)

## 🎯 Đánh giá dự án

| Yêu cầu | Trạng thái | Điểm |
|---------|------------|------|
| App + Socket logic | ✅ Hoàn thành | 1/1 |
| Multi Client | ✅ Hoàn thành | 1/1 |
| Multi Server | ✅ Hoàn thành | 1/1 |
| Demo LAN | ✅ Hoàn thành | 1/1 |
| Load Balancing | ✅ Hoàn thành | 1/1 |
| Demo Internet | ⚠️ Cần ngrok | 0.5/1 |
| Deploy | ⚠️ Có thể deploy | 0.5/1 |

**Tổng điểm: 6/7 (85%) - Dự kiến: 8-9 điểm**

## 📦 Cấu trúc dự án

```
NT106_Project/
├── BookReaderApp/          # Desktop client application
├── BookReaderServer/       # TCP server application
├── LoadBalancer/          # Load balancer application
├── *.bat                  # Demo scripts
└── README.md             # Documentation
```

## 🔧 Test Accounts

- **admin** / **admin123** (Admin)
- **user1** / **user123** (User)
- **user2** / **user123** (User)

## 📞 Hỗ trợ

Nếu gặp lỗi:
1. Chạy `clean_project.bat`
2. Chạy lại demo script
3. Kiểm tra .NET 8.0 SDK đã cài đặt

## 🎮 Demo Scenarios

1. **Basic Chat**: Clients chat real-time
2. **Load Balancing**: Clients phân phối giữa servers
3. **Failover**: Tắt 1 server, clients vẫn hoạt động
4. **Internet**: Chat qua Internet với ngrok

---
*Developed for NT106 - Network Programming Course*