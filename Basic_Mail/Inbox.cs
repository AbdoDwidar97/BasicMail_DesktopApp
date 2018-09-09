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
    public partial class Inbox : Form
    {
        SqlConnection Conn = new SqlConnection(Settings.Con_String());
        SqlCommand Comm = new SqlCommand();
        int Msg_ID;
        public Inbox()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void Inbox_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            DGV.DataSource = Dt;

            Comm.Parameters.Clear();
            Conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Show_All_Msgs";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);

            SqlDataAdapter da = new SqlDataAdapter(Comm);
            DataSet ds = new DataSet();
            DataTable Dt = new DataTable();
            da.Fill(ds);
            Dt = ds.Tables[0];
            DGV.DataSource = Dt;

            Comm.Parameters.Clear();
            Conn.Close();

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGV.Rows[e.RowIndex];

            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_ReadMsgs";
            Conn.Open();
            Comm.Parameters.AddWithValue("@Msg_ID", row.Cells["Msg_ID"].Value.ToString());
            Msg_ID = Convert.ToInt32(row.Cells["Msg_ID"].Value.ToString());
            Comm.ExecuteNonQuery();

            ComposeForm cfrm = new ComposeForm();

            
            cfrm.Txt_Title.Text = row.Cells["Title"].Value.ToString();
            cfrm.Txt_Msg.Text = row.Cells["Msg"].Value.ToString();

            cfrm.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Archive_Msg";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);
            Comm.Parameters.AddWithValue("@Msg_ID", Msg_ID);
            Comm.Parameters.AddWithValue("@Arc_Date",DTP.Value);
            int es = Comm.ExecuteNonQuery();
            if (es > 0)
            {
                MessageBox.Show("Done Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Comm.Parameters.Clear();
            Conn.Close();

        }
    }
}
