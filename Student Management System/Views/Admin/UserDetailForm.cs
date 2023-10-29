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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Views.Admin
{
    public partial class UserDetailForm : Form
    {
        private readonly string workingDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName ?? "";

        private user _user;
        private user selectedUser;
        private UserController userController;

        // Add new user
        public UserDetailForm(user user)
        {
            InitializeComponent();
            _user = user;
            userController = new UserController();

            btnSave.Text = "ADD";
            labelFormStatus.Text = "Adding ...";
        }

        // Edit user
        public UserDetailForm(user user, String userEmail)
        {
            InitializeComponent();
            _user = user;
            userController = new UserController();
            selectedUser = userController.Get(userEmail);

            btnSave.Text = "EDIT";
            labelFormStatus.Text = "Editing ...";
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            if (!_user.role.Equals("Admin"))
            {
                MessageBox.Show("You have no authorization", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnReset_Click(sender, e);
            labelErrorMessage.Visible = false;

            string rootDirectory = "Resources";
            string avatarPath = Path.Combine(rootDirectory, _user.email);
            string folderPath = Path.Combine(workingDir, avatarPath);

            if (!Directory.Exists(folderPath))
            {
                string defaultAvatar = Path.Combine(workingDir, rootDirectory, "defaultAvatar.png");
                picBoxAvatar.Image = Image.FromFile(defaultAvatar);
                return;
            }

            string[] matchingFiles = Directory.GetFiles(folderPath, "avatar.*");

            if (matchingFiles.Length > 0)
            {
                picBoxAvatar.Image = Image.FromFile(matchingFiles[0]);
            }
            else
            {
                string defaultAvatar = Path.Combine(workingDir, rootDirectory, "defaultAvatar.png");
                picBoxAvatar.Image = Image.FromFile(defaultAvatar);
            }
        }

        //TODO: Test delete button
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = userController.Delete(selectedUser);

                    if (isDeleted)
                    {
                        string avtPath = Path.Combine(workingDir, "Resources", selectedUser.email);

                        if (Directory.Exists(avtPath))
                            Directory.Delete(avtPath, true);

                        MessageBox.Show("Deleted successfully", "Deleted user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Failed to delete");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // TODO: Test change password button
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = inputNewPassword.Texts;
            Regex passEx = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

            if(!passEx.IsMatch(newPassword))
            {
                labelErrorMessage.Text = "Password must contain at least 8 characters, including (A-Z), (a-z), (1-9), (#?!@$%^&*-)";
                labelErrorMessage.Visible = true;
                return;
            }

            try
            {
                selectedUser.password = BCrypt.Net.BCrypt.HashPassword(newPassword, 10);
                selectedUser.updatedAt = DateTime.Now; 

                bool isUpdated = userController.Update(selectedUser);

                if (isUpdated)
                {
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inputNewPassword.Texts = "";
                }
                else MessageBox.Show("Failed to change password");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while changing password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputNewPassword_Enter(object sender, EventArgs e)
        {
            labelErrorMessage.Visible = false;
        }

        private void inputNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnChangePassword_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        //TODO: test change avatar button
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to reset avatar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string rootDirectory = "Resources";
                string defaultAvatar = Path.Combine(workingDir, rootDirectory, "defaultAvatar.png");

                using (FileStream fileStream = new FileStream(defaultAvatar, FileMode.Open, FileAccess.Read))
                {
                    if (picBoxAvatar.Image != null)
                        picBoxAvatar.Image.Dispose();
                    picBoxAvatar.Image = Image.FromStream(fileStream);

                    string imagePath = SystemStudentUtils.SaveAvatars(selectedUser.email, "defaultAvatar.png");
                    picBoxAvatar.Image.Save(imagePath);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(selectedUser == null)
            {
                inputName.Texts = "";
                inputDoB.Value = DateTime.Now;
                inputEmail.Texts = "";
                inputPhone.Texts = "";
                inputRole.SelectedIndex = 0;
                inputStatus.SelectedIndex = 0;
                inputCreatedAt.Texts = DateTime.Now.ToString("dd-MM-yyyy");
                inputUpdatedAt.Texts = DateTime.Now.ToString("dd-MM-yyyy");
            }
            else
            {
                inputName.Texts = selectedUser.name;
                inputDoB.Value = selectedUser.dob.Value;
                inputEmail.Texts = selectedUser.email;
                inputPhone.Texts = selectedUser.phone;
                inputRole.Texts = selectedUser.role;
                inputStatus.Texts = selectedUser.status;
                inputCreatedAt.Texts = selectedUser.createdAt?.ToString("dd-MM-yyyy");
                inputUpdatedAt.Texts = selectedUser.updatedAt?.ToString("dd-MM-yyyy");
            }
        }

        // TODO: implement save button (edit, add features)
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
