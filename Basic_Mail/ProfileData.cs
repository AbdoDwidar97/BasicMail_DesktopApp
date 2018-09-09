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
    public partial class ProfileData : Form
    {
        SqlConnection Conn = new SqlConnection(Settings.Con_String());
        SqlCommand Comm = new SqlCommand();
        public ProfileData()
        {
            InitializeComponent();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfileData_Load(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Get_UserData";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);
            SqlDataReader Dr = Comm.ExecuteReader();
            Dr.Read();

            Txt_FirstName.Text = Dr["User_FirstName"].ToString();
            Txt_LastName.Text = Dr["User_LastName"].ToString();
            Txt_Phone.Text = Dr["Phone"].ToString();
            Txt_address.Text = Dr["Address"].ToString();
            Txt_Email.Text = Dr["Email"].ToString();
            Txt_Status.Text = Dr["Disc"].ToString();
            if (Convert.ToBoolean(Dr["Acc_Status"].ToString()) == true)
            {
                Chk_Active.Checked = true;
            }
            else { Chk_Active.Checked = false; }
            Comm.Parameters.Clear();
            Conn.Close();
        }

        private void Btn_Save_profile_Click(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Update_ProfileInfo";
            Conn.Open();

            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);
            Comm.Parameters.AddWithValue("@User_FirstName", Txt_FirstName.Text);
            Comm.Parameters.AddWithValue("@User_LastName", Txt_LastName.Text);
            Comm.Parameters.AddWithValue("@Phone", Txt_Phone.Text);
            Comm.Parameters.AddWithValue("@Address", Txt_address.Text);
            Comm.Parameters.AddWithValue("@Email", Txt_Email.Text);

            int es = Comm.ExecuteNonQuery();
            if (es > 0) {
                MessageBox.Show("Done Successfully!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Comm.Parameters.Clear();
            Conn.Close();

        }

        private void Btn_Save_Status_Click(object sender, EventArgs e)
        {
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Update_ProfileDisc";
            Conn.Open();
            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);
            Comm.Parameters.AddWithValue("@Disc", Txt_Status.Text);
            
            int es = Comm.ExecuteNonQuery();
            if (es > 0)
            {
                MessageBox.Show("Done Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Comm.Parameters.Clear();
            Conn.Close();

        }

        private void Btn_Save_Pwd_Click(object sender, EventArgs e)
        {
            if (Txt_NewPwd.Text != Txt_RePwd.Text) { return; }

            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Update_Pwd";
            Conn.Open();

            Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);
            Comm.Parameters.AddWithValue("@Old_Pwd", Txt_OldPwd.Text);
            Comm.Parameters.AddWithValue("@New_Pwd", Txt_NewPwd.Text);

            int es = Comm.ExecuteNonQuery();
            if (es > 0)
            {
                MessageBox.Show("Done Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Your Current password is not correct!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Txt_OldPwd.Text = "";
                Txt_NewPwd.Text = "";
                Txt_RePwd.Text = "";
            }
            Comm.Parameters.Clear();
            Conn.Close();
        }

        private void Btn_Save_Active_Click(object sender, EventArgs e)
        {

            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_Update_AccActive";
            Conn.Open();

            if (Chk_Active.Checked == true)
            {
                
                Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);
                Comm.Parameters.AddWithValue("@Acc_Status", true);

                int es = Comm.ExecuteNonQuery();
                if (es > 0)
                {
                    MessageBox.Show("Done Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                Comm.Parameters.Clear();
                Conn.Close();

            }
            else if (Chk_Active.Checked == false) {

                Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);
                Comm.Parameters.AddWithValue("@Acc_Status", false);

                int es = Comm.ExecuteNonQuery();
                if (es > 0)
                {
                    MessageBox.Show("Done Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Comm.Parameters.Clear();
                Conn.Close();
            }

            //=========================================================================================================

            if (Chk_Del.Checked == true) {
                DialogResult DT = MessageBox.Show("are you sure for deleting your account permenentily ?","Deleting",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (DT == DialogResult.Yes)
                {
                    Comm.Connection = Conn;
                    Comm.CommandType = CommandType.StoredProcedure;
                    Comm.CommandText = "Sp_Delete_User";
                    Conn.Open();

                    Comm.Parameters.AddWithValue("@User_ID", Settings.User_ID);

                    int es = Comm.ExecuteNonQuery();
                    if (es > 0)
                    {
                        MessageBox.Show("Your account deleted! \n We are sorry to leave you ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Comm.Parameters.Clear();
                    Conn.Close();
                }
            }
        }
    }
}
