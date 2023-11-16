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

            RefreshGridView("");
        }

        private void gridViewUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string email = gridViewUser.Rows[e.RowIndex].Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
            UserDetailForm userDetailForm = new UserDetailForm(_user, email);
            userDetailForm.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!_user.role.Equals("Admin"))
            {
                MessageBox.Show("You have no authorization to do this operation", "Unauthorization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserDetailForm userDetailForm = new UserDetailForm(_user);
            userDetailForm.Show();
        }

        public void RefreshGridView(string text = "")
        {
            ICollection<user> users = null;

            if (string.IsNullOrEmpty(text)) users = userController.GetAll();
            else users = userController.GetUserByName(text);

            gridViewUser.DataSource = users;
        }

        public void RefreshGridView(int age = 0, string status = "", string role = "")
        {
            ICollection<user> users = userController.GetUserByCriteria(age, status, role);
            gridViewUser.DataSource = users;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = !panelFilter.Visible;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel|*.xlsx|CSV|*.csv";
            saveFileDialog.Title = "Export to";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                string extension = Path.GetExtension(saveFileDialog.FileName);
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    var users = db.users.ToList();
                    var userToExport = users.Select(u => new UserExport
                    {
                        Email = u.email,
                        Name = u.name,
                        Age = u.age,
                        DateOfBirth = u.dob?.ToString("dd-MM-yyyy") ?? "",
                        Status = u.status,
                        Role = u.role,
                        Phone = u.phone,
                        CreatedAt = u.createdAt?.ToString("dd-MM-yyyy") ?? "",
                        UpdatedAt = u.updatedAt?.ToString("dd-MM-yyyy") ?? ""
                    }).ToList();

                    try
                    {
                        if (extension.Equals(".xlsx"))
                        {
                            SystemStudentUtils.ExportToExcel(saveFileDialog.FileName, userToExport);
                        }
                        else if (extension.Equals(".csv"))
                        {
                            SystemStudentUtils.ExportCsvFile(saveFileDialog.FileName, userToExport);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Export successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to import?\nThis will remove all user from the database. Please be certain!", "Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel|*.xlsx|CSV|*.csv";
                openFileDialog.Title = "Import from";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    string extension = Path.GetExtension(openFileDialog.FileName);
                    using (var db = new MidTermDBDataContext(Program.ConnectionString))
                    {
                        Func<UserExport, user> userConvertFunction = record => new user
                        {
                            email = record.Email,
                            name = record.Name,
                            dob = SystemStudentUtils.ParseDate(record.DateOfBirth),
                            age = record.Age,
                            phone = record.Phone,
                            role = record.Role,
                            status = record.Status,
                            createdAt = SystemStudentUtils.ParseDate(record.CreatedAt),
                            updatedAt = SystemStudentUtils.ParseDate(record.UpdatedAt)
                        };

                        db.loginhistories.DeleteAllOnSubmit(db.loginhistories);
                        db.users.DeleteAllOnSubmit(db.users);

                        if (extension.Equals(".csv"))
                        {
                            try
                            {
                                var users = SystemStudentUtils.ImportCsvFile<user, UserExport>(openFileDialog.FileName, userConvertFunction);
                                if(users.Count == 0)
                                {
                                    MessageBox.Show("No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                users.ForEach(u => u.password = SystemStudentUtils.EncryptPassword(u.phone));
                                db.users.InsertAllOnSubmit(users);
                                db.SubmitChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else if (extension.Equals(".xlsx"))
                        {
                            try
                            {
                                var users = SystemStudentUtils.ImportExcelFile<user, UserExport>(openFileDialog.FileName, userConvertFunction);

                                if(users.Count == 0)
                                {
                                    MessageBox.Show("No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                users.ForEach(u => u.password = SystemStudentUtils.EncryptPassword(u.phone));
                                db.users.InsertAllOnSubmit(users);
                                db.SubmitChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    MessageBox.Show("Import successfully!\nAccounts password will be their phone number", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridView("");
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var text = inputSearch.Texts;

            if (string.IsNullOrEmpty(text) || text.Equals("Search by Name"))
                RefreshGridView("");
            else
                RefreshGridView(text);
        }

        private void inputSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputAge.Texts = "";
            inputStatus.Texts = "";
            inputRole.Texts = "";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var age = inputAge.Texts;
            var status = inputStatus.Texts;
            var role = inputRole.Texts;

            if(Int32.TryParse(age, out int ageInt))
                age = ageInt.ToString();
            else age = "0";

            RefreshGridView(Int32.Parse(age), status, role);
            panelFilter.Visible = false;
        }
    }
}
