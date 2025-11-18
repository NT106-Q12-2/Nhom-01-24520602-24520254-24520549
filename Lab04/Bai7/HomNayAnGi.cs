using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bai7.Model;
using Newtonsoft.Json.Linq;

namespace Bai7
{
    public partial class frm_HomNayAnGi : Form
    {
        private readonly HttpClient httpClient;
        private readonly string authToken;
        private readonly string NguoiThem;

        public frm_HomNayAnGi(string name, string token)
        {
            InitializeComponent();
            this.authToken = token;
            this.NguoiThem = name;

            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("https://nt106.uitiot.vn");
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthToken);

            SetupPaginationControls();

            // Gắn sự kiện
            this.Load += Frm_HomNayAnGi_Load;
            comboBox1.SelectedIndexChanged += ComboBox_Pagination_Changed;
            comboBox2.SelectedIndexChanged += ComboBox_Pagination_Changed;
            tc_DanhSachMonAn.SelectedIndexChanged += Tc_DanhSachMonAn_SelectedIndexChanged;
        }

        private void SetupPaginationControls()
        {
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("15");
            comboBox2.SelectedIndex = 0;

            comboBox1.Items.Add("1");
            comboBox1.SelectedIndex = 0;
        }

        private async void Frm_HomNayAnGi_Load(object sender, EventArgs e)
        {
            await Load_Data_For_Active_Tab();
        }

        private async void Tc_DanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Reset_Page_And_Load_Data();
        }

        private async void ComboBox_Pagination_Changed(object sender, EventArgs e)
        {
            if (_Is_Changing_Pagination)
                return;

            await Load_Data_For_Active_Tab();
        }

        private async Task Reset_Page_And_Load_Data()
        {
            _Is_Changing_Pagination = true;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("1");
            comboBox1.SelectedIndex = 0;

            await Load_Data_For_Active_Tab();

            _Is_Changing_Pagination = false;
        }

        private async Task Load_Data_For_Active_Tab()
        {
            if (_Is_Changing_Pagination)
                return;

            _Is_Changing_Pagination = true;

            int Current_Page = comboBox1.SelectedItem != null ? int.Parse(comboBox1.SelectedItem.ToString()) : 1;
            int Page_Size = comboBox2.SelectedItem != null ? int.Parse(comboBox2.SelectedItem.ToString()) : 5;

            try
            {
                if (tc_DanhSachMonAn.SelectedTab == tPage_All)
                {
                    await Load_All_Dishes(Current_Page, Page_Size);
                }
                else if (tc_DanhSachMonAn.SelectedTab == tPage_CuaToi)
                {
                    await Load_My_Dishes(Current_Page, Page_Size);
                }
            }
            finally
            {
                _Is_Changing_Pagination = false;
            }
        }

        private async Task Load_All_Dishes(int Page, int Page_Size)
        {
            var All_Dishes = new List<FoodItem>();
            int Current_Page = 1;

            try
            {
                while (All_Dishes.Count < Page_Size)
                {
                    var Api_Request_Body = new ApiRequest { Current = Current_Page, PageSize = Page_Size };
                    string Json_Request_Body = JsonConvert.SerializeObject(Api_Request_Body);
                    var Content = new StringContent(Json_Request_Body, Encoding.UTF8, "application/json");

                    HttpResponseMessage Response = await HttpClient.PostAsync("/api/v1/monan/all", Content);
                    string Json_Response = await Response.Content.ReadAsStringAsync();

                    if (!Response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Lỗi tải 'All': {Json_Response}", "Lỗi API");
                        break;
                    }

                    var Api_Response = JsonConvert.DeserializeObject<ApiResponse>(Json_Response);

                    if (Api_Response.Data == null || Api_Response.Data.Count == 0)
                        break;

                    All_Dishes.AddRange(Api_Response.Data);

                    if (All_Dishes.Count >= Page_Size || All_Dishes.Count >= Api_Response.Pagination.Total)
                        break;

                    Current_Page++;
                }

                var Dishes_To_Show = All_Dishes.Count > Page_Size ? All_Dishes.GetRange(0, Page_Size) : All_Dishes;

                await Update_Dishes_UI(flp_MenuAll, Dishes_To_Show);

                Update_Pagination_Controls(new PaginationInfo
                {
                    Current = 1,
                    PageSize = Page_Size,
                    Total = Math.Max(Page_Size, All_Dishes.Count)
                });
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Lỗi: {Ex.Message}", "Lỗi kết nối");
            }
        }

        private async Task Load_My_Dishes(int Page, int Page_Size)
        {
            var All_Dishes = new List<FoodItem>();
            int Current_Page = 1;

            try
            {
                while (All_Dishes.Count < Page_Size)
                {
                    var Api_Request_Body = new ApiRequest { Current = Current_Page, PageSize = Page_Size };
                    string Json_Request_Body = JsonConvert.SerializeObject(Api_Request_Body);
                    var Content = new StringContent(Json_Request_Body, Encoding.UTF8, "application/json");

                    HttpResponseMessage Response = await HttpClient.PostAsync("/api/v1/monan/my-dishes", Content);
                    string Json_Response = await Response.Content.ReadAsStringAsync();

                    if (!Response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Lỗi tải 'All': {Json_Response}", "Lỗi API");
                        break;
                    }

                    var Api_Response = JsonConvert.DeserializeObject<ApiResponse>(Json_Response);

                    if (Api_Response.Data == null || Api_Response.Data.Count == 0)
                        break;

                    All_Dishes.AddRange(Api_Response.Data);

                    if (All_Dishes.Count >= Page_Size || All_Dishes.Count >= Api_Response.Pagination.Total)
                        break;

                    Current_Page++;
                }

                var Dishes_To_Show = All_Dishes.Count > Page_Size ? All_Dishes.GetRange(0, Page_Size) : All_Dishes;

                await Update_Dishes_UI(flp_MenuAll, Dishes_To_Show);

                Update_Pagination_Controls(new PaginationInfo
                {
                    Current = 1,
                    PageSize = Page_Size,
                    Total = Math.Max(Page_Size, All_Dishes.Count)
                });
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Lỗi: {Ex.Message}", "Lỗi kết nối");
            }
        }

        private async Task XoaMonAn(string id,FoodItemControl controlRemove)
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://nt106.uitiot.vn");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

                try
                {
                    HttpResponseMessage response = await client.DeleteAsync($"/api/v1/monan/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xoá món thành công");

                        controlRemove.Parent.Controls.Remove(controlRemove);
                        controlRemove.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi xoá món","Lỗi");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
        }

        private async Task UpdateDishesUI(FlowLayoutPanel panel, List<FoodItem> dishes)
        {
            Panel.SuspendLayout();
            Panel.Controls.Clear();

            foreach (var Dish in Dishes)
            {
                FoodItemControl itemControl = new FoodItemControl();
                Image foodImage = await LoadImageAsync(dish.HinhAnh); 
                itemControl.SetData(dish.Id,dish.TenMonAn, dish.Gia, dish.DiaChi, dish.NguoiDongGop, foodImage);

                bool IsMyFood = (tc_DanhSachMonAn.SelectedTab == tPage_CuaToi);

                itemControl.ShowDeleteButton(IsMyFood);

                itemControl.DeleteClicked += async (s, e) =>
                {
                    await XoaMonAn(dish.Id, itemControl);
                };
                panel.Controls.Add(itemControl);
            }

        }

        private void Update_Pagination_Controls(PaginationInfo Pagination)
        {
            comboBox1.SelectedIndexChanged -= ComboBox_Pagination_Changed;

            int Total_Pages = Math.Max(1, (int)Math.Ceiling((double)Pagination.Total / Pagination.PageSize));
            comboBox1.Items.Clear();
            for (int i = 1; i <= Total_Pages; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            comboBox1.SelectedItem = Pagination.Current.ToString();

            comboBox1.SelectedIndexChanged += ComboBox_Pagination_Changed;
        }

        private async Task<Image> LoadImageAsync(string Url)
        {
            return null;
        }

        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            ThemMonAn AddFood = new ThemMonAn(NguoiThem, authToken);
            AddFood.Show();
        }

        private async void btn_AnGi_Click(object sender, EventArgs e)
        {
            string apiUrl = "";
            if (tc_DanhSachMonAn.SelectedIndex == 0)
            {
                apiUrl = "https://nt106.uitiot.vn/api/v1/monan/all";
            }
            else
            {
                apiUrl = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";
            }

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",authToken);
                try
                {
                    var payload = new
                    {
                        page = 1,
                        page_size = -1
                    };

                    string JsonString = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(JsonString, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        JObject jsonResponse = JObject.Parse(responseBody);

                        var listMonAn = jsonResponse["data"].ToObject<List<FoodItem>>();

                        if (listMonAn != null && listMonAn.Count > 0)
                        {
                            Random rnd = new Random();
                            int index = rnd.Next(listMonAn.Count);
                            FoodItem KetQua = listMonAn[index];
                            frm_AnGi Angi = new frm_AnGi(KetQua);
                            Angi.Show();
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
        }

    }
}
