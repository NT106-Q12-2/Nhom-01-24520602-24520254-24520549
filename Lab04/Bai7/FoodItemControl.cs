using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class FoodItemControl: UserControl
    {
        public FoodItemControl()
        {
            InitializeComponent();
        }

        public void SetData(string name, string price, string address, string contributor, Image img)
        {
            lbl_Ten.Text = name;
            tb_Gia.Text = price;
            tb_DiaChi.Text = address;
            tb_DongGop.Text = contributor;
            ptb_HinhAnh.Image = img;
        }
    }
}
