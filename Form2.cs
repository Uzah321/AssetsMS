using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetsMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invoice Obj = new Invoice();
            //Obj.AssetDescriptionTb = AssetDescriptionTb.Text;
            
            //Obj.Date = DateTime.Now.ToString();
            if (Obj.date != null)
                Obj.date = "";
            else
                Obj.date = date.Text;
            if (Obj.AssetDescriptionTb != null)
                Obj.AssetDescriptionTb = "";
            else
                Obj.AssetDescriptionTb = AssetDescriptionTb.Text;
            if (Obj.NameTb != null)
                Obj.NameTb = "";
            else
                Obj.NameTb = NameTb.Text;
            // Obj.NameTb = NameTb.Text;
            if (Obj.SerialNumberTb != null)
                Obj.SerialNumberTb = "";
            else
                Obj.SerialNumberTb = SerialNumberTb.Text;
            //Obj.SerialNumberTb = SerialNumberTb.Text;
            if (Obj.ConditionTb != null)
                Obj.ConditionTb = "";
            else
                Obj.ConditionTb = ConditionTb.Text;
            //Obj.ConditionTb = ConditionTb.Text;
            Obj.Show();
            this.Hide();

        }
    }
}
