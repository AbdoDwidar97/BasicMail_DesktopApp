using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Basic_Mail
{
    public partial class Form1 : Form
    {
        
        SqlConnection Conn = new SqlConnection(Settings.Con_String());
        SqlCommand Comm = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_UserName.Focus();
            
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Login";
            Conn.Open();
            Comm.Parameters.AddWithValue("@UserName",Txt_UserName.Text);
            Comm.Parameters.AddWithValue("@Pwd",Txt_Pwd.Text);
            SqlDataReader Dr = Comm.ExecuteReader();
            Dr.Read();
            if (Dr.HasRows)
            {
                Settings.User_ID = Convert.ToInt32(Dr["User_ID"].ToString());
                Home Hfrm = new Home();
                Hfrm.Lbl_Name.Text = Dr["User_FirstName"].ToString() + " " + Dr["User_LastName"].ToString();
                Hfrm.Lbl_UN.Text = Dr["UserName"].ToString();
                Hfrm.Txt_Status.Text = Dr["Disc"].ToString();

                Hfrm.Lbl_Mail.Text = Dr["Email"].ToString();
                Hfrm.Lbl_Adrs.Text = Dr["Address"].ToString();
                Hfrm.Lbl_Phone.Text = Dr["Phone"].ToString();

                try
                {
                    byte[] imgs = (byte[])(Dr["Pic"]);
                    MemoryStream ms = new MemoryStream(imgs);
                    Hfrm.Pr_Pic.Image = Image.FromStream(ms);

                }
                catch { }
                
                Hfrm.Show();
                this.Hide();
            }
            else { MessageBox.Show("Invalid user name or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);}
            Comm.Parameters.Clear();
            Conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp Sufrm = new SignUp();
            Sufrm.ShowDialog();
        }
    }
}
