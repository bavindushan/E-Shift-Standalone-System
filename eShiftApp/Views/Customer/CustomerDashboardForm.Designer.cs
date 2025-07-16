namespace eShiftApp.Views.Customer
{
    partial class CustomerDashboardForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewRequest = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.progressCompletedJobs = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressApprovedJobs = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressTotalJobs = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.dataGridJobs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Controls.Add(this.btnSettings);
            this.guna2Panel1.Controls.Add(this.btnAddNewRequest);
            this.guna2Panel1.Controls.Add(this.btnDashboard);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(206, 516);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(11, 461);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            // 
            // btnSettings
            // 
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(13, 192);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(180, 45);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            // 
            // btnAddNewRequest
            // 
            this.btnAddNewRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewRequest.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNewRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewRequest.ForeColor = System.Drawing.Color.White;
            this.btnAddNewRequest.Location = new System.Drawing.Point(13, 107);
            this.btnAddNewRequest.Name = "btnAddNewRequest";
            this.btnAddNewRequest.Size = new System.Drawing.Size(180, 45);
            this.btnAddNewRequest.TabIndex = 1;
            this.btnAddNewRequest.Text = "Add New Request";
            // 
            // btnDashboard
            // 
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(12, 28);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(180, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.progressCompletedJobs);
            this.guna2Panel2.Controls.Add(this.progressApprovedJobs);
            this.guna2Panel2.Controls.Add(this.progressTotalJobs);
            this.guna2Panel2.Location = new System.Drawing.Point(221, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(768, 494);
            this.guna2Panel2.TabIndex = 1;
            // 
            // progressCompletedJobs
            // 
            this.progressCompletedJobs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressCompletedJobs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressCompletedJobs.ForeColor = System.Drawing.Color.White;
            this.progressCompletedJobs.Location = new System.Drawing.Point(575, 13);
            this.progressCompletedJobs.Minimum = 0;
            this.progressCompletedJobs.Name = "progressCompletedJobs";
            this.progressCompletedJobs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressCompletedJobs.Size = new System.Drawing.Size(106, 106);
            this.progressCompletedJobs.TabIndex = 2;
            this.progressCompletedJobs.Text = "guna2CircleProgressBar3";
            // 
            // progressApprovedJobs
            // 
            this.progressApprovedJobs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressApprovedJobs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressApprovedJobs.ForeColor = System.Drawing.Color.White;
            this.progressApprovedJobs.Location = new System.Drawing.Point(308, 13);
            this.progressApprovedJobs.Minimum = 0;
            this.progressApprovedJobs.Name = "progressApprovedJobs";
            this.progressApprovedJobs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressApprovedJobs.Size = new System.Drawing.Size(106, 106);
            this.progressApprovedJobs.TabIndex = 1;
            this.progressApprovedJobs.Text = "guna2CircleProgressBar2";
            // 
            // progressTotalJobs
            // 
            this.progressTotalJobs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressTotalJobs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressTotalJobs.ForeColor = System.Drawing.Color.White;
            this.progressTotalJobs.Location = new System.Drawing.Point(63, 14);
            this.progressTotalJobs.Minimum = 0;
            this.progressTotalJobs.Name = "progressTotalJobs";
            this.progressTotalJobs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressTotalJobs.Size = new System.Drawing.Size(106, 106);
            this.progressTotalJobs.TabIndex = 0;
            this.progressTotalJobs.Text = "Total Jobs";
            // 
            // dataGridJobs
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridJobs.ColumnHeadersHeight = 4;
            this.dataGridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridJobs.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridJobs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridJobs.Location = new System.Drawing.Point(222, 171);
            this.dataGridJobs.Name = "dataGridJobs";
            this.dataGridJobs.RowHeadersVisible = false;
            this.dataGridJobs.RowHeadersWidth = 62;
            this.dataGridJobs.RowTemplate.Height = 28;
            this.dataGridJobs.Size = new System.Drawing.Size(768, 330);
            this.dataGridJobs.TabIndex = 2;
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
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 516);
            this.Controls.Add(this.dataGridJobs);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "CustomerDashboardForm";
            this.Text = "CustomerDashboardForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnAddNewRequest;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressTotalJobs;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressCompletedJobs;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressApprovedJobs;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridJobs;
    }
}