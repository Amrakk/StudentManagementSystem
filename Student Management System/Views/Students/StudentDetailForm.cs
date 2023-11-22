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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Views.Students
{
    public partial class StudentDetailForm : Form
    {
        private user _user;
        private student _student;
        private CertificateController certController;
        private StudentController stdController;

        private certificate _selectedCert = null;

        public StudentDetailForm(user user, string SID)
        {
            InitializeComponent();

            this._user = user;

            stdController = new StudentController();
            certController = new CertificateController();

            _student = stdController.Get(SID);
            gridViewCertificate.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }

        private void StudentDetailForm_Load(object sender, EventArgs e)
        {
            DepartmentController departController = new DepartmentController();
            ClassController classController = new ClassController();
            var departments = departController.GetAll();
            inputDepartment.DataSource = departments;

            var classes = classController.GetAll();
            inputClass.DataSource = classes;

            inputDepartment.ValueMember = "departId";
            inputDepartment.DisplayMember = "departName";

            inputClass.ValueMember = "classId";
            inputClass.DisplayMember = "classId";

            RefreshGridView();
            btnStuReset_Click(sender, e);
            btnCertReset_Click(sender, e);
        }

        #region Student

        private void btnStuReset_Click(object sender, EventArgs e)
        {
            inputStuID.Texts = _student.id;
            inputName.Texts = _student.name;
            inputDoB.Value = _student.dob.Value.Date;
            if(_student.gender.Equals("Male"))
                rbtnMale.Checked = true;
            else
                rbtnFemale.Checked = true;

            inputCourseYear.Texts = _student.courseYear;

            var eduTypeIndex = inputEduType.Items.IndexOf(_student.eduType);
            inputEduType.SelectedIndex = eduTypeIndex;
    
            var departmentList = inputDepartment.DataSource as List<Department>;    
            var departIndex = departmentList.FindIndex(x => x.departId == _student.department);
            inputDepartment.SelectedIndex = departIndex;

            var classList = inputClass.DataSource as List<Class>;
            var classIndex = classList.FindIndex(x => x.classId == _student.className);
            inputClass.SelectedIndex = classIndex;

            inputDepartment_OnSelectedIndexChanged(sender, e);
            var majorList = inputMajor.DataSource as List<Major>;
            var majorIndex = majorList.FindIndex(x => x.majorId == _student.major);
            inputMajor.SelectedIndex = majorIndex;

            inputStuCreatedAt.Texts = _student.createdAt?.ToString("dd-MM-yyyy");
            inputStuUpdatedAt.Texts = _student.updatedAt?.ToString("dd-MM-yyyy");
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

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            string userRole = _user.role;
            if (userRole.Equals("Employee"))
            {
                MessageBox.Show("You are not authorized to do this operation", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {   
                try
                {
                    stdController.Delete(_student);
                    MessageBox.Show("Delete student successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentForm_Reload();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Delete student failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void btnStuAdd_Click(object sender, EventArgs e)
        {
            string userRole = _user.role;
            if (userRole.Equals("Employee"))
            {
                MessageBox.Show("You are not authorized to do this operation", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = inputStuID.Texts;
            var name = inputName.Texts;
            var dob = inputDoB.Value.Date;
            var gender = (rbtnMale.Checked) ? "Male" : "Female";
            var eduType = inputEduType.Texts;
            Department department = inputDepartment.SelectedItem as Department;
            Major major = inputMajor.SelectedItem as Major;
            Class className = inputClass.SelectedItem as Class;

            Regex yearRegEx = new Regex(@"^\d{4}$");
            var courseYear = inputCourseYear.Texts;
            int.TryParse(courseYear, out int parsedYear);

            #region Validation
            if (
                string.IsNullOrEmpty(id) || 
                string.IsNullOrEmpty(name) || 
                string.IsNullOrEmpty(eduType) || 
                string.IsNullOrEmpty(courseYear)
            )
            {
                MessageBox.Show("Please fill in all fields!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(department == null)
            {
                MessageBox.Show("Please select a valid department!", "Invalid department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (major == null)
            {
                MessageBox.Show("Please select a valid major!", "Invalid major", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (className == null)
            {
                MessageBox.Show("Please select a valid class", "Invalid class", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dob >= DateTime.Now)
            {
                MessageBox.Show("Date of birth must be less than current date!", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!yearRegEx.IsMatch(courseYear) || parsedYear > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid course year", "Invalid course year", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            _student.name = name;
            _student.dob = dob;
            _student.gender = gender;
            _student.eduType = eduType;
            _student.department = department.departId;
            _student.major = major.majorId;
            _student.className = className.classId;
            _student.courseYear = courseYear;
            _student.updatedAt = DateTime.Now;

            try
            {
                stdController.Update(_student);
                MessageBox.Show("Update student successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentForm_Reload();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Update student failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void StudentForm_Reload()
        {
            if (Application.OpenForms["StudentForm"] is StudentForm studentForm)
                studentForm.RefreshGridView("");
        }

        #endregion

        #region Certificate
        private void btnCertSave_Click(object sender, EventArgs e)
        {
            string userRole = _user.role;
            if (userRole.Equals("Employee"))
            {
                MessageBox.Show("You are not authorized to do this operation", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var certID = inputCertID.Texts;
            var title = inputCertTitle.Texts;
            var description = inputDescription.Texts;
            var issueDate = inputCertIssueDate.Value.Date;
            var expiredDate = inputCertExpiredDate.Value.Date;
            var organization = inputCertOrganization.Texts;
            var isValid = inputCertIsValid.Checked;
            var createdAt = DateTime.Now;

            if(
                issueDate == null ||
                expiredDate == null ||
                string.IsNullOrEmpty(certID) ||
                string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(description) ||
                string.IsNullOrEmpty(organization)
                                                                        )
            {
                MessageBox.Show("Please fill in all fields!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(issueDate > expiredDate)
            {
                MessageBox.Show("Issue date must be less than expired date!", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            certificate cert = new certificate
            {
                id = certID,
                title = title,
                description = description,
                issue_date = issueDate,
                expiry_date = expiredDate,
                organization_name = organization,
                isValid = isValid,
                sid = _student.id,
                createdAt = createdAt,
                updatedAt = null
            };

            if (_selectedCert == null)
            {
                var existCert = certController.Get(certID);
                if (existCert != null)
                {
                    MessageBox.Show("This certificate ID already exists!", "Invalid certificate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    certController.Add(cert);
                    MessageBox.Show("Add certificate successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridView();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Add certificate failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                cert.updatedAt = DateTime.Now;
                try
                {
                    certController.Update(cert);
                    MessageBox.Show("Update certificate successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridView();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Update certificate failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshGridView()
        {
            var certificates = certController.GetAllByStudent(_student);
            gridViewCertificate.DataSource = certificates;
        }

        private void btnCertReset_Click(object sender, EventArgs e)
        {
            if(_selectedCert == null)
            {
                labelStatus.Text = "Adding...";
                btnCertSave.Text = "ADD";

                inputCertID.Enabled = true;
                inputCertID.Texts = "";
                inputCertTitle.Texts = "";
                inputDescription.Texts = "";
                inputCertIssueDate.Value = DateTime.Now;
                inputCertExpiredDate.Value = DateTime.Now;
                inputCertOrganization.Texts = "";
                inputCertIsValid.Checked = false;
                inputCertCreatedAt.Texts = DateTime.Now.ToString("dd-MM-yyyy");
                inputCertUpdatedAt.Texts = "";
            }
            else
            {
                labelStatus.Text = "Editing...";
                btnCertSave.Text = "EDIT";

                inputCertID.Enabled = false;
                inputCertID.Texts = _selectedCert.id;
                inputCertTitle.Texts = _selectedCert.title;
                inputDescription.Texts = _selectedCert.description;
                inputCertIssueDate.Value = _selectedCert.issue_date.Value.Date;
                inputCertExpiredDate.Value = _selectedCert.expiry_date.Value.Date;
                inputCertOrganization.Texts = _selectedCert.organization_name;
                inputCertIsValid.Checked = _selectedCert.isValid.Value;
                inputCertCreatedAt.Texts = _selectedCert.createdAt?.ToString("dd-MM-yyyy");
                inputCertUpdatedAt.Texts = _selectedCert.updatedAt?.ToString("dd-MM-yyyy");
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

            inputCertID.Focus();
            _selectedCert = null;
            btnCertReset_Click(sender, e);
        }

        private void gridViewCertificate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string certID = gridViewCertificate.Rows[e.RowIndex].Cells["id"].Value.ToString();
            _selectedCert = certController.Get(certID);
            btnCertReset_Click(sender, e);
        }

        private void btnDeleteCertificate_Click(object sender, EventArgs e)
        {
            string userRole = _user.role;
            if (userRole.Equals("Employee"))
            {
                MessageBox.Show("You are not authorized to do this operation", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this certificate?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    certController.Delete(_selectedCert);
                    MessageBox.Show("Delete certificate successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridView();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Delete certificate failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    var certificates = db.certificates.ToList();
                    var certificatesToExport = certificates.Select(s => new CertificateExport
                    {
                        CertificateID = s.id,
                        Title = s.title,
                        Description = s.description,
                        IssueDate = s.issue_date?.ToString("dd-MM-yyyy"),
                        ExpiryDate = s.expiry_date?.ToString("dd-MM-yyyy"),
                        OrganizationName = s.organization_name,
                        IsValid = s.isValid,
                        SID = s.sid,
                        CreatedAt = s.createdAt?.ToString("dd-MM-yyyy"),
                        UpdatedAt = s.updatedAt?.ToString("dd-MM-yyyy")
                    }).ToList();

                    try
                    {
                        if (extension.Equals(".xlsx"))
                        {
                            SystemStudentUtils.ExportToExcel(saveFileDialog.FileName, certificatesToExport);
                        }
                        else if (extension.Equals(".csv"))
                        {
                            SystemStudentUtils.ExportCsvFile(saveFileDialog.FileName, certificatesToExport);
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
            string userRole = _user.role;
            if (userRole.Equals("Employee"))
            {
                MessageBox.Show("You are not authorized to do this operation", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure to import?\nThis will remove all certificates from the database. Please be certain!", "Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                        Func<CertificateExport, certificate> certConvertFunction = record => new certificate
                        {
                            id = record.CertificateID,
                            title = record.Title,
                            description = record.Description,
                            issue_date = SystemStudentUtils.ParseDate(record.IssueDate),
                            expiry_date = SystemStudentUtils.ParseDate(record.ExpiryDate),
                            organization_name = record.OrganizationName,
                            isValid = record.IsValid,
                            sid = record.SID,
                            createdAt = SystemStudentUtils.ParseDate(record.CreatedAt),
                            updatedAt = SystemStudentUtils.ParseDate(record.UpdatedAt)
                        };
                        
                        db.certificates.DeleteAllOnSubmit(db.certificates);

                        if (extension.Equals(".csv"))
                        {
                            try
                            {
                                var certificates = SystemStudentUtils.ImportCsvFile<certificate, CertificateExport>(openFileDialog.FileName, certConvertFunction);
                                if (certificates.Count == 0)
                                {
                                    MessageBox.Show("No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                db.certificates.InsertAllOnSubmit(certificates);
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
                                var certificates = SystemStudentUtils.ImportExcelFile<certificate, CertificateExport>(openFileDialog.FileName, certConvertFunction);
                                if (certificates.Count == 0)
                                {
                                    MessageBox.Show("No record found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                db.certificates.InsertAllOnSubmit(certificates);
                                db.SubmitChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    MessageBox.Show("Import successfully", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridView();
                }
            }
        }

        #endregion
    }
}
