using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Student_Management_System.Models;

namespace Student_Management_System.Views
{
    public partial class MainForm : Form
    {
        private user _user;
        private Form currentChildForm;
        public MainForm(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnProfile.Text = _user.name;
            openChildForm(new Students.StudentForm(_user));
        }

        #region Utils
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void openUserForm()
        {
            openChildForm(new Admin.UserForm());
        }
        #endregion


        private void btnProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfileForm(_user));
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            openChildForm(new Students.StudentForm(_user));
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
