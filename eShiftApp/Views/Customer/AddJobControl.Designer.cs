namespace eShiftApp.Views.Customer
{
    partial class AddJobControl
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
            this.txtVolume = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmitRequest = new Guna.UI2.WinForms.Guna2Button();
            this.txtDeliveryLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPickupLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtVolume
            // 
            this.txtVolume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVolume.DefaultText = "Enter Volume (m³)";
            this.txtVolume.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVolume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVolume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVolume.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVolume.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVolume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVolume.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVolume.Location = new System.Drawing.Point(242, 277);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.PlaceholderText = "";
            this.txtVolume.SelectedText = "";
            this.txtVolume.Size = new System.Drawing.Size(286, 41);
            this.txtVolume.TabIndex = 13;
            // 
            // txtWeight
            // 
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.DefaultText = "Enter Weight (kg)";
            this.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Location = new System.Drawing.Point(241, 226);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PlaceholderText = "";
            this.txtWeight.SelectedText = "";
            this.txtWeight.Size = new System.Drawing.Size(286, 41);
            this.txtWeight.TabIndex = 12;
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.Transparent;
            this.cmbProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProduct.ItemHeight = 30;
            this.cmbProduct.Location = new System.Drawing.Point(242, 180);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(285, 36);
            this.cmbProduct.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(249, 344);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(3, 2);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = null;
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
            this.btnSubmitRequest.Location = new System.Drawing.Point(347, 375);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(180, 45);
            this.btnSubmitRequest.TabIndex = 9;
            this.btnSubmitRequest.Text = "Submit Request";
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
            this.txtDeliveryLocation.Location = new System.Drawing.Point(242, 126);
            this.txtDeliveryLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeliveryLocation.Name = "txtDeliveryLocation";
            this.txtDeliveryLocation.PlaceholderText = "";
            this.txtDeliveryLocation.SelectedText = "";
            this.txtDeliveryLocation.Size = new System.Drawing.Size(286, 41);
            this.txtDeliveryLocation.TabIndex = 8;
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
            this.txtPickupLocation.Location = new System.Drawing.Point(242, 75);
            this.txtPickupLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPickupLocation.Name = "txtPickupLocation";
            this.txtPickupLocation.PlaceholderText = "";
            this.txtPickupLocation.SelectedText = "";
            this.txtPickupLocation.Size = new System.Drawing.Size(286, 41);
            this.txtPickupLocation.TabIndex = 7;
            // 
            // AddJobControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.txtDeliveryLocation);
            this.Controls.Add(this.txtPickupLocation);
            this.Name = "AddJobControl";
            this.Size = new System.Drawing.Size(768, 494);
            this.Load += new System.EventHandler(this.AddJobControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtVolume;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnSubmitRequest;
        private Guna.UI2.WinForms.Guna2TextBox txtDeliveryLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtPickupLocation;
    }
}
