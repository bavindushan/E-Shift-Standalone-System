namespace eShiftApp.Views.Customer
{
    partial class CustomerDashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridJobs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.progressCompletedJobs = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressApprovedJobs = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressTotalJobs = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridJobs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridJobs.ColumnHeadersHeight = 4;
            this.dataGridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridJobs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridJobs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridJobs.Location = new System.Drawing.Point(3, 158);
            this.dataGridJobs.Name = "dataGridJobs";
            this.dataGridJobs.RowHeadersVisible = false;
            this.dataGridJobs.RowHeadersWidth = 62;
            this.dataGridJobs.RowTemplate.Height = 28;
            this.dataGridJobs.Size = new System.Drawing.Size(765, 330);
            this.dataGridJobs.TabIndex = 5;
            this.dataGridJobs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridJobs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridJobs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridJobs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridJobs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridJobs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridJobs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridJobs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridJobs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridJobs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridJobs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridJobs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridJobs.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridJobs.ThemeStyle.ReadOnly = false;
            this.dataGridJobs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridJobs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridJobs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridJobs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridJobs.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridJobs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridJobs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // progressCompletedJobs
            // 
            this.progressCompletedJobs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressCompletedJobs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressCompletedJobs.ForeColor = System.Drawing.Color.White;
            this.progressCompletedJobs.Location = new System.Drawing.Point(574, 12);
            this.progressCompletedJobs.Minimum = 0;
            this.progressCompletedJobs.Name = "progressCompletedJobs";
            this.progressCompletedJobs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressCompletedJobs.Size = new System.Drawing.Size(106, 106);
            this.progressCompletedJobs.TabIndex = 6;
            this.progressCompletedJobs.Text = "guna2CircleProgressBar3";
            // 
            // progressApprovedJobs
            // 
            this.progressApprovedJobs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressApprovedJobs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressApprovedJobs.ForeColor = System.Drawing.Color.White;
            this.progressApprovedJobs.Location = new System.Drawing.Point(311, 12);
            this.progressApprovedJobs.Minimum = 0;
            this.progressApprovedJobs.Name = "progressApprovedJobs";
            this.progressApprovedJobs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressApprovedJobs.Size = new System.Drawing.Size(106, 106);
            this.progressApprovedJobs.TabIndex = 4;
            this.progressApprovedJobs.Text = "guna2CircleProgressBar2";
            // 
            // progressTotalJobs
            // 
            this.progressTotalJobs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressTotalJobs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressTotalJobs.ForeColor = System.Drawing.Color.White;
            this.progressTotalJobs.Location = new System.Drawing.Point(62, 13);
            this.progressTotalJobs.Minimum = 0;
            this.progressTotalJobs.Name = "progressTotalJobs";
            this.progressTotalJobs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressTotalJobs.Size = new System.Drawing.Size(106, 106);
            this.progressTotalJobs.TabIndex = 3;
            this.progressTotalJobs.Text = "Total Jobs";
            // 
            // CustomerDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridJobs);
            this.Controls.Add(this.progressCompletedJobs);
            this.Controls.Add(this.progressApprovedJobs);
            this.Controls.Add(this.progressTotalJobs);
            this.Name = "CustomerDashboardControl";
            this.Size = new System.Drawing.Size(768, 494);
            this.Load += new System.EventHandler(this.CustomerDashboardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridJobs;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressCompletedJobs;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressApprovedJobs;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressTotalJobs;
    }
}
