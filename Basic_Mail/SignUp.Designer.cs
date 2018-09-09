namespace Basic_Mail
{
    partial class SignUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_FirstName = new System.Windows.Forms.TextBox();
            this.Txt_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Rd_Male = new System.Windows.Forms.RadioButton();
            this.Rd_Female = new System.Windows.Forms.RadioButton();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Pwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_RePwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pr_pic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pr_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Browse);
            this.groupBox1.Controls.Add(this.Pr_pic);
            this.groupBox1.Controls.Add(this.Txt_RePwd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Txt_Pwd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txt_Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Rd_Female);
            this.groupBox1.Controls.Add(this.Rd_Male);
            this.groupBox1.Controls.Add(this.Txt_Address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_Phone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_UserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_LastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_FirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // Txt_FirstName
            // 
            this.Txt_FirstName.Location = new System.Drawing.Point(17, 56);
            this.Txt_FirstName.Name = "Txt_FirstName";
            this.Txt_FirstName.Size = new System.Drawing.Size(202, 21);
            this.Txt_FirstName.TabIndex = 1;
            this.Txt_FirstName.TextChanged += new System.EventHandler(this.Txt_FirstName_TextChanged);
            // 
            // Txt_LastName
            // 
            this.Txt_LastName.Location = new System.Drawing.Point(322, 56);
            this.Txt_LastName.Name = "Txt_LastName";
            this.Txt_LastName.Size = new System.Drawing.Size(202, 21);
            this.Txt_LastName.TabIndex = 3;
            this.Txt_LastName.TextChanged += new System.EventHandler(this.Txt_LastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(319, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name:";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(17, 116);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(202, 21);
            this.Txt_UserName.TabIndex = 5;
            this.Txt_UserName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(322, 116);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(202, 21);
            this.Txt_Phone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(319, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(17, 181);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(202, 21);
            this.Txt_Address.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(14, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address:";
            // 
            // Rd_Male
            // 
            this.Rd_Male.AutoSize = true;
            this.Rd_Male.ForeColor = System.Drawing.Color.DarkGreen;
            this.Rd_Male.Location = new System.Drawing.Point(322, 182);
            this.Rd_Male.Name = "Rd_Male";
            this.Rd_Male.Size = new System.Drawing.Size(52, 17);
            this.Rd_Male.TabIndex = 10;
            this.Rd_Male.TabStop = true;
            this.Rd_Male.Text = "Male";
            this.Rd_Male.UseVisualStyleBackColor = true;
            // 
            // Rd_Female
            // 
            this.Rd_Female.AutoSize = true;
            this.Rd_Female.ForeColor = System.Drawing.Color.DarkGreen;
            this.Rd_Female.Location = new System.Drawing.Point(458, 182);
            this.Rd_Female.Name = "Rd_Female";
            this.Rd_Female.Size = new System.Drawing.Size(66, 17);
            this.Rd_Female.TabIndex = 11;
            this.Rd_Female.TabStop = true;
            this.Rd_Female.Text = "Female";
            this.Rd_Female.UseVisualStyleBackColor = true;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(17, 247);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(507, 21);
            this.Txt_Email.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(14, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // Txt_Pwd
            // 
            this.Txt_Pwd.Location = new System.Drawing.Point(17, 314);
            this.Txt_Pwd.Name = "Txt_Pwd";
            this.Txt_Pwd.PasswordChar = '•';
            this.Txt_Pwd.Size = new System.Drawing.Size(202, 21);
            this.Txt_Pwd.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(14, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password:";
            // 
            // Txt_RePwd
            // 
            this.Txt_RePwd.Location = new System.Drawing.Point(322, 314);
            this.Txt_RePwd.Name = "Txt_RePwd";
            this.Txt_RePwd.PasswordChar = '•';
            this.Txt_RePwd.Size = new System.Drawing.Size(202, 21);
            this.Txt_RePwd.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(319, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Confirm password:";
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.Location = new System.Drawing.Point(690, 252);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(71, 24);
            this.Btn_Browse.TabIndex = 19;
            this.Btn_Browse.Text = "Browse";
            this.Btn_Browse.UseVisualStyleBackColor = true;
            this.Btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(563, 449);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(222, 43);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Create Account";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basic_Mail.Properties.Resources.Logo_VR;
            this.pictureBox1.Location = new System.Drawing.Point(-22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pr_pic
            // 
            this.Pr_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pr_pic.Location = new System.Drawing.Point(584, 50);
            this.Pr_pic.Name = "Pr_pic";
            this.Pr_pic.Size = new System.Drawing.Size(178, 194);
            this.Pr_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pr_pic.TabIndex = 18;
            this.Pr_pic.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pr_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_FirstName;
        private System.Windows.Forms.TextBox Txt_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Rd_Female;
        private System.Windows.Forms.RadioButton Rd_Male;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_RePwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Pwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Pr_pic;
        private System.Windows.Forms.Button Btn_Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}