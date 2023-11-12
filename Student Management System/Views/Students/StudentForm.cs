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
            var gettedStudents = stdController.GetAll().ToList();
            var studentData = gettedStudents.Select(s => new
            {
                SID = s.id,
                Name = s.name,
                Gender = s.gender,
                Dob = s.dob,
                Class = s.className,
                Type = s.eduType,
                Department = s.Department1.departName,
                Major = s.Major1.majorName,
                CourseYear = s.courseYear,
                Created = s.createdAt,
                Updated = s.updatedAt,
            }).ToList();

            // Test export
            // SystemStudentUtils.ExportCsvFile("exported_students.csv", gettedStudents);
            // End test

            // Test import
            // var importedStudents = SystemStudentUtils.ImportCsvFile<student>("exported_students.csv");
            // dataGridView1.DataSource = importedStudents;
            // End test

            // Test excel
            // SystemStudentUtils.ExportToExcel("exported_excel_students.xlsx", studentData);

            dataGridView1.DataSource = studentData;
            dataGridView1.Columns["courseYear"].HeaderText = "Course Year";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userRole = _user.role.ToLower() ?? "";
            if (!userRole.Equals("admin") && !userRole.Equals("manager")) 
            {
                MessageBox.Show("You have no permission");
                return;
            }

            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("No cell is selected", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedId = dataGridView1.SelectedCells[0].Value?.ToString();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userRole = _user.role.ToLower() ?? "";
            if (!userRole.Equals("admin") && !userRole.Equals("manager"))
            {
                MessageBox.Show("You have no priority");
                return;
            }

            string selectedId = dataGridView1.SelectedCells[0].Value?.ToString();

            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("The selected cell does not contain a valid Student ID", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var studentToUpdate = stdController.Get(selectedId);
            if (studentToUpdate == null)
            {
                MessageBox.Show("There is no student");
                return;
            }

            UpdateStudentForm updateStudentForm = new UpdateStudentForm(studentToUpdate);
            updateStudentForm.Show();
        }
    }
}
