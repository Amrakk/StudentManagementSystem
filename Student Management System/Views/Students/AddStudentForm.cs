using Student_Management_System.Controllers;
using Student_Management_System.Database;
using Student_Management_System.Views.Admin;
using Student_Management_System.Views.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AddStudentForm : Form
    {
        private user _user;
        StudentController stdController;
        DepartmentController departController;
        ClassController classController;
        MajorController majorController;
        public AddStudentForm(user user)
        {
            InitializeComponent();
            _user = user;
            stdController = new StudentController();
            departController = new DepartmentController();
            classController = new ClassController();
            majorController = new MajorController();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            rbtnMale.Checked = true;
            inputEduType.Items.Add("Standard");
            inputEduType.Items.Add("High Quality");

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                var departments = departController.GetAll();
                inputDepartment.DataSource = departments;
                
                var classes = classController.GetAll();
                inputClass.DataSource = classes;
            }

            inputDepartment.ValueMember = "departId";
            inputDepartment.DisplayMember = "departName";

            inputClass.ValueMember = "classId";
            inputClass.DisplayMember = "classId";
                
            btnReset_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userRole = _user.role;
            if (userRole.Equals("Employee"))
            {
                MessageBox.Show("You are not authorized");
                return;
            }

            string StudentName = inputName.Texts;
            string EduType = inputEduType.SelectedItem as string;
            Department Department = inputDepartment.SelectedItem as Department;
            Class ClassName = inputClass.SelectedItem as Class;
            Major Major = inputMajor.SelectedItem as Major;

            Regex yearRegEx = new Regex(@"^\d{4}$");
            string CourseYear = inputCourseYear.Texts;
            string Gender = (rbtnMale.Checked) ? "Male" : "Female";
            DateTime Dob = inputDoB.Value.Date;

            int.TryParse(CourseYear, out int parsedYear);

            if (Dob == null||
                Major == null||
                ClassName == null ||
                Department == null ||
                string.IsNullOrEmpty(EduType) ||
                string.IsNullOrEmpty(StudentName) ||
                string.IsNullOrEmpty(parsedYear.ToString()) )
            {
                MessageBox.Show("Please fill all fields");
                return;
            }


            if (!yearRegEx.IsMatch(CourseYear) || parsedYear > DateTime.Now.Year)
            {
                MessageBox.Show("Invalid course year");
                return;
            }

            var student = new student()
            {
                name = StudentName,
                gender = Gender,
                eduType = EduType,
                className = ClassName.classId,
                department = Department.departId,
                major = Major.majorId,
                dob = Dob,
                courseYear = CourseYear,
                createdAt = DateTime.Now
            };

            bool isAdded = stdController.Add(student);

            if (isAdded) { MessageBox.Show("Student Added"); StudentForm_Reload(); this.Close(); }
            else MessageBox.Show("Failed to add");
        }

        private void inputDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                if (inputDepartment.SelectedItem != null)
                {
                    Department department = inputDepartment.SelectedItem as Department;
                    var majors = majorController.GetAllByDepartment(department.departId);
                    inputMajor.Texts = "";
                    
                    inputMajor.ValueMember = "majorId";
                    inputMajor.DisplayMember = "majorName";

                    inputMajor.DataSource = majors;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputName.Texts = "";
            rbtnMale.Checked = true;
            inputCourseYear.Texts = "";
            inputDoB.Value = DateTime.Now;
            inputClass.SelectedIndex = 0;
            inputEduType.SelectedIndex = 0;
            inputDepartment.SelectedIndex = 0;
        }

        private void StudentForm_Reload()
        {
            if (Application.OpenForms["StudentForm"] is StudentForm studentForm)
                studentForm.RefreshGridView();
        }
    }
}
