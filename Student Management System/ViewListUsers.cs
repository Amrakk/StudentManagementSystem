using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Student_Management_System
{
    public partial class ViewListUsers : Form
    {
        private user _user;
        public ViewListUsers(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void ViewListUsers_Load(object sender, EventArgs e)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                string userRole = _user.role?.ToLower() ?? "";
                if (!userRole.Equals("admin"))
                {
                    MessageBox.Show("You have no authorization", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var users = (from u in db.users select u).ToList();

                dGVUsers.DataSource = users;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                string userRole = _user.role?.ToLower() ?? "";
                if (!userRole.Equals("admin"))
                {
                    MessageBox.Show("You have no priority", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dGVUsers.SelectedCells.Count == 0)
                {
                    MessageBox.Show("No cell is selected", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedEmail = dGVUsers.SelectedCells[0].Value?.ToString();

                if (string.IsNullOrEmpty(selectedEmail))
                {
                    MessageBox.Show("The selected cell does not contain a valid email", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingUser = db.users.FirstOrDefault(u => u.email == selectedEmail);

                if (existingUser == null)
                {
                    MessageBox.Show("No user found with the selected email", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        var loginHistoryRecordsToDelete = db.loginhistories.Where(lh => lh.email == selectedEmail);
                        db.loginhistories.DeleteAllOnSubmit(loginHistoryRecordsToDelete);

                        db.users.DeleteOnSubmit(existingUser);
                        db.SubmitChanges();

                        string workingDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName ?? "";
                        string avtPath = Path.Combine(workingDir, "Resources", existingUser.email);

                        if (Directory.Exists(avtPath))
                        {
                            Directory.Delete(avtPath, true);
                        }

                        MessageBox.Show("Deleted successfully", "Deleted user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
