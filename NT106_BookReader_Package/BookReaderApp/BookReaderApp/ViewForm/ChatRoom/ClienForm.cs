using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
namespace BookReaderApp.ViewForm
{
    public partial class ClienForm : KryptonForm
    {
        private TcpClient client = null!; // Initialize to null-forgiving operator to satisfy CS8618 // client for communication
        private NetworkStream stream = null!; // Initialize to null-forgiving operator to satisfy CS8618 // stream for communication
        private bool isConnected = false; // Remove assignment to satisfy CS0414 // flag to check connection status

        public ClienForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1100, 200);
        }

        private void ClienForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 8080);
                stream = client.GetStream();
                isConnected = true;

                Task.Run(() => Receive());
            }
            catch (SocketException)
            {
                MessageBox.Show("Không thể kết nối tới server.\nVui lòng đảm bảo server đã khởi động!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void Receive()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int byteCount;

                while ((byteCount = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string msg = Encoding.UTF8.GetString(buffer, 0, byteCount);
                    AppendMessage(msg);
                }

                // Khi byteCount == 0: server đã đóng kết nối
                ShowDisconnectedMessage();
            }
            catch
            {
                ShowDisconnectedMessage();
            }
        }

        private void ShowDisconnectedMessage()
        {
            this.Invoke(() =>
            {
                MessageBox.Show("Server đã ngắt kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // hoặc Disable giao diện, tùy ý bạn
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Chưa kết nối tới server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string msg = $"{textBoxName.Text}: {textBox_Message.Text}";
            byte[] data = Encoding.UTF8.GetBytes(msg);
            stream.Write(data, 0, data.Length);
            AppendMessage(msg); // cũng hiển thị cho chính mình
            textBox_Message.Clear();
        }

        void AppendMessage(string msg)
        {
            Invoke(() => richTextBox_Chat.AppendText(msg + Environment.NewLine));
        }
    }
}
