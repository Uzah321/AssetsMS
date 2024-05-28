using OfficeOpenXml;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.OleDb;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data.OleDb;


namespace AssetsMS
{
    public partial class MDIParent1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uzah01\Documents\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30");

        private int childFormNumber = 0;


        public MDIParent1()
        {
            InitializeComponent();

        }

        public void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            this.Text += $" v.{versionInfo.FileVersion }";
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)

            {
                string FileName = openFileDialog.FileName;
            }
            
        }
       
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void assetMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assets Obj = new Assets();
            Obj.Show();
        }



        private void AssetsBtn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AssetsTbl";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ListOfAssets.DataSource = dt;

        }


        // Replace this connection string with your actual connection string
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Uzah01\\Documents\\AssetsDB.mdf;Integrated Security=True;Connect Timeout=30";
        private object connection;
        private Bitmap bitmap;
        private object printDocument1;
        private object printPreviewDialog1;

        public object OleDbSchemaGroup { get; private set; }

        private void SearchBtn_Click(object sender, EventArgs e)
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

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetsDBDataSet.AssetsTbl' table. You can move, or remove it, as needed.
            //this.assetsTblTableAdapter.Fill(this.assetsDBDataSet.AssetsTbl);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void AssetsStatusBtn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StatusTbl";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ListOfAssets.DataSource = dt;


        }
        /*****
        private void importFromExcelBtn_Click(object sender, EventArgs e)
        {

            // OpenFileDialog to select the Excel file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Excel File";
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Create a DataTable to hold the imported data
                DataTable dataTable = new DataTable();

                // Connection string for Excel files (adjust based on your Excel version)
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"; // Adjust for Excel version
                string sheetName;
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        // Get information about tables (worksheets)
                        DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGroup.Tables, null);

                        if (schemaTable.Rows.Count > 0)
                        {
                            sheetName = schemaTable.Rows[0]["TABLE_NAME"].ToString();
                        }
                        else
                        {
                            // Handle the case of no tables (worksheets)
                            MessageBox.Show("The Excel file does not contain any worksheets.");
                            return; // Or take other appropriate action
                        }

                        // ... rest of your code for retrieving data from the sheet
                    }
                }
                catch (Exception ex)
                {
                    // Handle connection or other errors
                    MessageBox.Show("Error getting sheet name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        *****/
    }

}





