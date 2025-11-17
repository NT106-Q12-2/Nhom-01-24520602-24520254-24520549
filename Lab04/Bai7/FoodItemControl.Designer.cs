namespace Bai7
{
    partial class FoodItemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.lbl_Gia = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_DongGop = new System.Windows.Forms.Label();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_DongGop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_HinhAnh
            // 
            this.ptb_HinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_HinhAnh.Location = new System.Drawing.Point(13, 14);
            this.ptb_HinhAnh.Name = "ptb_HinhAnh";
            this.ptb_HinhAnh.Size = new System.Drawing.Size(165, 168);
            this.ptb_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_HinhAnh.TabIndex = 0;
            this.ptb_HinhAnh.TabStop = false;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Ten.Location = new System.Drawing.Point(193, 14);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(179, 36);
            this.lbl_Ten.TabIndex = 1;
            this.lbl_Ten.Text = "Tên món ăn";
            // 
            // lbl_Gia
            // 
            this.lbl_Gia.AutoSize = true;
            this.lbl_Gia.Location = new System.Drawing.Point(208, 68);
            this.lbl_Gia.Name = "lbl_Gia";
            this.lbl_Gia.Size = new System.Drawing.Size(38, 20);
            this.lbl_Gia.TabIndex = 2;
            this.lbl_Gia.Text = "Giá:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(208, 108);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(61, 20);
            this.lbl_DiaChi.TabIndex = 3;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_DongGop
            // 
            this.lbl_DongGop.AutoSize = true;
            this.lbl_DongGop.Location = new System.Drawing.Point(208, 146);
            this.lbl_DongGop.Name = "lbl_DongGop";
            this.lbl_DongGop.Size = new System.Drawing.Size(83, 20);
            this.lbl_DongGop.TabIndex = 4;
            this.lbl_DongGop.Text = "Đóng góp:";
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(306, 62);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.ReadOnly = true;
            this.tb_Gia.Size = new System.Drawing.Size(192, 26);
            this.tb_Gia.TabIndex = 5;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(306, 105);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.ReadOnly = true;
            this.tb_DiaChi.Size = new System.Drawing.Size(192, 26);
            this.tb_DiaChi.TabIndex = 6;
            // 
            // tb_DongGop
            // 
            this.tb_DongGop.Location = new System.Drawing.Point(306, 143);
            this.tb_DongGop.Name = "tb_DongGop";
            this.tb_DongGop.ReadOnly = true;
            this.tb_DongGop.Size = new System.Drawing.Size(192, 26);
            this.tb_DongGop.TabIndex = 7;
            // 
            // FoodItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_DongGop);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.lbl_DongGop);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_Gia);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.ptb_HinhAnh);
            this.Name = "FoodItemControl";
            this.Size = new System.Drawing.Size(549, 190);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_HinhAnh;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.Label lbl_Gia;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_DongGop;
        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_DongGop;
    }
}
