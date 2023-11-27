using System;
using System.Windows.Forms;

namespace AssetsMS
{
    partial class Assets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.DashBoardLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.SuppliersLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TagTb = new System.Windows.Forms.TextBox();
            this.SNTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnedByTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SupplierTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.StatusTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ReceivedTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AssetsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.DateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.Date1Tb = new System.Windows.Forms.DateTimePicker();
            this.ModelTb = new System.Windows.Forms.TextBox();
            this.ManagerTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssetsList)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            this.panel2.Controls.Add(this.DashBoardLbl);
            this.panel2.Controls.Add(this.StatusLbl);
            this.panel2.Controls.Add(this.SuppliersLbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1525, 47);
            this.panel2.TabIndex = 1;
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(721, 13);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(165, 26);
            this.LocationLbl.TabIndex = 33;
            this.LocationLbl.Text = "Manage Location";
            this.LocationLbl.Click += new System.EventHandler(this.LocationLbl_Click_1);
            // 
            // DashBoardLbl
            // 
            this.DashBoardLbl.AutoSize = true;
            this.DashBoardLbl.Location = new System.Drawing.Point(933, 15);
            this.DashBoardLbl.Name = "DashBoardLbl";
            this.DashBoardLbl.Size = new System.Drawing.Size(156, 26);
            this.DashBoardLbl.TabIndex = 5;
            this.DashBoardLbl.Text = "View Dashboard";
            this.DashBoardLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(519, 13);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(143, 26);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "Manage Status";
            this.StatusLbl.Click += new System.EventHandler(this.StatusLbl_Click);
            // 
            // SuppliersLbl
            // 
            this.SuppliersLbl.AutoSize = true;
            this.SuppliersLbl.Location = new System.Drawing.Point(282, 13);
            this.SuppliersLbl.Name = "SuppliersLbl";
            this.SuppliersLbl.Size = new System.Drawing.Size(161, 26);
            this.SuppliersLbl.TabIndex = 3;
            this.SuppliersLbl.Text = "Manage Supplier";
            this.SuppliersLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(43, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 41);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Assets";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Asset Tag";
            // 
            // TagTb
            // 
            this.TagTb.Location = new System.Drawing.Point(76, 211);
            this.TagTb.Name = "TagTb";
            this.TagTb.Size = new System.Drawing.Size(273, 31);
            this.TagTb.TabIndex = 3;
            // 
            // SNTb
            // 
            this.SNTb.Location = new System.Drawing.Point(76, 305);
            this.SNTb.Name = "SNTb";
            this.SNTb.Size = new System.Drawing.Size(273, 31);
            this.SNTb.TabIndex = 5;
            this.SNTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Serial Number";
            // 
            // ReturnedByTb
            // 
            this.ReturnedByTb.Location = new System.Drawing.Point(412, 396);
            this.ReturnedByTb.Name = "ReturnedByTb";
            this.ReturnedByTb.Size = new System.Drawing.Size(273, 31);
            this.ReturnedByTb.TabIndex = 7;
            this.ReturnedByTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Purchase Date";
            // 
            // SupplierTb
            // 
            this.SupplierTb.Location = new System.Drawing.Point(76, 482);
            this.SupplierTb.Name = "SupplierTb";
            this.SupplierTb.Size = new System.Drawing.Size(273, 31);
            this.SupplierTb.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Supplier";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Model/Brand";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Manager Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Deployment Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(407, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Returned By";
            // 
            // StatusTb
            // 
            this.StatusTb.Location = new System.Drawing.Point(412, 305);
            this.StatusTb.Name = "StatusTb";
            this.StatusTb.Size = new System.Drawing.Size(273, 31);
            this.StatusTb.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(407, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 26);
            this.label13.TabIndex = 14;
            this.label13.Text = "Status";
            // 
            // ReceivedTb
            // 
            this.ReceivedTb.Location = new System.Drawing.Point(412, 211);
            this.ReceivedTb.Name = "ReceivedTb";
            this.ReceivedTb.Size = new System.Drawing.Size(273, 31);
            this.ReceivedTb.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 26);
            this.label14.TabIndex = 12;
            this.label14.Text = "Received By";
            // 
            // AssetsList
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.AssetsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssetsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.AssetsList.ColumnHeadersHeight = 4;
            this.AssetsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AssetsList.DefaultCellStyle = dataGridViewCellStyle9;
            this.AssetsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AssetsList.Location = new System.Drawing.Point(754, 172);
            this.AssetsList.Name = "AssetsList";
            this.AssetsList.RowHeadersVisible = false;
            this.AssetsList.RowHeadersWidth = 51;
            this.AssetsList.RowTemplate.Height = 24;
            this.AssetsList.Size = new System.Drawing.Size(736, 589);
            this.AssetsList.TabIndex = 22;
            this.AssetsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AssetsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AssetsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AssetsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AssetsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AssetsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AssetsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AssetsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AssetsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AssetsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AssetsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AssetsList.ThemeStyle.HeaderStyle.Height = 4;
            this.AssetsList.ThemeStyle.ReadOnly = false;
            this.AssetsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AssetsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AssetsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AssetsList.ThemeStyle.RowsStyle.Height = 24;
            this.AssetsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AssetsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AssetsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssetsList_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 793);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1525, 12);
            this.panel4.TabIndex = 23;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditBtn.Location = new System.Drawing.Point(412, 640);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(164, 45);
            this.EditBtn.TabIndex = 25;
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
            this.AddBtn.Location = new System.Drawing.Point(178, 640);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(171, 45);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteBtn.Location = new System.Drawing.Point(285, 716);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(164, 45);
            this.DeleteBtn.TabIndex = 26;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(245, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 29);
            this.label15.TabIndex = 27;
            this.label15.Text = "Manage Assets";
            // 
            // DateTb
            // 
            this.DateTb.Checked = true;
            this.DateTb.FillColor = System.Drawing.Color.Aqua;
            this.DateTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTb.Location = new System.Drawing.Point(76, 396);
            this.DateTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTb.Name = "DateTb";
            this.DateTb.Size = new System.Drawing.Size(273, 31);
            this.DateTb.TabIndex = 29;
            this.DateTb.Value = new System.DateTime(2023, 11, 8, 15, 14, 16, 776);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(1062, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 28);
            this.label16.TabIndex = 32;
            this.label16.Text = "List Of Assets";
            // 
            // Date1Tb
            // 
            this.Date1Tb.CalendarMonthBackground = System.Drawing.Color.Aqua;
            this.Date1Tb.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date1Tb.Location = new System.Drawing.Point(412, 482);
            this.Date1Tb.Name = "Date1Tb";
            this.Date1Tb.Size = new System.Drawing.Size(273, 27);
            this.Date1Tb.TabIndex = 33;
            // 
            // ModelTb
            // 
            this.ModelTb.Location = new System.Drawing.Point(76, 577);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(277, 31);
            this.ModelTb.TabIndex = 34;
            // 
            // ManagerTb
            // 
            this.ManagerTb.Location = new System.Drawing.Point(412, 577);
            this.ManagerTb.Name = "ManagerTb";
            this.ManagerTb.Size = new System.Drawing.Size(277, 31);
            this.ManagerTb.TabIndex = 35;
            // 
            // Assets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 805);
            this.Controls.Add(this.ManagerTb);
            this.Controls.Add(this.ModelTb);
            this.Controls.Add(this.Date1Tb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DateTb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.AssetsList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.StatusTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ReceivedTb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SupplierTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ReturnedByTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SNTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TagTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Assets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assets";
            this.Load += new System.EventHandler(this.Assets_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssetsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AssetsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label SuppliersLbl;
        private System.Windows.Forms.Label DashBoardLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TagTb;
        private System.Windows.Forms.TextBox SNTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReturnedByTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SupplierTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox StatusTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ReceivedTb;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView AssetsList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LocationLbl;
        private DateTimePicker Date1Tb;
        private TextBox ModelTb;
        private TextBox ManagerTb;
    }
}