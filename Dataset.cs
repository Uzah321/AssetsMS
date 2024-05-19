using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AssetsMS
{
    public partial class Dataset : Form
    {
        public Dataset()
        {
            InitializeComponent();
        }
        DataSet ds;
        private void Dataset_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()
            { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fileStream);
                    //reader.IsFirstRowAsColumnNames = true;
                    // ds = reader.AsDataSet();
                    ResultGrid.DataSource = ds.Tables[0];

                }
            }
        }
    }
}
