namespace Basic_Mail
{
    partial class Inbox
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Btn_ShowAll = new System.Windows.Forms.Button();
            this.Btn_ShowUnRead = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(0, -1);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(773, 384);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            // 
            // Btn_ShowAll
            // 
            this.Btn_ShowAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShowAll.Location = new System.Drawing.Point(10, 399);
            this.Btn_ShowAll.Name = "Btn_ShowAll";
            this.Btn_ShowAll.Size = new System.Drawing.Size(144, 38);
            this.Btn_ShowAll.TabIndex = 1;
            this.Btn_ShowAll.Text = "Show All Messages";
            this.Btn_ShowAll.UseVisualStyleBackColor = true;
            this.Btn_ShowAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_ShowUnRead
            // 
            this.Btn_ShowUnRead.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShowUnRead.Location = new System.Drawing.Point(160, 399);
            this.Btn_ShowUnRead.Name = "Btn_ShowUnRead";
            this.Btn_ShowUnRead.Size = new System.Drawing.Size(165, 38);
            this.Btn_ShowUnRead.TabIndex = 2;
            this.Btn_ShowUnRead.Text = "Show unreaed Messages";
            this.Btn_ShowUnRead.UseVisualStyleBackColor = true;
            this.Btn_ShowUnRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(618, 399);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(144, 38);
            this.Btn_Back.TabIndex = 3;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Archieve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DTP
            // 
            this.DTP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(502, 407);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(105, 21);
            this.DTP.TabIndex = 5;
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 469);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_ShowUnRead);
            this.Controls.Add(this.Btn_ShowAll);
            this.Controls.Add(this.DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Inbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inbox";
            this.Load += new System.EventHandler(this.Inbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button Btn_ShowAll;
        private System.Windows.Forms.Button Btn_ShowUnRead;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DTP;
    }
}