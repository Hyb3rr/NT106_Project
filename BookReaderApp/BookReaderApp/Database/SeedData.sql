USE BookReaderDB;
GO

-- Xóa dữ liệu cũ trước khi thêm mới
DELETE FROM Downloads;
DELETE FROM Ratings;
DELETE FROM Notes;
DELETE FROM Bookmarks;
DELETE FROM ReadingSessions;
DELETE FROM UserLibrary;
DELETE FROM CollectionBooks;
DELETE FROM Collections;
DELETE FROM Notifications;
DELETE FROM Settings;
DELETE FROM Books;
DELETE FROM Categories;
DELETE FROM Users;
GO

INSERT INTO Users (Username, PasswordHash, Email, FullName, Avatar) 
VALUES ('admin', 'e38ad214943daad1d64c102faec29de4afe9da3d', 'admin@example.com', 'Administrator', NULL);

-- Thêm dữ liệu mẫu cho Users
INSERT INTO Users (Username, PasswordHash, Email, FullName, Avatar) VALUES
('admin', 'hashed_password_1', 'admin@example.com', 'Administrator', NULL),
('john_doe', 'hashed_password_2', 'john@example.com', 'John Doe', NULL),
('jane_smith', 'hashed_password_3', 'jane@example.com', 'Jane Smith', NULL);
GO

-- Thêm dữ liệu mẫu cho Categories
INSERT INTO Categories (CategoryName, Description) VALUES
('Science Fiction', 'Books related to sci-fi themes'),
('Fantasy', 'Fantasy and mythical books'),
('Technology', 'Books about tech and programming'),
('Self Help', 'Books for personal growth');
GO

-- Thêm dữ liệu mẫu cho Books
INSERT INTO Books (Title, Author, Description, CoverImage, FilePath, FileSize, PageCount, PublishDate, UploadedBy, CategoryID) VALUES
('Dune', 'Frank Herbert', 'A sci-fi classic.', '/images/dune.jpg', '/books/dune.pdf', 5000, 412, '1965-08-01', 1, 1),
('The Hobbit', 'J.R.R. Tolkien', 'A fantasy adventure.', '/images/hobbit.jpg', '/books/hobbit.pdf', 4500, 320, '1937-09-21', 2, 2),
('Clean Code', 'Robert C. Martin', 'A guide to writing clean code.', '/images/clean_code.jpg', '/books/clean_code.pdf', 6000, 464, '2008-08-11', 3, 3),
('Atomic Habits', 'James Clear', 'A book on habit formation.', '/images/atomic_habits.jpg', '/books/atomic_habits.pdf', 3800, 280, '2018-10-16', 2, 4);
GO

-- Thêm dữ liệu mẫu cho UserLibrary
INSERT INTO UserLibrary (UserID, BookID, AddedDate, CurrentPage, IsFavorite) VALUES
(1, 1, GETDATE(), 50, 1),
(2, 2, GETDATE(), 10, 0),
(3, 3, GETDATE(), 100, 1);
GO

-- Thêm dữ liệu mẫu cho Ratings
INSERT INTO Ratings (UserID, BookID, Score, Comment) VALUES
(1, 1, 5, 'Amazing book!'),
(2, 2, 4, 'Very enjoyable'),
(3, 3, 5, 'Must-read for programmers.');
GO

-- Thêm dữ liệu mẫu cho Notes
INSERT INTO Notes (UserID, BookID, PageNumber, NoteText) VALUES
(1, 1, 50, 'Great chapter on politics in sci-fi.'),
(2, 2, 10, 'Interesting start to the adventure.'),
(3, 3, 100, 'Clean coding principles make sense.');
GO

-- Thêm dữ liệu mẫu cho Settings
INSERT INTO Settings (UserID, FontSize, FontFamily, BackgroundColor, TextColor, NightMode) VALUES
(1, 14, 'Arial', '#F5F5F5', '#000000', 1),
(2, 12, 'Times New Roman', '#FFFFFF', '#000000', 0),
(3, 16, 'Verdana', '#EFEFEF', '#333333', 1);
GO
