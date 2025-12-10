using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("Table", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Qty", typeof(int));
            dataTable.Columns.Add("Total", typeof(int));

            // Liên kết DataTable với DataGridView
            dgv_Menu.DataSource = dataTable;
        }

        List<TcpClient> clients = new List<TcpClient>();
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
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                NetworkStream ns = client.GetStream();
                reader = new StreamReader(ns);
                writer = new StreamWriter(ns) { AutoFlush = true };
                while (client.Connected)
                {
                    string jsonstring = reader.ReadLine();
                    if (jsonstring == null) break;

                    var response = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonstring);

                    if (!response.ContainsKey("action")) continue;

                    string Action = response["action"].GetString();

                    switch (Action)
                    {
                        case "MENU":
                            clients.Add(client);
                            Send_Menu(client,ns);
                            AddMessage($"Receive from client");
                            break;
                        case "ORDER":
                            HandleOrder(response);
                            break;
                        case "QUIT":
                            CloseConnection(client,ns);
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
              
            }
        }

        private void HandleOrder(Dictionary<string, JsonElement> response)
        {
            throw new NotImplementedException();
        }

        private void CloseConnection(TcpClient client,NetworkStream ns)
        {
            if (client.Connected)
            {
                clients.Remove(client);
                var data = new
                {
                    action = "QUIT_SUCCESS"
                };

                StreamWriter sw = new StreamWriter(ns) { AutoFlush =true };
                sw.WriteLine(JsonSerializer.Serialize(data));
            }
        }


        private void AddMessage(string v)
        {
            if (rtb_Message.InvokeRequired)
            {
                rtb_Message.Invoke(new Action(() => AddMessage(v)));
            }
            else
            {
                rtb_Message.Text += $"{v}\r\n";
            }
        }

        private void Send_Menu(TcpClient client, NetworkStream stream)
        {
            try
            {
                using (StreamReader sr = new StreamReader("menu.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(";");

                        var Data = new
                        {
                            action = "GET_MENU",
                            STT = words[0],
                            Tien = words[1],
                            Ten = words[2]
                        };
                        stream = client.GetStream();
                        StreamWriter sw = new StreamWriter(stream) { AutoFlush =true };
                        sw.WriteLine(JsonSerializer.Serialize(Data));                   
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Thread threadServer = new Thread(StartServer);
            threadServer.IsBackground = true;
            threadServer.Start();
            lbl_Status.Text = "Listening on 8080";
        }

        private void btn_Charge_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string table = tb_Table.Text;
            foreach(DataGridViewRow row in dgv_Menu.Rows)
            {
            if (!row.IsNewRow) // Kiểm tra nếu không phải là dòng mới
            {
            string data = row.Cells[0].Value.ToString(); // Lấy giá trị từ ô đầu tiên của hàng
            if (table == data)
            {
                sum += (Convert.ToInt32(row.Cells[3].Value));
            }
            }
            }
            tb_Sum.Text = sum.ToString();
        
        }
    }
}
