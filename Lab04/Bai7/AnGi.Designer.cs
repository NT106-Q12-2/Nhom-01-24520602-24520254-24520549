namespace Bai7
{
    partial class frm_AnGi
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
            this.p_MonAn = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // p_MonAn
            // 
            this.p_MonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_MonAn.Location = new System.Drawing.Point(0, 0);
            this.p_MonAn.Name = "p_MonAn";
            this.p_MonAn.Size = new System.Drawing.Size(761, 184);
            this.p_MonAn.TabIndex = 0;
            // 
            // frm_AnGi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 184);
            this.Controls.Add(this.p_MonAn);
            this.Name = "frm_AnGi";
            this.Text = "Ăn [món ăn] đi!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_MonAn;
    }
}