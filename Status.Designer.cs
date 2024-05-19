using System;
using System.Windows.Forms;

namespace AssetsMS
{
    partial class Status
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.SuppliersLbl = new System.Windows.Forms.Label();
            this.AssetsLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.DashboardLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.StatusList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ModelTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SNTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TagTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SupplierTb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusList)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.panel2.Controls.Add(this.SuppliersLbl);
            this.panel2.Controls.Add(this.AssetsLbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.DashboardLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1525, 47);
            this.panel2.TabIndex = 4;
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(745, 15);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(165, 26);
            this.LocationLbl.TabIndex = 75;
            this.LocationLbl.Text = "Manage Location";
            this.LocationLbl.Click += new System.EventHandler(this.LocationLbl_Click);
            // 
            // SuppliersLbl
            // 
            this.SuppliersLbl.AutoSize = true;
            this.SuppliersLbl.Location = new System.Drawing.Point(284, 15);
            this.SuppliersLbl.Name = "SuppliersLbl";
            this.SuppliersLbl.Size = new System.Drawing.Size(161, 26);
            this.SuppliersLbl.TabIndex = 3;
            this.SuppliersLbl.Text = "Manage Supplier";
            this.SuppliersLbl.Click += new System.EventHandler(this.label2_Click);
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
            this.panel3.Controls.Add(this.StatusLbl);
            this.panel3.Location = new System.Drawing.Point(507, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 41);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(27, 8);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(143, 26);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "Manage Status";
            this.StatusLbl.Click += new System.EventHandler(this.StatusLbl_Click);
            // 
            // DashboardLbl
            // 
            this.DashboardLbl.AutoSize = true;
            this.DashboardLbl.Location = new System.Drawing.Point(941, 15);
            this.DashboardLbl.Name = "DashboardLbl";
            this.DashboardLbl.Size = new System.Drawing.Size(156, 26);
            this.DashboardLbl.TabIndex = 5;
            this.DashboardLbl.Text = "View Dashboard";
            this.DashboardLbl.Click += new System.EventHandler(this.DashboardLbl_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(177, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(271, 29);
            this.label15.TabIndex = 70;
            this.label15.Text = "Manage Available Assets";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteBtn.Location = new System.Drawing.Point(218, 740);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(164, 45);
            this.DeleteBtn.TabIndex = 69;
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
            this.EditBtn.Location = new System.Drawing.Point(345, 664);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(164, 45);
            this.EditBtn.TabIndex = 68;
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
            this.AddBtn.Location = new System.Drawing.Point(111, 664);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(171, 45);
            this.AddBtn.TabIndex = 67;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(1010, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 28);
            this.label16.TabIndex = 74;
            this.label16.Text = "List Of Available Assets";
            // 
            // StatusList
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.StatusList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.StatusList.ColumnHeadersHeight = 4;
            this.StatusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StatusList.DefaultCellStyle = dataGridViewCellStyle9;
            this.StatusList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StatusList.Location = new System.Drawing.Point(761, 198);
            this.StatusList.Name = "StatusList";
            this.StatusList.RowHeadersVisible = false;
            this.StatusList.RowHeadersWidth = 51;
            this.StatusList.RowTemplate.Height = 24;
            this.StatusList.Size = new System.Drawing.Size(736, 589);
            this.StatusList.TabIndex = 73;
            this.StatusList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StatusList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StatusList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StatusList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StatusList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StatusList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StatusList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StatusList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StatusList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StatusList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StatusList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StatusList.ThemeStyle.HeaderStyle.Height = 4;
            this.StatusList.ThemeStyle.ReadOnly = false;
            this.StatusList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StatusList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StatusList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StatusList.ThemeStyle.RowsStyle.Height = 24;
            this.StatusList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StatusList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StatusList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StatusList_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 793);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1525, 12);
            this.panel4.TabIndex = 72;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.StatusLbl;
            // 
            // ModelTb
            // 
            this.ModelTb.Location = new System.Drawing.Point(172, 549);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(277, 31);
            this.ModelTb.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 26);
            this.label9.TabIndex = 83;
            this.label9.Text = "Model/Brand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 26);
            this.label8.TabIndex = 81;
            this.label8.Text = "Status";
            // 
            // SNTb
            // 
            this.SNTb.Location = new System.Drawing.Point(172, 358);
            this.SNTb.Name = "SNTb";
            this.SNTb.Size = new System.Drawing.Size(273, 31);
            this.SNTb.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 26);
            this.label6.TabIndex = 77;
            this.label6.Text = "Serial Number";
            // 
            // TagTb
            // 
            this.TagTb.Location = new System.Drawing.Point(172, 264);
            this.TagTb.Name = "TagTb";
            this.TagTb.Size = new System.Drawing.Size(273, 31);
            this.TagTb.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 75;
            this.label5.Text = "Asset Tag";
            // 
            // SupplierTb
            // 
            this.SupplierTb.BackColor = System.Drawing.Color.Transparent;
            this.SupplierTb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SupplierTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierTb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SupplierTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SupplierTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SupplierTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SupplierTb.ItemHeight = 30;
            this.SupplierTb.Items.AddRange(new object[] {
            "Available",
            "Deployed",
            "On repair"});
            this.SupplierTb.Location = new System.Drawing.Point(172, 449);
            this.SupplierTb.Name = "SupplierTb";
            this.SupplierTb.Size = new System.Drawing.Size(273, 36);
            this.SupplierTb.TabIndex = 94;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 805);
            this.Controls.Add(this.SupplierTb);
            this.Controls.Add(this.ModelTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SNTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TagTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.StatusList);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Status_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void StatusList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AssetsLbl;
        private System.Windows.Forms.Label DashboardLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label SuppliersLbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2DataGridView StatusList;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.TextBox ModelTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SNTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TagTb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox SupplierTb;
    }
}