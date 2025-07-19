using eShiftApp.Views.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShiftApp
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            lblGoToSignUp.Cursor = Cursors.Hand;
            lblGoToSignUp.ForeColor = Color.Blue;
            lblGoToSignUp.Font = new Font(lblGoToSignUp.Font, FontStyle.Underline);


        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            //AdminLoginForm adminForm = new AdminLoginForm();
            //adminForm.Show();
            //this.Hide();
        }

        private void lblGoToSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
