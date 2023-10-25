//using Student_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Views.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            if (email == "")
            {
                labelErrorMessage.Text = "Email is required";
                return;
            }

            if (!email.Contains("@"))
            {
                labelErrorMessage.Text = "Email is invalid";
                return;
            }

            if (password == "")
            {
                labelErrorMessage.Text = "Password is required";
                return;
            }

            //var user = new User();
            //var userFound = user.FindByEmail(email);

            //if (userFound == null)
            //{
            //    labelErrorMessage.Text = "Email not found";
            //    return;
            //}

            //if (userFound.Password != password)
            //{
            //    labelErrorMessage.Text = "Password is incorrect";
            //    return;
            //}

            //if (userFound.Status == false)
            //{
            //    labelErrorMessage.Text = "Account is locked";
            //    return;
            //}

            //var loginHistory = new Models.Loginhistory();
            //loginHistory.UserId = userFound.Id;
            //loginHistory.LoginTime = DateTime.Now;
            //loginHistory.Save();

            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
