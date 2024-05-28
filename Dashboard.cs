using OfficeOpenXml;
using SharpCompress.Common;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EPPlus7 = EPPlus;


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

        private void ExcelBtn_Click(string fpath, object sender, EventArgs e)
        {


            OpenFileDialog dilg = new OpenFileDialog();
            dilg.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (dilg.ShowDialog() == DialogResult.OK)
            {
                string filepath = dilg.FileName;
                SearchTb.Text = filepath;
                LoadDataFromExcelToDataGridView(filepath, ".xlsx", "yes");




                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files (*.xlsx; *.xlsm; *.xls)|*.xlsx; *.xlsm; *.xls";
                openFileDialog.Title = "Select Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //filePath = openFileDialog.FileName;
                    //SearchTb.Text = filePath; // Update textbox (optional)
                }
                /*****
                if (string.IsNullOrEmpty(fpath))
                {
                    MessageBox.Show("Please select an Excel file to import.");

                }

                DataTable dataTable = new DataTable();

                try
                {
                    // Use third-party libraries like EPPlus for reading Excel files
                    using (var package = ExcelPackage.Load("path/to/your/file.xlsx"))
                    {
                        // Get the first worksheet (modify for specific sheet selection)
                        var worksheet = package.Workbook.Worksheets.First();

                        // Build a DataTable based on worksheet data
                        dataTable = LoadDataFromExcelToDataGridView(worksheet);
                    }

                    // Bind the data table to your DataGridView or other control
                    ListOfAssets.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error importing data: " + ex.Message);
                }
                *****/
            }
           
        }

        private void LoadDataFromExcelToDataGridView(string fpath, string ext, string hdr)
        {
            if (fpath is null)
            {
                throw new ArgumentNullException(nameof(fpath));
            }

            string con = "Provider=Microisoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            con = String.Format(con, fpath, hdr);
            OleDbConnection excelcon = new OleDbConnection(con);
            excelcon.Open();
            DataTable exceldata = excelcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string exsheetname = exceldata.Rows[0]["TABLE_NAME"].ToString();
            OleDbCommand com = new OleDbCommand("Select * from [" + exsheetname + "]", excelcon);
            OleDbDataAdapter oda = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            excelcon.Close();
            ListOfAssets.DataSource = dt;
        }
        private void Format(string con, string fpath, string hdr)
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


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx; *.xlsm; *.xls)|*.xlsx; *.xlsm; *.xls";
            openFileDialog.Title = "Select Excel File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //filePath = openFileDialog.FileName;
                // txtFilePath.Text = filePath; // Update textbox (optional)
            }
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






