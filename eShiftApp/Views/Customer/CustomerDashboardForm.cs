using System;
using System.Windows.Forms;
using eShiftApp.Controllers;
using eShiftApp.Models;
using eShiftApp.Views.Customer;
using CustomerModel = eShiftApp.Models.Customer;

namespace eShiftApp.Views.Customer
{
    public partial class CustomerDashboardForm : Form
    {
        private readonly CustomerModel _currentCustomer;

        public CustomerDashboardForm(CustomerModel customer)
        {
            InitializeComponent();
            _currentCustomer = customer;

            LoadDashboardControl();

            btnDashboard.Click += btnDashboard_Click;
            btnAddNewRequest.Click += btnAddNewRequest_Click;
            btnSettings.Click += btnSettings_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardControl();
        }

        // Load CustomerDashboardControl into the panel
        private void LoadDashboardControl()
        {
            guna2Panel2.Controls.Clear();

            var dashboardControl = new CustomerDashboardControl(_currentCustomer);
            dashboardControl.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(dashboardControl);
        }

        //Load CustomerSettingControl into the panel
        private void LoadSettingControl()
        {
            guna2Panel2.Controls.Clear();

            var settingsControl = new CustomerSettingsControl(_currentCustomer);
            settingsControl.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(settingsControl);
        }

        // Load AddJobControl into the panel
        private void btnAddNewRequest_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            var addJobControl = new AddJobControl(_currentCustomer, this);
            addJobControl.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(addJobControl);
        }

        // Settings (placeholder)
        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadSettingControl();
        }

        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // You can also redirect to LoginForm
        }

        // Refresh Dashboard from external controls
        public void RefreshDashboard()
        {
            LoadDashboardControl();
        }

        // Sidebar Dashboard Button
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardControl();
        }
    }
}
