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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssetsMS
{
    public partial class Location : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uzah01\Documents\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Location()
        {
            InitializeComponent();
        }

        private void Location_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_dg();
            //display();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into LocationTbl values('" + NameTb.Text + "','" + DescTb.Text + "','" + DestTb.Text + "')";
            cmd.ExecuteNonQuery();

            NameTb.Text = "";
            fill_dg();
            MessageBox.Show("record inserted successfully");

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(LocationList.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from LocationTbl where id=" + id + "";
            cmd.ExecuteNonQuery();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            int i = Convert.ToInt32(LocationList.SelectedCells[0].Value.ToString());
            MessageBox.Show(i.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update LocationTbl set Name ='" + NameTb.Text + "',Description='" + DescTb.Text + "',Destination='" + DestTb.Text + "'  where id=" + i + "";
            cmd.ExecuteNonQuery();
            panel2.Visible = false;
            fill_dg();

        }
        public void fill_dg()
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from LocationTbl";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            LocationList.DataSource = dt;
        }

      

        private void LocationLbl_Click_1(object sender, EventArgs e)
        {
            Location Obj = new Location();
            Obj.Show();
            this.Hide();
        }

        private void StatusLbl_Click_1(object sender, EventArgs e)
        {
            Status Obj = new Status();
            Obj.Show();
            this.Hide();
        }

        private void SuppliersLbl_Click(object sender, EventArgs e)
        {
            Suppliers Obj = new Suppliers();
            Obj.Show();
            this.Hide();
        }

        private void DashboardLbl_Click_1(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void AssetsLbl_Click_1(object sender, EventArgs e)
        {
            Assets Obj = new Assets();
            Obj.Show();
            this.Hide();
        }





        /* private void DeleteBtn_Click(object sender, EventArgs e)
          {
              int id;
              id = Convert.ToInt32(LocationList.SelectedCells[0].Value.ToString());
              SqlCommand cmd = con.CreateCommand();
              cmd.CommandType = CommandType.Text;
              cmd.CommandText = "delete from LocationTbl where id=" + id + "";
              cmd.ExecuteNonQuery();

              //display();
          } }*/
    }
} 


