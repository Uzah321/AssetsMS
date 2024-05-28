using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AssetsMS
{
    public partial class Invoice : Form
    {
        public string Date, NameTb, AssetDescriptionTb, ConditionTb, SerialNumberTb;

        private void Print_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(OnPrint, "Print");
        }

        public Invoice()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");
        }
        /***
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            Panel1 = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void getprintarea(Panel pnl)
        {
            throw new NotImplementedException();
        }
        /***
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelOnPrint.width / 2), this.PanelOnPrint.Location.Y);
        }
        ***/
        private void Invoice_Load(object sender, EventArgs e)
        {
            AssetDscTb.Text = AssetDescriptionTb;
            Date = DateTime.Now.ToString();
            AssetNumTb.Text = NameTb;
            SerialNumTb.Text = SerialNumberTb;
            Condition.Text = ConditionTb;



        }
    }
}
