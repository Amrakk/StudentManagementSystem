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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            panelFilter.Show();
            _user = user;
            userController = new UserController();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            string userRole = _user.role?.ToLower() ?? "";
            if (!userRole.Equals("admin"))
            {
                MessageBox.Show("You have no authorization", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = userController.GetAll();
            dGVUsers.DataSource = users;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userRole = _user.role?.ToLower() ?? "";
            if (!userRole.Equals("admin"))
            {
                MessageBox.Show("You have no priority", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dGVUsers.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a user first", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedEmail = dGVUsers.SelectedCells[0].Value?.ToString();

            if (string.IsNullOrEmpty(selectedEmail))
            {
                MessageBox.Show("The selected cell does not contain a valid email", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            user selectedUser = userController.Get(selectedEmail);

            if (selectedUser == null)
            {
                MessageBox.Show("No user found with the selected email", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = userController.Delete(selectedUser);

                    if (isDeleted)
                    {
                        string workingDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName ?? "";
                        string avtPath = Path.Combine(workingDir, "Resources", selectedEmail);

                        if (Directory.Exists(avtPath))
                        {
                            Directory.Delete(avtPath, true);
                        }

                        MessageBox.Show("Deleted successfully", "Deleted user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
