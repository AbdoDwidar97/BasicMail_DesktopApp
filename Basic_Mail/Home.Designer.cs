namespace Basic_Mail
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_UN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Status = new System.Windows.Forms.TextBox();
            this.Pr_Pic = new System.Windows.Forms.PictureBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_UpdatePic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Cmb_Search = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Adrs = new System.Windows.Forms.Label();
            this.Lbl_Phone = new System.Windows.Forms.Label();
            this.Lbl_Mail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Friend_List = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pr_Pic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Image = global::Basic_Mail.Properties.Resources.BackColor_VR;
            this.Lbl_Name.Location = new System.Drawing.Point(222, 64);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(166, 33);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Your Name";
            // 
            // Lbl_UN
            // 
            this.Lbl_UN.AutoSize = true;
            this.Lbl_UN.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UN.Image = global::Basic_Mail.Properties.Resources.BackColor_VR;
            this.Lbl_UN.Location = new System.Drawing.Point(224, 107);
            this.Lbl_UN.Name = "Lbl_UN";
            this.Lbl_UN.Size = new System.Drawing.Size(126, 18);
            this.Lbl_UN.TabIndex = 1;
            this.Lbl_UN.Text = "Your UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // Txt_Status
            // 
            this.Txt_Status.BackColor = System.Drawing.Color.White;
            this.Txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Status.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Status.Location = new System.Drawing.Point(43, 271);
            this.Txt_Status.Multiline = true;
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.ReadOnly = true;
            this.Txt_Status.Size = new System.Drawing.Size(197, 96);
            this.Txt_Status.TabIndex = 4;
            // 
            // Pr_Pic
            // 
            this.Pr_Pic.Image = global::Basic_Mail.Properties.Resources.User_green;
            this.Pr_Pic.Location = new System.Drawing.Point(29, 35);
            this.Pr_Pic.Name = "Pr_Pic";
            this.Pr_Pic.Size = new System.Drawing.Size(176, 165);
            this.Pr_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pr_Pic.TabIndex = 5;
            this.Pr_Pic.TabStop = false;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.Location = new System.Drawing.Point(102, 239);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(54, 26);
            this.Btn_Edit.TabIndex = 6;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_UpdatePic
            // 
            this.Btn_UpdatePic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdatePic.Location = new System.Drawing.Point(211, 174);
            this.Btn_UpdatePic.Name = "Btn_UpdatePic";
            this.Btn_UpdatePic.Size = new System.Drawing.Size(54, 26);
            this.Btn_UpdatePic.TabIndex = 7;
            this.Btn_UpdatePic.Text = "Upload";
            this.Btn_UpdatePic.UseVisualStyleBackColor = true;
            this.Btn_UpdatePic.Click += new System.EventHandler(this.Btn_UpdatePic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Cmb_Search
            // 
            this.Cmb_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Search.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Search.FormattingEnabled = true;
            this.Cmb_Search.Location = new System.Drawing.Point(499, 24);
            this.Cmb_Search.Name = "Cmb_Search";
            this.Cmb_Search.Size = new System.Drawing.Size(235, 22);
            this.Cmb_Search.TabIndex = 8;
            this.Cmb_Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cmb_Search_MouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Basic_Mail.Properties.Resources.Search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(740, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 22);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messagesToolStripMenuItem,
            this.blockListToolStripMenuItem,
            this.myInfoToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.messagesToolStripMenuItem.Text = "Messages";
            this.messagesToolStripMenuItem.Click += new System.EventHandler(this.messagesToolStripMenuItem_Click);
            // 
            // blockListToolStripMenuItem
            // 
            this.blockListToolStripMenuItem.Name = "blockListToolStripMenuItem";
            this.blockListToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.blockListToolStripMenuItem.Text = "Block List";
            // 
            // myInfoToolStripMenuItem
            // 
            this.myInfoToolStripMenuItem.Name = "myInfoToolStripMenuItem";
            this.myInfoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.myInfoToolStripMenuItem.Text = "My info";
            this.myInfoToolStripMenuItem.Click += new System.EventHandler(this.myInfoToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Lbl_Adrs
            // 
            this.Lbl_Adrs.AutoSize = true;
            this.Lbl_Adrs.BackColor = System.Drawing.Color.White;
            this.Lbl_Adrs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Adrs.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_Adrs.Location = new System.Drawing.Point(114, 469);
            this.Lbl_Adrs.Name = "Lbl_Adrs";
            this.Lbl_Adrs.Size = new System.Drawing.Size(42, 14);
            this.Lbl_Adrs.TabIndex = 29;
            this.Lbl_Adrs.Text = "Email:";
            this.Lbl_Adrs.Click += new System.EventHandler(this.Lbl_Adrs_Click);
            // 
            // Lbl_Phone
            // 
            this.Lbl_Phone.AutoSize = true;
            this.Lbl_Phone.BackColor = System.Drawing.Color.White;
            this.Lbl_Phone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Phone.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_Phone.Location = new System.Drawing.Point(114, 443);
            this.Lbl_Phone.Name = "Lbl_Phone";
            this.Lbl_Phone.Size = new System.Drawing.Size(42, 14);
            this.Lbl_Phone.TabIndex = 28;
            this.Lbl_Phone.Text = "Email:";
            this.Lbl_Phone.Click += new System.EventHandler(this.Lbl_Phone_Click);
            // 
            // Lbl_Mail
            // 
            this.Lbl_Mail.AutoSize = true;
            this.Lbl_Mail.BackColor = System.Drawing.Color.White;
            this.Lbl_Mail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mail.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_Mail.Location = new System.Drawing.Point(114, 415);
            this.Lbl_Mail.Name = "Lbl_Mail";
            this.Lbl_Mail.Size = new System.Drawing.Size(42, 14);
            this.Lbl_Mail.TabIndex = 27;
            this.Lbl_Mail.Text = "Email:";
            this.Lbl_Mail.Click += new System.EventHandler(this.Lbl_Mail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 26;
            this.label5.Text = "Address:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Phone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "About";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Friend_List
            // 
            this.Friend_List.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Friend_List.FormattingEnabled = true;
            this.Friend_List.ItemHeight = 14;
            this.Friend_List.Location = new System.Drawing.Point(632, 198);
            this.Friend_List.Name = "Friend_List";
            this.Friend_List.Size = new System.Drawing.Size(167, 354);
            this.Friend_List.TabIndex = 30;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Basic_Mail.Properties.Resources.Home_Form_VR;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.Friend_List);
            this.Controls.Add(this.Lbl_Adrs);
            this.Controls.Add(this.Lbl_Phone);
            this.Controls.Add(this.Lbl_Mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cmb_Search);
            this.Controls.Add(this.Btn_UpdatePic);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Pr_Pic);
            this.Controls.Add(this.Txt_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_UN);
            this.Controls.Add(this.Lbl_Name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Mail (Home)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pr_Pic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Lbl_Name;
        public System.Windows.Forms.Label Lbl_UN;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Txt_Status;
        public System.Windows.Forms.PictureBox Pr_Pic;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_UpdatePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox Cmb_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Label Lbl_Adrs;
        public System.Windows.Forms.Label Lbl_Phone;
        public System.Windows.Forms.Label Lbl_Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem blockListToolStripMenuItem;
        private System.Windows.Forms.ListBox Friend_List;
    }
}