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
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            var students = stdController.GetAll();
            

            // Test export
            // SystemStudentUtils.ExportCsvFile("exported_students.csv", gettedStudents);
            // End test

            // Test import
            // var importedStudents = SystemStudentUtils.ImportCsvFile<student>("exported_students.csv");
            // dataGridView1.DataSource = importedStudents;
            // End test

            //Test excel
            //SystemStudentUtils.ExportToExcel("exported_excel_students.xlsx", studentData);

            gridViewStudent.DataSource = students;
        }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdForm = new AddStudentForm(_user);
            addStdForm.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {

        }
    }
}
