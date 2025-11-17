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
    public partial class frm_HomNayAnGi: Form
    {
        public frm_HomNayAnGi()
        {
            InitializeComponent();
        }


        private readonly HttpClient httpClient;
        private readonly string authToken; // Token nhận từ Form Login

        public frm_HomNayAnGi(string token)
        {
            InitializeComponent();
            this.authToken = token;

            // Khởi tạo HttpClient
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://nt106.uitiot.vn");
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", authToken); 

            // Cài đặt các ComboBox
            SetupPaginationControls();

            // Gắn sự kiện
            this.Load += Frm_HomNayAnGi_Load;
            this.comboBox1.SelectedIndexChanged += ComboBox_Pagination_Changed; // Page
            this.comboBox2.SelectedIndexChanged += ComboBox_Pagination_Changed; // Page Size
            this.tc_DanhSachMonAn.SelectedIndexChanged += Tc_DanhSachMonAn_SelectedIndexChanged;
        }

        // Cài đặt giá trị ban đầu cho ComboBox
        private void SetupPaginationControls()
        {
            // comboBox2 là PageSize
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("15");
            comboBox2.SelectedIndex = 0; // Mặc định là 5

            // comboBox1 là Page
            comboBox1.Items.Add("1");
            comboBox1.SelectedIndex = 0; // Mặc định là trang 1
        }

        // 1. Hàm Load chính khi Form mở lên
        private async void Frm_HomNayAnGi_Load(object sender, EventArgs e)
        {
            await LoadDataForActiveTab();
        }

        // 2. Hàm xử lý khi đổi Tab
        private async void Tc_DanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi đổi tab, reset về trang 1 và tải lại
            await ResetAndLoadData();
        }

        // 3. Hàm xử lý khi đổi Page (comboBox1) hoặc PageSize (comboBox2)
        private async void ComboBox_Pagination_Changed(object sender, EventArgs e)
        {
            if (sender == comboBox2) // Nếu đổi PageSize
            {
                // Reset về trang 1 và tải lại
                await ResetAndLoadData();
            }
            else // Nếu chỉ đổi Page
            {
                await LoadDataForActiveTab();
            }
        }

        // 4. Hàm reset phân trang về trang 1
        private async Task ResetAndLoadData(bool loadData = true)
        {
            // Tạm ngắt sự kiện để tránh lặp vô tận
            comboBox1.SelectedIndexChanged -= ComboBox_Pagination_Changed;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("1");
            comboBox1.SelectedIndex = 0;

            // Gắn lại sự kiện
            comboBox1.SelectedIndexChanged += ComboBox_Pagination_Changed;

            if (loadData)
            {
                await LoadDataForActiveTab();
            }
        }

        // 5. Hàm quyết định tải dữ liệu cho tab nào
        private async Task LoadDataForActiveTab()
        {
            // Lấy giá trị phân trang hiện tại từ UI
            int currentPage = int.Parse(comboBox1.SelectedItem.ToString());
            int pageSize = int.Parse(comboBox2.SelectedItem.ToString());

            if (tc_DanhSachMonAn.SelectedTab == tPage_All)
            {
                await LoadAllDishesAsync(currentPage, pageSize);
            }
            else if (tc_DanhSachMonAn.SelectedTab == tPage_CuaToi)
            {
                // Bỏ phần code tạm thời và gọi hàm mới
                await LoadMyDishesAsync(currentPage, pageSize);
            }
        }

        // 6. HÀM QUAN TRỌNG: Tải danh sách "All"
        private async Task LoadAllDishesAsync(int page, int pageSize)
        {
            var requestBody = new ApiRequest
            {
                Current = page,
                PageSize = pageSize
            };

            try
            {
                string jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                StringContent content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync("/api/v1/monan/all", content);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

                    // Cập nhật UI với dữ liệu mới
                    await UpdateDishesUI(flp_MenuAll, apiResponse.Data);

                    // Cập nhật số trang trong ComboBox
                    UpdatePaginationControls(apiResponse.Pagination);
                }
                else
                {
                    MessageBox.Show($"Lỗi khi tải danh sách 'All': {jsonResponse}", "Lỗi API");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi kết nối");
            }
        }

        // 7. HÀM TẢI MÓN ĂN CỦA TÔI (bạn sẽ làm)
        private async Task LoadMyDishesAsync(int page, int pageSize)
        {
            var requestBody = new ApiRequest
            {
                Current = page,
                PageSize = pageSize
            };

            try
            {
                string jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                StringContent content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                // SỬ DỤNG ENDPOINT CỦA USER
                HttpResponseMessage response = await httpClient.PostAsync("/api/v1/monan/my-dishes", content);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

                    // CẬP NHẬT VÀO flp_Menu (thay vì flp_MenuAll)
                    await UpdateDishesUI(flp_Menu, apiResponse.Data);

                    // Cập nhật số trang trong ComboBox
                    UpdatePaginationControls(apiResponse.Pagination);
                }
                else
                {
                    MessageBox.Show($"Lỗi khi tải danh sách 'My Dishes': {jsonResponse}", "Lỗi API");
                    // Nếu lỗi (ví dụ 422), xóa các control cũ và reset phân trang
                    flp_Menu.Controls.Clear();
                    UpdatePaginationControls(new PaginationInfo { Current = 1, PageSize = pageSize, Total = 0 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi kết nối");
            }
        }


        // 8. Hàm cập nhật các món ăn lên FlowLayoutPanel
        private async Task UpdateDishesUI(FlowLayoutPanel panel, List<FoodItem> dishes)
        {
            panel.Controls.Clear(); // Xóa các món ăn cũ

            foreach (var dish in dishes)
            {
                FoodItemControl itemControl = new FoodItemControl();

                // Tải hình ảnh (sẽ trả về null như đã thảo luận)
                Image foodImage = await LoadImageAsync(dish.HinhAnh);

                itemControl.SetData(
                    dish.TenMonAn,
                    dish.Gia,
                    dish.DiaChi,
                    dish.NguoiDongGop,
                    foodImage
                );

                panel.Controls.Add(itemControl);
            }
        }

        // 9. Hàm cập nhật ComboBox phân trang
        private void UpdatePaginationControls(PaginationInfo pagination)
        {
            // Tạm ngắt sự kiện
            comboBox1.SelectedIndexChanged -= ComboBox_Pagination_Changed;

            int totalPages = (int)Math.Ceiling((double)pagination.Total / pagination.PageSize);
            // Đảm bảo có ít nhất 1 trang
            if (totalPages == 0) totalPages = 1;

            string currentPage = (pagination.Current).ToString();
            comboBox1.Items.Clear();

            for (int i = 1; i <= totalPages; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            // Đặt lại trang hiện tại
            comboBox1.SelectedItem = currentPage;

            // Gắn lại sự kiện
            comboBox1.SelectedIndexChanged += ComboBox_Pagination_Changed;
        }

        // 10. Hàm phụ: Tải ảnh (Đã cập nhật)
        private async Task<Image> LoadImageAsync(string url)
        {
            // Như đã thảo luận, server trả về URL trang web, không phải file ảnh.
            // Chúng ta sẽ bỏ qua việc tải ảnh và trả về null.
            return null;
        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {

        }

        private void btn_AnGi_Click(object sender, EventArgs e)
        {

        }
    }
}
