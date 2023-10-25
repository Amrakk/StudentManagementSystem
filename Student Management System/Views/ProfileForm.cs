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

namespace Student_Management_System.Views
{
    public partial class ProfileForm : Form
    {
        //private User user;
        public ProfileForm()
        {
            InitializeComponent();
            //this.user = user;

            //if (user.Role != "Admin")
            //{
            //    grBoxAdmin.Enabled = false;
            //    grBoxAdmin.Visible = false;
            //}
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.openUserForm();
        }

        private void btnLoginHistory_Click(object sender, EventArgs e)
        {
            Admin.LoginHistoryForm form = new Admin.LoginHistoryForm();
            form.ShowDialog();
        }
    }
}
