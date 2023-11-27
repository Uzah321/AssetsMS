 namespace AssetsMS
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.SuppliersLbl = new System.Windows.Forms.Label();
            this.AssetsLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DashboardLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Date1Tb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ListOfAssets = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AssetsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1525, 42);
            this.panel1.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(543, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(371, 36);
            this.label17.TabIndex = 33;
            this.label17.Text = "Assets Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.LocationLbl);
            this.panel2.Controls.Add(this.StatusLbl);
            this.panel2.Controls.Add(this.SuppliersLbl);
            this.panel2.Controls.Add(this.AssetsLbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1525, 47);
            this.panel2.TabIndex = 5;
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(709, 15);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(165, 26);
            this.LocationLbl.TabIndex = 80;
            this.LocationLbl.Text = "Manage Location";
            this.LocationLbl.Click += new System.EventHandler(this.LocationLbl_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(506, 15);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(143, 26);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "Manage Status";
            this.StatusLbl.Click += new System.EventHandler(this.StatusLbl_Click);
            // 
            // SuppliersLbl
            // 
            this.SuppliersLbl.AutoSize = true;
            this.SuppliersLbl.Location = new System.Drawing.Point(268, 15);
            this.SuppliersLbl.Name = "SuppliersLbl";
            this.SuppliersLbl.Size = new System.Drawing.Size(161, 26);
            this.SuppliersLbl.TabIndex = 3;
            this.SuppliersLbl.Text = "Manage Supplier";
            this.SuppliersLbl.Click += new System.EventHandler(this.Suppliers_Click);
            // 
            // AssetsLbl
            // 
            this.AssetsLbl.AutoSize = true;
            this.AssetsLbl.Location = new System.Drawing.Point(60, 15);
            this.AssetsLbl.Name = "AssetsLbl";
            this.AssetsLbl.Size = new System.Drawing.Size(141, 26);
            this.AssetsLbl.TabIndex = 2;
            this.AssetsLbl.Text = "Manage Assets";
            this.AssetsLbl.Click += new System.EventHandler(this.AssetsLbl_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.DashboardLbl);
            this.panel3.Location = new System.Drawing.Point(925, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 41);
            this.panel3.TabIndex = 2;
            // 
            // DashboardLbl
            // 
            this.DashboardLbl.AutoSize = true;
            this.DashboardLbl.Location = new System.Drawing.Point(20, 6);
            this.DashboardLbl.Name = "DashboardLbl";
            this.DashboardLbl.Size = new System.Drawing.Size(156, 26);
            this.DashboardLbl.TabIndex = 5;
            this.DashboardLbl.Text = "View Dashboard";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 793);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1525, 12);
            this.panel4.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(211, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 29);
            this.label15.TabIndex = 78;
            this.label15.Text = "View Dashboard";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(43, 213);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 30);
            this.guna2HtmlLabel1.TabIndex = 80;
            this.guna2HtmlLabel1.Text = "Start Date";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(434, 213);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(96, 30);
            this.guna2HtmlLabel2.TabIndex = 81;
            this.guna2HtmlLabel2.Text = "End Date";
            // 
            // DateTb
            // 
            this.DateTb.Checked = true;
            this.DateTb.FillColor = System.Drawing.Color.Silver;
            this.DateTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTb.Location = new System.Drawing.Point(157, 207);
            this.DateTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTb.Name = "DateTb";
            this.DateTb.Size = new System.Drawing.Size(253, 36);
            this.DateTb.TabIndex = 82;
            this.DateTb.Value = new System.DateTime(2023, 11, 26, 20, 13, 54, 795);
            // 
            // Date1Tb
            // 
            this.Date1Tb.BackColor = System.Drawing.Color.Silver;
            this.Date1Tb.Checked = true;
            this.Date1Tb.FillColor = System.Drawing.Color.Silver;
            this.Date1Tb.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Date1Tb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date1Tb.Location = new System.Drawing.Point(536, 207);
            this.Date1Tb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date1Tb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date1Tb.Name = "Date1Tb";
            this.Date1Tb.Size = new System.Drawing.Size(251, 36);
            this.Date1Tb.TabIndex = 83;
            this.Date1Tb.Value = new System.DateTime(2023, 11, 26, 20, 13, 54, 795);
            // 
            // ListOfAssets
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ListOfAssets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListOfAssets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ListOfAssets.ColumnHeadersHeight = 4;
            this.ListOfAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListOfAssets.DefaultCellStyle = dataGridViewCellStyle6;
            this.ListOfAssets.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListOfAssets.Location = new System.Drawing.Point(43, 296);
            this.ListOfAssets.Name = "ListOfAssets";
            this.ListOfAssets.RowHeadersVisible = false;
            this.ListOfAssets.RowHeadersWidth = 51;
            this.ListOfAssets.RowTemplate.Height = 24;
            this.ListOfAssets.Size = new System.Drawing.Size(1419, 425);
            this.ListOfAssets.TabIndex = 84;
            this.ListOfAssets.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ListOfAssets.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ListOfAssets.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ListOfAssets.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ListOfAssets.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ListOfAssets.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ListOfAssets.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListOfAssets.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ListOfAssets.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListOfAssets.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfAssets.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListOfAssets.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ListOfAssets.ThemeStyle.HeaderStyle.Height = 4;
            this.ListOfAssets.ThemeStyle.ReadOnly = false;
            this.ListOfAssets.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListOfAssets.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListOfAssets.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfAssets.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListOfAssets.ThemeStyle.RowsStyle.Height = 24;
            this.ListOfAssets.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListOfAssets.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SearchBtn
            // 
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.Aqua;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(893, 198);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(118, 45);
            this.SearchBtn.TabIndex = 85;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AssetsBtn
            // 
            this.AssetsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AssetsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AssetsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AssetsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AssetsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AssetsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetsBtn.ForeColor = System.Drawing.Color.White;
            this.AssetsBtn.Location = new System.Drawing.Point(1083, 198);
            this.AssetsBtn.Name = "AssetsBtn";
            this.AssetsBtn.Size = new System.Drawing.Size(118, 45);
            this.AssetsBtn.TabIndex = 86;
            this.AssetsBtn.Text = "All Assets";
            this.AssetsBtn.Click += new System.EventHandler(this.AssetsBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintBtn.FillColor = System.Drawing.Color.Teal;
            this.PrintBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Location = new System.Drawing.Point(1274, 198);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(118, 45);
            this.PrintBtn.TabIndex = 87;
            this.PrintBtn.Text = "Print";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 805);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.AssetsBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ListOfAssets);
            this.Controls.Add(this.Date1Tb);
            this.Controls.Add(this.DateTb);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAssets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SuppliersLbl;
        private System.Windows.Forms.Label AssetsLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label DashboardLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LocationLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker Date1Tb;
        private Guna.UI2.WinForms.Guna2DataGridView ListOfAssets;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button AssetsBtn;
        private Guna.UI2.WinForms.Guna2Button PrintBtn;
    }
}