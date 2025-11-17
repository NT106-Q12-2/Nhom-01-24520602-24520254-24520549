using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bai7.Model; 

namespace Bai7
{
    public partial class frm_HomNayAnGi : Form
    {
        private readonly HttpClient httpClient;
        private readonly string authToken;

        public frm_HomNayAnGi(string token)
        {
            InitializeComponent();
            this.authToken = token;

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://nt106.uitiot.vn");
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", authToken);

            SetupPaginationControls();

            // Gắn sự kiện
            this.Load += Frm_HomNayAnGi_Load;
            this.comboBox1.SelectedIndexChanged += ComboBox_Pagination_Changed; 
            this.comboBox2.SelectedIndexChanged += ComboBox_Pagination_Changed; 
            this.tc_DanhSachMonAn.SelectedIndexChanged += Tc_DanhSachMonAn_SelectedIndexChanged;
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
            
            comboBox1.SelectedIndexChanged -= ComboBox_Pagination_Changed;
            comboBox2.SelectedIndexChanged -= ComboBox_Pagination_Changed;

            try
            {
                await LoadDataForActiveTab(); 
            }
            finally
            {
                comboBox1.SelectedIndexChanged += ComboBox_Pagination_Changed;
                comboBox2.SelectedIndexChanged += ComboBox_Pagination_Changed;
            }
        }

        private async void Tc_DanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged -= ComboBox_Pagination_Changed;
            comboBox2.SelectedIndexChanged -= ComboBox_Pagination_Changed;

            try
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.SelectedIndex = 0;

                await LoadDataForActiveTab();
            }
            finally
            {
                comboBox1.SelectedIndexChanged += ComboBox_Pagination_Changed;
                comboBox2.SelectedIndexChanged += ComboBox_Pagination_Changed;
            }
        }

        private async void ComboBox_Pagination_Changed(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged -= ComboBox_Pagination_Changed;
            comboBox2.SelectedIndexChanged -= ComboBox_Pagination_Changed;

            try
            {
                if (sender == comboBox2)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("1");
                    comboBox1.SelectedIndex = 0;
                }

                await LoadDataForActiveTab();
            }
            finally
            {
                comboBox1.SelectedIndexChanged += ComboBox_Pagination_Changed;
                comboBox2.SelectedIndexChanged += ComboBox_Pagination_Changed;
            }
        }

        private async Task LoadDataForActiveTab()
        {
            int currentPage = 1;
            int pageSize = 5;

            if (comboBox1.SelectedItem != null)
                currentPage = int.Parse(comboBox1.SelectedItem.ToString());

            if (comboBox2.SelectedItem != null)
                pageSize = int.Parse(comboBox2.SelectedItem.ToString());

            if (tc_DanhSachMonAn.SelectedTab == tPage_All)
            {
                await LoadAllDishesAsync(currentPage, pageSize);
            }
            else if (tc_DanhSachMonAn.SelectedTab == tPage_CuaToi)
            {
                await LoadMyDishesAsync(currentPage, pageSize);
            }
        }

        private async Task LoadAllDishesAsync(int page, int pageSize)
        {
            var requestBody = new ApiRequest { Current = page, PageSize = pageSize };
            try
            {
                string jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                StringContent content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync("/api/v1/monan/all", content);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);
                    await UpdateDishesUI(flp_MenuAll, apiResponse.Data);
                    UpdatePaginationControls(apiResponse.Pagination); 
                }
                else
                {
                    MessageBox.Show($"Lỗi tải 'All': {jsonResponse}", "Lỗi API");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi kết nối");
            }
        }

        private async Task LoadMyDishesAsync(int page, int pageSize)
        {
            var requestBody = new ApiRequest { Current = page, PageSize = pageSize };
            try
            {
                string jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                StringContent content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync("/api/v1/monan/my-dishes", content);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);
                    await UpdateDishesUI(flp_Menu, apiResponse.Data);
                    UpdatePaginationControls(apiResponse.Pagination); 
                }
                else
                {
                    MessageBox.Show($"Lỗi tải 'My Dishes': {jsonResponse}", "Lỗi API");
                    flp_Menu.Controls.Clear();
                    UpdatePaginationControls(new PaginationInfo { Current = 1, PageSize = pageSize, Total = 0 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi kết nối");
            }
        }

        private async Task UpdateDishesUI(FlowLayoutPanel panel, List<FoodItem> dishes)
        {
            panel.Controls.Clear();
            foreach (var dish in dishes)
            {
                FoodItemControl itemControl = new FoodItemControl();
                Image foodImage = await LoadImageAsync(dish.HinhAnh); 
                itemControl.SetData(dish.TenMonAn, dish.Gia, dish.DiaChi, dish.NguoiDongGop, foodImage);
                panel.Controls.Add(itemControl);
            }
        }

        private void UpdatePaginationControls(PaginationInfo pagination)
        {
            int totalPages = (int)Math.Ceiling((double)pagination.Total / pagination.PageSize);
            if (totalPages == 0) totalPages = 1;

            string currentPage = (pagination.Current).ToString();

            comboBox1.Items.Clear(); 
            for (int i = 1; i <= totalPages; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            comboBox1.SelectedItem = currentPage; 
        }

        private async Task<Image> LoadImageAsync(string url)
        {
            return null;
        }
    }
}