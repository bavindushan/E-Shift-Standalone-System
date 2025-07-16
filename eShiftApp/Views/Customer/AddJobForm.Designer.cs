namespace eShiftApp.Views.Customer
{
    partial class AddJobForm
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
            this.txtPickupLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDeliveryLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmitRequest = new Guna.UI2.WinForms.Guna2Button();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPickupLocation
            // 
            this.txtPickupLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPickupLocation.DefaultText = "Enter Pickup Location";
            this.txtPickupLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPickupLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPickupLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPickupLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPickupLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPickupLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPickupLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPickupLocation.Location = new System.Drawing.Point(227, 118);
            this.txtPickupLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPickupLocation.Name = "txtPickupLocation";
            this.txtPickupLocation.PlaceholderText = "";
            this.txtPickupLocation.SelectedText = "";
            this.txtPickupLocation.Size = new System.Drawing.Size(286, 41);
            this.txtPickupLocation.TabIndex = 0;
            // 
            // txtDeliveryLocation
            // 
            this.txtDeliveryLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryLocation.DefaultText = "Enter Delivery Location";
            this.txtDeliveryLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeliveryLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeliveryLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeliveryLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryLocation.Location = new System.Drawing.Point(227, 197);
            this.txtDeliveryLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeliveryLocation.Name = "txtDeliveryLocation";
            this.txtDeliveryLocation.PlaceholderText = "";
            this.txtDeliveryLocation.SelectedText = "";
            this.txtDeliveryLocation.Size = new System.Drawing.Size(286, 41);
            this.txtDeliveryLocation.TabIndex = 1;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmitRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmitRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmitRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmitRequest.FillColor = System.Drawing.Color.Green;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmitRequest.ForeColor = System.Drawing.Color.White;
            this.btnSubmitRequest.Location = new System.Drawing.Point(332, 317);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(180, 45);
            this.btnSubmitRequest.TabIndex = 2;
            this.btnSubmitRequest.Text = "Submit Request";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(227, 260);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(3, 2);
            this.lblStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "in this get load details";
            // 
            // AddJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.txtDeliveryLocation);
            this.Controls.Add(this.txtPickupLocation);
            this.Name = "AddJobForm";
            this.Text = "AddJobForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtPickupLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtDeliveryLocation;
        private Guna.UI2.WinForms.Guna2Button btnSubmitRequest;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private System.Windows.Forms.Label label1;
    }
}