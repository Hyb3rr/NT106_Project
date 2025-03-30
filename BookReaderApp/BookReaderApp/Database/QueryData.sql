USE BookReaderDB;
GO

SELECT name AS DatabaseName, physical_name AS FilePath, type_desc AS FileType
FROM sys.master_files
WHERE database_id = DB_ID('BookReaderDB');

Select * from Users;

UPDATE Users 
SET PasswordHash = N'abcd' 
WHERE Username = 'admin';


Select * from Categories;

Select * from Books;

Select * from UserLibrary;

Select * from Ratings;

Select * from Notes;

Select * from Bookmarks;

Select * from ReadingSessions;

Select * from Downloads;

Select * from Collections;

Select * from CollectionBooks;

Select * from Notifications;

Select * from Settings;

GO