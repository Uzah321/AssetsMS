using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace AssetsMS
{
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uzah01\Documents\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public Dashboard()
        {
            InitializeComponent();


        }
        DataSet ds;


        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetsDBDataSet.AssetsTbl' table. You can move, or remove it, as needed.
            //int v = this.assetsTblTableAdapter.Fill(this.assetsDBDataSet.AssetsTbl);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 43, 1000, s);
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            var frmDialog = new System.Windows.Forms.OpenFileDialog();
            if (frmDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string constr = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES""", frmDialog.FileName);
                OleDbConnection myConnection = new OleDbConnection(constr);
                myConnection.Open();
                DataTable spreadSheetData = myConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = "";
                DataTable dt;
                OleDbCommand onlineConnection;
                OleDbDataAdapter theDataAdapter;

                foreach (DataRow dr in spreadSheetData.Rows)
                {
                    sheetName = dr["TABLE_NAME"].ToString();
                    sheetName = sheetName.Replace("'", "");
                    if (sheetName.EndsWith("$"))
                    {
                        onlineConnection = new OleDbCommand("SELECT * FROM [" + sheetName + "]", myConnection);
                        theDataAdapter = new OleDbDataAdapter(onlineConnection);
                        dt = new DataTable();
                        dt.TableName = sheetName;
                        theDataAdapter.Fill(dt);
                        ds.Tables.Add(dt);
                    }
                }
                myConnection.Close();
                ListOfAssets.DataSource = ds.Tables[0];
                setLabe2();

            }
        }

        private void setLabe2()
        {
            //throw new NotImplementedException();
        }


        private void AssetsBtn_Click_1(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AssetsTbl";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ListOfAssets.DataSource = dt;

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Uzah01\\Desktop\\AssetsMS\\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private void SearchBtn_Click_1(object sender, EventArgs e)
        {

            string searchKeyword = SearchTb.Text;

            // Replace "YourTableName" and "YourColumnName" with your actual table and column names
            string query = "SELECT * FROM AssetsTbl WHERE Atag LIKE @searchKeyword";

            using (SqlConnection connection = new SqlConnection(connectionString))
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
        }

        private void AssetsLbl_Click(object sender, EventArgs e)
        {

            Assets Obj = new Assets();
            Obj.Show();
            this.Hide();
        }

        private void SuppliersLbl_Click(object sender, EventArgs e)
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
    }
}






