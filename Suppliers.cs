using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using Guna.UI2.WinForms.Suite;

namespace AssetsMS
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSuppliers();

        }
        Functions Con;

        public object Key { get; private set; }




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

        private void SupplierLbl_Click(object sender, EventArgs e)
        {
            Suppliers Obj = new Suppliers();
            Obj.Show();
            this.Hide();
        }
        private void ShowSuppliers()
        {
            string Query = "selecte * from SuppliersTbl";
            SuppliersList.DataSource = Con.GetData(Query);


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (NameTb.Text == "" || EmailTb.Text == "" || PhoneTb.Text == "" || DescriptionTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Email = EmailTb.Text;
                    string Phone = PhoneTb.Text;
                    string Description = DescriptionTb.Text;


                    string Query = "insert into SuppliersTbl values('{0}',{1}','{2}','{3}')";
                    Query = string.Format(Query, Name, Email, Phone, Description);
                    Con.SetData(Query);
                    MessageBox.Show("status Added!!!");
                    ShowSuppliers();
                    NameTb.Text = "";
                    EmailTb.Text = "";
                    PhoneTb.Text = "";
                    DescriptionTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        //int Key = 0;
        private void SuppliersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            NameTb.Text = SuppliersList.SelectedRows[0].Cells[1].Value.ToString();
            EmailTb.Text = SuppliersList.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = SuppliersList.SelectedRows[0].Cells[3].Value.ToString();
            DescriptionTb.Text = SuppliersList.SelectedRows[0].Cells[4].Value.ToString();


            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SuppliersList.SelectedRows[0].Cells[0].Value.ToString());
                object cellValue = SuppliersList.SelectedRows[0].Cells[0].Value;
                Key = cellValue != null ? Convert.ToInt32(cellValue.ToString()) : 0;
            }



        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || EmailTb.Text == "" || PhoneTb.Text == "" || DescriptionTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Email = EmailTb.Text;
                    string Phone = PhoneTb.Text;
                    string Description = DescriptionTb.Text;


                    string Query = "update SuppliersTbl set SupName = '{0}', SupEmail = '{1}', SupPhone = '{2}', SupDescription = '{3}' where SupCode = '{4}'";
                    Query = string.Format(Query, Name, Email, Phone, Description, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Supplier Modified!!!");
                    ShowSuppliers();
                    NameTb.Text = "";
                    EmailTb.Text = "";
                    PhoneTb.Text = "";
                    DescriptionTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || EmailTb.Text == "" || PhoneTb.Text == "" || DescriptionTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Email = EmailTb.Text;
                    string Phone = PhoneTb.Text;
                    string Description = DescriptionTb.Text;


                    string Query = "delete from SuppliersTbl where SupCode = '{0}'";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Supplier Deleted!!!");
                    ShowSuppliers();
                    NameTb.Text = "";
                    EmailTb.Text = "";
                    PhoneTb.Text = "";
                    DescriptionTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AssetsLbl_Click_1(object sender, EventArgs e)
        {
            Assets Obj = new Assets();
            Obj.Show();
            this.Hide();
        }

        private void DashboardLbl_Click_1(object sender, EventArgs e)
        { 
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void StatusLbl_Click(object sender, EventArgs e)
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

        private void LocationLbl_Click(object sender, EventArgs e)
        {
            Location Obj = new Location();
            Obj.Show();
            this.Hide();
        }
    }
    
}
