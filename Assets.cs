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
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web.UI.WebControls;
using System.Deployment.Application;

namespace AssetsMS
{
    public partial class Assets : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uzah01\Documents\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Assets()
        {
            InitializeComponent();
            Con = new Functions();
            ShowAssets();

        }
        Functions Con;
        private object dt;

        private void Assets_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dg();
        }




        private void AssetsLbl_Click(object sender, EventArgs e)
        {
            Assets Obj = new Assets();
            Obj.Show();
            this.Hide();
        }


        private void SupplierLbl_Click(object sender, EventArgs e)
        {
            Suppliers Obj = new Suppliers();
            Obj.Show();
            this.Hide();
        }

        private void StatusLbl_Click(object sender, EventArgs e)
        {
            Status Obj = new Status();
            Obj.Show();
            this.Hide();
        }


        private void LocationLbl_Click(object sender, EventArgs e)
        {
            Location Obj = new Location();
            Obj.Show();
            this.Hide();
        }

        private void ShowAssets()
        {
            string Query = "select * frpm AssetsTbl";
            AssetsList.DataSource = Con.GetData(Query);
        }
            

        private void AddBtn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into AssetsTbl values('" + TagTb.Text + "','" + SNTb.Text + "','" + DateTb.Text + "','" + SupplierTb.Text + "','" + ModelTb.Text + "','" + ReceivedTb.Text + "','" + StatusTb.Text + "','" + ReturnedToTb.Text + "','" + Date1Tb.Text + "','" + ManagerTb.Text + "')";
            cmd.ExecuteNonQuery();

            ShowAssets();
            TagTb.Text = "";
            SNTb.Text = "";
            DateTb.Text = "";
            SupplierTb.Text = "";
            ModelTb.Text = "";
            ReceivedTb.Text = "";
            StatusTb.Text = "";
            ReturnedToTb.Text = "";
            Date1Tb.Text = "";
            ManagerTb.Text = "";            
            

            dg();
            MessageBox.Show("Record inserted successfully");

            
        }



        private void label2_Click(object sender, EventArgs e)
        {
            Suppliers Obj = new Suppliers();
            Obj.Show();
            this.Hide();

        }

       


        public void dg()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AssetsTbl";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            AssetsList.DataSource = dt;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            int id;
            id = Convert.ToInt32(AssetsList.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AssetsTbl where id=" + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                

                TagTb.Text = dr["Atag"].ToString();
                SNTb.Text = dr["SerialNumber"].ToString();
                DateTb.Text = dr["PurchaseDate"].ToString();
                SupplierTb.Text = dr["Supplier"].ToString();
                ModelTb.Text = dr["Model/Brand"].ToString();
                ReceivedTb.Text = dr["Received_By"].ToString();
                StatusTb.Text = dr["AStatus"].ToString();
                ReturnedToTb.Text = dr["Returned_To"].ToString();
                Date1Tb.Text = dr["DeploymentDate"].ToString();
                ManagerTb.Text = dr["ManagerName"].ToString();
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(AssetsList.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from AssetsTbl where id=" + id + "";
            cmd.ExecuteNonQuery();

            dg();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void LocationLbl_Click_1(object sender, EventArgs e)
        {
            Location Obj = new Location();
            Obj.Show();
            this.Hide();
        }
    }
}
