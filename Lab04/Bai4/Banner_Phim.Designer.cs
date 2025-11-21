namespace Bai4
{
    partial class Banner_Phim
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Ten_Phim = new System.Windows.Forms.Label();
            this.lbl_URL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Ten_Phim
            // 
            this.lbl_Ten_Phim.AutoSize = true;
            this.lbl_Ten_Phim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten_Phim.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_Ten_Phim.Location = new System.Drawing.Point(150, 3);
            this.lbl_Ten_Phim.Name = "lbl_Ten_Phim";
            this.lbl_Ten_Phim.Size = new System.Drawing.Size(122, 31);
            this.lbl_Ten_Phim.TabIndex = 1;
            this.lbl_Ten_Phim.Text = "TenPhim";
            // 
            // lbl_URL
            // 
            this.lbl_URL.AutoSize = true;
            this.lbl_URL.Location = new System.Drawing.Point(153, 52);
            this.lbl_URL.Name = "lbl_URL";
            this.lbl_URL.Size = new System.Drawing.Size(29, 13);
            this.lbl_URL.TabIndex = 2;
            this.lbl_URL.Text = "URL";
            // 
            // Banner_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_URL);
            this.Controls.Add(this.lbl_Ten_Phim);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Banner_Phim";
            this.Size = new System.Drawing.Size(488, 142);
            this.Click += new System.EventHandler(this.Banner_Phim_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Ten_Phim;
        private System.Windows.Forms.Label lbl_URL;
    }
}
