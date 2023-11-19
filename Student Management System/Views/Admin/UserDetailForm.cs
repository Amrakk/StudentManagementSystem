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

            grBoxSercurity.Hide();
            grBoxSercurity.Enabled = false;

            btnSave.Text = "ADD";
            inputEmail.Enabled = true;
            labelFormStatus.Text = "Adding ...";
        }

        // Edit user
        public UserDetailForm(user user, string userEmail)
        {
            InitializeComponent();
            _user = user;
            userController = new UserController();
            selectedUser = userController.Get(userEmail);

            btnSave.Text = "EDIT";
            inputEmail.Enabled = false;
            labelFormStatus.Text = "Editing ...";
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
            labelErrorMessage.Visible = false;

            string rootDirectory = "Resources";
            if(selectedUser != null)
            {
                string avatarPath = Path.Combine(rootDirectory, selectedUser.email);
                string folderPath = Path.Combine(workingDir, avatarPath);

                if (!Directory.Exists(folderPath))
                {
                    string defaultAvatar = Path.Combine(workingDir, rootDirectory, "defaultAvatar.png");
                    picBoxAvatar.Image = Image.FromFile(defaultAvatar);
                    return;
                }

                string[] matchingFiles = Directory.GetFiles(folderPath, "avatar.*");
                picBoxAvatar.Image = Image.FromFile(matchingFiles[0]);
            }
            else
            {
                string defaultAvatar = Path.Combine(workingDir, rootDirectory, "defaultAvatar.png");
                picBoxAvatar.Image = Image.FromFile(defaultAvatar);
            }
        }

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
                        picBoxAvatar.Image.Dispose();

                        if (Directory.Exists(avtPath))
                            Directory.Delete(avtPath, true);

                        MessageBox.Show("Deleted successfully", "Deleted user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserForm_Reload();
                        this.Close();
                    }
                    else MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = inputNewPassword.Texts;
            Regex passEx = new Regex("^[a-zA-Z0-9]{8,}$");

            if (!passEx.IsMatch(newPassword))
            {
                labelErrorMessage.Text = "Password must be at least 8 characters long and contain only letters and numbers";
                labelErrorMessage.Visible = true;
                return;
            }

            try
            {
                selectedUser.password = SystemStudentUtils.EncryptPassword(newPassword);
                selectedUser.updatedAt = DateTime.Now;

                bool isUpdated = userController.Update(selectedUser);

                if (isUpdated)
                {
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inputNewPassword.Texts = "";
                }
                else MessageBox.Show("Failed to change password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to reset avatar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SetDefaultAvatar();
                } catch(Exception ex)
                {
                    MessageBox.Show("An error occurred while changing avatar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex phoneEx = new Regex("^[0-9]{10,}$");
            Regex emailEx = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");

            string name = inputName.Texts;
            string email = inputEmail.Texts;
            string phone = inputPhone.Texts;
            string role = inputRole.Texts;
            string password = phone;
            string status = inputStatus.Texts;
            DateTime dob = inputDoB.Value.Date;

            if (string.IsNullOrEmpty(email) &&
                string.IsNullOrEmpty(role) &&
                string.IsNullOrEmpty(name) &&
                string.IsNullOrEmpty(phone) &&
                string.IsNullOrEmpty(status) &&
                string.IsNullOrEmpty(password)
            )
            {
                MessageBox.Show("Please fill in all fields", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!emailEx.IsMatch(email))
            {
                MessageBox.Show("Email is not valid", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!phoneEx.IsMatch(phone))
            {
                MessageBox.Show("Phone number is not valid", "Invalid phone number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var roleList = inputRole.Items;
            var statusList = inputStatus.Items;

            if(!roleList.Contains(role))
            {
                MessageBox.Show("Role is not valid", "Invalid role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!statusList.Contains(status))
            {
                MessageBox.Show("Status is not valid", "Invalid status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingUser = userController.Get(email);

            // Add
            if (selectedUser == null)
            {
                if (existingUser != null)
                {
                    MessageBox.Show("This email has been used by another user", "Email already exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newUser = new user
                {
                    email = email,
                    name = name,
                    password = password,
                    phone = phone.Replace(" ", "").Replace("-", ""),
                    role = role,
                    dob = dob,
                    status = status,
                    age = DateTime.Now.Year - dob.Year,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                };

                SetDefaultAvatar(email);

                try
                {
                    bool isAdded = userController.Add(newUser);

                    if (isAdded)
                    {
                        MessageBox.Show($"Added successfully\n\nUser's password will be: {phone}", "Added user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserForm_Reload();
                        this.Close();
                    }
                    else MessageBox.Show("Failed to add", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Edit
            else
            {
                selectedUser.name = name;
                selectedUser.phone = phone;
                selectedUser.role = role;
                selectedUser.status = status;
                selectedUser.dob = dob;
                selectedUser.updatedAt = DateTime.Now;

                try
                {
                    bool isUpdated = userController.Update(selectedUser);

                    if (isUpdated)
                    {
                        MessageBox.Show("Updated successfully", "Updated user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserForm_Reload();
                    }
                    else MessageBox.Show("Failed to update", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UserForm_Reload()
        {
            if (Application.OpenForms["UserForm"] is UserForm userForm)
                userForm.RefreshGridView("");
        }

        private void SetDefaultAvatar(string email = "")
        {
            string rootDirectory = "Resources";
            string defaultAvatar = Path.Combine(workingDir, rootDirectory, "defaultAvatar.png");

            using (FileStream fileStream = new FileStream(defaultAvatar, FileMode.Open, FileAccess.Read))
            {
                if (picBoxAvatar.Image != null)
                    picBoxAvatar.Image.Dispose();
                picBoxAvatar.Image = Image.FromStream(fileStream);

                if (string.IsNullOrEmpty(email))
                    email = selectedUser.email;

                string imagePath = SystemStudentUtils.SaveAvatars(email, defaultAvatar);
                picBoxAvatar.Image.Save(imagePath);
            }
        }

        private void UserDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            picBoxAvatar.Image.Dispose();
            picBoxAvatar.Dispose();
        }
    }
}
