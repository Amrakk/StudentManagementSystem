using Student_Management_System.Controllers;
using Student_Management_System.Database;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Student_Management_System
{
    public partial class AddUserForm : Form
    {
        private UserController userController;
        private string selectedFilePath;
        private readonly string workingDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName ?? "";
        private user _user;
        public AddUserForm(user user)
        {
            InitializeComponent();
            _user = user;
            userController = new UserController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userRole = _user.role?.ToLower() ?? "";
            if (!userRole.Equals("admin"))
            {
                MessageBox.Show("You have no priority", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                Regex emailEx = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
                string email = tbEmail.Text;

                string name = tbName.Text;

                Regex passEx = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                string password = tbPassword.Text;
                string confirmed = tbConfirmPassword.Text;

                Regex phoneEx = new Regex("^(?:\\d{10}|\\d{3}[-\\s]?\\d{3}[-\\s]?\\d{4})$");
                string phone = tbPhone.Text;
                string role = cbbRole.SelectedItem?.ToString();
                DateTime now = DateTime.Now;
                int age = now.Year - dtpDob.Value.Year;

                if (!string.IsNullOrEmpty(email) &&
                    emailEx.IsMatch(email) &&
                    !string.IsNullOrEmpty(name) &&
                    !string.IsNullOrEmpty(password) &&
                    passEx.IsMatch(password) &&
                    confirmed.Equals(password) &&
                    !string.IsNullOrEmpty(phone) &&
                    phoneEx.IsMatch(phone) &&
                    !string.IsNullOrEmpty(role))
                {
                    var existingUser = userController.Get(email);

                    if (existingUser != null)
                    {
                        MessageBox.Show("This email has been used", "Not acceptable email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newUser = new user
                    {
                        email = email,
                        name = name,
                        password = password,
                        phone = phone.Replace(" ", "").Replace("-", ""),
                        role = role,
                        dob = dtpDob.Value.Date,
                        status = "Normal",
                        age = age
                    };

                    if (pbAvatar.Image != null)
                    {
                        string rootDirectory = "Resources";
                        string avatarPath = Path.Combine(rootDirectory, _user.email);
                        string folderPath = Path.Combine(workingDir, avatarPath);

                        try
                        {
                            Directory.CreateDirectory(folderPath);
                            string fileUploadedExtension = Path.GetExtension(selectedFilePath);
                            string imagePath = Path.Combine(folderPath, "avatar" + "." + fileUploadedExtension);

                            pbAvatar.Image.Save(imagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    bool isAdded = userController.Add(newUser);
                    if (isAdded)
                    {
                        MessageBox.Show("Added");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Please check the fields again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            cbbRole.Items.Add("Admin");
            cbbRole.Items.Add("Manager");
            cbbRole.Items.Add("Employee");
        }

        private void pbAvatar_Click(object sender, EventArgs e)
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
                            pbAvatar.Image = Image.FromStream(fileStream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading the selected avatar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            cbbRole.Items.Add("Admin");
            cbbRole.Items.Add("Manager");
            cbbRole.Items.Add("Employee");

            cbbRole.SelectedIndex = 0;
        }
    }
}
