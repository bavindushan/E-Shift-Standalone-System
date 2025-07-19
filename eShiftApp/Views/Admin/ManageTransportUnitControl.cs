using eShiftApp.Controllers;
using eShiftApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShiftApp.Views.Admin
{
    public partial class ManageTransportUnitControl : UserControl
    {
        private readonly TransportUnitController _transportUnitController;
        private readonly AdminDashboardForm _adminDashboardForm;

        public ManageTransportUnitControl(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            _transportUnitController = new TransportUnitController();
            _adminDashboardForm = adminDashboardForm;
            this.txtUnitId.KeyDown += new KeyEventHandler(this.txtUnitId_KeyDown);

        }

        private void ManageTransportUnitControl_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadTransportUnitDetails()
        {
            if (int.TryParse(txtUnitId.Text.Trim(), out int unitId))
            {
                var units = _transportUnitController.GetAllUnits();
                var selectedUnit = units.FirstOrDefault(u => u.UnitId == unitId);

                if (selectedUnit != null)
                {
                    txtLorryNumber.Text = selectedUnit.LorryNumber;
                    txtDriverName.Text = selectedUnit.DriverName;
                    txtAssistantName.Text = selectedUnit.AssistantName;
                    txtContainerCapacity.Text = selectedUnit.ContainerCapacity.ToString();
                    chkIsBooked.Checked = selectedUnit.IsBooked;
                }
                else
                {
                    MessageBox.Show("Transport Unit not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFieldsExceptId();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Unit ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFieldsExceptId();
            }
        }

        private void txtUnitId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadTransportUnitDetails();
                e.SuppressKeyPress = true;
            }
        }


        private void ClearFieldsExceptId()
        {
            txtLorryNumber.Text = "";
            txtDriverName.Text = "";
            txtAssistantName.Text = "";
            txtContainerCapacity.Text = "";
            chkIsBooked.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  Validate input
            if (string.IsNullOrWhiteSpace(txtLorryNumber.Text) ||
                string.IsNullOrWhiteSpace(txtDriverName.Text) ||
                string.IsNullOrWhiteSpace(txtAssistantName.Text) ||
                string.IsNullOrWhiteSpace(txtContainerCapacity.Text))
            {
                MessageBox.Show("Please fill in all fields before adding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Parse container capacity
            if (!float.TryParse(txtContainerCapacity.Text.Trim(), out float capacity))
            {
                MessageBox.Show("Invalid container capacity format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  Create TransportUnit object
            var newUnit = new TransportUnit
            {
                LorryNumber = txtLorryNumber.Text.Trim(),
                DriverName = txtDriverName.Text.Trim(),
                AssistantName = txtAssistantName.Text.Trim(),
                ContainerCapacity = capacity,
            };

            int result = _transportUnitController.AddTransportUnit(newUnit);

            if (result > 0)
            {
                MessageBox.Show("Transport unit added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllFields(); 
            }
            else
            {
                MessageBox.Show("Failed to add transport unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAllFields()
        {
            txtUnitId.Text = "";
            txtLorryNumber.Text = "";
            txtDriverName.Text = "";
            txtAssistantName.Text = "";
            txtContainerCapacity.Text = "";
            chkIsBooked.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUnitId.Text.Trim(), out int unitId))
            {
                MessageBox.Show("Please enter a valid Unit ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lorryNumber = txtLorryNumber.Text.Trim();
            string driverName = txtDriverName.Text.Trim();
            string assistantName = txtAssistantName.Text.Trim();
            string containerCapacityText = txtContainerCapacity.Text.Trim();

            if (string.IsNullOrEmpty(lorryNumber) || string.IsNullOrEmpty(driverName) ||
                string.IsNullOrEmpty(assistantName) || string.IsNullOrEmpty(containerCapacityText))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(containerCapacityText, out float containerCapacity))
            {
                MessageBox.Show("Please enter a valid number for Container Capacity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var unitToUpdate = new TransportUnit
            {
                UnitId = unitId,
                LorryNumber = lorryNumber,
                DriverName = driverName,
                AssistantName = assistantName,
                ContainerCapacity = containerCapacity,
            };

            int result = _transportUnitController.UpdateTransportUnit(unitToUpdate);

            if (result > 0)
            {
                MessageBox.Show("Transport Unit updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFieldsExceptId();
            }
            else
            {
                MessageBox.Show("Failed to update Transport Unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUnitId.Text.Trim(), out int unitId))
            {
                MessageBox.Show("Please enter a valid Unit ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check unit is free
            bool isFree = _transportUnitController.IsTransportUnitFree(unitId);
            if (!isFree)
            {
                MessageBox.Show("This Transport Unit is currently assigned to active jobs and cannot be deleted.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this Transport Unit?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                int result = _transportUnitController.DeleteTransportUnit(unitId);

                if (result > 0)
                {
                    MessageBox.Show("Transport Unit deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFieldsExceptId();
                }
                else
                {
                    MessageBox.Show("Failed to delete Transport Unit. It may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUnitId.Clear();
            txtLorryNumber.Clear();
            txtDriverName.Clear();
            txtAssistantName.Clear();
            txtContainerCapacity.Clear();
            chkIsBooked.Checked = false;

            txtUnitId.Focus();
        }

        private void txtUnitId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriverName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLorryNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
