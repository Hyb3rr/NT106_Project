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
    public partial class OnlineReaderForm: KryptonForm
    {
        public OnlineReaderForm(string driveUrl)
        {
            InitializeComponent();
            // Sử dụng WebView2 hoặc một trình duyệt nhúng khác để hiển thị nội dung
            var webView = new Microsoft.Web.WebView2.WinForms.WebView2
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(webView);

            webView.Source = new Uri(driveUrl);

            /*
             * // Tạo WebView2 và thêm vào form
                var webView = new WebView2
                {
                    Dock = DockStyle.Fill
                };
                this.Controls.Add(webView);

                // Điều hướng đến URL Google Drive
                webView.Source = new Uri(driveUrl);
             */
        }
    }
}
