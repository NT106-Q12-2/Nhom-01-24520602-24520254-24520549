using System.Drawing;
using System.Windows.Forms;

namespace Bai5
{
    partial class Hom_Nay_An_Gi
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
            this.lv_dsmonan = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themmon = new System.Windows.Forms.Button();
            this.btn_chonmon = new System.Windows.Forms.Button();
            this.ptb_ketquamonan = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ketquamonan)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_dsmonan
            // 
            this.lv_dsmonan.HideSelection = false;
            this.lv_dsmonan.Location = new System.Drawing.Point(14, 54);
            this.lv_dsmonan.Name = "lv_dsmonan";
            this.lv_dsmonan.Size = new System.Drawing.Size(301, 375);
            this.lv_dsmonan.TabIndex = 0;
            this.lv_dsmonan.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hôm Nay Ăn Gì?";
            // 
            // btn_themmon
            // 
            this.btn_themmon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmon.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_themmon.Location = new System.Drawing.Point(321, 57);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.Size = new System.Drawing.Size(249, 139);
            this.btn_themmon.TabIndex = 8;
            this.btn_themmon.Text = "Thêm món ăn";
            this.btn_themmon.UseVisualStyleBackColor = true;
            this.btn_themmon.Click += new System.EventHandler(this.btn_themmon_Click);
            // 
            // btn_chonmon
            // 
            this.btn_chonmon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonmon.ForeColor = System.Drawing.Color.Red;
            this.btn_chonmon.Location = new System.Drawing.Point(321, 290);
            this.btn_chonmon.Name = "btn_chonmon";
            this.btn_chonmon.Size = new System.Drawing.Size(249, 139);
            this.btn_chonmon.TabIndex = 10;
            this.btn_chonmon.Text = "Chọn món ăn";
            this.btn_chonmon.UseVisualStyleBackColor = true;
            this.btn_chonmon.Click += new System.EventHandler(this.btn_chonmon_Click);
            // 
            // ptb_ketquamonan
            // 
            this.ptb_ketquamonan.BackColor = System.Drawing.Color.White;
            this.ptb_ketquamonan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_ketquamonan.Location = new System.Drawing.Point(576, 57);
            this.ptb_ketquamonan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_ketquamonan.Name = "ptb_ketquamonan";
            this.ptb_ketquamonan.Size = new System.Drawing.Size(323, 369);
            this.ptb_ketquamonan.TabIndex = 13;
            this.ptb_ketquamonan.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách món ăn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hình ảnh món ăn";
            // 
            // Hom_Nay_An_Gi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(914, 438);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ptb_ketquamonan);
            this.Controls.Add(this.btn_chonmon);
            this.Controls.Add(this.btn_themmon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_dsmonan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Hom_Nay_An_Gi";
            this.Text = "Hôm Nay Ăn Gì";
            this.Load += new System.EventHandler(this.Hom_Nay_An_Gi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ketquamonan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView lv_dsmonan;
        private Label label1;
        private Button btn_themmon;
        private Button btn_chonmon;
        private PictureBox ptb_ketquamonan;
        private Label label6;
        private Label label7;
    }
}

