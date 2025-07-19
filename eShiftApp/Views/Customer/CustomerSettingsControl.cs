using eShiftApp.Controllers;
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
using eShiftApp.Utils;

namespace eShiftApp.Views.Customer
{
    public partial class CustomerSettingsControl : UserControl
    {
        private readonly CustomerModel _currentCustomer;
        private readonly CustomerController _customerController;

        public CustomerSettingsControl(CustomerModel customer)
        {
            InitializeComponent();

            _currentCustomer = customer;
            _customerController = new CustomerController();

            this.Load += CustomerSettingsControl_Load;

            this.btnUpdateDetails.Click += btnUpdateDetails_Click;
            this.btnChangePassword.Click += btnChangePassword_Click;

        }

        private void CustomerSettingsControl_Load(object sender, EventArgs e)
        {
            txtName.Text = _currentCustomer.Name;
            txtEmail.Text = _currentCustomer.Email;
            txtPhone.Text = _currentCustomer.Phone;
            txtAddress.Text = _currentCustomer.Address;

            txtEmail.ReadOnly = true;
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                lblDetailsStatus.Text = "Please fill all the fields.";
                lblDetailsStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (!PhoneAndEmailValidator.IsValidPhone(phone))
            {
                lblDetailsStatus.Text = "Please insert valid phone number.";
                lblDetailsStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            _currentCustomer.Name = name;
            _currentCustomer.Phone = phone;
            _currentCustomer.Address = address;

            int result = _customerController.UpdateCustomer(_currentCustomer);

            if (result > 0)
            {
                lblDetailsStatus.Text = "Details updated successfully.";
                lblDetailsStatus.ForeColor = System.Drawing.Color.Green;

                //  Refresh session
                var updatedCustomer = _customerController.GetCustomerById(_currentCustomer.CustomerId);
                if (updatedCustomer != null)
                    UpdateCustomerSession(updatedCustomer);
            }
            else
            {
                lblDetailsStatus.Text = "Failed to update details.";
                lblDetailsStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblPasswordStatus.Text = "Please fill all password fields.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            //  Verify hashed password
            if (!PasswordHasher.Verify(currentPassword, _currentCustomer.Password))
            {
                lblPasswordStatus.Text = "Current password is incorrect.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (newPassword != confirmPassword)
            {
                lblPasswordStatus.Text = "New passwords do not match.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            //  Update customer object
            _currentCustomer.Password = newPassword;

            int result = _customerController.UpdateCustomer(_currentCustomer);

            if (result > 0)
            {
                lblPasswordStatus.Text = "Password updated successfully.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Green;

                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();

                //  Refresh session
                var updatedCustomer = _customerController.GetCustomerById(_currentCustomer.CustomerId);
                if (updatedCustomer != null)
                    UpdateCustomerSession(updatedCustomer);
            }
            else
            {
                lblPasswordStatus.Text = "Failed to update password.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void UpdateCustomerSession(CustomerModel updated)
        {
            _currentCustomer.Name = updated.Name;
            _currentCustomer.Phone = updated.Phone;
            _currentCustomer.Address = updated.Address;
            _currentCustomer.Password = updated.Password;
        }
    }
}
