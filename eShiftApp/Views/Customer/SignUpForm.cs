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
using CustomerModel = eShiftApp.Models.Customer;
using eShiftApp.Utils;


namespace eShiftApp.Views.Customer
{
    public partial class SignUpForm : Form
    {
        private readonly CustomerController _customerController;

        public SignUpForm()
        {
            InitializeComponent();
            _customerController = new CustomerController();
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            btnRegister.Click += btnRegister_Click;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblStatus.Text = "Please fill in all fields.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            //email format validation
            if (!PhoneAndEmailValidator.IsValidEmail(email))
            {
                lblStatus.Text = "Please enter a valid email address.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            // Phone format validation
            if (!PhoneAndEmailValidator.IsValidPhone(phone))
            {
                lblStatus.Text = "Please enter a valid phone number.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            // Cant Add same locations, It should be different
            if (password != confirmPassword)
            {
                lblStatus.Text = "Passwords do not match.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Check if user already exists
            //var existingCustomer = _customerController.Login(email, password);
            if (_customerController.EmailExists(email))
            {
                lblStatus.Text = "An account with this email already exists.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Create new customer
            CustomerModel newCustomer = new CustomerModel
            {
                Name = name,
                Email = email,
                Phone = phone,
                Address = address,
                Password = password // Will be hashed in the controller
            };

            int result = _customerController.AddCustomer(newCustomer);

            if (result > 0)
            {
                lblStatus.Text = "Registration successful. You can now log in.";
                lblStatus.ForeColor = System.Drawing.Color.Green;

                //rederect to login form
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                lblStatus.Text = "Registration failed. Please try again.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        // hyperlink to Login Form
        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
