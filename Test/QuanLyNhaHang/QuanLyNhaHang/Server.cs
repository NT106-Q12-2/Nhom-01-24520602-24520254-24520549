using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        Dictionary<TcpClient, string> clientNames = new Dictionary<TcpClient, string>();
        Dictionary<TcpClient, StreamWriter> clientWriters = new Dictionary<TcpClient, StreamWriter>();
        TcpListener server;

        void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 8080);
                server.Start();

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    Thread threadClient = new Thread(() => HandleClient(client));
                    threadClient.IsBackground = true;
                    threadClient.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }
        }

        private void HandleClient(TcpClient client)
        { 
                    
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Thread threadServer = new Thread(StartServer);
            threadServer.IsBackground = true;
            threadServer.Start();
        }

        private void btn_Charge_Click(object sender, EventArgs e)
        {

        }
    }
}
