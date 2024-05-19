using System;
using System.Windows.Forms;

namespace AssetsMS
{
    public partial class Form1 : Form
    {

        private int currentPercentage = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        int start = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void PourcentLbl_Click(object sender, EventArgs e)
        {
            if (currentPercentage <= 100)
            {
                PourcentLbl.Text = $"{currentPercentage}%";
                currentPercentage++;
            }
        }*/

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        int Start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Start += 1;
            ProgressBar.Value = Start;
            if (ProgressBar.Value == 100)
            {
                timer1.Stop();
                ProgressBar.Value = 0;
                Login Obj = new Login();
                Obj.Show();
                this.Hide();

            }
        }
        private void PourcentLbl_Click(object sender, EventArgs e)
        {

            Start += 1;
            ProgressBar.Value = Start;
            if (ProgressBar.Value == 100)
            {
                timer1.Stop();
                ProgressBar.Value = 0;
                Login Obj = new Login();
                Obj.Show();
                this.Hide();

            }
        }

        private void ProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}