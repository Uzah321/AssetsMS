namespace AssetsMS
{
    partial class Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.SuppliersLbl = new System.Windows.Forms.Label();
            this.AssetsLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.DashboardLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.maskedTextBoxArray1 = new Microsoft.VisualBasic.Compatibility.VB6.MaskedTextBoxArray(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ListOfAssets = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LocationTb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskedTextBoxArray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
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
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.StatusLbl);
            this.panel2.Controls.Add(this.SuppliersLbl);
            this.panel2.Controls.Add(this.AssetsLbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.DashboardLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1525, 47);
            this.panel2.TabIndex = 5;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(532, 15);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(143, 26);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "Manage Status";
            this.StatusLbl.Click += new System.EventHandler(this.StatusLbl_Click_1);
            // 
            // SuppliersLbl
            // 
            this.SuppliersLbl.AutoSize = true;
            this.SuppliersLbl.Location = new System.Drawing.Point(284, 15);
            this.SuppliersLbl.Name = "SuppliersLbl";
            this.SuppliersLbl.Size = new System.Drawing.Size(161, 26);
            this.SuppliersLbl.TabIndex = 3;
            this.SuppliersLbl.Text = "Manage Supplier";
            this.SuppliersLbl.Click += new System.EventHandler(this.SuppliersLbl_Click);
            // 
            // AssetsLbl
            // 
            this.AssetsLbl.AutoSize = true;
            this.AssetsLbl.Location = new System.Drawing.Point(60, 15);
            this.AssetsLbl.Name = "AssetsLbl";
            this.AssetsLbl.Size = new System.Drawing.Size(141, 26);
            this.AssetsLbl.TabIndex = 2;
            this.AssetsLbl.Text = "Manage Assets";
            this.AssetsLbl.Click += new System.EventHandler(this.AssetsLbl_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.LocationLbl);
            this.panel3.Location = new System.Drawing.Point(729, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 41);
            this.panel3.TabIndex = 2;
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(19, 5);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(165, 26);
            this.LocationLbl.TabIndex = 84;
            this.LocationLbl.Text = "Manage Location";
            this.LocationLbl.Click += new System.EventHandler(this.LocationLbl_Click_1);
            // 
            // DashboardLbl
            // 
            this.DashboardLbl.AutoSize = true;
            this.DashboardLbl.Location = new System.Drawing.Point(1001, 15);
            this.DashboardLbl.Name = "DashboardLbl";
            this.DashboardLbl.Size = new System.Drawing.Size(156, 26);
            this.DashboardLbl.TabIndex = 5;
            this.DashboardLbl.Text = "View Dashboard";
            this.DashboardLbl.Click += new System.EventHandler(this.DashboardLbl_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(116, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 29);
            this.label15.TabIndex = 78;
            this.label15.Text = "Manage Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 26);
            this.label5.TabIndex = 71;
            this.label5.Text = "Location Name";
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
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Animated = true;
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.White;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageOffset = new System.Drawing.Point(1, 0);
            this.SearchBtn.ImageSize = new System.Drawing.Size(50, 45);
            this.SearchBtn.Location = new System.Drawing.Point(277, 257);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(54, 45);
            this.SearchBtn.TabIndex = 105;
            this.SearchBtn.UseTransparentBackground = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ListOfAssets
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ListOfAssets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListOfAssets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListOfAssets.ColumnHeadersHeight = 4;
            this.ListOfAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListOfAssets.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListOfAssets.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListOfAssets.Location = new System.Drawing.Point(611, 167);
            this.ListOfAssets.Name = "ListOfAssets";
            this.ListOfAssets.RowHeadersVisible = false;
            this.ListOfAssets.RowHeadersWidth = 51;
            this.ListOfAssets.RowTemplate.Height = 24;
            this.ListOfAssets.Size = new System.Drawing.Size(845, 589);
            this.ListOfAssets.TabIndex = 106;
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
            // DeleteBtn
            // 
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(149, 470);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(180, 45);
            this.DeleteBtn.TabIndex = 107;
            this.DeleteBtn.Text = "delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // LocationTb
            // 
            this.LocationTb.BackColor = System.Drawing.Color.Transparent;
            this.LocationTb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LocationTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationTb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LocationTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LocationTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LocationTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.LocationTb.ItemHeight = 30;
            this.LocationTb.Items.AddRange(new object[] {
            "Bulawayo",
            "Gwanda",
            "Beitbridge",
            "Kwekwe",
            "Zvishavane",
            "Hwange"});
            this.LocationTb.Location = new System.Drawing.Point(65, 262);
            this.LocationTb.Name = "LocationTb";
            this.LocationTb.Size = new System.Drawing.Size(204, 36);
            this.LocationTb.TabIndex = 108;
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 805);
            this.Controls.Add(this.LocationTb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListOfAssets);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Location_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskedTextBoxArray1)).EndInit();
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LocationLbl;
        private Microsoft.VisualBasic.Compatibility.VB6.MaskedTextBoxArray maskedTextBoxArray1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2DataGridView ListOfAssets;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2ComboBox LocationTb;
        //   private Guna.UI2.WinForms.Guna2Cont textMenuStrip guna2ContextMenuStrip2;
    }
}