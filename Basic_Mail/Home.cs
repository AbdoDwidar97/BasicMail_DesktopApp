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
    public partial class Home : Form
    {
        SqlConnection Conn = new SqlConnection(Settings.Con_String());
        SqlCommand Comm = new SqlCommand();
        public Home()
        {
            InitializeComponent();
        }

        private void Btn_UpdatePic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            byte[] pic = System.IO.File.ReadAllBytes(openFileDialog1.FileName);

            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Change_Pic";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);
            Comm.Parameters.AddWithValue("@Pic", pic);
            Comm.ExecuteNonQuery();

            Pr_Pic.ImageLocation = openFileDialog1.FileName;
            Comm.Parameters.Clear();
            Conn.Close();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            ProfileData pdfrm = new ProfileData();
            pdfrm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_GetAllUsers";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);

            SqlDataAdapter da = new SqlDataAdapter(Comm);
            DataSet ds = new DataSet();
            DataTable Dt = new DataTable();
            da.Fill(ds);
            Dt = ds.Tables[0];
            Cmb_Search.Items.Clear();
            Cmb_Search.DataSource = Dt;
            Cmb_Search.DisplayMember = "UserName";
            Cmb_Search.ValueMember = "User_ID";
            Cmb_Search.Text = "";
            Comm.Parameters.Clear();
            Conn.Close();

            //-------------------------------------------------------------------


            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Get_AllFriends";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);

            da = new SqlDataAdapter(Comm);
            ds = new DataSet();
            Dt = new DataTable();
            da.Fill(ds);
            Dt = ds.Tables[0];
            Friend_List.Items.Clear();
            Friend_List.DataSource = Dt;
            Friend_List.DisplayMember = "UserName";
            Friend_List.ValueMember = "User_ID";
            Comm.Parameters.Clear();
            Conn.Close();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Are you sure for exit ?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { e.Cancel = true; }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Are you sure for logging out ?", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dr == DialogResult.Yes)
            {
                this.Dispose();
                Form1 frmlogin = new Form1();
                frmlogin.Show();
                Settings.User_ID = -1;
            }
            
        }

        private void myInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileData pdfrm = new ProfileData();
            pdfrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Get_UserData";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Cmb_Search.SelectedValue);

            if (Cmb_Search.SelectedValue == null) { Conn.Close();  return; }

            SqlDataReader dr = Comm.ExecuteReader();
            dr.Read();
            Searched_UserProfile frm = new Searched_UserProfile();
            frm.Lbl_Name.Text = dr["User_FirstName"].ToString() + " " + dr["User_LastName"].ToString();
            frm.Lbl_UN.Text = dr["UserName"].ToString();
            frm.Txt_Status.Text = dr["Disc"].ToString();
            frm.Lbl_Mail.Text = dr["Email"].ToString();
            frm.Lbl_Adrs.Text = dr["Address"].ToString();
            frm.Lbl_Phone.Text = dr["Phone"].ToString();


            try
            {
                byte[] imgs = (byte[])(dr["Pic"]);
                MemoryStream ms = new MemoryStream(imgs);
                frm.Pr_Pic.Image = Image.FromStream(ms);

            }
            catch { }

            Comm.Parameters.Clear();
            Conn.Close();
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Phone_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Mail_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Adrs_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inbox ifrm = new Inbox();

            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_ShowUnReadMsgs";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);

            SqlDataAdapter da = new SqlDataAdapter(Comm);
            DataSet ds = new DataSet();
            DataTable Dt = new DataTable();
            da.Fill(ds);
            Dt = ds.Tables[0];
            ifrm.DGV.Rows.Clear();
            ifrm.DGV.DataSource = Dt;

            Comm.Parameters.Clear();
            Conn.Close();


            ifrm.ShowDialog();
        }

        private void Cmb_Search_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
