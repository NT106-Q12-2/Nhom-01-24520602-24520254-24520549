using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Dat_Ve : Form
    {
        public Dat_Ve()
        {
            InitializeComponent();
            Xu_Ly_HTML();
            Xu_Ly_Load_Ds();
        }

        public class Movie
        {
            public string Ten_Phim { get; set; }
            public string The_Loai { get; set; }
            public string Thoi_Luong { get; set; }
            public List<string> Phong_Chieu { get; set; }
            public int Gia_Ve { get; set; }
        }

        List<Movie> Danh_Sach_Phim = new List<Movie>();

        Dictionary<string, List<string>> Ghe_Da_Dat = new Dictionary<string, List<string>>();

        public void Xu_Ly_HTML()
        {
            string URL = "https://www.betacinemas.vn/phim.htm";

            var Web = new HtmlWeb();
            var Content = Web.Load(URL);

            var Nodes = Content.DocumentNode.SelectNodes("//div[contains(@class,'film-info')]");
            if (Nodes == null) return;

            foreach (var Film in Nodes)
            {
                var Name_Node = Film.SelectSingleNode(".//h3/a");
                string Name = Name_Node?.InnerText.Trim();

                var Genre_Node = Film.SelectSingleNode(".//li[span[text()='Thể loại:']]");
                string Genre = Name_Node?.InnerText.Trim();

                var Duration_Node = Film.SelectSingleNode(".//li[span[text()='Thời lượng:']]");
                string Duration = Name_Node?.InnerText.Trim();

                Danh_Sach_Phim.Add(new Movie
                {
                    Ten_Phim = Name,
                    The_Loai = Genre,
                    Thoi_Luong = Duration,
                    Phong_Chieu = new List<string> { "1", "2", "3" },
                    Gia_Ve = 36000
                });
            }

            var Options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };

            string Json = JsonSerializer.Serialize(Danh_Sach_Phim, Options);
            File.WriteAllText("Thong_Tin_Phim.json", Json, Encoding.UTF8);
        }

        public void Xu_Ly_Load_Ds()
        {
            cb_Phim.DataSource = Danh_Sach_Phim.Select(Phim => Phim.Ten_Phim).ToList();
        }

        private void cb_Phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Phim = cb_Phim.SelectedItem.ToString();

            var Movie = Danh_Sach_Phim.FirstOrDefault(P => P.Ten_Phim == Phim);

            if (Movie != null)
            {
                cb_Phong.DataSource = Movie.Phong_Chieu;
            }
        }

        private void cb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Phong = cb_Phong.SelectedItem.ToString();
            clb_Ghe.Items.Clear();

            foreach (var Hang_Ghe in new[] { "A", "B", "C" })
            {
                for (int i = 1; i <= 5; i++)
                {
                    string Ghe = $"{Phong} - {Hang_Ghe}{i}";

                    int Index = clb_Ghe.Items.Add(Ghe, false);

                    if (Ghe_Da_Dat.Values.Any(G => G.Contains(Ghe)))
                    {
                        clb_Ghe.SetItemCheckState(Index, CheckState.Indeterminate);
                    }
                }
            }
        }

        private void btn_DatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenKhach.Text) || cb_Phim.SelectedIndex == -1 || cb_Phong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                tb_TenKhach.Focus();
                return;
            }

            string Khach = tb_TenKhach.Text.Trim();

            if (!Ghe_Da_Dat.ContainsKey(Khach))
                Ghe_Da_Dat[Khach] = new List<string>();

            var Ghe_Cu = Ghe_Da_Dat[Khach];

            var Ghe_Moi = clb_Ghe.CheckedItems.Cast<string>().Where(Ghe => !Ghe_Da_Dat.Values.Any(List => List.Contains(Ghe))).ToList();

            if (Ghe_Moi.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế");
                return;
            }

            string Phim = cb_Phim.SelectedItem.ToString();

            var movie = Danh_Sach_Phim.FirstOrDefault(P => P.Ten_Phim == Phim);
            if (movie == null) return;

            int Gia_Ve = movie.Gia_Ve;
            string The_Loai = movie.The_Loai;
            string Thoi_Luong = movie.Thoi_Luong;

            double Tong_Tien = 0;
            List<string> Chi_Tiet_Ve = new List<string>();

            foreach (var Ghe in Ghe_Moi)
            {
                Ghe_Da_Dat[Khach].Add(Ghe);

                double Tien = Gia_Ve;
                Tong_Tien += Tien;

                Chi_Tiet_Ve.Add(Ghe);
            }

            tb_KQ.Text = $"Họ tên: {Khach}" + Environment.NewLine +
                         $"Phim: {Phim}" + Environment.NewLine +
                         $"Thể loại: {The_Loai}" + Environment.NewLine +
                         $"Thời lượng: {Thoi_Luong}" + Environment.NewLine +
                         $"Phòng chiếu: {cb_Phong.SelectedItem}" + Environment.NewLine +
                         $"Ghế: {string.Join(", ", Chi_Tiet_Ve)}" + Environment.NewLine +
                         $"Tổng tiền: {Tong_Tien}đ";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            tb_KQ.Clear();
            tb_TenKhach.Clear();
        }
    }
}
