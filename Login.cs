using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace AssetsMS
{
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uzah01\Documents\AssetsDB.mdf;Integrated Security=False;Connect Timeout=30;Encrypt=False");
        //internal Functions Con { get; }

        public Login()
        {
            InitializeComponent();

            CheckForUpdates();
        }

        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager(@"\Temp\Releases"))
            {
                await manager.UpdateApp(); 
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void SignupLbl_Click(object sender, EventArgs e)
        {
            Signup Obj = new Signup();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SignupTbl where username='" + UsernameTb.Text + "' and password='" + PasswordTb.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Username or Password is incorrect");
            }
            else
            {
                this.Hide();
                MDIParent1 mdi = new MDIParent1();
                mdi.Show();
            }

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}




