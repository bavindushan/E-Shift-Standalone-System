using eShiftApp.Controllers;
using eShiftApp.Models;
using AdminModel = eShiftApp.Models.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eShiftApp.Utils;
using eShiftApp.Views.Customer;

namespace eShiftApp.Views.Admin
{
    public partial class AdminLoginForm : Form
    {
        private AdminController adminController = new AdminController();

        public AdminLoginForm()
        {
            InitializeComponent();
            //btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            lblErrorMessage.Text = "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblErrorMessage.Text = "Please enter both username and password.";
                lblErrorMessage.ForeColor = Color.Red;
                return;
            }

            Console.WriteLine("Admin pass:"+password);

            AdminModel admin = adminController.Login(username, password);

            Console.WriteLine("Admin object"+admin);

            if (admin != null)
            {
                lblErrorMessage.Text = "Login Succes!.";
                lblErrorMessage.ForeColor = Color.Green;

                MessageBox.Show($"Welcome, {admin.Username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var dashboardForm = new AdminDashboardForm(admin);
                dashboardForm.Show();
                this.Hide();

            }
            else
            {
                lblErrorMessage.Text = "Invalid username or password.";
                lblErrorMessage.ForeColor = Color.Red;
            }
        }
    }
}
