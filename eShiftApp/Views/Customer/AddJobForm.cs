using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eShiftApp.Controllers;
using eShiftApp.Models;
using CustomerModel = eShiftApp.Models.Customer;

namespace eShiftApp.Views.Customer
{
    public partial class AddJobForm : Form
    {
        private readonly CustomerModel _currentCustomer;
        private readonly TransportJobController _jobController;

        public AddJobForm(CustomerModel customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _jobController = new TransportJobController();
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            string pickup = txtPickupLocation.Text.Trim();
            string delivery = txtDeliveryLocation.Text.Trim();

            if (string.IsNullOrWhiteSpace(pickup) || string.IsNullOrWhiteSpace(delivery))
            {
                lblStatus.Text = "Please fill in both pickup and delivery locations.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            TransportJob job = new TransportJob
            {
                CustomerId = _currentCustomer.CustomerId,
                PickupLocation = pickup,
                DeliveryLocation = delivery,
                Status = "Pending",
                RequestDate = DateTime.Now,
                UnitId = 0 // null in DB
            };

            int result = _jobController.AddJob(job);

            if (result > 0)
            {
                lblStatus.Text = "Request submitted successfully!";
                lblStatus.ForeColor = System.Drawing.Color.Green;

                // Optionally close or reset form
                this.Close(); // or clear fields
            }
            else
            {
                lblStatus.Text = "Failed to submit request.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
