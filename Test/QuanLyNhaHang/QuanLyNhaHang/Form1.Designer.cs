namespace QuanLyNhaHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Connect = new Button();
            lbl_Status = new Label();
            dgv_Menu = new DataGridView();
            lbl_Table = new Label();
            lbl_Gia = new Label();
            btn_Order = new Button();
            btn_Quit = new Button();
            tb_Table = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Menu).BeginInit();
            SuspendLayout();
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(47, 49);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(129, 49);
            btn_Connect.TabIndex = 0;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Location = new Point(330, 61);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(59, 25);
            lbl_Status.TabIndex = 1;
            lbl_Status.Text = "status";
            // 
            // dgv_Menu
            // 
            dgv_Menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Menu.Location = new Point(47, 104);
            dgv_Menu.Name = "dgv_Menu";
            dgv_Menu.RowHeadersWidth = 62;
            dgv_Menu.Size = new Size(553, 261);
            dgv_Menu.TabIndex = 2;
            // 
            // lbl_Table
            // 
            lbl_Table.AutoSize = true;
            lbl_Table.Location = new Point(60, 420);
            lbl_Table.Name = "lbl_Table";
            lbl_Table.Size = new Size(52, 25);
            lbl_Table.TabIndex = 3;
            lbl_Table.Text = "Table";
            // 
            // lbl_Gia
            // 
            lbl_Gia.AutoSize = true;
            lbl_Gia.Location = new Point(60, 484);
            lbl_Gia.Name = "lbl_Gia";
            lbl_Gia.Size = new Size(36, 25);
            lbl_Gia.TabIndex = 4;
            lbl_Gia.Text = "OK";
            // 
            // btn_Order
            // 
            btn_Order.Location = new Point(321, 411);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(130, 34);
            btn_Order.TabIndex = 5;
            btn_Order.Text = "Order";
            btn_Order.UseVisualStyleBackColor = true;
            // 
            // btn_Quit
            // 
            btn_Quit.Location = new Point(470, 410);
            btn_Quit.Name = "btn_Quit";
            btn_Quit.Size = new Size(130, 34);
            btn_Quit.TabIndex = 6;
            btn_Quit.Text = "Quit";
            btn_Quit.UseVisualStyleBackColor = true;
            // 
            // tb_Table
            // 
            tb_Table.Location = new Point(143, 413);
            tb_Table.Name = "tb_Table";
            tb_Table.Size = new Size(150, 31);
            tb_Table.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 559);
            Controls.Add(tb_Table);
            Controls.Add(btn_Quit);
            Controls.Add(btn_Order);
            Controls.Add(lbl_Gia);
            Controls.Add(lbl_Table);
            Controls.Add(dgv_Menu);
            Controls.Add(lbl_Status);
            Controls.Add(btn_Connect);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Connect;
        private Label lbl_Status;
        private DataGridView dgv_Menu;
        private Label lbl_Table;
        private Label lbl_Gia;
        private Button btn_Order;
        private Button btn_Quit;
        private TextBox tb_Table;
    }
}
