using eShiftApp.Controllers;
using eShiftApp.Utils;
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
    public partial class AdminSettingsControl : UserControl
    {
        private readonly AdminController _adminController;
        private AdminModel _currentAdmin;

        public AdminSettingsControl(AdminModel currentAdmin)
        {
            InitializeComponent();

            _adminController = new AdminController();
            _currentAdmin = currentAdmin;

            txtCurrentUsername.Text = _currentAdmin.Username;
        }

        private void btnUpdateUsername_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text.Trim();
            string confirmUsername = txtCnfirmUsername.Text.Trim();

            if (string.IsNullOrEmpty(newUsername) || newUsername != confirmUsername)
            {
                MessageBox.Show("New username and confirm username must match and not be empty!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentAdmin.Username = newUsername;

            int result = _adminController.UpdateAdminUserNameOrPass(_currentAdmin);
            if (result > 0)
            {
                MessageBox.Show("Username updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCurrentUsername.Text = newUsername;
            }
            else
            {
                MessageBox.Show("Username update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (!PasswordHasher.Verify(currentPassword, _currentAdmin.Password))
            {
                MessageBox.Show("Current password is incorrect!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(newPassword) || newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password must match and not be empty!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentAdmin.Password = PasswordHasher.Hash(newPassword);

            string query = "UPDATE Admin SET password = @Password WHERE admin_id = @AdminId";
            int result = DBHelper.ExecuteQuery(query, new[]
            {
                new System.Data.SqlClient.SqlParameter("@Password", _currentAdmin.Password),
                new System.Data.SqlClient.SqlParameter("@AdminId", _currentAdmin.AdminId)
            });

            if (result > 0)
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
