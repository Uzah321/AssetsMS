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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
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
            this.ListOfAssets = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AssetsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ExcelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.assetsDBDataSet = new AssetsMS.AssetsDBDataSet();
            this.assetsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetsTblTableAdapter = new AssetsMS.AssetsDBDataSetTableAdapters.AssetsTblTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deploymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsTblBindingSource)).BeginInit();
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
            // ListOfAssets
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ListOfAssets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListOfAssets.AutoGenerateColumns = false;
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
            this.ListOfAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.atagDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.modelBrandDataGridViewTextBoxColumn,
            this.receivedByDataGridViewTextBoxColumn,
            this.aStatusDataGridViewTextBoxColumn,
            this.returnedToDataGridViewTextBoxColumn,
            this.deploymentDateDataGridViewTextBoxColumn,
            this.managerNameDataGridViewTextBoxColumn});
            this.ListOfAssets.DataSource = this.assetsTblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListOfAssets.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListOfAssets.GridColor = System.Drawing.Color.Teal;
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
            this.ListOfAssets.ThemeStyle.GridColor = System.Drawing.Color.Teal;
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
            // AssetsBtn
            // 
            this.AssetsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AssetsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AssetsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AssetsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AssetsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AssetsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetsBtn.ForeColor = System.Drawing.Color.White;
            this.AssetsBtn.Location = new System.Drawing.Point(1083, 224);
            this.AssetsBtn.Name = "AssetsBtn";
            this.AssetsBtn.Size = new System.Drawing.Size(118, 45);
            this.AssetsBtn.TabIndex = 86;
            this.AssetsBtn.Text = "All Assets";
            this.AssetsBtn.Click += new System.EventHandler(this.AssetsBtn_Click_1);
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
            this.PrintBtn.Location = new System.Drawing.Point(1274, 224);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(118, 45);
            this.PrintBtn.TabIndex = 87;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScroll = true;
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(900, 600);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExcelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExcelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExcelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExcelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExcelBtn.ForeColor = System.Drawing.Color.White;
            this.ExcelBtn.Location = new System.Drawing.Point(1243, 742);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(180, 45);
            this.ExcelBtn.TabIndex = 88;
            this.ExcelBtn.Text = "import from Excel";
            //this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // assetsDBDataSet
            // 
            this.assetsDBDataSet.DataSetName = "AssetsDBDataSet";
            this.assetsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsDBDataSetBindingSource
            // 
            this.assetsDBDataSetBindingSource.DataSource = this.assetsDBDataSet;
            this.assetsDBDataSetBindingSource.Position = 0;
            // 
            // assetsTblBindingSource
            // 
            this.assetsTblBindingSource.DataMember = "AssetsTbl";
            this.assetsTblBindingSource.DataSource = this.assetsDBDataSet;
            // 
            // assetsTblTableAdapter
            // 
            this.assetsTblTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atagDataGridViewTextBoxColumn
            // 
            this.atagDataGridViewTextBoxColumn.DataPropertyName = "Atag";
            this.atagDataGridViewTextBoxColumn.HeaderText = "Atag";
            this.atagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.atagDataGridViewTextBoxColumn.Name = "atagDataGridViewTextBoxColumn";
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // modelBrandDataGridViewTextBoxColumn
            // 
            this.modelBrandDataGridViewTextBoxColumn.DataPropertyName = "Model/Brand";
            this.modelBrandDataGridViewTextBoxColumn.HeaderText = "Model/Brand";
            this.modelBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelBrandDataGridViewTextBoxColumn.Name = "modelBrandDataGridViewTextBoxColumn";
            // 
            // receivedByDataGridViewTextBoxColumn
            // 
            this.receivedByDataGridViewTextBoxColumn.DataPropertyName = "Received_By";
            this.receivedByDataGridViewTextBoxColumn.HeaderText = "Received_By";
            this.receivedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receivedByDataGridViewTextBoxColumn.Name = "receivedByDataGridViewTextBoxColumn";
            // 
            // aStatusDataGridViewTextBoxColumn
            // 
            this.aStatusDataGridViewTextBoxColumn.DataPropertyName = "AStatus";
            this.aStatusDataGridViewTextBoxColumn.HeaderText = "AStatus";
            this.aStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aStatusDataGridViewTextBoxColumn.Name = "aStatusDataGridViewTextBoxColumn";
            // 
            // returnedToDataGridViewTextBoxColumn
            // 
            this.returnedToDataGridViewTextBoxColumn.DataPropertyName = "Returned_To";
            this.returnedToDataGridViewTextBoxColumn.HeaderText = "Returned_To";
            this.returnedToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnedToDataGridViewTextBoxColumn.Name = "returnedToDataGridViewTextBoxColumn";
            // 
            // deploymentDateDataGridViewTextBoxColumn
            // 
            this.deploymentDateDataGridViewTextBoxColumn.DataPropertyName = "DeploymentDate";
            this.deploymentDateDataGridViewTextBoxColumn.HeaderText = "DeploymentDate";
            this.deploymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deploymentDateDataGridViewTextBoxColumn.Name = "deploymentDateDataGridViewTextBoxColumn";
            // 
            // managerNameDataGridViewTextBoxColumn
            // 
            this.managerNameDataGridViewTextBoxColumn.DataPropertyName = "ManagerName";
            this.managerNameDataGridViewTextBoxColumn.HeaderText = "ManagerName";
            this.managerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerNameDataGridViewTextBoxColumn.Name = "managerNameDataGridViewTextBoxColumn";
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
            this.SearchBtn.Location = new System.Drawing.Point(263, 224);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(54, 45);
            this.SearchBtn.TabIndex = 104;
            this.SearchBtn.UseTransparentBackground = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // SearchTb
            // 
            this.SearchTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTb.DefaultText = "";
            this.SearchTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTb.Location = new System.Drawing.Point(43, 224);
            this.SearchTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.PasswordChar = '\0';
            this.SearchTb.PlaceholderText = "Search";
            this.SearchTb.SelectedText = "";
            this.SearchTb.Size = new System.Drawing.Size(218, 45);
            this.SearchTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchTb.TabIndex = 103;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 805);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.AssetsBtn);
            this.Controls.Add(this.ListOfAssets);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsTblBindingSource)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView ListOfAssets;
        private Guna.UI2.WinForms.Guna2Button AssetsBtn;
        private Guna.UI2.WinForms.Guna2Button PrintBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button ExcelBtn;
        private System.Windows.Forms.BindingSource assetsDBDataSetBindingSource;
        private AssetsDBDataSet assetsDBDataSet;
        private System.Windows.Forms.BindingSource assetsTblBindingSource;
        private AssetsDBDataSetTableAdapters.AssetsTblTableAdapter assetsTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deploymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerNameDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox SearchTb;
    }
}