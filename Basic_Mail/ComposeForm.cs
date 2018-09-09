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

namespace Basic_Mail
{
    public partial class ComposeForm : Form
    {
        SqlConnection Conn = new SqlConnection(Settings.Con_String());
        SqlCommand Comm = new SqlCommand();
        public string username;
        public ComposeForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComposeForm_Load(object sender, EventArgs e)
        {
            Cmb_Search_To.SelectedText = username;

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
            Cmb_Search_To.Items.Clear();
            Cmb_Search_To.DataSource = Dt;
            Cmb_Search_To.DisplayMember = "UserName";
            Cmb_Search_To.ValueMember = "User_ID";
            Cmb_Search_To.Text = "";
            Comm.Parameters.Clear();
            Conn.Close();


        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            if (Cmb_Search_To.SelectedValue == null) { MessageBox.Show("This user may not exists or Blocked","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);return; }
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_New_Message";
            Conn.Open();
            Comm.Parameters.AddWithValue("@From_User_ID", Settings.User_ID);
            Comm.Parameters.AddWithValue("@To_User_ID",Cmb_Search_To.SelectedValue);
            Comm.Parameters.AddWithValue("@Title", Txt_Title.Text);
            Comm.Parameters.AddWithValue("@Msg", Txt_Msg.Text);
            Comm.Parameters.AddWithValue("@Msg_Date", DTP.Value);

            Comm.ExecuteNonQuery();
            MessageBox.Show("Message Sent!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Comm.Parameters.Clear();
            Conn.Close();
            this.Close();
        }
    }
}
