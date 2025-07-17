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
    public partial class CustomerDashboardControl : UserControl
    {

        private readonly CustomerModel _currentCustomer;
        private readonly TransportJobController _jobController;

        private int _targetTotal = 0;
        private int _targetApproved = 0;
        private int _targetCompleted = 0;

        private Timer timerTotal;
        private Timer timerApproved;
        private Timer timerCompleted;

        public CustomerDashboardControl(CustomerModel customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _jobController = new TransportJobController();
            this.Load += CustomerDashboardControl_Load;
        }

        private void CustomerDashboardControl_Load(object sender, EventArgs e)
        {
            timerTotal = new Timer { Interval = 20 };
            timerTotal.Tick += TimerTotal_Tick;

            timerApproved = new Timer { Interval = 20 };
            timerApproved.Tick += TimerApproved_Tick;

            timerCompleted = new Timer { Interval = 20 };
            timerCompleted.Tick += TimerCompleted_Tick;

            LoadJobStats();
            LoadJobTable();
        }

        public void LoadJobStats()
        {
            try
            {
                _targetTotal = _jobController.GetTotalJobCount(_currentCustomer.CustomerId);
                _targetApproved = _jobController.GetJobCountByStatus(_currentCustomer.CustomerId, "Approved");
                _targetCompleted = _jobController.GetJobCountByStatus(_currentCustomer.CustomerId, "Completed");

                progressTotalJobs.Value = 0;
                progressApprovedJobs.Value = 0;
                progressCompletedJobs.Value = 0;

                progressTotalJobs.Text = "0";
                progressApprovedJobs.Text = "0";
                progressCompletedJobs.Text = "0";

                timerTotal.Start();
                timerApproved.Start();
                timerCompleted.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job stats: " + ex.Message);
            }
        }

        private void TimerTotal_Tick(object sender, EventArgs e)
        {
            if (progressTotalJobs.Value < _targetTotal)
            {
                progressTotalJobs.Value += 2;
                progressTotalJobs.Text = progressTotalJobs.Value.ToString();
            }
            else
            {
                timerTotal.Stop();
            }
        }

        private void TimerApproved_Tick(object sender, EventArgs e)
        {
            if (progressApprovedJobs.Value < _targetApproved)
            {
                progressApprovedJobs.Value += 2;
                progressApprovedJobs.Text = progressApprovedJobs.Value.ToString();
            }
            else
            {
                timerApproved.Stop();
            }
        }

        private void TimerCompleted_Tick(object sender, EventArgs e)
        {
            if (progressCompletedJobs.Value < _targetCompleted)
            {
                progressCompletedJobs.Value += 2;
                progressCompletedJobs.Text = progressCompletedJobs.Value.ToString();
            }
            else
            {
                timerCompleted.Stop();
            }
        }

        public void LoadJobTable()
        {
            try
            {
                var jobs = _jobController.GetJobsByCustomerId(_currentCustomer.CustomerId);
                dataGridJobs.DataSource = jobs;

                dataGridJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridJobs.ReadOnly = true;
                dataGridJobs.AllowUserToAddRows = false;
                dataGridJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job list: " + ex.Message);
            }
        }
    }
}
