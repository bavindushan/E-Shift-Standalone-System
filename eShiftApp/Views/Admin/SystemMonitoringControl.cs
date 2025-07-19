using eShiftApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShiftApp.Views.Admin
{
    public partial class SystemMonitoringControl : UserControl
    {
        private readonly CustomerController _customerController;
        private readonly ProductController _productController;
        private readonly TransportJobController _jobController;
        private readonly TransportUnitController _transportUnitController;
        public SystemMonitoringControl()
        {
            InitializeComponent();

            _customerController = new CustomerController();
            _productController = new ProductController();
            _jobController = new TransportJobController();
            _transportUnitController = new TransportUnitController();

            cmbFilterType.Items.AddRange(new string[] { "Customer", "Product", "Job", "Transport Unit" });
            cmbFilterType.SelectedIndexChanged += cmbFilterType_SelectedIndexChanged;

        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbFilterType.SelectedItem?.ToString();

            switch (selected)
            {
                case "Customer":
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _customerController.GetAllCustomers();
                    break;

                case "Product":
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _productController.GetAllProducts();
                    break;

                case "Job":
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _jobController.GetAllJobs();
                    break;

                case "Transport Unit":
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _transportUnitController.GetAllUnits();
                    break;

                default:
                    dgvMonitor.DataSource = null;
                    dgvMonitor.DataSource = _customerController.GetAllCustomers();
                    break;
            }
        }

        private void SystemMonitoringControl_Load(object sender, EventArgs e)
        {
            cmbFilterType.SelectedIndex = 1;
        }


    }
}
