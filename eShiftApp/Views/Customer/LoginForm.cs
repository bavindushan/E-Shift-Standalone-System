using CustomerModel = eShiftApp.Models.Customer;
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

namespace eShiftApp.Views.Customer
{
    public partial class LoginForm : Form
    {
        private readonly CustomerController _customerController;

        public LoginForm()
        {
            InitializeComponent();

            _customerController = new CustomerController();

            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter email and password.";
                return;
            }

            CustomerModel customer = _customerController.Login(email, password);

            if (customer != null)
            {
                lblMessage.Text = "Login successful!";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                Console.WriteLine("not HAshed :" + password);

                MessageBox.Show($"Welcome, {customer.Name}!", "e-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var dashboard = new CustomerDashboardForm(customer);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Invalid credentials.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
