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
    public partial class ProgressForm : KryptonForm
    {
        public ProgressForm(string message)
        {
            InitializeComponent();
            // Thiết lập các thuộc tính của form
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new System.Drawing.Size(300, 100);
            this.Text = "Đang xử lý";

            // Thêm ProgressBar và Label
            ProgressBar progressBar = new ProgressBar();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Dock = DockStyle.Bottom;
            progressBar.Height = 20;

            Label label = new Label();
            label.Text = message;
            label.Dock = DockStyle.Fill;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.Controls.Add(progressBar);
            this.Controls.Add(label);
        }
    }
}
