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
    }
}
