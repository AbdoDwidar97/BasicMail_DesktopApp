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
    public partial class Searched_UserProfile : Form
    {
        SqlConnection Conn = new SqlConnection(Settings.Con_String());
        SqlCommand Comm = new SqlCommand();
        public Searched_UserProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Searched_UserProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Contact_Click(object sender, EventArgs e)
        {
            ComposeForm cfrm = new ComposeForm();
            cfrm.username = Lbl_UN.Text;
            cfrm.ShowDialog();
        }

        private void Btn_Block_Click(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Block";
            Conn.Open();
            Comm.Parameters.AddWithValue("@Blocker_ID", Settings.User_ID);
            Comm.Parameters.AddWithValue("@Blocked_UserName", Lbl_UN.Text);

            Comm.ExecuteNonQuery();

            Comm.Parameters.Clear();
            Conn.Close();
            this.Close();
        }

        private void Btn_AddList_Click(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Add_FriendList";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);
            Comm.Parameters.AddWithValue("@Friend_UserName", Lbl_UN.Text);

            Comm.ExecuteNonQuery();

            Comm.Parameters.Clear();
            Conn.Close();
            this.Close();
        }
    }
}
