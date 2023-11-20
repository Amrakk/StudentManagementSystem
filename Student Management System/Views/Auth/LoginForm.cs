using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Student_Management_System.Database;
using Student_Management_System.Controllers;

namespace Student_Management_System.Views.Auth
{
    public partial class LoginForm : Form
    {
        private UserController userController;
        public LoginForm()
        {
            InitializeComponent();
            userController = new UserController();
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
            string email = txtEmail.Text;
            string password = txtPassword.Text;

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

            user loginUser;
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                loginUser = userController.Get(email);
                if (loginUser == null)
                {
                    labelErrorMessage.Text = "Invalid email or password";
                    return;
                }

                bool isCorrectedPassword = BCrypt.Net.BCrypt.Verify(password, loginUser.password);
                if (!isCorrectedPassword)
                {
                    labelErrorMessage.Text = "Invalid email or password";
                    return;
                }

                if (loginUser.status == "Locked")
                {
                    labelErrorMessage.Text = "This account is locked";
                    return;
                }

                var loginHis = new loginhistory()
                {
                    email = loginUser.email,
                    history = DateTime.Now
                };

                db.loginhistories.InsertOnSubmit(loginHis);
                db.SubmitChanges();
            }

            MainForm form = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f is MainForm)
                {
                    form = f as MainForm;
                    break;
                }
            }

            if (form != null)
            {
                form.SetUser(loginUser);
                form.Visible = true;
                form.Enabled = true;
                
                this.Visible = false;
                this.Enabled = false;
                return;
            }

            form = new MainForm(loginUser);
            form.Show();

            this.Visible = false;
            this.Enabled = false;   
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnLogin_Click(sender, e);
            }
        }
    }
}
