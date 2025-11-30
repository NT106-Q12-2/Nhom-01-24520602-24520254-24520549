namespace Bai5
{
    partial class Send_Mail
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
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_EmailSender = new System.Windows.Forms.TextBox();
            this.lbl_Sender = new System.Windows.Forms.Label();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tenmonan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_quyenhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(143, 129);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(565, 22);
            this.tb_Subject.TabIndex = 28;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(579, 306);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(129, 45);
            this.btn_Send.TabIndex = 23;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(31, 135);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(52, 16);
            this.lbl_Subject.TabIndex = 18;
            this.lbl_Subject.Text = "Subject";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(143, 85);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(565, 22);
            this.tb_Name.TabIndex = 26;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(31, 88);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 16);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Name";
            // 
            // tb_EmailSender
            // 
            this.tb_EmailSender.Location = new System.Drawing.Point(143, 40);
            this.tb_EmailSender.Name = "tb_EmailSender";
            this.tb_EmailSender.Size = new System.Drawing.Size(565, 22);
            this.tb_EmailSender.TabIndex = 25;
            // 
            // lbl_Sender
            // 
            this.lbl_Sender.AutoSize = true;
            this.lbl_Sender.Location = new System.Drawing.Point(31, 43);
            this.lbl_Sender.Name = "lbl_Sender";
            this.lbl_Sender.Size = new System.Drawing.Size(38, 16);
            this.lbl_Sender.TabIndex = 15;
            this.lbl_Sender.Text = "From";
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(143, 221);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(565, 22);
            this.tb_link.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Link hình ảnh";
            // 
            // tb_tenmonan
            // 
            this.tb_tenmonan.Location = new System.Drawing.Point(143, 174);
            this.tb_tenmonan.Name = "tb_tenmonan";
            this.tb_tenmonan.Size = new System.Drawing.Size(565, 22);
            this.tb_tenmonan.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên món ăn";
            // 
            // tb_quyenhan
            // 
            this.tb_quyenhan.Location = new System.Drawing.Point(143, 267);
            this.tb_quyenhan.Name = "tb_quyenhan";
            this.tb_quyenhan.Size = new System.Drawing.Size(565, 22);
            this.tb_quyenhan.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Quyền hạn";
            // 
            // Send_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 360);
            this.Controls.Add(this.tb_quyenhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tenmonan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_EmailSender);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Sender);
            this.Name = "Send_Mail";
            this.Text = "Send_Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_EmailSender;
        private System.Windows.Forms.Label lbl_Sender;
        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tenmonan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_quyenhan;
        private System.Windows.Forms.Label label3;
    }
}