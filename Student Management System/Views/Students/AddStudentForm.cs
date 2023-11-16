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
        
        public AddStudentForm(user user)
        {
            InitializeComponent();
            _user = user;
            stdController = new StudentController();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            rbtnMale.Checked = true;

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                DepartmentController departController = new DepartmentController();
                ClassController classController = new ClassController();
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
                string.IsNullOrEmpty(EduType) ||
                string.IsNullOrEmpty(StudentName) ||
                string.IsNullOrEmpty(parsedYear.ToString()) )
            {
                MessageBox.Show("Please fill in all fields", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(Department == null)
            {
                MessageBox.Show("Please select a valid department", "Invalid department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClassName == null)
            {
                MessageBox.Show("Please select a valid class", "Invalid class", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Major == null)
            {
                MessageBox.Show("Please select a valid major", "Invalid major", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!yearRegEx.IsMatch(CourseYear) || parsedYear > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid course year", "Invalid course year", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (isAdded) { 
                MessageBox.Show("Student Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                StudentForm_Reload(); 
                this.Close(); 
            }
            else MessageBox.Show("Failed to add", "" , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void inputDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                if (inputDepartment.SelectedItem != null)
                {
                    MajorController majorController = new MajorController();
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
                studentForm.RefreshGridView("");
        }
    }
}
