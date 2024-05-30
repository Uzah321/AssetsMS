namespace AssetsMS
{
    partial class Form2
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
            this.date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.NameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.AssetDescriptionTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.SerialNumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ConditionTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Checked = true;
            this.date.FillColor = System.Drawing.Color.Teal;
            this.date.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.Location = new System.Drawing.Point(57, 309);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(337, 51);
            this.date.TabIndex = 23;
            this.date.Value = new System.DateTime(2024, 5, 28, 2, 32, 59, 682);
            // 
            // NameTb
            // 
            this.NameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTb.DefaultText = "";
            this.NameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NameTb.ForeColor = System.Drawing.Color.DimGray;
            this.NameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTb.Location = new System.Drawing.Point(57, 180);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTb.Name = "NameTb";
            this.NameTb.PasswordChar = '\0';
            this.NameTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.NameTb.PlaceholderText = "Name of Technician";
            this.NameTb.SelectedText = "";
            this.NameTb.Size = new System.Drawing.Size(337, 60);
            this.NameTb.TabIndex = 24;
            // 
            // AssetDescriptionTb
            // 
            this.AssetDescriptionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AssetDescriptionTb.DefaultText = "";
            this.AssetDescriptionTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AssetDescriptionTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AssetDescriptionTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AssetDescriptionTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AssetDescriptionTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AssetDescriptionTb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.AssetDescriptionTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AssetDescriptionTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AssetDescriptionTb.Location = new System.Drawing.Point(539, 180);
            this.AssetDescriptionTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AssetDescriptionTb.Name = "AssetDescriptionTb";
            this.AssetDescriptionTb.PasswordChar = '\0';
            this.AssetDescriptionTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.AssetDescriptionTb.PlaceholderText = "Asset Description";
            this.AssetDescriptionTb.SelectedText = "";
            this.AssetDescriptionTb.Size = new System.Drawing.Size(337, 60);
            this.AssetDescriptionTb.TabIndex = 25;
            // 
            // SerialNumberTb
            // 
            this.SerialNumberTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SerialNumberTb.DefaultText = "";
            this.SerialNumberTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SerialNumberTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SerialNumberTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SerialNumberTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SerialNumberTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerialNumberTb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SerialNumberTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SerialNumberTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerialNumberTb.Location = new System.Drawing.Point(539, 291);
            this.SerialNumberTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SerialNumberTb.Name = "SerialNumberTb";
            this.SerialNumberTb.PasswordChar = '\0';
            this.SerialNumberTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.SerialNumberTb.PlaceholderText = "Serial Number";
            this.SerialNumberTb.SelectedText = "";
            this.SerialNumberTb.Size = new System.Drawing.Size(337, 60);
            this.SerialNumberTb.TabIndex = 26;
            // 
            // ConditionTb
            // 
            this.ConditionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConditionTb.DefaultText = "";
            this.ConditionTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConditionTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConditionTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConditionTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConditionTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConditionTb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ConditionTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConditionTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConditionTb.Location = new System.Drawing.Point(539, 416);
            this.ConditionTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConditionTb.Name = "ConditionTb";
            this.ConditionTb.PasswordChar = '\0';
            this.ConditionTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.ConditionTb.PlaceholderText = "Condition";
            this.ConditionTb.SelectedText = "";
            this.ConditionTb.Size = new System.Drawing.Size(337, 60);
            this.ConditionTb.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(700, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 45);
            this.button1.TabIndex = 96;
            this.button1.Text = "Generate Invoice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 670);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConditionTb);
            this.Controls.Add(this.SerialNumberTb);
            this.Controls.Add(this.AssetDescriptionTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.date);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker date;
        private Guna.UI2.WinForms.Guna2TextBox NameTb;
        private Guna.UI2.WinForms.Guna2TextBox AssetDescriptionTb;
        private Guna.UI2.WinForms.Guna2TextBox SerialNumberTb;
        private Guna.UI2.WinForms.Guna2TextBox ConditionTb;
        private System.Windows.Forms.Button button1;
    }
}