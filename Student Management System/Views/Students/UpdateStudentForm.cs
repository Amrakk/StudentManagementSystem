using Student_Management_System.Controllers;
using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Views.Students
{
    public partial class UpdateStudentForm : Form
    {
        private student _student;
        StudentController stdController;
        DepartmentController departController;
        ClassController classController;
        MajorController majorController;
        public UpdateStudentForm(student student)
        {
            InitializeComponent();
            _student = student;
            stdController = new StudentController();
            departController = new DepartmentController();
            classController = new ClassController();
            majorController = new MajorController();
        }

        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                if (cbbDepartment.SelectedValue != null)
                {
                    string selectedDepartmentId = cbbDepartment.SelectedValue.ToString();

                    var majors = majorController.GetAllByDepartment(selectedDepartmentId);

                    cbbMajor.ValueMember = "majorId";
                    cbbMajor.DisplayMember = "majorName";

                    cbbMajor.DataSource = majors;
                }
            }
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            tbName.Text = _student.name;
            tbCourseYear.Text = _student.courseYear;
            inputDoB.Value = _student.dob.Value;

            if (_student.gender.ToLower().Equals("male")) 
            {
                rbtnMale.Checked = true;
            } else
            {
                rbtnFemale.Checked = true;
            }

            cbbEduType.Items.Add("Standard");
            cbbEduType.Items.Add("High Quality");

            var departments = departController.GetAll();
            cbbDepartment.DataSource = departments;

            var classes = classController.GetAll();
            cbbClass.DataSource = classes;

            cbbDepartment.ValueMember = "departId";
            cbbDepartment.DisplayMember = "departName";

            cbbMajor.ValueMember = "majorId";
            cbbMajor.DisplayMember = "majorName";

            cbbClass.ValueMember = "classId";
            cbbClass.DisplayMember = "className";

            cbbDepartment.SelectedValue = _student.department;
            cbbClass.SelectedValue = _student.className;
            cbbMajor.SelectedValue = _student.major;

            if (_student.eduType.ToLower().Equals("standard"))
            {
                cbbEduType.SelectedIndex = 0;
            }
            else
            {
                cbbEduType.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StudentName = tbName.Text;
            string EduType = cbbEduType.SelectedItem as string;
            string Department = cbbDepartment.SelectedValue as string;
            string ClassName = cbbClass.SelectedValue as string;
            string Major = cbbMajor.SelectedValue as string;

            Regex yearRegEx = new Regex(@"^\d{4}$");
            string CourseYear = tbCourseYear.Text;
            string Gender = (rbtnMale.Checked) ? "Male" : "Female";
            DateTime Dob = inputDoB.Value.Date;

            if (!yearRegEx.IsMatch(CourseYear))
            {
                MessageBox.Show("Check input again");
                return;
            }

            var updatedStudent = new student
            {
                id = _student.id,
                name = StudentName,
                eduType = EduType,
                department = Department,
                className = ClassName,
                major = Major,
                dob = Dob,
                courseYear = CourseYear,
                gender = Gender,
            };

            bool isUpdated = stdController.Update(updatedStudent);

            if (isUpdated)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }
    }
}
