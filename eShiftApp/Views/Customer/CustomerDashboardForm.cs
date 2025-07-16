using System;
using System.Windows.Forms;
using eShiftApp.Controllers;
using eShiftApp.Models;
using CustomerModel = eShiftApp.Models.Customer;

namespace eShiftApp.Views.Customer
{
    public partial class CustomerDashboardForm : Form
    {
        private readonly CustomerModel _currentCustomer;
        private readonly TransportJobController _jobController;

        private int _targetTotal = 0;
        private int _targetApproved = 0;
        private int _targetCompleted = 0;

        private Timer timerTotal;
        private Timer timerApproved;
        private Timer timerCompleted;


        public CustomerDashboardForm(CustomerModel customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _jobController = new TransportJobController();
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            // Create timers
            timerTotal = new Timer { Interval = 20 };
            timerTotal.Tick += TimerTotal_Tick;

            timerApproved = new Timer { Interval = 20 };
            timerApproved.Tick += TimerApproved_Tick;

            timerCompleted = new Timer { Interval = 20 };
            timerCompleted.Tick += TimerCompleted_Tick;


            LoadJobStats();
            LoadJobTable();
        }

        //  Load job counts into Guna2CircleProgressBars
        private void LoadJobStats()
        {
            try
            {
                _targetTotal = _jobController.GetTotalJobCount(_currentCustomer.CustomerId);
                _targetApproved = _jobController.GetJobCountByStatus(_currentCustomer.CustomerId, "Approved");
                _targetCompleted = _jobController.GetJobCountByStatus(_currentCustomer.CustomerId, "Completed");

                // Reset values to 0 before animation
                progressTotalJobs.Value = 0;
                progressApprovedJobs.Value = 0;
                progressCompletedJobs.Value = 0;

                progressTotalJobs.Text = "0";
                progressApprovedJobs.Text = "0";
                progressCompletedJobs.Text = "0";

                // Start animations
                timerTotal.Start();
                timerApproved.Start();
                timerCompleted.Start();

                // Stop the timer immediately if target is 0
                if (_targetTotal == 0) timerTotal.Stop();
                if (_targetApproved == 0) timerApproved.Stop();
                if (_targetCompleted == 0) timerCompleted.Stop();

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
                //progressTotalJobs.Value += 2;
                progressTotalJobs.Value = Math.Min(progressTotalJobs.Value + 2, _targetTotal);
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
                //progressApprovedJobs.Value += 2;
                progressApprovedJobs.Value = Math.Min(progressApprovedJobs.Value + 2, _targetApproved);
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
                //progressCompletedJobs.Value += 2;
                progressCompletedJobs.Value = Math.Min(progressCompletedJobs.Value + 2, _targetCompleted);
                progressCompletedJobs.Text = progressCompletedJobs.Value.ToString();
            }
            else
            {
                timerCompleted.Stop();
            }
        }

        //  Load job list into DataGridView
        private void LoadJobTable()
        {
            try
            {
                var jobs = _jobController.GetJobsByCustomerId(_currentCustomer.CustomerId);
                dataGridJobs.DataSource = jobs;

                // Optional styling
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

        //  Add New Request button from sidebar
        private void btnAddNewRequest_Click(object sender, EventArgs e)
        {
            //var requestForm = new AddJobForm(_currentCustomer); // To be created next
            //requestForm.ShowDialog();

            LoadJobStats();
            LoadJobTable();
        }

        //  Settings (placeholder)
        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings page coming soon!");
        }

        //  Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // You can also redirect to LoginForm
        }

        //  Reload Dashboard view
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadJobStats();
            LoadJobTable();
        }
    }
}
