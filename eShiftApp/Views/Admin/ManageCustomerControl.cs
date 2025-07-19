using System;
using System.Windows.Forms;
using eShiftApp.Controllers;
using eShiftApp.Models;
using eShiftApp.Utils;
using CustomerModel = eShiftApp.Models.Customer;

namespace eShiftApp.Views.Admin
{
    public partial class ManageCustomerControl : UserControl
    {
        private readonly CustomerController _customerController;
        private CustomerModel _selectedCustomer;
        private readonly AdminDashboardForm _adminDashboardForm;

        public ManageCustomerControl(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();

            _customerController = new CustomerController();

            this.txtCustomerId.TextChanged += TxtCustomerId_TextChanged;
            this.btnUpdateDetails.Click += BtnUpdateDetails_Click;
            this.btnChangePassword.Click += BtnChangePassword_Click;
            _adminDashboardForm = adminDashboardForm;
        }

        private void TxtCustomerId_TextChanged(object sender, EventArgs e)
        {
            string input = txtCustomerId.Text.Trim();
            if (int.TryParse(input, out int customerId))
            {
                var customer = _customerController.GetCustomerById(customerId);
                if (customer != null)
                {
                    _selectedCustomer = customer;

                    txtName.Text = customer.Name;
                    txtEmail.Text = customer.Email;
                    txtPhone.Text = customer.Phone;
                    txtAddress.Text = customer.Address;
                    lblDetailsStatus.Text = "";
                    lblPasswordStatus.Text = "";

                    txtEmail.ReadOnly = true;
                }
                else
                {
                    _selectedCustomer = null;
                    ClearFields();
                    lblDetailsStatus.Text = "Customer not found.";
                    lblDetailsStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void BtnUpdateDetails_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                lblDetailsStatus.Text = "No customer selected.";
                lblDetailsStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

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
                lblDetailsStatus.Text = "Invalid phone number.";
                lblDetailsStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            _selectedCustomer.Name = name;
            _selectedCustomer.Phone = phone;
            _selectedCustomer.Address = address;

            int result = _customerController.UpdateCustomer(_selectedCustomer);
            if (result > 0)
            {
                lblDetailsStatus.Text = "Details updated successfully.";
                lblDetailsStatus.ForeColor = System.Drawing.Color.Green;
                ReloadCustomerData(_selectedCustomer.CustomerId);
            }
            else
            {
                lblDetailsStatus.Text = "Failed to update details.";
                lblDetailsStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                lblPasswordStatus.Text = "No customer selected.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblPasswordStatus.Text = "Please fill all password fields.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (newPassword != confirmPassword)
            {
                lblPasswordStatus.Text = "Passwords do not match.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            _selectedCustomer.Password = newPassword;

            int result = _customerController.UpdateCustomer(_selectedCustomer);
            if (result > 0)
            {
                lblPasswordStatus.Text = "Password updated successfully.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Green;

                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
                ReloadCustomerData(_selectedCustomer.CustomerId);

            }
            else
            {
                lblPasswordStatus.Text = "Failed to update password.";
                lblPasswordStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void ReloadCustomerData(int customerId)
        {
            var customer = _customerController.GetCustomerById(customerId);
            if (customer != null)
            {
                _selectedCustomer = customer;

                txtCustomerId.Text = customer.CustomerId.ToString();
                txtName.Text = customer.Name;
                txtEmail.Text = customer.Email;
                txtPhone.Text = customer.Phone;
                txtAddress.Text = customer.Address;
                lblDetailsStatus.Text = "";
                lblPasswordStatus.Text = "";

                txtEmail.ReadOnly = true;
            }
            else
            {
                _selectedCustomer = null;
                ClearFields();
                lblDetailsStatus.Text = "Customer not found.";
                lblDetailsStatus.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }
    }
}
