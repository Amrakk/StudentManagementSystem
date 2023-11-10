using Student_Management_System.Controllers;
using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Views.Admin
{
    public partial class UserForm : Form
    {
        private user _user;
        private UserController userController;
        public UserForm(user user)
        {
            InitializeComponent();
            _user = user;
            userController = new UserController();

            panelFilter.Hide();
            inputSearch.ForeColor = Color.Silver;
            inputSearch.Texts = "Search by Name";
            gridViewUser.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }

        private void inputSearch_Enter(object sender, EventArgs e)
        {
            if(inputSearch.Texts == "Search by Name")
            {
                inputSearch.Texts = "";
                inputSearch.ForeColor = Color.DimGray;
            }
        }

        private void inputSearch_Leave(object sender, EventArgs e)
        {
            if (inputSearch.Texts == "")
            {
                inputSearch.Texts = "Search by Name";
                inputSearch.ForeColor = Color.Silver;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (!_user.role.Equals("Admin"))
            {
                MessageBox.Show("You have no authorization", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = userController.GetAll();
            gridViewUser.DataSource = users;
        }

        private void gridViewUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string email = gridViewUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            UserDetailForm userDetailForm = new UserDetailForm(_user, email);
            userDetailForm.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserDetailForm userDetailForm = new UserDetailForm(_user);
            userDetailForm.Show();
        }

        public void RefreshGridView()
        {
            var users = userController.GetAll();
            gridViewUser.DataSource = users;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (panelFilter.Visible == true) panelFilter.Hide();
            else panelFilter.Show();
        }

        // TODO: Export and Import (Find)
        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

    }
}
