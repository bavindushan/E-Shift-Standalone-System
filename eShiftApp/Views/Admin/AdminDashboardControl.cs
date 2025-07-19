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
using AdminModel = eShiftApp.Models.Admin;

namespace eShiftApp.Views.Admin
{
    public partial class AdminDashboardControl : UserControl
    {
        private readonly TransportJobController _jobController;
        private readonly AdminModel _adminModel;
        private readonly AdminDashboardForm _adminDashboardForm;

        private int _targetTotal = 0;
        private int _targetOngoing = 0;
        private int _targetCompleted = 0;

        private Timer timerTotal;
        private Timer timerOngoing;
        private Timer timerCompleted;

        public AdminDashboardControl(AdminModel admin, AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            _jobController = new TransportJobController();
            this.Load += AdminDashboardControl_Load;
            _adminModel = admin;
            _adminDashboardForm = adminDashboardForm;
        }

        private void AdminDashboardControl_Load(object sender, EventArgs e)
        {
            timerTotal = new Timer { Interval = 20 };
            timerTotal.Tick += TimerTotal_Tick;

            timerOngoing = new Timer { Interval = 20 };
            timerOngoing.Tick += TimerOngoing_Tick;

            timerCompleted = new Timer { Interval = 20 };
            timerCompleted.Tick += TimerCompleted_Tick;

            LoadChartStats();
            LoadJobTable();
        }

        private void LoadChartStats()
        {
            try
            {
                var allJobs = _jobController.GetAllJobs();
                _targetTotal = allJobs.Count;
                _targetOngoing = allJobs.Count(j => j.Status == "Ongoing");
                _targetCompleted = allJobs.Count(j => j.Status == "Completed");

                progressTotalJobs.Value = 0;
                progressApprovedJobs.Value = 0;
                progressCompletedJobs.Value = 0;

                progressTotalJobs.Text = "0";
                progressApprovedJobs.Text = "0";
                progressCompletedJobs.Text = "0";

                timerTotal.Start();
                timerOngoing.Start();
                timerCompleted.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard stats: " + ex.Message);
            }
        }

        private void LoadJobTable()
        {
            try
            {
                var pendingJobs = _jobController.GetPendingJobs();
                dgvJobs.AutoGenerateColumns = true;
                dgvJobs.DataSource = pendingJobs;

                dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvJobs.ReadOnly = true;
                dgvJobs.AllowUserToAddRows = false;
                dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvJobs.ColumnHeadersVisible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending jobs: " + ex.Message);
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

        private void TimerOngoing_Tick(object sender, EventArgs e)
        {
            if (progressApprovedJobs.Value < _targetOngoing)
            {
                progressApprovedJobs.Value += 2;
                progressApprovedJobs.Text = progressApprovedJobs.Value.ToString();
            }
            else
            {
                timerOngoing.Stop();
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
    }
}
