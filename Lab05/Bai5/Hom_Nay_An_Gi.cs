using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Bai5
{
    public partial class Hom_Nay_An_Gi : Form
    {
        public Hom_Nay_An_Gi()
        {
            InitializeComponent();
        }

        // Định nghĩa kiểu dữ liệu Food
        public class Food
        {
            public string FoodName { get; set; }
            public string Image { get; set; }
            public string NameNCC { get; set; }
        }

        // Chuỗi kết nối SQL
        static string ConnectionSQL = "Data Source=SQLHomNayAnGi.db;Version=3;";

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            // Đọc mail rồi gửi lên db
        }

        private void btn_xemmon_Click(object sender, EventArgs e)
        {
            lv_dsmonan.Items.Clear();
            lv_dsmonan.View = View.Details;
            lv_dsmonan.FullRowSelect = true;
            lv_dsmonan.GridLines = true;
            lv_dsmonan.Columns.Add("Tên món ăn", 300);
            lv_dsmonan.Columns.Add("Người cung cấp", 300);
            lv_dsmonan.Columns.Add("Link hình ảnh", 800);
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionSQL))
            {
                connect.Open();
                string selectData = "SELECT TenMonAn, HoVaTen, HinhAnh FROM MonAn JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";
                using (SQLiteCommand command = new SQLiteCommand(selectData, connect))
                {
                    using (SQLiteDataReader readData = command.ExecuteReader())
                    {
                        while (readData.Read())
                        {
                            ListViewItem item = new ListViewItem(readData["TenMonAn"].ToString());
                            item.SubItems.Add(readData["HoVaTen"].ToString());
                            item.SubItems.Add(readData["HinhAnh"].ToString());
                            lv_dsmonan.Items.Add(item);
                        }
                    }
                }                                                                                       
            }
        }
                                                                                                                                                            
        private void btn_chonmon_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionSQL))
            {
                connect.Open();
                string countFoods = "SELECT COUNT(*) FROM MonAn";
                using (SQLiteCommand command = new SQLiteCommand(countFoods, connect))
                {
                    object cnt = command.ExecuteScalar();
                    if (Convert.ToInt32(cnt) == 0)
                    {
                        MessageBox.Show("Danh sách món ăn trống!");
                        return;
                    }
                }
                string selectData = "SELECT TenMonAn, HinhAnh, HoVaTen FROM MonAn M JOIN NguoiDung D ON M.IDNCC = D.IDNCC";
                using (SQLiteCommand command = new SQLiteCommand(selectData, connect))
                {
                    List<Food> foods = new List<Food>();
                    using (SQLiteDataReader readData = command.ExecuteReader())
                    {
                        while (readData.Read())
                        {
                            Food monan = new Food()
                            {
                                FoodName = readData["TenMonAn"].ToString(),
                                Image = readData["HinhAnh"].ToString(),
                                NameNCC = readData["HoVaTen"].ToString()
                            };
                            foods.Add(monan);
                        }
                        Random random = new Random();
                        int index = random.Next(foods.Count);
                        Food HomNay = foods[index];
                        try
                        {
                            ptb_ketquamonan.Load(HomNay.Image);
                            ptb_ketquamonan.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        MessageBox.Show($"Món ăn hôm nay: {HomNay.FoodName}\n" +
                                        $"Người cung cấp: {HomNay.NameNCC}"
                        );
                    }
                }
            }
        }
    }
}
