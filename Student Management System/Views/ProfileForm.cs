using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System.Controllers;
using Student_Management_System.Database;

namespace Student_Management_System.Views
{
    public partial class ProfileForm : Form
    {
        private readonly string workingDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName ?? "";
        private user _user;
        public ProfileForm(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (!_user.role.Equals("Admin"))
            {
                MessageBox.Show("You have no authorization to do this operation", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.openUserForm();
        }

        private void btnLoginHistory_Click(object sender, EventArgs e)
        {
            if (!_user.role.Equals("Admin"))
            {
                MessageBox.Show("You have no authorization to do this operation", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Admin.LoginHistoryForm form = new Admin.LoginHistoryForm(_user);
            form.ShowDialog();
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico|Icon Files|*.ico";
                openFileDialog.Title = "Select an Avatar";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        using (FileStream fileStream = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                        {
                            if (picBoxAvatar.Image != null)
                                picBoxAvatar.Image.Dispose();

                            picBoxAvatar.Image = Image.FromStream(fileStream);
                            string rootDirectory = "Resources";
                            string avatarPath = Path.Combine(rootDirectory, _user.email);
                            string folderPath = Path.Combine(workingDir, avatarPath);

                            string imagePath = SystemStudentUtils.SaveAvatars(_user.email, selectedFilePath);
                            picBoxAvatar.Image.Save(imagePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading the selected avatar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (_user.role != "Admin")
            {
                grBoxAdmin.Enabled = false;
                grBoxAdmin.Visible = false;
            }

            labelErrorMessage.Visible = false;

            inputName.Texts = _user.name;
            inputDoB.Texts = string.Format("{0:dd-MM-yyyy}", _user.dob);
            inputEmail.Texts = _user.email;
            inputPhone.Texts = _user.phone;
            inputRole.Texts = _user.role;
            inputCreatedAt.Texts = _user.createdAt.ToString();
            inputUpdatedAt.Texts = _user.updatedAt.ToString();

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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Regex passEx = new Regex("^[a-zA-Z0-9]{8,}$");
            string newPassword = inputNewPassword.Texts;
            string confirmPassword = inputConfirmPassword.Texts;    

            if(!passEx.IsMatch(newPassword))
            {
                labelErrorMessage.Text = "Password must be at least 8 characters long and contain only letters and numbers";    
                labelErrorMessage.Visible = true;
                return;
            }

            if (!newPassword.Equals(confirmPassword))
            {
                labelErrorMessage.Text = "New password and confirm password do not match";
                labelErrorMessage.Visible = true;
                return;
            }
            try
            {
                _user.password = SystemStudentUtils.EncryptPassword(newPassword);
                _user.updatedAt = DateTime.Now;

                var userController = new UserController();
                bool isUpdated = userController.Update(_user);

                if (isUpdated)
                {
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inputNewPassword.Texts = "";
                    inputConfirmPassword.Texts = "";
                }
                else MessageBox.Show("Failed to change password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch(Exception ex)
            {
                MessageBox.Show("An error occurred while changing password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnChangePassword_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void inputConfirmPassword_Enter(object sender, EventArgs e)
        {
            labelErrorMessage.Visible = false;
        }

        private void inputNewPassword_Enter(object sender, EventArgs e)
        {
            labelErrorMessage.Visible = false;
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            picBoxAvatar.Image.Dispose();
            picBoxAvatar.Dispose();
        }
    }
}
