USE master;
DROP DATABASE IF EXISTS BookReaderDB;
CREATE DATABASE BookReaderDB;
GO

USE BookReaderDB;
GO

-- Bảng người dùng
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    Avatar VARCHAR(255) NULL,  -- Lưu đường dẫn ảnh
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    LastLogin DATETIME NULL,
    IsActive BIT NOT NULL DEFAULT 1
);

-- Bảng danh mục sách
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL,
    Description VARCHAR(255) NULL,
    ParentCategoryID INT NULL FOREIGN KEY REFERENCES Categories(CategoryID)
);

-- Bảng sách
CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    Description TEXT NOT NULL,
    CoverImage VARCHAR(255) NOT NULL,  -- Lưu đường dẫn ảnh
    FilePath VARCHAR(255) NOT NULL,    -- Lưu đường dẫn file
    FileSize INT NOT NULL,
    PageCount INT NOT NULL,
    PublishDate DATE NOT NULL,
    UploadedBy INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    UploadDate DATETIME NOT NULL DEFAULT GETDATE(),
    CategoryID INT NOT NULL FOREIGN KEY REFERENCES Categories(CategoryID),
    IsPublic BIT NOT NULL DEFAULT 1,
    DownloadCount INT NOT NULL DEFAULT 0,
    Rating FLOAT NOT NULL DEFAULT 0
);

-- Bảng lưu sách người dùng đã thêm vào thư viện cá nhân
CREATE TABLE UserLibrary (
    LibraryID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    BookID INT NOT NULL FOREIGN KEY REFERENCES Books(BookID),
    AddedDate DATETIME NOT NULL DEFAULT GETDATE(),
    LastReadDate DATETIME NULL,
    CurrentPage INT NOT NULL DEFAULT 0,
    IsDownloaded BIT NOT NULL DEFAULT 0,
    IsFavorite BIT NOT NULL DEFAULT 0,
    LastSyncDate DATETIME NULL  -- Thời gian đồng bộ lần cuối
);

-- Bảng lưu lịch sử đọc sách
CREATE TABLE ReadingSessions (
    SessionID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    BookID INT NOT NULL FOREIGN KEY REFERENCES Books(BookID),
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NULL,
    StartPage INT NOT NULL,
    EndPage INT NULL,
    ReadDuration INT NULL  -- Tính theo phút
);

-- Bảng lưu đánh dấu trang
CREATE TABLE Bookmarks (
    BookmarkID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    BookID INT NOT NULL FOREIGN KEY REFERENCES Books(BookID),
    PageNumber INT NOT NULL,
    BookmarkName VARCHAR(100) NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Bảng lưu ghi chú
CREATE TABLE Notes (
    NoteID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    BookID INT NOT NULL FOREIGN KEY REFERENCES Books(BookID),
    PageNumber INT NOT NULL,
    NoteText TEXT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    ModifiedDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Bảng đánh giá sách
CREATE TABLE Ratings (
    RatingID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    BookID INT NOT NULL FOREIGN KEY REFERENCES Books(BookID),
    Score INT NOT NULL CHECK (Score BETWEEN 1 AND 5),
    Comment TEXT NULL,
    RatingDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Bảng tải xuống sách
CREATE TABLE Downloads (
    DownloadID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    BookID INT NOT NULL FOREIGN KEY REFERENCES Books(BookID),
    DownloadDate DATETIME NOT NULL DEFAULT GETDATE(),
    DeviceInfo VARCHAR(255) NULL
);

-- Bảng cài đặt cá nhân
CREATE TABLE Settings (
    SettingID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    FontSize INT NOT NULL DEFAULT 12,
    FontFamily VARCHAR(50) NOT NULL DEFAULT 'Segoe UI',
    BackgroundColor VARCHAR(20) NOT NULL DEFAULT '#FFFFFF',
    TextColor VARCHAR(20) NOT NULL DEFAULT '#000000',
    Brightness INT NOT NULL DEFAULT 100,
    NightMode BIT NOT NULL DEFAULT 0,
    EyeComfortMode BIT NOT NULL DEFAULT 0,
    AutoSync BIT NOT NULL DEFAULT 1
);

-- Bảng bộ sưu tập sách cá nhân
CREATE TABLE Collections (
    CollectionID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    CollectionName VARCHAR(100) NOT NULL,
    Description VARCHAR(255) NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    IsPublic BIT NOT NULL DEFAULT 1
);

-- Bảng liên kết sách với bộ sưu tập
CREATE TABLE CollectionBooks (
    CollectionBookID INT IDENTITY(1,1) PRIMARY KEY,
    CollectionID INT NOT NULL FOREIGN KEY REFERENCES Collections(CollectionID),
    BookID INT NOT NULL FOREIGN KEY REFERENCES Books(BookID),
    AddedDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Bảng thông báo cho người dùng
CREATE TABLE Notifications (
    NotificationID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    Message VARCHAR(255) NOT NULL,
    IsRead BIT NOT NULL DEFAULT 0,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    RelatedBookID INT NULL FOREIGN KEY REFERENCES Books(BookID)
);

-- Tạo index tối ưu hiệu suất truy vấn
CREATE INDEX IX_Books_Title ON Books (Title);
CREATE INDEX IX_Books_Category ON Books (CategoryID);
CREATE INDEX IX_Users_Email ON Users (Email);
