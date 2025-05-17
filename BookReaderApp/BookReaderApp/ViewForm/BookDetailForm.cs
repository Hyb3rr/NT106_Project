using BookReaderApp.Data;
using BookReaderApp.Models;
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
    public partial class BookDetailForm : KryptonForm
    {
        private readonly Book _book;
        private readonly BookReaderDbContext _context;
        private readonly int _userId;

        public BookDetailForm(Book book, BookReaderDbContext context, int userId)
        {
            InitializeComponent();
            _book = book;
            _context = context;
            _userId = userId;
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin sách
            lblTitle.Text = _book.Title;
            lblAuthor.Text = _book.Author;
            lblCategory.Text = _book.Category?.CategoryName ?? "Không xác định";
            lblPublishedDate.Text = _book.PublishedDate != default(DateTime)
                ? _book.PublishedDate.ToString("dd/MM/yyyy")
                : "Không xác định";
            kryptonRichTextBox1.Text = _book.Description ?? "Không có mô tả.";
            lblAverageRating.Text = $"Đánh giá trung bình: {_context.Ratings
            .Where(r => r.BookId == _book.BookId && r.Score.HasValue)
            .Average(r => r.Score) ?? 0:F1}/5";
        }

        private void btnReadBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_book.FilePath))
            {
                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", _book.FilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể mở file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy file sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            var reviewForm = new ReviewForm(_context, _userId, _book.BookId);
            var result = reviewForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Đánh giá đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kryptonButtonReadBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_book.FilePath))
            {
                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", _book.FilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể mở file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy file sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kryptonButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void kryptonButtonReview_Click(object sender, EventArgs e)
        {
            var reviewForm = new ReviewForm(_context, _userId, _book.BookId);
            var result = reviewForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Đánh giá đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
