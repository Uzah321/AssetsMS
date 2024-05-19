namespace AssetsMS
{
    partial class Suppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.AssetsLbl = new System.Windows.Forms.Label();
            this.DashboardLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuppliersLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuppliersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersList)).BeginInit();
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
            this.panel2.Controls.Add(this.LocationLbl);
            this.panel2.Controls.Add(this.StatusLbl);
            this.panel2.Controls.Add(this.AssetsLbl);
            this.panel2.Controls.Add(this.DashboardLbl);
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
            this.LocationLbl.Location = new System.Drawing.Point(742, 15);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(165, 26);
            this.LocationLbl.TabIndex = 86;
            this.LocationLbl.Text = "Manage Location";
            this.LocationLbl.Click += new System.EventHandler(this.LocationLbl_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(550, 15);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(143, 26);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "Manage Status";
            this.StatusLbl.Click += new System.EventHandler(this.StatusLbl_Click);
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
            // DashboardLbl
            // 
            this.DashboardLbl.AutoSize = true;
            this.DashboardLbl.Location = new System.Drawing.Point(926, 15);
            this.DashboardLbl.Name = "DashboardLbl";
            this.DashboardLbl.Size = new System.Drawing.Size(156, 26);
            this.DashboardLbl.TabIndex = 5;
            this.DashboardLbl.Text = "View Dashboard";
            this.DashboardLbl.Click += new System.EventHandler(this.DashboardLbl_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.SuppliersLbl);
            this.panel3.Location = new System.Drawing.Point(276, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 41);
            this.panel3.TabIndex = 2;
            // 
            // SuppliersLbl
            // 
            this.SuppliersLbl.AutoSize = true;
            this.SuppliersLbl.Location = new System.Drawing.Point(17, 6);
            this.SuppliersLbl.Name = "SuppliersLbl";
            this.SuppliersLbl.Size = new System.Drawing.Size(161, 26);
            this.SuppliersLbl.TabIndex = 3;
            this.SuppliersLbl.Text = "Manage Supplier";
            this.SuppliersLbl.Click += new System.EventHandler(this.SuppliersLbl_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(181, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 29);
            this.label15.TabIndex = 78;
            this.label15.Text = "Manage Supplier";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteBtn.Location = new System.Drawing.Point(171, 728);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(164, 45);
            this.DeleteBtn.TabIndex = 77;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditBtn.Location = new System.Drawing.Point(298, 647);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(164, 45);
            this.EditBtn.TabIndex = 76;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Teal;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBtn.Location = new System.Drawing.Point(64, 647);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(171, 45);
            this.AddBtn.TabIndex = 75;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(139, 341);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(273, 31);
            this.EmailTb.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 26);
            this.label6.TabIndex = 73;
            this.label6.Text = "Supplier Email";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(139, 246);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(273, 31);
            this.NameTb.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 26);
            this.label5.TabIndex = 71;
            this.label5.Text = "Supplier Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(1035, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 28);
            this.label16.TabIndex = 81;
            this.label16.Text = "List Of Suppliers";
            // 
            // SuppliersList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SuppliersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SuppliersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SuppliersList.ColumnHeadersHeight = 4;
            this.SuppliersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuppliersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.SuppliersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SuppliersList.Location = new System.Drawing.Point(665, 198);
            this.SuppliersList.Name = "SuppliersList";
            this.SuppliersList.RowHeadersVisible = false;
            this.SuppliersList.RowHeadersWidth = 51;
            this.SuppliersList.RowTemplate.Height = 24;
            this.SuppliersList.Size = new System.Drawing.Size(795, 574);
            this.SuppliersList.TabIndex = 80;
            this.SuppliersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SuppliersList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SuppliersList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SuppliersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SuppliersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SuppliersList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SuppliersList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SuppliersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SuppliersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SuppliersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SuppliersList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SuppliersList.ThemeStyle.HeaderStyle.Height = 4;
            this.SuppliersList.ThemeStyle.ReadOnly = false;
            this.SuppliersList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SuppliersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SuppliersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SuppliersList.ThemeStyle.RowsStyle.Height = 24;
            this.SuppliersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SuppliersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SuppliersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliersList_CellContentClick);
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
            // DescriptionTb
            // 
            this.DescriptionTb.Location = new System.Drawing.Point(139, 530);
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(273, 94);
            this.DescriptionTb.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 84;
            this.label1.Text = "Supplier Description";
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(139, 427);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(273, 31);
            this.PhoneTb.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 82;
            this.label2.Text = "Supplier Phone";
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 805);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.SuppliersList);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EmailTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Suppliers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersList)).EndInit();
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
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2DataGridView SuppliersList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label LocationLbl;
    }
}