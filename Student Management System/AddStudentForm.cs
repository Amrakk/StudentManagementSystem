using DevExpress.XtraEditors.Filtering.Templates;
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

namespace Student_Management_System
{
    public partial class AddStudentForm : Form
    {
        private user _user;
        public AddStudentForm(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            rbtnMale.Checked = true;
            cbbEduType.Items.Add("Standard");
            cbbEduType.Items.Add("High Quality");

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                var departments = (from dp in db.Departments select dp).ToList();
                cbbDepartment.DataSource = departments;
                
                var classes = (from c in db.Classes select c).ToList();
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

            try
            {
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    int count = (from row in db.students select row).Count();
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

                    db.students.InsertOnSubmit(student);
                    db.SubmitChanges();

                    MessageBox.Show("Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                if (cbbDepartment.SelectedValue != null)
                {
                    string selectedDepartmentId = cbbDepartment.SelectedValue.ToString();

                    var majors = (from m in db.Majors where m.department == selectedDepartmentId select m).ToList();

                    cbbMajor.ValueMember = "majorId";
                    cbbMajor.DisplayMember = "majorName";

                    cbbMajor.DataSource = majors;
                }
            }
        }
    }
}
