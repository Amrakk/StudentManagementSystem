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
                db.DeferredLoadingEnabled = false;
                loginUser = (from u in db.users
                            where u.email == email
                            select u).FirstOrDefault();

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

            var mainForm = new MainForm(loginUser);
            mainForm.Show();
            this.Hide();
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
