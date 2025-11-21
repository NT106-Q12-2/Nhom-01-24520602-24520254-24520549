namespace Bai4
{
    partial class Dat_Ve
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Phim = new System.Windows.Forms.ComboBox();
            this.cb_Phong = new System.Windows.Forms.ComboBox();
            this.btn_DatVe = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TenKhach = new System.Windows.Forms.TextBox();
            this.clb_Ghe = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_KQ = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Phim
            // 
            this.cb_Phim.FormattingEnabled = true;
            this.cb_Phim.Location = new System.Drawing.Point(163, 134);
            this.cb_Phim.Name = "cb_Phim";
            this.cb_Phim.Size = new System.Drawing.Size(245, 21);
            this.cb_Phim.TabIndex = 0;
            // 
            // cb_Phong
            // 
            this.cb_Phong.FormattingEnabled = true;
            this.cb_Phong.Location = new System.Drawing.Point(163, 166);
            this.cb_Phong.Name = "cb_Phong";
            this.cb_Phong.Size = new System.Drawing.Size(245, 21);
            this.cb_Phong.TabIndex = 1;
            // 
            // btn_DatVe
            // 
            this.btn_DatVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DatVe.Location = new System.Drawing.Point(514, 96);
            this.btn_DatVe.Name = "btn_DatVe";
            this.btn_DatVe.Size = new System.Drawing.Size(140, 30);
            this.btn_DatVe.TabIndex = 2;
            this.btn_DatVe.Text = "Đặt vé";
            this.btn_DatVe.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.Location = new System.Drawing.Point(514, 151);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(140, 32);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá thông tin";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(198, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Phòng Vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(43, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(43, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(43, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phòng ";
            // 
            // tb_TenKhach
            // 
            this.tb_TenKhach.Location = new System.Drawing.Point(163, 104);
            this.tb_TenKhach.Name = "tb_TenKhach";
            this.tb_TenKhach.Size = new System.Drawing.Size(245, 20);
            this.tb_TenKhach.TabIndex = 8;
            // 
            // clb_Ghe
            // 
            this.clb_Ghe.FormattingEnabled = true;
            this.clb_Ghe.Location = new System.Drawing.Point(10, 211);
            this.clb_Ghe.MultiColumn = true;
            this.clb_Ghe.Name = "clb_Ghe";
            this.clb_Ghe.Size = new System.Drawing.Size(268, 94);
            this.clb_Ghe.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_KQ);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(315, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 144);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // tb_KQ
            // 
            this.tb_KQ.BackColor = System.Drawing.SystemColors.Control;
            this.tb_KQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_KQ.Location = new System.Drawing.Point(5, 24);
            this.tb_KQ.Multiline = true;
            this.tb_KQ.Name = "tb_KQ";
            this.tb_KQ.Size = new System.Drawing.Size(329, 114);
            this.tb_KQ.TabIndex = 11;
            // 
            // Dat_Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clb_Ghe);
            this.Controls.Add(this.tb_TenKhach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_DatVe);
            this.Controls.Add(this.cb_Phong);
            this.Controls.Add(this.cb_Phim);
            this.Name = "Dat_Ve";
            this.Text = "Quản Lý Phòng Vé";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TenKhach;
        private System.Windows.Forms.Button btn_DatVe;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.CheckedListBox clb_Ghe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_KQ;
        private System.Windows.Forms.ComboBox cb_Phim;
        private System.Windows.Forms.ComboBox cb_Phong;
    }
}