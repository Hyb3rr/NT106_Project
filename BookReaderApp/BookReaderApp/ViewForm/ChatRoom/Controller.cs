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
using System.Net.Sockets;
namespace BookReaderApp.ViewForm
{
    public partial class Controller : KryptonForm
    {
        public Controller()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form Client = new Client();
            //Client.Show();
            Form ClientForm = new ClienForm();
            ClientForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form Server = new Server();
            //Server.Show();
            Form ServerForm = new ServerForm();
            ServerForm.Show();
        }
    }
}
