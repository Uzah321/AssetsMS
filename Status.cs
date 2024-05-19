using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AssetsMS
{
    public partial class Status : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uzah01\Documents\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Status()
        {
            InitializeComponent();
            Con = new Functions();
            ShowStatus();
        }
        Functions Con;

        public object Key { get; private set; }

        private void ShowStatus()
        {
            string Query = "select * from StatusTbl";
            StatusList.DataSource = Con.GetData(Query);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Suppliers Obj = new Suppliers();
            Obj.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AssetsLbl_Click(object sender, EventArgs e)
        {
            Assets Obj = new Assets();
            Obj.Show();
            this.Hide();
        }

        private void DashboardLbl_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into StatusTbl values('" + TagTb.Text + "','" + SNTb.Text + "','" + SupplierTb.Text + "','" + ModelTb.Text + "')";
            cmd.ExecuteNonQuery();

            ShowStatus();
            TagTb.Text = "";
            SNTb.Text = "";
            SupplierTb.Text = "";
            ModelTb.Text = "";


            dg();
            MessageBox.Show("Record inserted successfully");


        }


        public void dg()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StatusTbl";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            StatusList.DataSource = dt;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;
            int id;
            id = Convert.ToInt32(StatusList.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StatusTbl where id=" + id + "";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                TagTb.Text = dr["Atag"].ToString();
                SNTb.Text = dr["SerialNumber"].ToString();
                SupplierTb.Text = dr["Supplier"].ToString();
                ModelTb.Text = dr["Model/Brand"].ToString();

            }
        }
        int key = 0;


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(StatusList.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from StatusTbl where id=" + id + "";
            cmd.ExecuteNonQuery();

            dg();

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

        private void Status_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dg();
        }
    }
}