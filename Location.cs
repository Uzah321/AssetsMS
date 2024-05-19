using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AssetsMS
{
    public partial class Location : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uzah01\Documents\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        public Location()
        {
            InitializeComponent();
            Con = new Functions();
            ShowLocation();
        }
        Functions Con;
        private string connectionString;

        private void Location_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dg();

        }

        private void ShowLocation()
        {
            string Query = "select * from LocationTbl";
            ListOfAssets.DataSource = Con.GetData(Query);
        }



        public void dg()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from LocationTbl";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ListOfAssets.DataSource = dt;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;
            int id;
            id = Convert.ToInt32(ListOfAssets.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from LocationTbl where id=" + id + "";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                LocationTb.Text = dr["Name"].ToString();


            }

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


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchKeyword = LocationTb.Text;

            // Replace "YourTableName" and "YourColumnName" with your actual table and column names
            string query = "SELECT * FROM AssetsTbl WHERE Returned_To LIKE @searchKeyword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        // Use parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            System.Data.DataTable dataTable = new System.Data.DataTable();
                            adapter.Fill(dataTable);

                            // Display the search results in a DataGridView
                            ListOfAssets.DataSource = dataTable;


                            // Optionally, you can format the DataGridView or handle empty results
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("No results found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(ListOfAssets.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from LocationTbl where id=" + id + "";
            cmd.ExecuteNonQuery();

            dg();
        }
    }

}


