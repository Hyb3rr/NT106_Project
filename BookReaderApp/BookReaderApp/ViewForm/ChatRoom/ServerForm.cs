using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
namespace BookReaderApp.ViewForm
{
    public partial class ServerForm : KryptonForm
    {
        private TcpListener? listener; // Marked as nullable to resolve CS8618  
        private List<TcpClient> clients = new List<TcpClient>();

        public ServerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.Location = new Point(200, 200);
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();
            Log("Server started on port 8080");

            Task.Run(() =>
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clients.Add(client);
                    Log($"New client connected: {client.Client.RemoteEndPoint}");

                    Task.Run(() => HandleClient(client));
                }
            });
        }

        void HandleClient(TcpClient client)
        {
            if (client.Client?.RemoteEndPoint == null)
            {
                Log("Client connection is invalid or null.");
                return;
            }

            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int byteCount;

            while ((byteCount = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string msg = Encoding.UTF8.GetString(buffer, 0, byteCount);
                string? clientAddress = client.Client.RemoteEndPoint.ToString();
                string logMsg = $"[{clientAddress}] {msg}";
                //Log(msg);
                Log(logMsg);
                Broadcast(msg, client);
            }

            clients.Remove(client);
            client.Close();
        }

        void Broadcast(string msg, TcpClient excludeClient)
        {
            byte[] data = Encoding.UTF8.GetBytes(msg);
            foreach (var client in clients)
            {
                if (client != excludeClient)
                {
                    try
                    {
                        client.GetStream().Write(data, 0, data.Length);
                    }
                    catch { }
                }
            }
        }

        void Log(string msg)
        {
            Invoke(() => richTextBox_Log.AppendText(msg + Environment.NewLine));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var client in clients)
                {
                    client.Close();
                }

                listener?.Stop();
                Log("Server manually stopped.");
            }
            catch (Exception ex)
            {
                Log($"Lỗi khi dừng server: {ex.Message}");
            }
        }
    }
}

