using eShiftApp.Views.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminModel = eShiftApp.Models.Admin;

namespace eShiftApp.Views.Admin
{
    public partial class AdminDashboardForm : Form
    {
        private readonly AdminModel _currentAdmin;

        public AdminDashboardForm(AdminModel admin)
        {
            InitializeComponent();
            _currentAdmin = admin;
            LoadDashBoard();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashBoard();
        }

        private void LoadDashBoard()
        {
            guna2Panel2.Controls.Clear();

            var adminDAshbordController = new AdminDashboardControl(_currentAdmin, this);
            adminDAshbordController.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(adminDAshbordController);
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            var manageCustomerControl = new ManageCustomerControl(this);
            manageCustomerControl.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(manageCustomerControl);
        }

        private void btnManageTransportUnits_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            var manageTransportUitControl = new ManageTransportUnitControl(this);
            manageTransportUitControl.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(manageTransportUitControl);
        }

        private void btnViewJobRecords_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            var viewJobRecordsControl= new ViewJobRecordsControl(this);
            viewJobRecordsControl.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(viewJobRecordsControl);
        }

        private void btnSystemMonitoring_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            var systemMonitoringControl = new SystemMonitoringControl();
            systemMonitoringControl.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(systemMonitoringControl);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Manage products
            guna2Panel2.Controls.Clear();

            var manageProductControl =  new ManageProductControl();
            manageProductControl.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(manageProductControl);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();

            var adminSettingsControl = new AdminSettingsControl(_currentAdmin);
            adminSettingsControl.Dock = DockStyle.Fill;

            guna2Panel2.Controls.Add(adminSettingsControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
