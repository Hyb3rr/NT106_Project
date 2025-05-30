﻿using BookReaderApp.Data;
using BookReaderApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace BookReaderApp.ViewForm
{
    public partial class AdminForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private readonly DriveServiceHelper _driveServiceHelper;
        public AdminForm(BookReaderDbContext context)
        {
            InitializeComponent();
            _context = context;
            _driveServiceHelper = new DriveServiceHelper();
        }
        // ========================= QUẢN LÝ NGƯỜI DÙNG =========================
        private void LoadUsers()
        {
            dgvUsers.DataSource = _context.Users
                .Select(u => new
                {
                    u.UserId,
                    u.Username,
                    u.PasswordHash,
                    u.Email,
                    u.FullName,
                    u.Avatar,
                    u.Role,
                    u.IsActive,
                    u.CreatedDate,
                    u.LastLogin
                })
                .ToList();
        }
        // ========================= QUẢN LÝ SÁCH =========================
        private void LoadBooks()
        {
            dgvBooks.DataSource = _context.Books
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Description,
                    b.Author,
                    CategoryName = b.Category != null ? b.Category.CategoryName : "Unknown",
                    UploaderUsername = b.Uploader != null ? b.Uploader.Username : "Unknown",
                    b.PublishedDate,
                    b.CoverImage,
                    b.FilePath,
                    b.DriveUrl
                })
                .ToList();
        }
        // ========================= QUẢN LÝ THỂ LOẠI =========================
        private void LoadCategories()
        {
            dgvCategories.DataSource = _context.Categories
                .Select(c => new
                {
                    c.CategoryId,
                    c.CategoryName,
                    c.Description
                })
                .ToList();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadBooks();
            LoadCategories();
            ChooseTag.Items.AddRange(new string[] { "Users", "Books", "Categories" });
            ChooseTag.SelectedIndex = 0; // Default to "Users"
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm(_context);
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = (int)dgvUsers.SelectedRows[0].Cells["UserId"].Value;
                var user = _context.Users.Find(userId);

                if (user != null)
                {
                    var editUserForm = new EditUserForm(_context, user);
                    if (editUserForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadUsers();
                    }
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = (int)dgvUsers.SelectedRows[0].Cells["UserId"].Value;
                var user = _context.Users.Find(userId);

                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    LoadUsers();
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm(_context);
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    var editBookForm = new EditBookForm(_context, book);
                    if (editBookForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadBooks();
                    }
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    _context.Books.Remove(book);
                    _context.SaveChanges();
                    LoadBooks();
                }
            }
        }

        private async void btnUploadToDrive_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null && !string.IsNullOrEmpty(book.FilePath))
                {
                    try
                    {
                        string fileId = await _driveServiceHelper.UploadFileAsync(book.FilePath);
                        string driveUrl = $"https://drive.google.com/file/d/{fileId}/view";

                        // Lưu URL vào cơ sở dữ liệu
                        book.DriveUrl = driveUrl;
                        _context.SaveChanges();

                        MessageBox.Show($"Tải sách lên Google Drive thành công! URL: {driveUrl}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var addCategoryForm = new AddCategoryForm(_context);
            if (addCategoryForm.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int categoryId = (int)dgvCategories.SelectedRows[0].Cells["CategoryId"].Value;
                var category = _context.Categories.Find(categoryId);

                if (category != null)
                {
                    var editCategoryForm = new EditCategoryForm(_context, category);
                    if (editCategoryForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCategories();
                    }
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int categoryId = (int)dgvCategories.SelectedRows[0].Cells["CategoryId"].Value;
                var category = _context.Categories.Find(categoryId);

                if (category != null)
                {
                    _context.Categories.Remove(category);
                    _context.SaveChanges();
                    LoadCategories();
                }
            }
        }
        // ========================= MENUSTRIP =========================
        private void menuExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát ứng dụng
        }

        private void menuLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Đăng xuất
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = kryptonTextBoxSearch.Text.Trim();

            // Use AsEnumerable to switch to client-side evaluation for unsupported methods
            //var filteredBooks = _context.Books
            //    .Include(b => b.Category) // Ensure related data is loaded
            //    .AsEnumerable() // Switch to client-side evaluation
            //    .Where(b => (b.Title != null && b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
            //                (b.Author != null && b.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
            //                (b.Category != null && b.Category.CategoryName != null && b.Category.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
            //    .Select(b => new
            //    {
            //        b.BookId,
            //        b.Title,
            //        b.Author,
            //        Category = b.Category != null ? b.Category.CategoryName : "Unknown",
            //        b.PublishedDate
            //    })
            //    .ToList();
            // with server
            var filteredBooks = _context.Books
                .Include(b => b.Category)
                .Where(b => EF.Functions.Like(b.Title, $"%{keyword}%") ||
                            EF.Functions.Like(b.Author, $"%{keyword}%") ||
                            (b.Category != null && EF.Functions.Like(b.Category.CategoryName, $"%{keyword}%"))) // Added null check for b.Category
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Author,
                    Category = b.Category != null ? b.Category.CategoryName : "Unknown",
                    b.PublishedDate
                })
                .ToList();
            // Update DataGridView
            dgvBooks.DataSource = filteredBooks;
        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchUser.Text.Trim();

            var filteredUsers = _context.Users
                .AsEnumerable() // Switch to client-side evaluation
                .Where(u => (u.Username != null && u.Username.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                            (u.Email != null && u.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                            (u.FullName != null && u.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                .Select(u => new
                {
                    u.UserId,
                    u.Username,
                    u.Email,
                    u.Role,
                    u.IsActive,
                    u.CreatedDate,
                    u.LastLogin
                })
                .ToList();

            // Update DataGridView
            dgvUsers.DataSource = filteredUsers;
        }

        private void ChooseTag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchAll_TextChanged(object sender, EventArgs e)
        {
            //string keyword = SearchAll.Text.Trim();
            //string? selectedTarget = ChooseTag.SelectedItem?.ToString(); // Use nullable string

            //if (string.IsNullOrEmpty(keyword) || string.IsNullOrEmpty(selectedTarget))
            //    return;

            //switch (selectedTarget)
            //{
            //    case "Users":
            //        var filteredUsers = _context.Users
            //            .AsEnumerable()
            //            .Where(u => (u.Username != null && u.Username.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
            //                        (u.Email != null && u.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
            //                        (u.FullName != null && u.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
            //            .Select(u => new
            //            {
            //                u.UserId,
            //                u.Username,
            //                u.Email,
            //                u.Role,
            //                u.IsActive,
            //                u.CreatedDate,
            //                u.LastLogin
            //            })
            //            .ToList();
            //        dgvUsers.DataSource = filteredUsers;
            //        break;

            //    case "Books":
            //        var filteredBooks = _context.Books
            //            .Include(b => b.Category)
            //            .AsEnumerable()
            //            .Where(b => (b.Title != null && b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
            //                        (b.Author != null && b.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
            //                        (b.Category != null && b.Category.CategoryName != null && b.Category.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
            //            .Select(b => new
            //            {
            //                b.BookId,
            //                b.Title,
            //                b.Author,
            //                Category = b.Category != null ? b.Category.CategoryName : "Unknown",
            //                b.PublishedDate
            //            })
            //            .ToList();
            //        dgvBooks.DataSource = filteredBooks;
            //        break;

            //    case "Categories":
            //        var filteredCategories = _context.Categories
            //            .AsEnumerable()
            //            .Where(c => (c.CategoryName != null && c.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
            //                        (c.Description != null && c.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
            //            .Select(c => new
            //            {
            //                c.CategoryId,
            //                c.CategoryName,
            //                c.Description
            //            })
            //            .ToList();
            //        dgvCategories.DataSource = filteredCategories;
            //        break;

            //    default:
            //        break;
            //}

            // Các không cần chia       // ========================= TÌM KIẾM =========================
            string keyword = SearchAll.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // Reload all data if the search box is empty
                LoadUsers();
                LoadBooks();
                LoadCategories();
                return;
            }

            // Filter Users
            var filteredUsers = _context.Users
                .AsEnumerable()
                .Where(u => (u.Username != null && u.Username.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                            (u.Email != null && u.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                            (u.FullName != null && u.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                .Select(u => new
                {
                    u.UserId,
                    u.Username,
                    u.Email,
                    u.Role,
                    u.IsActive,
                    u.CreatedDate,
                    u.LastLogin
                })
                .ToList();
            dgvUsers.DataSource = filteredUsers;

            // Filter Books
            var filteredBooks = _context.Books
                .Include(b => b.Category)
                .AsEnumerable()
                .Where(b => (b.Title != null && b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                            (b.Author != null && b.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                            (b.Category != null && b.Category.CategoryName != null && b.Category.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.Author,
                    Category = b.Category != null ? b.Category.CategoryName : "Unknown",
                    b.PublishedDate
                })
                .ToList();
            dgvBooks.DataSource = filteredBooks;

            // Filter Categories
            var filteredCategories = _context.Categories
                .AsEnumerable()
                .Where(c => (c.CategoryName != null && c.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                            (c.Description != null && c.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                .Select(c => new
                {
                    c.CategoryId,
                    c.CategoryName,
                    c.Description
                })
                .ToList();
            dgvCategories.DataSource = filteredCategories;
        }

        private void SearchCate_TextChanged(object sender, EventArgs e)
        {
            string keyword = SearchCate.Text.Trim();
            var filteredCategories = _context.Categories
                .AsEnumerable()
                .Where(c => (c.CategoryName != null && c.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                            (c.Description != null && c.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                .Select(c => new
                {
                    c.CategoryId,
                    c.CategoryName,
                    c.Description
                })
                .ToList();
            // Update DataGridView
            dgvCategories.DataSource = filteredCategories;
        }

        private void kryptonButtonAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm(_context);
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void kryptonButtonEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = (int)dgvUsers.SelectedRows[0].Cells["UserId"].Value;
                var user = _context.Users.Find(userId);

                if (user != null)
                {
                    var editUserForm = new EditUserForm(_context, user);
                    if (editUserForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadUsers();
                    }
                }
            }
        }

        private void kryptonButtonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = (int)dgvUsers.SelectedRows[0].Cells["UserId"].Value;
                var user = _context.Users.Find(userId);

                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    LoadUsers();
                }
            }
        }

        private void kryptonButtonAddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm(_context);
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void kryptonButtonEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    var editBookForm = new EditBookForm(_context, book);
                    if (editBookForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadBooks();
                    }
                }
            }
        }

        private void kryptonButtonDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    _context.Books.Remove(book);
                    _context.SaveChanges();
                    LoadBooks();
                }
            }
        }

        private async void kryptonButtonUploadToDrive_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookId"].Value;
                var book = _context.Books.Find(bookId);

                if (book != null && !string.IsNullOrEmpty(book.FilePath))
                {
                    try
                    {
                        string fileId = await _driveServiceHelper.UploadFileAsync(book.FilePath);
                        string driveUrl = $"https://drive.google.com/file/d/{fileId}/view";

                        // Lưu URL vào cơ sở dữ liệu
                        book.DriveUrl = driveUrl;
                        _context.SaveChanges();

                        MessageBox.Show($"Tải sách lên Google Drive thành công! URL: {driveUrl}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            var addCategoryForm = new AddCategoryForm(_context);
            if (addCategoryForm.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
            }
        }

        private void kryptonButtonEditCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int categoryId = (int)dgvCategories.SelectedRows[0].Cells["CategoryId"].Value;
                var category = _context.Categories.Find(categoryId);

                if (category != null)
                {
                    var editCategoryForm = new EditCategoryForm(_context, category);
                    if (editCategoryForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCategories();
                    }
                }
            }
        }

        private void kryptonButtonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int categoryId = (int)dgvCategories.SelectedRows[0].Cells["CategoryId"].Value;
                var category = _context.Categories.Find(categoryId);

                if (category != null)
                {
                    _context.Categories.Remove(category);
                    _context.SaveChanges();
                    LoadCategories();
                }
            }
        }
    }
}
