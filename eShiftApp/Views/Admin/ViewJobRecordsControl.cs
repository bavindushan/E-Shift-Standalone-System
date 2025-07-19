using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using eShiftApp.Controllers;

namespace eShiftApp.Views.Admin
{
    public partial class ViewJobRecordsControl : UserControl
    {
        private readonly TransportJobController _jobController;
        private readonly AdminDashboardForm _adminDashboardForm;

        public ViewJobRecordsControl(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            btnSearchJob.Click += btnSearchJob_Click;
            _jobController = new TransportJobController();
            LoadJobTable();
            _adminDashboardForm = adminDashboardForm;
        }

        private void LoadJobTable()
        {
            try
            {
                var allJobs = _jobController.GetAllJobs();
                dgvJobs.AutoGenerateColumns = true;
                dgvJobs.DataSource = allJobs;

                dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvJobs.ReadOnly = true;
                dgvJobs.AllowUserToAddRows = false;
                dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvJobs.ColumnHeadersVisible = true;

                Console.WriteLine("Load table.........................");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending jobs: " + ex.Message);
            }
        }

        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Method eka load wenawa");
                string input = txtSearchJobId.Text.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Please enter a Job ID to search.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(input, out int jobId))
                {
                    MessageBox.Show("Invalid Job ID. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Console.WriteLine("Job ID in first stage" + jobId);

                var jobData = _jobController.GetJobById(jobId);

                Console.WriteLine("Job data enne naaaaa:"+jobData);

                if (jobData != null && jobData.Rows.Count > 0)
                {
                    dgvJobs.AutoGenerateColumns = true;
                    dgvJobs.DataSource = jobData;

                    foreach (DataGridViewColumn col in dgvJobs.Columns)
                    {
                        Console.WriteLine("DGV Column: " + col.Name);
                    }


                    // DEBUG: Print all column names
                    string columns = string.Join(", ", jobData.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                    MessageBox.Show("Loaded columns: " + columns, "Debug");
                }
                else
                {
                    MessageBox.Show("No job found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvJobs.DataSource = null;
                }

                if (jobData != null && jobData.Rows.Count > 0)
                {
                    dgvJobs.AutoGenerateColumns = true;
                    dgvJobs.DataSource = jobData;

                    dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvJobs.ReadOnly = true;
                    dgvJobs.AllowUserToAddRows = false;
                    dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvJobs.ColumnHeadersVisible = true;
                }
                else
                {
                    MessageBox.Show("No job found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvJobs.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while searching for the job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefreshJobs_Click(object sender, EventArgs e)
        {
            txtSearchJobId.Clear();
            LoadJobTable(); // Reload pending jobs
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchJobId.Clear();
            dgvJobs.DataSource = null;
        }

        private void btnMarkAsComplete_Click(object sender, EventArgs e)
        {
            string input = txtSearchJobId.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a Job ID in the search box to mark as completed.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(input, out int jobId))
            {
                MessageBox.Show("Invalid Job ID. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = _jobController.MarkJobAsCompleted(jobId);

            if (success)
            {
                MessageBox.Show("Job marked as completed and associated transport unit freed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJobTable();
            }
            else
            {
                MessageBox.Show("Failed to mark the job as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
