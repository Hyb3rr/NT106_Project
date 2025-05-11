






using BookReaderApp.Data;
using BookReaderApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Krypton.Toolkit;
namespace BookReaderApp.ViewForm
{
    public partial class ReviewForm : KryptonForm
    {
        private readonly BookReaderDbContext _context;
        private readonly int _userId;
        private readonly int _bookId;
        public ReviewForm(BookReaderDbContext context, int userId, int bookId)
        {
            InitializeComponent();
            _context = context;
            _userId = userId;
            _bookId = bookId;
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã đánh giá sách này chưa
            var existingRating = _context.Ratings
                .FirstOrDefault(r => r.UserId == _userId && r.BookId == _bookId);
            if (existingRating != null)
            {
                numericUpDownRating.Value = existingRating.Score ?? 0;
                kryptonRichTextBox1.Text = existingRating.Comment ?? "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var score = (int)numericUpDownRating.Value;
            var comment = kryptonRichTextBox1.Text.Trim();

            // Kiểm tra xem người dùng đã đánh giá sách này chưa
            var existingRating = _context.Ratings
                .FirstOrDefault(r => r.UserId == _userId && r.BookId == _bookId);

            if (existingRating != null)
            {
                // Cập nhật đánh giá
                existingRating.Score = score;
                existingRating.Comment = comment;
            }
            else
            {
                // Thêm mới đánh giá
                var newRating = new Rating
                {
                    UserId = _userId,
                    BookId = _bookId,
                    Score = score,
                    Comment = comment
                };
                _context.Ratings.Add(newRating);
            }

            _context.SaveChanges();

            MessageBox.Show("Đã lưu đánh giá của bạn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //private void SetRatingFromPictureBox(object sender, EventArgs e)
        //{
        //    // Determine which PictureBox was clicked
        //    KryptonPictureBox clickedPictureBox = (KryptonPictureBox)sender;

        //    // Get the rating value based on the clicked PictureBox (from 1 to 5)

        //    // Map PictureBox to rating value (1 for kryptonPictureBox1, 5 for kryptonPictureBox5)
        //    if (clickedPictureBox == kryptonPictureBox6)
        //    {
        //        numericUpDownRating.Value = 1;
        //        kryptonLabel2.Text = " Very Bad ";
        //    }
        //    else if (clickedPictureBox == kryptonPictureBox2)
        //    {
        //        numericUpDownRating.Value = 2;
        //        kryptonLabel2.Text = " Bad ";
        //    }
        //    else if (clickedPictureBox == kryptonPictureBox3)
        //    {
        //        numericUpDownRating.Value = 3;
        //        kryptonLabel2.Text = " Meh ";
        //    }
        //    else if (clickedPictureBox == kryptonPictureBox4)
        //    {
        //        numericUpDownRating.Value = 4;
        //        kryptonLabel2.Text = " Good ";
        //    }
        //    else if (clickedPictureBox == kryptonPictureBox1)
        //    {
        //        numericUpDownRating.Value = 5;
        //        kryptonLabel2.Text = " Very Good ";
        //    }

        //}

        private void numericUpDownRating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
            numericUpDownRating.Value = 5;
            kryptonLabel2.Text = " Very Good ";
        }

        private void kryptonPictureBox2_Click(object sender, EventArgs e)
        {
            numericUpDownRating.Value = 2;
            kryptonLabel2.Text = " Bad ";
        }

        private void kryptonPictureBox3_Click(object sender, EventArgs e)
        {
            numericUpDownRating.Value = 3;
            kryptonLabel2.Text = " Meh ";
        }

        private void kryptonPictureBox4_Click(object sender, EventArgs e)
        {
            numericUpDownRating.Value = 4;
            kryptonLabel2.Text = " Good ";
        }

        private void kryptonPictureBox6_Click(object sender, EventArgs e)
        {
            numericUpDownRating.Value = 1;
            kryptonLabel2.Text = " Very Bad ";
        }
    }
}
