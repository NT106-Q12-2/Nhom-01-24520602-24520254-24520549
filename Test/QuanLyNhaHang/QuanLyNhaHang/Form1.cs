using System.Net;
using System.Net.Sockets;
using System.Text.Json;

namespace QuanLyNhaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpClient client = new TcpClient();
        StreamReader reader;
        StreamWriter writer;
        Dictionary<int, Dictionary<string, int>> DanhSachMonAn = new Dictionary<int, Dictionary<string, int>>();
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            IPEndPoint Ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            try
            {
                client.Connect(Ipe);
                MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Error");
            }

            NetworkStream ns = client.GetStream();
            reader = new StreamReader(ns);
            writer = new StreamWriter(ns) { AutoFlush = true };

            var Packet = new
            {
                action = "MENU",
            };

            writer.WriteLine(JsonSerializer.Serialize(Packet));

            Thread ListenThread = new Thread((HandleServer));
            ListenThread.IsBackground = true;
            ListenThread.Start();
        }

        private void HandleServer()
        {
            try
            {
                while (client.Connected)
                {
                    string data = reader.ReadLine();

                    
                    var respone = JsonSerializer.Deserialize<Dictionary<string,JsonElement>>(data);

                    if (!respone.ContainsKey("action")) return;

                    switch (respone["action"].GetString())
                    {
                        case "GET_MENU":
                            ThemMonAnVaoDanhSach(respone);
                            break;
                               
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình kết nối");
                return;
            }
        }

        void ThemMonAnVaoDanhSach(Dictionary<string, JsonElement> MonAn)
        {
            //DanhSachMonAn.Add(MonAn["STT"].GetInt32(), MonAn["Ten"].GetString(), MonAn["Tien"].GetInt32());
        }

    }
}
