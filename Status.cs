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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
            Con = new Functions();
            ShowStatus();
        }
        Functions Con;

        public object Key { get; private set; }

        private void ShowStatus()
        {
            string Query = "select * from statusTbl";
            StatusList.DataSource = Con.GetData(Query);
        }

        private void label2_Click(object sender, EventArgs e)
        {
             Suppliers Obj = new Suppliers();
            Obj.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

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


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StatusTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = StatusTb.Text;
                    string Desc = DescTb.Text;


                    string Query = "insert into StatusTbl values('{0}','{1}')";
                    Query = string.Format(Query, Name, Desc);
                    Con.SetData(Query);
                    MessageBox.Show("status Added!!!");
                    ShowStatus();
                    StatusTb.Text = "";
                    DescTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StatusTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = StatusTb.Text;
                    string Desc = DescTb.Text;


                    string Query = "Update StatusTbl set StName = '{0}',StDescription = '{1}' where StCode = {2}";
                    Query = string.Format(Query, Name, Desc, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Status Updated!!!");
                    ShowStatus();
                    StatusTb.Text = "";
                    DescTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        int key = 0;
        private void StatusList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StatusTb.Text = StatusList.SelectedRows[0].Cells[1].Value.ToString();
            DescTb.Text = StatusList.SelectedRows[0].Cells[2].Value.ToString();


            if (StatusTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(StatusList.SelectedRows[0].Cells[0].Value.ToString());
            }



        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = StatusTb.Text;
                    string Desc = DescTb.Text;


                    string Query = "Delete from StatusTbl where StCode  = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Status Deleted!!!");
                    ShowStatus();
                    StatusTb.Text = "";
                    DescTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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