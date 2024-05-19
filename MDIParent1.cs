using OfficeOpenXml;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


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
            /*****
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
            *****/
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*"; // Change the filter to Excel files

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string excelFilePath = openFileDialog.FileName;

                // Load Excel file using EPPlus
                using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFilePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming you want the first worksheet

                    // Create a DataTable to hold the Excel data
                    System.Data.DataTable dt = new System.Data.DataTable();

                    // Iterate through the Excel worksheet and populate the DataTable
                    foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                    {
                        dt.Columns.Add(firstRowCell.Text);
                    }

                    for (int rowNum = 2; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                    {
                        var wsRow = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                        DataRow row = dt.Rows.Add();
                        foreach (var cell in wsRow)
                        {
                            row[cell.Start.Column - 1] = cell.Text;
                        }
                    }

                    // Set the DataTable as the DataSource for your DataGridView
                    ListOfAssets.DataSource = dt;
                }
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
    }

}





