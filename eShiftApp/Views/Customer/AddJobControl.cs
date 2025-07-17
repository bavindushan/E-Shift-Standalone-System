using System;
using System.Windows.Forms;
using eShiftApp.Controllers;
using eShiftApp.Models;
using CustomerModel = eShiftApp.Models.Customer;

namespace eShiftApp.Views.Customer
{
    public partial class AddJobControl : UserControl
    {
        private readonly CustomerModel _currentCustomer;
        private readonly TransportJobController _jobController;
        private readonly ProductController _productController = new ProductController();
        private readonly CustomerDashboardForm _dashboardForm;

        public AddJobControl(CustomerModel customer, CustomerDashboardForm dashboardForm)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _dashboardForm = dashboardForm;
            _jobController = new TransportJobController();
            this.Load += AddJobControl_Load; //  wire up the Load event
        }

        private void AddJobControl_Load(object sender, EventArgs e)
        {
            var products = _productController.GetAllProducts();
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "ProductId";
            cmbProduct.SelectedIndex = -1;
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            string pickup = txtPickupLocation.Text.Trim();
            string delivery = txtDeliveryLocation.Text.Trim();
            string weightText = txtWeight.Text.Trim();
            string volumeText = txtVolume.Text.Trim();

            if (string.IsNullOrWhiteSpace(pickup) || string.IsNullOrWhiteSpace(delivery) ||
                cmbProduct.SelectedIndex == -1 || string.IsNullOrWhiteSpace(weightText) || string.IsNullOrWhiteSpace(volumeText))
            {
                lblStatus.Text = "Please fill in all fields.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (!double.TryParse(weightText, out double weight) || !double.TryParse(volumeText, out double volume))
            {
                lblStatus.Text = "Weight and Volume must be numbers.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Insert the job
            TransportJob job = new TransportJob
            {
                CustomerId = _currentCustomer.CustomerId,
                PickupLocation = pickup,
                DeliveryLocation = delivery,
                Status = "Pending",
                RequestDate = DateTime.Now,
                UnitId = null 
            };

            int jobResult = _jobController.AddJob(job);

            if (jobResult > 0)
            {
                int jobId = _jobController.GetLastInsertedJobId(); 

                if (jobId > 0)
                {
                    LoadController loadController = new LoadController();
                    Load load = new Load
                    {
                        JobId = jobId,
                        ProductId = (int)cmbProduct.SelectedValue,
                        Weight = (float)weight,
                        Volume = (float)volume
                    };

                    int loadResult = loadController.AddLoad(load);

                    if (loadResult > 0)
                    {
                        MessageBox.Show("Job and Load submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _dashboardForm.RefreshDashboard();
                        this.Dispose();
                    }
                    else
                    {
                        lblStatus.Text = "Job saved, but failed to save load.";
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    lblStatus.Text = "Job saved, but could not retrieve Job ID.";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblStatus.Text = "Failed to submit job.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
