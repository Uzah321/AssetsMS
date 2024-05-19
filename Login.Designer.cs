using System;

namespace AssetsMS
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.MainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.NAME = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SignupLbl = new System.Windows.Forms.Label();
            this.maskedTextBoxArray1 = new Microsoft.VisualBasic.Compatibility.VB6.MaskedTextBoxArray(this.components);
            this.maskedTextBoxArray2 = new Microsoft.VisualBasic.Compatibility.VB6.MaskedTextBoxArray(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.UsernameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.maskedTextBoxArray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedTextBoxArray2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.FillColor = System.Drawing.Color.DarkSlateGray;
            this.MainPanel.FillColor2 = System.Drawing.Color.Turquoise;
            this.MainPanel.FillColor3 = System.Drawing.Color.Teal;
            this.MainPanel.FillColor4 = System.Drawing.Color.Teal;
            this.MainPanel.Location = new System.Drawing.Point(26, 65);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(887, 71);
            this.MainPanel.TabIndex = 0;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.BackColor = System.Drawing.Color.White;
            this.NAME.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.ForeColor = System.Drawing.Color.DarkCyan;
            this.NAME.Location = new System.Drawing.Point(361, 13);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(197, 42);
            this.NAME.TabIndex = 1;
            this.NAME.Text = "BAOBAD.DB";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 10);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 656);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 10);
            this.panel2.TabIndex = 11;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(316, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Don\'t have an account? \r\n";
            // 
            // SignupLbl
            // 
            this.SignupLbl.AutoSize = true;
            this.SignupLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(150)))));
            this.SignupLbl.Location = new System.Drawing.Point(548, 522);
            this.SignupLbl.Name = "SignupLbl";
            this.SignupLbl.Size = new System.Drawing.Size(78, 26);
            this.SignupLbl.TabIndex = 13;
            this.SignupLbl.Text = "Signup.";
            this.SignupLbl.Click += new System.EventHandler(this.SignupLbl_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(26, 129);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(887, 549);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // UsernameTb
            // 
            this.UsernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTb.DefaultText = "";
            this.UsernameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsernameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTb.Location = new System.Drawing.Point(319, 227);
            this.UsernameTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.PasswordChar = '\0';
            this.UsernameTb.PlaceholderText = "Enter Username";
            this.UsernameTb.SelectedText = "";
            this.UsernameTb.Size = new System.Drawing.Size(337, 51);
            this.UsernameTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UsernameTb.TabIndex = 15;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.DefaultText = "";
            this.PasswordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.Location = new System.Drawing.Point(320, 334);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.PlaceholderText = "Enter Password";
            this.PasswordTb.SelectedText = "";
            this.PasswordTb.Size = new System.Drawing.Size(335, 56);
            this.PasswordTb.TabIndex = 16;
            // 
            // LoginBtn
            // 
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.FillColor = System.Drawing.Color.Teal;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(315, 443);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(341, 45);
            this.LoginBtn.TabIndex = 17;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 666);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SignupLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maskedTextBoxArray1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedTextBoxArray2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel MainPanel;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SignupLbl;
        private Microsoft.VisualBasic.Compatibility.VB6.MaskedTextBoxArray maskedTextBoxArray1;
        private Microsoft.VisualBasic.Compatibility.VB6.MaskedTextBoxArray maskedTextBoxArray2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTb;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTb;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
    }
}