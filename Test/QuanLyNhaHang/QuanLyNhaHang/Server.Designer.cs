namespace QuanLyNhaHang
{
    partial class Server
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
            btn_Start = new Button();
            label1 = new Label();
            lbl_Status = new Label();
            label2 = new Label();
            tb_Table = new TextBox();
            btn_Charge = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            dgv_Menu = new DataGridView();
            rtb_Message = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Menu).BeginInit();
            SuspendLayout();
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(33, 32);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(106, 42);
            btn_Start.TabIndex = 0;
            btn_Start.Text = "Start Server";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(164, 41);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Font = new Font("Segoe UI", 12F);
            lbl_Status.Location = new Point(241, 41);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(52, 21);
            lbl_Status.TabIndex = 2;
            lbl_Status.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(664, 67);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 3;
            label2.Text = "Enter table";
            // 
            // tb_Table
            // 
            tb_Table.Location = new Point(664, 110);
            tb_Table.Name = "tb_Table";
            tb_Table.Size = new Size(100, 23);
            tb_Table.TabIndex = 4;
            // 
            // btn_Charge
            // 
            btn_Charge.Location = new Point(664, 154);
            btn_Charge.Name = "btn_Charge";
            btn_Charge.Size = new Size(106, 30);
            btn_Charge.TabIndex = 5;
            btn_Charge.Text = "Charge";
            btn_Charge.UseVisualStyleBackColor = true;
            btn_Charge.Click += btn_Charge_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(664, 216);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 6;
            label3.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(664, 258);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // dgv_Menu
            // 
            dgv_Menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Menu.Location = new Point(33, 110);
            dgv_Menu.Name = "dgv_Menu";
            dgv_Menu.Size = new Size(569, 188);
            dgv_Menu.TabIndex = 8;
            // 
            // rtb_Message
            // 
            rtb_Message.Location = new Point(33, 333);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.Size = new Size(569, 145);
            rtb_Message.TabIndex = 9;
            rtb_Message.Text = "";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(rtb_Message);
            Controls.Add(dgv_Menu);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(btn_Charge);
            Controls.Add(tb_Table);
            Controls.Add(label2);
            Controls.Add(lbl_Status);
            Controls.Add(label1);
            Controls.Add(btn_Start);
            Name = "Server";
            Text = "Server";
            ((System.ComponentModel.ISupportInitialize)dgv_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Start;
        private Label label1;
        private Label lbl_Status;
        private Label label2;
        private TextBox tb_Table;
        private Button btn_Charge;
        private Label label3;
        private TextBox textBox1;
        private DataGridView dgv_Menu;
        private RichTextBox rtb_Message;
    }
}