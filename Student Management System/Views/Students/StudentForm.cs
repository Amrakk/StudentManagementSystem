using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System.Controllers;
using Student_Management_System.Database;
using Student_Management_System.Views.Admin;

namespace Student_Management_System.Views.Students
{
    public partial class StudentForm : Form
    {
        private user _user;
        StudentController stdController;
        public StudentForm(user user)
        {
            InitializeComponent();
            _user = user;
            stdController = new StudentController();

            panelFilter.Hide();
            inputSearch.ForeColor = Color.Silver;
            inputSearch.Texts = "Search by Name";
            gridViewStudent.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            // Test export
            // SystemStudentUtils.ExportCsvFile("exported_students.csv", gettedStudents);
            // End test

            // Test import
            // var importedStudents = SystemStudentUtils.ImportCsvFile<student>("exported_students.csv");
            // dataGridView1.DataSource = importedStudents;
            // End test

            //Test excel
            //SystemStudentUtils.ExportToExcel("exported_excel_students.xlsx", studentData);

        }
        // Template 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userRole = _user.role.ToLower() ?? "";
            if (!userRole.Equals("admin") && !userRole.Equals("manager")) 
            {
                MessageBox.Show("You have no priority");
                return;
            }

            if (gridViewStudent.SelectedCells.Count == 0)
            {
                MessageBox.Show("No cell is selected", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedId = gridViewStudent.SelectedCells[0].Value?.ToString();

            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("The selected cell does not contain a valid Student ID", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var studentToDel = stdController.Get(selectedId);
            if (studentToDel == null)
            {
                MessageBox.Show("There is no student");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                bool isDeleted = stdController.Delete(studentToDel);

                if (isDeleted)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Failed to delete");
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm(_user);
            addStudentForm.Show();
        }

        public void RefreshGridView()
        {
            var students = stdController.GetAll();
            gridViewStudent.DataSource = students;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (panelFilter.Visible == true) panelFilter.Hide();
            else panelFilter.Show();
        }

        private void inputSearch_Enter(object sender, EventArgs e)
        {
            if (inputSearch.Texts == "Search by Name")
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



        // TODO: Export and Import (Find)
        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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

        private void gridViewStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string SID = gridViewStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            StudentDetailForm studentDetailForm = new StudentDetailForm(_user, SID);
            studentDetailForm.Show();
        }
    }
}
