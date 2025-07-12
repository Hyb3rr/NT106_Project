using PdfiumViewer;
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
    public partial class PdfViewerForm: KryptonForm
    {
        private PdfViewer _pdfViewer;
        public PdfViewerForm(Stream pdfStream)
        {
            InitializeComponent();
            // Tạo PdfViewer và thêm vào form
            _pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(_pdfViewer);

            // Mở file PDF từ luồng
            var pdfDocument = PdfDocument.Load(pdfStream);
            _pdfViewer.Document = pdfDocument;
        }
    }
}
