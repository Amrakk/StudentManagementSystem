﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
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
            RefreshGridView("");

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                DepartmentController departController = new DepartmentController();

                var departments = departController.GetAll();
                inputDepartment.DataSource = departments;
                inputDepartment.ValueMember = "departId";
                inputDepartment.DisplayMember = "departName";

                inputDepartment.SelectedIndex = -1; 
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string userRole = _user.role;
            if (userRole.Equals("Employee"))
            {
                MessageBox.Show("You are not authorized to do this operation", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddStudentForm addStudentForm = new AddStudentForm(_user);
            addStudentForm.Show();
        }

        public void RefreshGridView(string text = "")
        {
            ICollection<student> students = null;

            if (string.IsNullOrEmpty(text)) students = stdController.GetAll();
            else students = stdController.GetStudentByName(text);

            gridViewStudent.DataSource = students;
        }
        
        public void RefreshGridView(string gender = "", string eduType = "", string department = "", string major = "")
        {
            MessageBox.Show(gender + ", " + eduType + ", " + department + ", " + major);
            ICollection<student> students = stdController.GetStudentByCriteria(gender, eduType, department, major);
            gridViewStudent.DataSource = students;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = !panelFilter.Visible;
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
                    var students = db.students.ToList();

                    // TODO: Remove unnecessary data


                    if (extension.Equals(".xlsx"))
                    {
                        SystemStudentUtils.ExportToExcel<student>(saveFileDialog.FileName, students);
                    }
                    else if (extension.Equals(".csv"))
                    {
                        SystemStudentUtils.ExportCsvFile<student>(saveFileDialog.FileName, students);
                    }
                }

                MessageBox.Show("Export successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // TODO: Import (duplicate key error when import)
        private void btnImport_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are you sure to import?\nThis will remove all students from the database. Please be certain!", "Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    return;

            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.Filter = "Excel|*.xlsx|CSV|*.csv";
            //    openFileDialog.Title = "Import from";
            //    openFileDialog.ShowDialog();

            //    if (openFileDialog.FileName != "")
            //    {
            //        string extension = Path.GetExtension(openFileDialog.FileName);
            //        using (var db = new MidTermDBDataContext(Program.ConnectionString))
            //        {

            //            //if (extension.Equals(".xlsx"))
            //            //{
            //            //    var users = SystemStudentUtils.ImportExcelFile<user>(openFileDialog.FileName);
            //            //    users.ForEach(u => u.password = SystemStudentUtils.EncryptPassword(u.password));
            //            //    db.users.InsertAllOnSubmit(users);
            //            //    db.SubmitChanges();
            //            //}
            //            if (extension.Equals(".csv"))
            //            {
            //                db.students.DeleteAllOnSubmit(db.students);
            //                var students = SystemStudentUtils.ImportCsvFile<student>(openFileDialog.FileName);
            //                db.students.InsertAllOnSubmit(students);
            //                db.SubmitChanges();
            //            }
            //        }

            //        MessageBox.Show("Import successfully", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            MessageBox.Show("This function is not available yet", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gridViewStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string SID = gridViewStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            StudentDetailForm studentDetailForm = new StudentDetailForm(_user, SID);
            studentDetailForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputGender.Texts = "";
            inputEduType.Texts = "";
            inputDepartment.Texts = "";
            inputMajor.Texts = "";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var gender = inputGender.SelectedItem as string;
            var eduType = inputEduType.SelectedItem as string;
            var department = inputDepartment.SelectedItem as Department;
            var major = inputMajor.SelectedItem as Major;

            var departId = department?.departId; 
            var majorId = major?.majorId;

            if(string.IsNullOrEmpty(departId))
            {
                departId = "";
                majorId = "";
            }

            if(string.IsNullOrEmpty(majorId)) majorId = "";

            RefreshGridView(gender, eduType, departId, majorId);    
            panelFilter.Visible = false;
        }

        private void inputDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                MajorController majorController = new MajorController();
                if (inputDepartment.SelectedItem != null)
                {
                    Department department = inputDepartment.SelectedItem as Department;
                    var majors = majorController.GetAllByDepartment(department.departId);

                    inputMajor.ValueMember = "majorId";
                    inputMajor.DisplayMember = "majorName";
                    inputMajor.DataSource = majors;
                    inputMajor.SelectedIndex = -1;
                }
            }
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
