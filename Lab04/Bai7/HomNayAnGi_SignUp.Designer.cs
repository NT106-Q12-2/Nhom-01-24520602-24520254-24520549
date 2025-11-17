namespace Bai7
{
    partial class frm_HomNayAnGi_SignUp
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gb_SignUp = new System.Windows.Forms.GroupBox();
            this.gb_UserInformation = new System.Windows.Forms.GroupBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_BirthDay = new System.Windows.Forms.Label();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.rtbn_Female = new System.Windows.Forms.RadioButton();
            this.cbb_Language = new System.Windows.Forms.ComboBox();
            this.dtp_Birthday = new System.Windows.Forms.DateTimePicker();
            this.gb_SignUp.SuspendLayout();
            this.gb_UserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(528, 81);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "HÔM NAY ĂN GÌ?";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_SignUp
            // 
            this.gb_SignUp.Controls.Add(this.tb_Password);
            this.gb_SignUp.Controls.Add(this.tb_Username);
            this.gb_SignUp.Controls.Add(this.lbl_Password);
            this.gb_SignUp.Controls.Add(this.lbl_Username);
            this.gb_SignUp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SignUp.Location = new System.Drawing.Point(55, 100);
            this.gb_SignUp.Name = "gb_SignUp";
            this.gb_SignUp.Size = new System.Drawing.Size(424, 149);
            this.gb_SignUp.TabIndex = 1;
            this.gb_SignUp.TabStop = false;
            this.gb_SignUp.Text = "Sign up";
            // 
            // gb_UserInformation
            // 
            this.gb_UserInformation.Controls.Add(this.dtp_Birthday);
            this.gb_UserInformation.Controls.Add(this.cbb_Language);
            this.gb_UserInformation.Controls.Add(this.rtbn_Female);
            this.gb_UserInformation.Controls.Add(this.rbtn_Male);
            this.gb_UserInformation.Controls.Add(this.tb_Phone);
            this.gb_UserInformation.Controls.Add(this.tb_LastName);
            this.gb_UserInformation.Controls.Add(this.tb_FirstName);
            this.gb_UserInformation.Controls.Add(this.tb_Email);
            this.gb_UserInformation.Controls.Add(this.lbl_Sex);
            this.gb_UserInformation.Controls.Add(this.lbl_Language);
            this.gb_UserInformation.Controls.Add(this.lbl_BirthDay);
            this.gb_UserInformation.Controls.Add(this.lbl_Phone);
            this.gb_UserInformation.Controls.Add(this.lbl_LastName);
            this.gb_UserInformation.Controls.Add(this.lbl_FirstName);
            this.gb_UserInformation.Controls.Add(this.lbl_Email);
            this.gb_UserInformation.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_UserInformation.Location = new System.Drawing.Point(55, 282);
            this.gb_UserInformation.Name = "gb_UserInformation";
            this.gb_UserInformation.Size = new System.Drawing.Size(424, 362);
            this.gb_UserInformation.TabIndex = 2;
            this.gb_UserInformation.TabStop = false;
            this.gb_UserInformation.Text = "User Information";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(29, 52);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(88, 22);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(29, 93);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(88, 22);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(136, 49);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(246, 30);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(136, 90);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(246, 30);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(33, 47);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(57, 22);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(33, 90);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(93, 22);
            this.lbl_FirstName.TabIndex = 1;
            this.lbl_FirstName.Text = "First name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(33, 133);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(89, 22);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "Last name";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(33, 176);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(58, 22);
            this.lbl_Phone.TabIndex = 3;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_BirthDay
            // 
            this.lbl_BirthDay.AutoSize = true;
            this.lbl_BirthDay.Location = new System.Drawing.Point(33, 219);
            this.lbl_BirthDay.Name = "lbl_BirthDay";
            this.lbl_BirthDay.Size = new System.Drawing.Size(78, 22);
            this.lbl_BirthDay.TabIndex = 4;
            this.lbl_BirthDay.Text = "Birthday";
            // 
            // lbl_Language
            // 
            this.lbl_Language.AutoSize = true;
            this.lbl_Language.Location = new System.Drawing.Point(33, 262);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(84, 22);
            this.lbl_Language.TabIndex = 5;
            this.lbl_Language.Text = "Language";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Location = new System.Drawing.Point(33, 305);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(39, 22);
            this.lbl_Sex.TabIndex = 6;
            this.lbl_Sex.Text = "Sex";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(136, 44);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(246, 30);
            this.tb_Email.TabIndex = 7;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(136, 87);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(246, 30);
            this.tb_FirstName.TabIndex = 8;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(136, 125);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(246, 30);
            this.tb_LastName.TabIndex = 9;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(136, 168);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(246, 30);
            this.tb_Phone.TabIndex = 10;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Location = new System.Drawing.Point(136, 301);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(76, 26);
            this.rbtn_Male.TabIndex = 11;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // rtbn_Female
            // 
            this.rtbn_Female.AutoSize = true;
            this.rtbn_Female.Location = new System.Drawing.Point(231, 301);
            this.rtbn_Female.Name = "rtbn_Female";
            this.rtbn_Female.Size = new System.Drawing.Size(93, 26);
            this.rtbn_Female.TabIndex = 12;
            this.rtbn_Female.TabStop = true;
            this.rtbn_Female.Text = "Female";
            this.rtbn_Female.UseVisualStyleBackColor = true;
            // 
            // cbb_Language
            // 
            this.cbb_Language.FormattingEnabled = true;
            this.cbb_Language.Location = new System.Drawing.Point(136, 254);
            this.cbb_Language.Name = "cbb_Language";
            this.cbb_Language.Size = new System.Drawing.Size(246, 30);
            this.cbb_Language.TabIndex = 13;
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.Location = new System.Drawing.Point(136, 211);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.Size = new System.Drawing.Size(246, 30);
            this.dtp_Birthday.TabIndex = 14;
            // 
            // frm_HomNayAnGi_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(528, 684);
            this.Controls.Add(this.gb_UserInformation);
            this.Controls.Add(this.gb_SignUp);
            this.Controls.Add(this.lbl_Title);
            this.Name = "frm_HomNayAnGi_SignUp";
            this.Text = "Hôm nay ăn gì? -Sign Up";
            this.gb_SignUp.ResumeLayout(false);
            this.gb_SignUp.PerformLayout();
            this.gb_UserInformation.ResumeLayout(false);
            this.gb_UserInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox gb_SignUp;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.GroupBox gb_UserInformation;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.Label lbl_BirthDay;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.DateTimePicker dtp_Birthday;
        private System.Windows.Forms.ComboBox cbb_Language;
        private System.Windows.Forms.RadioButton rtbn_Female;
        private System.Windows.Forms.RadioButton rbtn_Male;
    }
}