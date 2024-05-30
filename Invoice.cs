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
        public string date, NameTb, AssetDescriptionTb, ConditionTb, SerialNumberTb;
        private object panelOnPrint;
        /**
        private void OnPrint_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(OnPrint, "Print");
        }
        **/
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void OnPrint_Click(object sender, EventArgs e)
        {
            Panel panel2 = new Panel();
            this.Controls.Add(panel2);
            Graphics grp = panel2.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Height, formSize.Width, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel2.Location);
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
            bitmap = new Bitmap(s.Height, s.Width, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.Y, this.Location.X, 430, 1000, s);

        }
        public Invoice()
        {
            InitializeComponent();
            date = DateTime.Now.ToString("M/d/yyyy");
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            Panel1 = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void getprintarea(Panel pnl)
        {
            throw new NotImplementedException();
        }
      /***
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            //e.Graphics.DrawImage((pagearea.Width / 2) - this.panelOnPrint.Print_Click, this.panelOnPrint.Location.Y);
        }
        ***/
        private void Invoice_Load(object sender, EventArgs e)
        {
            AssetDscTb.Text = AssetDescriptionTb;
            date = DateTime.Now.ToString();
            AssetNumTb.Text = NameTb;
            SerialNumTb.Text = SerialNumberTb;
            Condition.Text = ConditionTb;

        }
    }
}