using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AssetsMS
{
    public partial class Suppliers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uzah01\Documents\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30;");
        public Suppliers()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSuppliers();

        }
        Functions Con;

        public object Key { get; private set; }




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

        private void SupplierLbl_Click(object sender, EventArgs e)
        {
            Suppliers Obj = new Suppliers();
            Obj.Show();
            this.Hide();
        }
        private void ShowSuppliers()
        {
            string Query = "select * from SuppliersTbl";
            SuppliersList.DataSource = Con.GetData(Query);


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into SuppliersTbl values('" + NameTb.Text + "','" + EmailTb.Text + "','" + PhoneTb.Text + "','" + DescriptionTb.Text + "')";
            cmd.ExecuteNonQuery();

            ShowSuppliers();
            NameTb.Text = "";
            EmailTb.Text = "";
            PhoneTb.Text = "";
            DescriptionTb.Text = "";


            dg();
            MessageBox.Show("Record inserted successfully");

        }

        public void dg()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SuppliersTbl";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SuppliersList.DataSource = dt;
        }
        //int Key = 0;
        private void SuppliersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            NameTb.Text = SuppliersList.SelectedRows[0].Cells[1].Value.ToString();
            EmailTb.Text = SuppliersList.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = SuppliersList.SelectedRows[0].Cells[3].Value.ToString();
            DescriptionTb.Text = SuppliersList.SelectedRows[0].Cells[4].Value.ToString();


            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SuppliersList.SelectedRows[0].Cells[0].Value.ToString());
                object cellValue = SuppliersList.SelectedRows[0].Cells[0].Value;
                Key = cellValue != null ? Convert.ToInt32(cellValue.ToString()) : 0;
            }



        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            int id;
            id = Convert.ToInt32(SuppliersList.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SuppliersTbl where id=" + id + "";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                NameTb.Text = dr["SupName"].ToString();
                EmailTb.Text = dr["SupEmail"].ToString();
                PhoneTb.Text = dr["SupPhone"].ToString();
                DescriptionTb.Text = dr["SupDescription"].ToString();

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(SuppliersList.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from SuppliersTbl where id=" + id + "";
            cmd.ExecuteNonQuery();

            dg();
        }

        private void AssetsLbl_Click_1(object sender, EventArgs e)
        {
            Assets Obj = new Assets();
            Obj.Show();
            this.Hide();
        }

        private void DashboardLbl_Click_1(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void StatusLbl_Click(object sender, EventArgs e)
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

        private void LocationLbl_Click(object sender, EventArgs e)
        {
            Location Obj = new Location();
            Obj.Show();
            this.Hide();
        }

        private void Suppliers_Load(object sender, EventArgs e)
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
