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
    public partial class SignUp : Form
    {
        SqlConnection Conn = new SqlConnection(Settings.Con_String());
        SqlCommand Comm = new SqlCommand();
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Pr_pic.ImageLocation = openFileDialog1.FileName;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_UserName.Text == "" || Txt_FirstName.Text == "" || Txt_LastName.Text == "" || Txt_Pwd.Text == "" || Txt_RePwd.Text == "") { MessageBox.Show("Complete your information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Comm.Connection = Conn;
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandText = "Sp_NewAccount";
            Conn.Open();

            Comm.Parameters.AddWithValue("@User_FirstName", Txt_FirstName.Text);
            Comm.Parameters.AddWithValue("@User_LastName", Txt_LastName.Text);
            Comm.Parameters.AddWithValue("@UserName", Txt_UserName.Text);
            Comm.Parameters.AddWithValue("@Phone", Txt_Phone.Text);
            Comm.Parameters.AddWithValue("@Address", Txt_Address.Text);
            Comm.Parameters.AddWithValue("@Email", Txt_Email.Text);

            if(Rd_Male.Checked == true) Comm.Parameters.AddWithValue("@Gender", true);
            if (Rd_Female.Checked == true) Comm.Parameters.AddWithValue("@Gender", false);

            if (Txt_Pwd.Text == Txt_RePwd.Text) Comm.Parameters.AddWithValue("@Pwd", Txt_Pwd.Text);
            else {
                    MessageBox.Show("password is not identical", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Comm.Parameters.Clear();
                    Conn.Close();
                    return;
            }

            if (Pr_pic.Image != null)
            {
                byte[] imgs = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                Comm.Parameters.AddWithValue("@Pic", imgs);
            }
            int Es = Comm.ExecuteNonQuery();
            if (Es > 0) { MessageBox.Show("Your account created successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Comm.Parameters.Clear();
                Conn.Close();
                this.Close();
            }
            else { MessageBox.Show("Sorry , you should choose another user name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Comm.Parameters.Clear();
                Conn.Close();
            }

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_LastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
