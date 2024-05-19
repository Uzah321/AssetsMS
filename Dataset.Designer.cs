namespace AssetsMS
{
    partial class Dataset
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
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultGrid
            // 
            this.ResultGrid.BackgroundColor = System.Drawing.Color.White;
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultGrid.Location = new System.Drawing.Point(0, 0);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.RowHeadersWidth = 51;
            this.ResultGrid.RowTemplate.Height = 24;
            this.ResultGrid.Size = new System.Drawing.Size(800, 450);
            this.ResultGrid.TabIndex = 0;
            // 
            // Dataset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultGrid);
            this.Name = "Dataset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dataset";
            this.Load += new System.EventHandler(this.Dataset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultGrid;
    }
}