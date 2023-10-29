using Student_Management_System.Controllers;
using Student_Management_System.Database;
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
            cbbEduType.Items.Add("Standard");
            cbbEduType.Items.Add("High Quality");

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                var departments = departController.GetAll();
                cbbDepartment.DataSource = departments;
                
                var classes = classController.GetAll();
                cbbClass.DataSource = classes;
            }

            cbbDepartment.ValueMember = "departId";
            cbbDepartment.DisplayMember = "departName";

            cbbMajor.ValueMember = "majorId";
            cbbMajor.DisplayMember = "majorName";

            cbbClass.ValueMember = "classId";
            cbbClass.DisplayMember = "classId";
            
            cbbEduType.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userRole = _user.role?.ToLower() ?? "";
            if (!userRole.Equals("admin") && !userRole.Equals("manager"))
            {
                MessageBox.Show("There is no authorization");
                return;
            }

            string StudentName = tbName.Text;
            string EduType = cbbEduType.SelectedItem as string;
            string Department = cbbDepartment.SelectedValue as string;
            string ClassName = cbbClass.SelectedValue as string;
            string Major = cbbMajor.SelectedValue as string;
            
            Regex yearRegEx = new Regex(@"^\d{4}$");
            string CourseYear = tbCourseYear.Text;
            string Gender = (rbtnMale.Checked) ? "Male" : "Female";
            DateTime Dob = inputDoB.Value.Date;

            int.TryParse(CourseYear, out int parsedYear);
            if (string.IsNullOrEmpty(StudentName) || !yearRegEx.IsMatch(CourseYear) || parsedYear > DateTime.Now.Year)
            {
                MessageBox.Show("Check inputs again");
                return;
            }

            int count = stdController.TotalStudents();
            string EduTypeCode = (EduType.Equals("Standard")) ? "" : "H";
            string Last2Digit = (parsedYear % 100).ToString();
            string formattedCount = count.ToString("D4");

            string SID = $"{Major}{Last2Digit}{EduTypeCode}{formattedCount}";
            var student = new student()
            {
                id = SID,
                name = StudentName,
                gender = Gender,
                eduType = EduType,
                className = ClassName,
                department = Department,
                major = Major,
                dob = Dob,
                courseYear = CourseYear,
                createdAt = DateTime.Now
            };

            bool isAdded = stdController.Add(student);

            if (isAdded)
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }

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
    }
}
