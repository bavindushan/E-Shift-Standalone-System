namespace eShiftApp.Views.Admin
{
    partial class ViewJobRecordsControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchJobId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchJob = new Guna.UI2.WinForms.Guna2Button();
            this.btnMarkAsComplete = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshJobs = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgvJobs = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Manage Job Records";
            // 
            // txtSearchJobId
            // 
            this.txtSearchJobId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchJobId.DefaultText = "";
            this.txtSearchJobId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchJobId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchJobId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchJobId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchJobId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchJobId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchJobId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchJobId.Location = new System.Drawing.Point(193, 116);
            this.txtSearchJobId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchJobId.Name = "txtSearchJobId";
            this.txtSearchJobId.PlaceholderText = "";
            this.txtSearchJobId.SelectedText = "";
            this.txtSearchJobId.Size = new System.Drawing.Size(163, 37);
            this.txtSearchJobId.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Search Job ID:";
            // 
            // btnSearchJob
            // 
            this.btnSearchJob.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchJob.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchJob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchJob.ForeColor = System.Drawing.Color.Black;
            this.btnSearchJob.Location = new System.Drawing.Point(438, 116);
            this.btnSearchJob.Name = "btnSearchJob";
            this.btnSearchJob.Size = new System.Drawing.Size(118, 37);
            this.btnSearchJob.TabIndex = 52;
            this.btnSearchJob.Text = "Search";
            this.btnSearchJob.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMarkAsComplete
            // 
            this.btnMarkAsComplete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMarkAsComplete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkAsComplete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkAsComplete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMarkAsComplete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMarkAsComplete.FillColor = System.Drawing.Color.Yellow;
            this.btnMarkAsComplete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMarkAsComplete.ForeColor = System.Drawing.Color.Black;
            this.btnMarkAsComplete.Location = new System.Drawing.Point(590, 116);
            this.btnMarkAsComplete.Name = "btnMarkAsComplete";
            this.btnMarkAsComplete.Size = new System.Drawing.Size(118, 37);
            this.btnMarkAsComplete.TabIndex = 51;
            this.btnMarkAsComplete.Text = "Complete";
            this.btnMarkAsComplete.Click += new System.EventHandler(this.btnMarkAsComplete_Click);
            // 
            // btnRefreshJobs
            // 
            this.btnRefreshJobs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshJobs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshJobs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshJobs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshJobs.FillColor = System.Drawing.Color.Black;
            this.btnRefreshJobs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshJobs.ForeColor = System.Drawing.Color.White;
            this.btnRefreshJobs.Location = new System.Drawing.Point(21, 176);
            this.btnRefreshJobs.Name = "btnRefreshJobs";
            this.btnRefreshJobs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRefreshJobs.Size = new System.Drawing.Size(46, 37);
            this.btnRefreshJobs.TabIndex = 53;
            this.btnRefreshJobs.Text = "↻";
            this.btnRefreshJobs.Click += new System.EventHandler(this.btnRefreshJobs_Click);
            // 
            // dgvJobs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJobs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvJobs.Location = new System.Drawing.Point(11, 219);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersVisible = false;
            this.dgvJobs.RowHeadersWidth = 62;
            this.dgvJobs.RowTemplate.Height = 28;
            this.dgvJobs.Size = new System.Drawing.Size(865, 374);
            this.dgvJobs.TabIndex = 54;
            this.dgvJobs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvJobs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvJobs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvJobs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvJobs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvJobs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvJobs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvJobs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvJobs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvJobs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvJobs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvJobs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvJobs.ThemeStyle.ReadOnly = false;
            this.dgvJobs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvJobs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvJobs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvJobs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvJobs.ThemeStyle.RowsStyle.Height = 28;
            this.dgvJobs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvJobs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ViewJobRecordsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.btnRefreshJobs);
            this.Controls.Add(this.btnSearchJob);
            this.Controls.Add(this.btnMarkAsComplete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchJobId);
            this.Controls.Add(this.label1);
            this.Name = "ViewJobRecordsControl";
            this.Size = new System.Drawing.Size(887, 601);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchJobId;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSearchJob;
        private Guna.UI2.WinForms.Guna2Button btnMarkAsComplete;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefreshJobs;
        private Guna.UI2.WinForms.Guna2DataGridView dgvJobs;
    }
}
