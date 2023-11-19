namespace Student_Management_System.Views.Students
{
    partial class StudentDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grBoxProfile = new System.Windows.Forms.GroupBox();
            this.labelStuUpdatedAt = new System.Windows.Forms.Label();
            this.inputStuID = new Student_Management_System.Views.CustomControls.Input();
            this.labelStuCreatedAt = new System.Windows.Forms.Label();
            this.inputStuCreatedAt = new Student_Management_System.Views.CustomControls.Input();
            this.labelStuID = new System.Windows.Forms.Label();
            this.inputStuUpdatedAt = new Student_Management_System.Views.CustomControls.Input();
            this.btnStuReset = new System.Windows.Forms.Button();
            this.btnStuAdd = new System.Windows.Forms.Button();
            this.inputCourseYear = new Student_Management_System.Views.CustomControls.Input();
            this.labelCourseYear = new System.Windows.Forms.Label();
            this.inputMajor = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelMajor = new System.Windows.Forms.Label();
            this.inputClass = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelClass = new System.Windows.Forms.Label();
            this.inputDepartment = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.inputEduType = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelEduType = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.inputDoB = new Student_Management_System.Views.CustomControls.DateTimeInput();
            this.labelDoB = new System.Windows.Forms.Label();
            this.inputName = new Student_Management_System.Views.CustomControls.Input();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCertUpdatedAt = new System.Windows.Forms.Label();
            this.labelCertCreatedAt = new System.Windows.Forms.Label();
            this.grBoxDeleteStudent = new System.Windows.Forms.GroupBox();
            this.panelDeleteAccount = new System.Windows.Forms.Panel();
            this.labelStuWarningMessage = new System.Windows.Forms.Label();
            this.labelDeleteStudent = new Student_Management_System.Views.CustomControls.Input();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.grBoxCertificate = new System.Windows.Forms.GroupBox();
            this.inputDescription = new Student_Management_System.Views.CustomControls.Input();
            this.labelStatus = new System.Windows.Forms.Label();
            this.gridViewCertificate = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCertReset = new System.Windows.Forms.Button();
            this.btnCertSave = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.inputCertIsValid = new System.Windows.Forms.CheckBox();
            this.labelIsValid = new System.Windows.Forms.Label();
            this.inputCertOrganization = new Student_Management_System.Views.CustomControls.Input();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.inputCertExpiredDate = new Student_Management_System.Views.CustomControls.DateTimeInput();
            this.inputCertCreatedAt = new Student_Management_System.Views.CustomControls.Input();
            this.labelExpiredDate = new System.Windows.Forms.Label();
            this.inputCertID = new Student_Management_System.Views.CustomControls.Input();
            this.inputCertUpdatedAt = new Student_Management_System.Views.CustomControls.Input();
            this.inputCertTitle = new Student_Management_System.Views.CustomControls.Input();
            this.labelCertID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.inputCertIssueDate = new Student_Management_System.Views.CustomControls.DateTimeInput();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.grBoxDeleteCertificate = new System.Windows.Forms.GroupBox();
            this.panelDeleteCertificate = new System.Windows.Forms.Panel();
            this.labelCertWarningMessage = new System.Windows.Forms.Label();
            this.labelDeleteCertificate = new Student_Management_System.Views.CustomControls.Input();
            this.btnDeleteCertificate = new System.Windows.Forms.Button();
            this.grBoxProfile.SuspendLayout();
            this.grBoxDeleteStudent.SuspendLayout();
            this.panelDeleteAccount.SuspendLayout();
            this.grBoxCertificate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).BeginInit();
            this.grBoxDeleteCertificate.SuspendLayout();
            this.panelDeleteCertificate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxProfile
            // 
            this.grBoxProfile.Controls.Add(this.labelStuUpdatedAt);
            this.grBoxProfile.Controls.Add(this.inputStuID);
            this.grBoxProfile.Controls.Add(this.labelStuCreatedAt);
            this.grBoxProfile.Controls.Add(this.inputStuCreatedAt);
            this.grBoxProfile.Controls.Add(this.labelStuID);
            this.grBoxProfile.Controls.Add(this.inputStuUpdatedAt);
            this.grBoxProfile.Controls.Add(this.btnStuReset);
            this.grBoxProfile.Controls.Add(this.btnStuAdd);
            this.grBoxProfile.Controls.Add(this.inputCourseYear);
            this.grBoxProfile.Controls.Add(this.labelCourseYear);
            this.grBoxProfile.Controls.Add(this.inputMajor);
            this.grBoxProfile.Controls.Add(this.labelMajor);
            this.grBoxProfile.Controls.Add(this.inputClass);
            this.grBoxProfile.Controls.Add(this.labelClass);
            this.grBoxProfile.Controls.Add(this.inputDepartment);
            this.grBoxProfile.Controls.Add(this.labelDepartment);
            this.grBoxProfile.Controls.Add(this.inputEduType);
            this.grBoxProfile.Controls.Add(this.labelEduType);
            this.grBoxProfile.Controls.Add(this.rbtnFemale);
            this.grBoxProfile.Controls.Add(this.labelGender);
            this.grBoxProfile.Controls.Add(this.rbtnMale);
            this.grBoxProfile.Controls.Add(this.inputDoB);
            this.grBoxProfile.Controls.Add(this.labelDoB);
            this.grBoxProfile.Controls.Add(this.inputName);
            this.grBoxProfile.Controls.Add(this.labelName);
            this.grBoxProfile.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxProfile.ForeColor = System.Drawing.Color.DimGray;
            this.grBoxProfile.Location = new System.Drawing.Point(30, 35);
            this.grBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.grBoxProfile.Name = "grBoxProfile";
            this.grBoxProfile.Padding = new System.Windows.Forms.Padding(4);
            this.grBoxProfile.Size = new System.Drawing.Size(942, 387);
            this.grBoxProfile.TabIndex = 1;
            this.grBoxProfile.TabStop = false;
            this.grBoxProfile.Text = "Profile";
            // 
            // labelStuUpdatedAt
            // 
            this.labelStuUpdatedAt.AutoSize = true;
            this.labelStuUpdatedAt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStuUpdatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelStuUpdatedAt.Location = new System.Drawing.Point(33, 335);
            this.labelStuUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStuUpdatedAt.Name = "labelStuUpdatedAt";
            this.labelStuUpdatedAt.Size = new System.Drawing.Size(73, 13);
            this.labelStuUpdatedAt.TabIndex = 71;
            this.labelStuUpdatedAt.Text = "UPDATED AT";
            // 
            // inputStuID
            // 
            this.inputStuID.BorderColor = System.Drawing.Color.DimGray;
            this.inputStuID.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputStuID.BorderSize = 1;
            this.inputStuID.Enabled = false;
            this.inputStuID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStuID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputStuID.Location = new System.Drawing.Point(162, 75);
            this.inputStuID.Margin = new System.Windows.Forms.Padding(5);
            this.inputStuID.Multiline = false;
            this.inputStuID.Name = "inputStuID";
            this.inputStuID.Padding = new System.Windows.Forms.Padding(5);
            this.inputStuID.PasswordChar = false;
            this.inputStuID.ReadOnly = false;
            this.inputStuID.Size = new System.Drawing.Size(178, 32);
            this.inputStuID.TabIndex = 1;
            this.inputStuID.Texts = "521H0350";
            this.inputStuID.Underlined = false;
            // 
            // labelStuCreatedAt
            // 
            this.labelStuCreatedAt.AutoSize = true;
            this.labelStuCreatedAt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStuCreatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelStuCreatedAt.Location = new System.Drawing.Point(33, 310);
            this.labelStuCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStuCreatedAt.Name = "labelStuCreatedAt";
            this.labelStuCreatedAt.Size = new System.Drawing.Size(70, 13);
            this.labelStuCreatedAt.TabIndex = 70;
            this.labelStuCreatedAt.Text = "CREATED AT";
            // 
            // inputStuCreatedAt
            // 
            this.inputStuCreatedAt.BorderColor = System.Drawing.SystemColors.Control;
            this.inputStuCreatedAt.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputStuCreatedAt.BorderSize = 1;
            this.inputStuCreatedAt.Enabled = false;
            this.inputStuCreatedAt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStuCreatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputStuCreatedAt.Location = new System.Drawing.Point(112, 305);
            this.inputStuCreatedAt.Margin = new System.Windows.Forms.Padding(5);
            this.inputStuCreatedAt.Multiline = false;
            this.inputStuCreatedAt.Name = "inputStuCreatedAt";
            this.inputStuCreatedAt.Padding = new System.Windows.Forms.Padding(5);
            this.inputStuCreatedAt.PasswordChar = false;
            this.inputStuCreatedAt.ReadOnly = true;
            this.inputStuCreatedAt.Size = new System.Drawing.Size(65, 25);
            this.inputStuCreatedAt.TabIndex = 68;
            this.inputStuCreatedAt.Texts = "29-10-2023";
            this.inputStuCreatedAt.Underlined = false;
            // 
            // labelStuID
            // 
            this.labelStuID.AutoSize = true;
            this.labelStuID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStuID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelStuID.Location = new System.Drawing.Point(32, 80);
            this.labelStuID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStuID.Name = "labelStuID";
            this.labelStuID.Size = new System.Drawing.Size(27, 21);
            this.labelStuID.TabIndex = 53;
            this.labelStuID.Text = "ID";
            // 
            // inputStuUpdatedAt
            // 
            this.inputStuUpdatedAt.BorderColor = System.Drawing.SystemColors.Control;
            this.inputStuUpdatedAt.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputStuUpdatedAt.BorderSize = 1;
            this.inputStuUpdatedAt.Enabled = false;
            this.inputStuUpdatedAt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStuUpdatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputStuUpdatedAt.Location = new System.Drawing.Point(112, 330);
            this.inputStuUpdatedAt.Margin = new System.Windows.Forms.Padding(5);
            this.inputStuUpdatedAt.Multiline = false;
            this.inputStuUpdatedAt.Name = "inputStuUpdatedAt";
            this.inputStuUpdatedAt.Padding = new System.Windows.Forms.Padding(5);
            this.inputStuUpdatedAt.PasswordChar = false;
            this.inputStuUpdatedAt.ReadOnly = true;
            this.inputStuUpdatedAt.Size = new System.Drawing.Size(65, 25);
            this.inputStuUpdatedAt.TabIndex = 69;
            this.inputStuUpdatedAt.Texts = "29-10-2023";
            this.inputStuUpdatedAt.Underlined = false;
            // 
            // btnStuReset
            // 
            this.btnStuReset.BackColor = System.Drawing.Color.Transparent;
            this.btnStuReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuReset.ForeColor = System.Drawing.Color.DimGray;
            this.btnStuReset.Location = new System.Drawing.Point(646, 321);
            this.btnStuReset.Name = "btnStuReset";
            this.btnStuReset.Size = new System.Drawing.Size(130, 36);
            this.btnStuReset.TabIndex = 43;
            this.btnStuReset.Text = "RESET";
            this.btnStuReset.UseVisualStyleBackColor = false;
            this.btnStuReset.Click += new System.EventHandler(this.btnStuReset_Click);
            // 
            // btnStuAdd
            // 
            this.btnStuAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStuAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnStuAdd.FlatAppearance.BorderSize = 0;
            this.btnStuAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStuAdd.Location = new System.Drawing.Point(786, 321);
            this.btnStuAdd.Name = "btnStuAdd";
            this.btnStuAdd.Size = new System.Drawing.Size(130, 36);
            this.btnStuAdd.TabIndex = 11;
            this.btnStuAdd.Text = "EDIT";
            this.btnStuAdd.UseVisualStyleBackColor = false;
            this.btnStuAdd.Click += new System.EventHandler(this.btnStuAdd_Click);
            // 
            // inputCourseYear
            // 
            this.inputCourseYear.BorderColor = System.Drawing.Color.DimGray;
            this.inputCourseYear.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputCourseYear.BorderSize = 1;
            this.inputCourseYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCourseYear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputCourseYear.Location = new System.Drawing.Point(162, 240);
            this.inputCourseYear.Margin = new System.Windows.Forms.Padding(5);
            this.inputCourseYear.Multiline = false;
            this.inputCourseYear.Name = "inputCourseYear";
            this.inputCourseYear.Padding = new System.Windows.Forms.Padding(5);
            this.inputCourseYear.PasswordChar = false;
            this.inputCourseYear.ReadOnly = false;
            this.inputCourseYear.Size = new System.Drawing.Size(178, 32);
            this.inputCourseYear.TabIndex = 6;
            this.inputCourseYear.Texts = "2021";
            this.inputCourseYear.Underlined = false;
            // 
            // labelCourseYear
            // 
            this.labelCourseYear.AutoSize = true;
            this.labelCourseYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseYear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCourseYear.Location = new System.Drawing.Point(32, 245);
            this.labelCourseYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseYear.Name = "labelCourseYear";
            this.labelCourseYear.Size = new System.Drawing.Size(99, 21);
            this.labelCourseYear.TabIndex = 51;
            this.labelCourseYear.Text = "Course Year";
            // 
            // inputMajor
            // 
            this.inputMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputMajor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputMajor.BorderColor = System.Drawing.Color.DimGray;
            this.inputMajor.BorderSize = 1;
            this.inputMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputMajor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMajor.ForeColor = System.Drawing.Color.DimGray;
            this.inputMajor.IconColor = System.Drawing.Color.DimGray;
            this.inputMajor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputMajor.ListTextColor = System.Drawing.Color.DimGray;
            this.inputMajor.Location = new System.Drawing.Point(614, 165);
            this.inputMajor.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputMajor.Name = "inputMajor";
            this.inputMajor.Padding = new System.Windows.Forms.Padding(1);
            this.inputMajor.Size = new System.Drawing.Size(302, 32);
            this.inputMajor.TabIndex = 8;
            this.inputMajor.Texts = "";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMajor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelMajor.Location = new System.Drawing.Point(444, 170);
            this.labelMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(55, 21);
            this.labelMajor.TabIndex = 50;
            this.labelMajor.Text = "Major";
            // 
            // inputClass
            // 
            this.inputClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputClass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputClass.BorderColor = System.Drawing.Color.DimGray;
            this.inputClass.BorderSize = 1;
            this.inputClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputClass.ForeColor = System.Drawing.Color.DimGray;
            this.inputClass.IconColor = System.Drawing.Color.DimGray;
            this.inputClass.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputClass.ListTextColor = System.Drawing.Color.DimGray;
            this.inputClass.Location = new System.Drawing.Point(614, 245);
            this.inputClass.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputClass.Name = "inputClass";
            this.inputClass.Padding = new System.Windows.Forms.Padding(1);
            this.inputClass.Size = new System.Drawing.Size(302, 32);
            this.inputClass.TabIndex = 10;
            this.inputClass.Texts = "";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelClass.Location = new System.Drawing.Point(444, 250);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(48, 21);
            this.labelClass.TabIndex = 49;
            this.labelClass.Text = "Class";
            // 
            // inputDepartment
            // 
            this.inputDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputDepartment.BorderColor = System.Drawing.Color.DimGray;
            this.inputDepartment.BorderSize = 1;
            this.inputDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.inputDepartment.IconColor = System.Drawing.Color.DimGray;
            this.inputDepartment.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputDepartment.ListTextColor = System.Drawing.Color.DimGray;
            this.inputDepartment.Location = new System.Drawing.Point(614, 120);
            this.inputDepartment.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Padding = new System.Windows.Forms.Padding(1);
            this.inputDepartment.Size = new System.Drawing.Size(302, 32);
            this.inputDepartment.TabIndex = 7;
            this.inputDepartment.Texts = "";
            this.inputDepartment.OnSelectedIndexChanged += new System.EventHandler(this.inputDepartment_OnSelectedIndexChanged);
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDepartment.Location = new System.Drawing.Point(444, 125);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(102, 21);
            this.labelDepartment.TabIndex = 48;
            this.labelDepartment.Text = "Department";
            // 
            // inputEduType
            // 
            this.inputEduType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputEduType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputEduType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputEduType.BorderColor = System.Drawing.Color.DimGray;
            this.inputEduType.BorderSize = 1;
            this.inputEduType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputEduType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEduType.ForeColor = System.Drawing.Color.DimGray;
            this.inputEduType.IconColor = System.Drawing.Color.DimGray;
            this.inputEduType.Items.AddRange(new object[] {
            "Standard",
            "High Quality",
            "Standard",
            "High Quality"});
            this.inputEduType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputEduType.ListTextColor = System.Drawing.Color.DimGray;
            this.inputEduType.Location = new System.Drawing.Point(614, 205);
            this.inputEduType.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputEduType.Name = "inputEduType";
            this.inputEduType.Padding = new System.Windows.Forms.Padding(1);
            this.inputEduType.Size = new System.Drawing.Size(302, 32);
            this.inputEduType.TabIndex = 9;
            this.inputEduType.Texts = "";
            // 
            // labelEduType
            // 
            this.labelEduType.AutoSize = true;
            this.labelEduType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEduType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEduType.Location = new System.Drawing.Point(444, 210);
            this.labelEduType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEduType.Name = "labelEduType";
            this.labelEduType.Size = new System.Drawing.Size(127, 21);
            this.labelEduType.TabIndex = 47;
            this.labelEduType.Text = "Education Type";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rbtnFemale.Location = new System.Drawing.Point(247, 205);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(78, 25);
            this.rbtnFemale.TabIndex = 5;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelGender.Location = new System.Drawing.Point(32, 205);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(65, 21);
            this.labelGender.TabIndex = 46;
            this.labelGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rbtnMale.Location = new System.Drawing.Point(162, 205);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(62, 25);
            this.rbtnMale.TabIndex = 4;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // inputDoB
            // 
            this.inputDoB.BorderColor = System.Drawing.Color.DimGray;
            this.inputDoB.BorderSize = 1;
            this.inputDoB.CustomFormat = "dd-MM-yyyy";
            this.inputDoB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDoB.Location = new System.Drawing.Point(162, 160);
            this.inputDoB.MinimumSize = new System.Drawing.Size(4, 32);
            this.inputDoB.Name = "inputDoB";
            this.inputDoB.Size = new System.Drawing.Size(225, 32);
            this.inputDoB.SkinColor = System.Drawing.SystemColors.Control;
            this.inputDoB.TabIndex = 3;
            this.inputDoB.TextColor = System.Drawing.Color.DimGray;
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDoB.Location = new System.Drawing.Point(32, 165);
            this.labelDoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(42, 21);
            this.labelDoB.TabIndex = 45;
            this.labelDoB.Text = "DoB";
            // 
            // inputName
            // 
            this.inputName.BorderColor = System.Drawing.Color.DimGray;
            this.inputName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputName.BorderSize = 1;
            this.inputName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputName.Location = new System.Drawing.Point(162, 120);
            this.inputName.Margin = new System.Windows.Forms.Padding(5);
            this.inputName.Multiline = false;
            this.inputName.Name = "inputName";
            this.inputName.Padding = new System.Windows.Forms.Padding(5);
            this.inputName.PasswordChar = false;
            this.inputName.ReadOnly = false;
            this.inputName.Size = new System.Drawing.Size(225, 32);
            this.inputName.TabIndex = 2;
            this.inputName.Texts = "Nguyen Hoang Duy";
            this.inputName.Underlined = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelName.Location = new System.Drawing.Point(32, 125);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 21);
            this.labelName.TabIndex = 44;
            this.labelName.Text = "NAME";
            // 
            // labelCertUpdatedAt
            // 
            this.labelCertUpdatedAt.AutoSize = true;
            this.labelCertUpdatedAt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCertUpdatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCertUpdatedAt.Location = new System.Drawing.Point(26, 294);
            this.labelCertUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCertUpdatedAt.Name = "labelCertUpdatedAt";
            this.labelCertUpdatedAt.Size = new System.Drawing.Size(73, 13);
            this.labelCertUpdatedAt.TabIndex = 30;
            this.labelCertUpdatedAt.Text = "UPDATED AT";
            // 
            // labelCertCreatedAt
            // 
            this.labelCertCreatedAt.AutoSize = true;
            this.labelCertCreatedAt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCertCreatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCertCreatedAt.Location = new System.Drawing.Point(26, 269);
            this.labelCertCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCertCreatedAt.Name = "labelCertCreatedAt";
            this.labelCertCreatedAt.Size = new System.Drawing.Size(70, 13);
            this.labelCertCreatedAt.TabIndex = 29;
            this.labelCertCreatedAt.Text = "CREATED AT";
            // 
            // grBoxDeleteStudent
            // 
            this.grBoxDeleteStudent.Controls.Add(this.panelDeleteAccount);
            this.grBoxDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxDeleteStudent.ForeColor = System.Drawing.Color.DimGray;
            this.grBoxDeleteStudent.Location = new System.Drawing.Point(30, 450);
            this.grBoxDeleteStudent.Name = "grBoxDeleteStudent";
            this.grBoxDeleteStudent.Size = new System.Drawing.Size(439, 194);
            this.grBoxDeleteStudent.TabIndex = 31;
            this.grBoxDeleteStudent.TabStop = false;
            // 
            // panelDeleteAccount
            // 
            this.panelDeleteAccount.Controls.Add(this.labelStuWarningMessage);
            this.panelDeleteAccount.Controls.Add(this.labelDeleteStudent);
            this.panelDeleteAccount.Controls.Add(this.btnDeleteStudent);
            this.panelDeleteAccount.Location = new System.Drawing.Point(52, 45);
            this.panelDeleteAccount.Name = "panelDeleteAccount";
            this.panelDeleteAccount.Size = new System.Drawing.Size(335, 119);
            this.panelDeleteAccount.TabIndex = 38;
            // 
            // labelStuWarningMessage
            // 
            this.labelStuWarningMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStuWarningMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelStuWarningMessage.ForeColor = System.Drawing.Color.DimGray;
            this.labelStuWarningMessage.Location = new System.Drawing.Point(0, 32);
            this.labelStuWarningMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStuWarningMessage.Name = "labelStuWarningMessage";
            this.labelStuWarningMessage.Size = new System.Drawing.Size(335, 51);
            this.labelStuWarningMessage.TabIndex = 35;
            this.labelStuWarningMessage.Text = "Once you delete the student, there is no going back. Please be certain.";
            this.labelStuWarningMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDeleteStudent
            // 
            this.labelDeleteStudent.BorderColor = System.Drawing.Color.DimGray;
            this.labelDeleteStudent.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.labelDeleteStudent.BorderSize = 1;
            this.labelDeleteStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDeleteStudent.Enabled = false;
            this.labelDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteStudent.ForeColor = System.Drawing.Color.Red;
            this.labelDeleteStudent.Location = new System.Drawing.Point(0, 0);
            this.labelDeleteStudent.Margin = new System.Windows.Forms.Padding(5);
            this.labelDeleteStudent.Multiline = false;
            this.labelDeleteStudent.Name = "labelDeleteStudent";
            this.labelDeleteStudent.Padding = new System.Windows.Forms.Padding(5);
            this.labelDeleteStudent.PasswordChar = false;
            this.labelDeleteStudent.ReadOnly = true;
            this.labelDeleteStudent.Size = new System.Drawing.Size(335, 32);
            this.labelDeleteStudent.TabIndex = 36;
            this.labelDeleteStudent.Texts = "Delete Student";
            this.labelDeleteStudent.Underlined = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteStudent.Location = new System.Drawing.Point(0, 83);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(335, 36);
            this.btnDeleteStudent.TabIndex = 37;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // grBoxCertificate
            // 
            this.grBoxCertificate.Controls.Add(this.inputDescription);
            this.grBoxCertificate.Controls.Add(this.labelStatus);
            this.grBoxCertificate.Controls.Add(this.gridViewCertificate);
            this.grBoxCertificate.Controls.Add(this.btnCreate);
            this.grBoxCertificate.Controls.Add(this.btnImport);
            this.grBoxCertificate.Controls.Add(this.btnExport);
            this.grBoxCertificate.Controls.Add(this.btnCertReset);
            this.grBoxCertificate.Controls.Add(this.btnCertSave);
            this.grBoxCertificate.Controls.Add(this.labelDescription);
            this.grBoxCertificate.Controls.Add(this.inputCertIsValid);
            this.grBoxCertificate.Controls.Add(this.labelIsValid);
            this.grBoxCertificate.Controls.Add(this.labelCertUpdatedAt);
            this.grBoxCertificate.Controls.Add(this.inputCertOrganization);
            this.grBoxCertificate.Controls.Add(this.labelCertCreatedAt);
            this.grBoxCertificate.Controls.Add(this.labelOrganization);
            this.grBoxCertificate.Controls.Add(this.inputCertExpiredDate);
            this.grBoxCertificate.Controls.Add(this.inputCertCreatedAt);
            this.grBoxCertificate.Controls.Add(this.labelExpiredDate);
            this.grBoxCertificate.Controls.Add(this.inputCertID);
            this.grBoxCertificate.Controls.Add(this.inputCertUpdatedAt);
            this.grBoxCertificate.Controls.Add(this.inputCertTitle);
            this.grBoxCertificate.Controls.Add(this.labelCertID);
            this.grBoxCertificate.Controls.Add(this.labelTitle);
            this.grBoxCertificate.Controls.Add(this.inputCertIssueDate);
            this.grBoxCertificate.Controls.Add(this.labelIssueDate);
            this.grBoxCertificate.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCertificate.ForeColor = System.Drawing.Color.DimGray;
            this.grBoxCertificate.Location = new System.Drawing.Point(1012, 35);
            this.grBoxCertificate.Margin = new System.Windows.Forms.Padding(4);
            this.grBoxCertificate.Name = "grBoxCertificate";
            this.grBoxCertificate.Padding = new System.Windows.Forms.Padding(4);
            this.grBoxCertificate.Size = new System.Drawing.Size(780, 833);
            this.grBoxCertificate.TabIndex = 4;
            this.grBoxCertificate.TabStop = false;
            this.grBoxCertificate.Text = "Certificate";
            // 
            // inputDescription
            // 
            this.inputDescription.BorderColor = System.Drawing.Color.DimGray;
            this.inputDescription.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputDescription.BorderSize = 1;
            this.inputDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputDescription.Location = new System.Drawing.Point(29, 199);
            this.inputDescription.Margin = new System.Windows.Forms.Padding(5);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Padding = new System.Windows.Forms.Padding(5);
            this.inputDescription.PasswordChar = false;
            this.inputDescription.ReadOnly = false;
            this.inputDescription.Size = new System.Drawing.Size(303, 32);
            this.inputDescription.TabIndex = 72;
            this.inputDescription.Texts = "Overall 6.5";
            this.inputDescription.Underlined = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelStatus.Location = new System.Drawing.Point(656, 43);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(90, 25);
            this.labelStatus.TabIndex = 71;
            this.labelStatus.Text = "Editing...";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridViewCertificate
            // 
            this.gridViewCertificate.AllowUserToAddRows = false;
            this.gridViewCertificate.AllowUserToDeleteRows = false;
            this.gridViewCertificate.AutoGenerateColumns = false;
            this.gridViewCertificate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCertificate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.organizationnameDataGridViewTextBoxColumn,
            this.isValidDataGridViewTextBoxColumn,
            this.issue_date,
            this.expiry_date,
            this.id});
            this.gridViewCertificate.DataSource = this.certificateBindingSource;
            this.gridViewCertificate.Location = new System.Drawing.Point(29, 460);
            this.gridViewCertificate.Name = "gridViewCertificate";
            this.gridViewCertificate.ReadOnly = true;
            this.gridViewCertificate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCertificate.Size = new System.Drawing.Size(717, 336);
            this.gridViewCertificate.TabIndex = 70;
            this.gridViewCertificate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCertificate_CellClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 139;
            // 
            // organizationnameDataGridViewTextBoxColumn
            // 
            this.organizationnameDataGridViewTextBoxColumn.DataPropertyName = "organization_name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.organizationnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.organizationnameDataGridViewTextBoxColumn.HeaderText = "Organization";
            this.organizationnameDataGridViewTextBoxColumn.Name = "organizationnameDataGridViewTextBoxColumn";
            this.organizationnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.organizationnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // isValidDataGridViewTextBoxColumn
            // 
            this.isValidDataGridViewTextBoxColumn.DataPropertyName = "isValid";
            this.isValidDataGridViewTextBoxColumn.HeaderText = "Valid";
            this.isValidDataGridViewTextBoxColumn.Name = "isValidDataGridViewTextBoxColumn";
            this.isValidDataGridViewTextBoxColumn.ReadOnly = true;
            this.isValidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isValidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isValidDataGridViewTextBoxColumn.Width = 70;
            // 
            // issue_date
            // 
            this.issue_date.DataPropertyName = "issue_date";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.issue_date.DefaultCellStyle = dataGridViewCellStyle3;
            this.issue_date.HeaderText = "Issue Date";
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
            this.issue_date.Width = 145;
            // 
            // expiry_date
            // 
            this.expiry_date.DataPropertyName = "expiry_date";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.expiry_date.DefaultCellStyle = dataGridViewCellStyle4;
            this.expiry_date.HeaderText = "Expired Date";
            this.expiry_date.Name = "expiry_date";
            this.expiry_date.ReadOnly = true;
            this.expiry_date.Width = 145;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // certificateBindingSource
            // 
            this.certificateBindingSource.DataSource = typeof(Student_Management_System.Database.certificate);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreate.Location = new System.Drawing.Point(629, 395);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 41);
            this.btnCreate.TabIndex = 69;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.DimGray;
            this.btnImport.Location = new System.Drawing.Point(494, 395);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(117, 41);
            this.btnImport.TabIndex = 68;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.DimGray;
            this.btnExport.Location = new System.Drawing.Point(360, 395);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(117, 41);
            this.btnExport.TabIndex = 67;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCertReset
            // 
            this.btnCertReset.BackColor = System.Drawing.Color.Transparent;
            this.btnCertReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertReset.ForeColor = System.Drawing.Color.DimGray;
            this.btnCertReset.Location = new System.Drawing.Point(476, 280);
            this.btnCertReset.Name = "btnCertReset";
            this.btnCertReset.Size = new System.Drawing.Size(130, 36);
            this.btnCertReset.TabIndex = 55;
            this.btnCertReset.Text = "RESET";
            this.btnCertReset.UseVisualStyleBackColor = false;
            this.btnCertReset.Click += new System.EventHandler(this.btnCertReset_Click);
            // 
            // btnCertSave
            // 
            this.btnCertSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCertSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCertSave.FlatAppearance.BorderSize = 0;
            this.btnCertSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCertSave.Location = new System.Drawing.Point(616, 280);
            this.btnCertSave.Name = "btnCertSave";
            this.btnCertSave.Size = new System.Drawing.Size(130, 36);
            this.btnCertSave.TabIndex = 8;
            this.btnCertSave.Text = "EDIT";
            this.btnCertSave.UseVisualStyleBackColor = false;
            this.btnCertSave.Click += new System.EventHandler(this.btnCertSave_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDescription.Location = new System.Drawing.Point(25, 170);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(114, 21);
            this.labelDescription.TabIndex = 66;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // inputCertIsValid
            // 
            this.inputCertIsValid.AutoSize = true;
            this.inputCertIsValid.Location = new System.Drawing.Point(521, 87);
            this.inputCertIsValid.Name = "inputCertIsValid";
            this.inputCertIsValid.Size = new System.Drawing.Size(15, 14);
            this.inputCertIsValid.TabIndex = 3;
            this.inputCertIsValid.UseVisualStyleBackColor = true;
            // 
            // labelIsValid
            // 
            this.labelIsValid.AutoSize = true;
            this.labelIsValid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsValid.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelIsValid.Location = new System.Drawing.Point(373, 80);
            this.labelIsValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIsValid.Name = "labelIsValid";
            this.labelIsValid.Size = new System.Drawing.Size(74, 21);
            this.labelIsValid.TabIndex = 64;
            this.labelIsValid.Text = "IS VALID";
            // 
            // inputCertOrganization
            // 
            this.inputCertOrganization.BorderColor = System.Drawing.Color.DimGray;
            this.inputCertOrganization.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputCertOrganization.BorderSize = 1;
            this.inputCertOrganization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCertOrganization.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputCertOrganization.Location = new System.Drawing.Point(521, 199);
            this.inputCertOrganization.Margin = new System.Windows.Forms.Padding(5);
            this.inputCertOrganization.Multiline = false;
            this.inputCertOrganization.Name = "inputCertOrganization";
            this.inputCertOrganization.Padding = new System.Windows.Forms.Padding(5);
            this.inputCertOrganization.PasswordChar = false;
            this.inputCertOrganization.ReadOnly = false;
            this.inputCertOrganization.Size = new System.Drawing.Size(225, 32);
            this.inputCertOrganization.TabIndex = 7;
            this.inputCertOrganization.Texts = "British Council";
            this.inputCertOrganization.Underlined = false;
            // 
            // labelOrganization
            // 
            this.labelOrganization.AutoSize = true;
            this.labelOrganization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganization.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelOrganization.Location = new System.Drawing.Point(373, 207);
            this.labelOrganization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrganization.Name = "labelOrganization";
            this.labelOrganization.Size = new System.Drawing.Size(131, 21);
            this.labelOrganization.TabIndex = 63;
            this.labelOrganization.Text = "ORGANIZATION";
            // 
            // inputCertExpiredDate
            // 
            this.inputCertExpiredDate.BorderColor = System.Drawing.Color.DimGray;
            this.inputCertExpiredDate.BorderSize = 1;
            this.inputCertExpiredDate.CustomFormat = "dd-MM-yyyy";
            this.inputCertExpiredDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCertExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputCertExpiredDate.Location = new System.Drawing.Point(521, 156);
            this.inputCertExpiredDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.inputCertExpiredDate.Name = "inputCertExpiredDate";
            this.inputCertExpiredDate.Size = new System.Drawing.Size(225, 32);
            this.inputCertExpiredDate.SkinColor = System.Drawing.SystemColors.Control;
            this.inputCertExpiredDate.TabIndex = 6;
            this.inputCertExpiredDate.TextColor = System.Drawing.Color.DimGray;
            // 
            // inputCertCreatedAt
            // 
            this.inputCertCreatedAt.BorderColor = System.Drawing.SystemColors.Control;
            this.inputCertCreatedAt.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputCertCreatedAt.BorderSize = 1;
            this.inputCertCreatedAt.Enabled = false;
            this.inputCertCreatedAt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCertCreatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputCertCreatedAt.Location = new System.Drawing.Point(105, 264);
            this.inputCertCreatedAt.Margin = new System.Windows.Forms.Padding(5);
            this.inputCertCreatedAt.Multiline = false;
            this.inputCertCreatedAt.Name = "inputCertCreatedAt";
            this.inputCertCreatedAt.Padding = new System.Windows.Forms.Padding(5);
            this.inputCertCreatedAt.PasswordChar = false;
            this.inputCertCreatedAt.ReadOnly = true;
            this.inputCertCreatedAt.Size = new System.Drawing.Size(65, 25);
            this.inputCertCreatedAt.TabIndex = 27;
            this.inputCertCreatedAt.Texts = "29-10-2023";
            this.inputCertCreatedAt.Underlined = false;
            // 
            // labelExpiredDate
            // 
            this.labelExpiredDate.AutoSize = true;
            this.labelExpiredDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpiredDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelExpiredDate.Location = new System.Drawing.Point(373, 164);
            this.labelExpiredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpiredDate.Name = "labelExpiredDate";
            this.labelExpiredDate.Size = new System.Drawing.Size(119, 21);
            this.labelExpiredDate.TabIndex = 61;
            this.labelExpiredDate.Text = "EXPIRED DATE";
            // 
            // inputCertID
            // 
            this.inputCertID.BorderColor = System.Drawing.Color.DimGray;
            this.inputCertID.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputCertID.BorderSize = 1;
            this.inputCertID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCertID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputCertID.Location = new System.Drawing.Point(107, 75);
            this.inputCertID.Margin = new System.Windows.Forms.Padding(5);
            this.inputCertID.Multiline = false;
            this.inputCertID.Name = "inputCertID";
            this.inputCertID.Padding = new System.Windows.Forms.Padding(5);
            this.inputCertID.PasswordChar = false;
            this.inputCertID.ReadOnly = false;
            this.inputCertID.Size = new System.Drawing.Size(178, 32);
            this.inputCertID.TabIndex = 1;
            this.inputCertID.Texts = "CERT001";
            this.inputCertID.Underlined = false;
            // 
            // inputCertUpdatedAt
            // 
            this.inputCertUpdatedAt.BorderColor = System.Drawing.SystemColors.Control;
            this.inputCertUpdatedAt.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputCertUpdatedAt.BorderSize = 1;
            this.inputCertUpdatedAt.Enabled = false;
            this.inputCertUpdatedAt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCertUpdatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputCertUpdatedAt.Location = new System.Drawing.Point(105, 289);
            this.inputCertUpdatedAt.Margin = new System.Windows.Forms.Padding(5);
            this.inputCertUpdatedAt.Multiline = false;
            this.inputCertUpdatedAt.Name = "inputCertUpdatedAt";
            this.inputCertUpdatedAt.Padding = new System.Windows.Forms.Padding(5);
            this.inputCertUpdatedAt.PasswordChar = false;
            this.inputCertUpdatedAt.ReadOnly = true;
            this.inputCertUpdatedAt.Size = new System.Drawing.Size(65, 25);
            this.inputCertUpdatedAt.TabIndex = 28;
            this.inputCertUpdatedAt.Texts = "29-10-2023";
            this.inputCertUpdatedAt.Underlined = false;
            // 
            // inputCertTitle
            // 
            this.inputCertTitle.BorderColor = System.Drawing.Color.DimGray;
            this.inputCertTitle.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputCertTitle.BorderSize = 1;
            this.inputCertTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCertTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputCertTitle.Location = new System.Drawing.Point(107, 120);
            this.inputCertTitle.Margin = new System.Windows.Forms.Padding(5);
            this.inputCertTitle.Multiline = false;
            this.inputCertTitle.Name = "inputCertTitle";
            this.inputCertTitle.Padding = new System.Windows.Forms.Padding(5);
            this.inputCertTitle.PasswordChar = false;
            this.inputCertTitle.ReadOnly = false;
            this.inputCertTitle.Size = new System.Drawing.Size(225, 32);
            this.inputCertTitle.TabIndex = 2;
            this.inputCertTitle.Texts = "IELTS";
            this.inputCertTitle.Underlined = false;
            // 
            // labelCertID
            // 
            this.labelCertID.AutoSize = true;
            this.labelCertID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCertID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCertID.Location = new System.Drawing.Point(25, 80);
            this.labelCertID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCertID.Name = "labelCertID";
            this.labelCertID.Size = new System.Drawing.Size(27, 21);
            this.labelCertID.TabIndex = 59;
            this.labelCertID.Text = "ID";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTitle.Location = new System.Drawing.Point(25, 125);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(50, 21);
            this.labelTitle.TabIndex = 56;
            this.labelTitle.Text = "TITLE";
            // 
            // inputCertIssueDate
            // 
            this.inputCertIssueDate.BorderColor = System.Drawing.Color.DimGray;
            this.inputCertIssueDate.BorderSize = 1;
            this.inputCertIssueDate.CustomFormat = "dd-MM-yyyy";
            this.inputCertIssueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCertIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputCertIssueDate.Location = new System.Drawing.Point(521, 114);
            this.inputCertIssueDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.inputCertIssueDate.Name = "inputCertIssueDate";
            this.inputCertIssueDate.Size = new System.Drawing.Size(225, 32);
            this.inputCertIssueDate.SkinColor = System.Drawing.SystemColors.Control;
            this.inputCertIssueDate.TabIndex = 5;
            this.inputCertIssueDate.TextColor = System.Drawing.Color.DimGray;
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssueDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelIssueDate.Location = new System.Drawing.Point(373, 122);
            this.labelIssueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(98, 21);
            this.labelIssueDate.TabIndex = 57;
            this.labelIssueDate.Text = "ISSUE DATE";
            // 
            // grBoxDeleteCertificate
            // 
            this.grBoxDeleteCertificate.Controls.Add(this.panelDeleteCertificate);
            this.grBoxDeleteCertificate.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxDeleteCertificate.ForeColor = System.Drawing.Color.DimGray;
            this.grBoxDeleteCertificate.Location = new System.Drawing.Point(509, 450);
            this.grBoxDeleteCertificate.Name = "grBoxDeleteCertificate";
            this.grBoxDeleteCertificate.Size = new System.Drawing.Size(463, 194);
            this.grBoxDeleteCertificate.TabIndex = 39;
            this.grBoxDeleteCertificate.TabStop = false;
            // 
            // panelDeleteCertificate
            // 
            this.panelDeleteCertificate.Controls.Add(this.labelCertWarningMessage);
            this.panelDeleteCertificate.Controls.Add(this.labelDeleteCertificate);
            this.panelDeleteCertificate.Controls.Add(this.btnDeleteCertificate);
            this.panelDeleteCertificate.Location = new System.Drawing.Point(54, 45);
            this.panelDeleteCertificate.Name = "panelDeleteCertificate";
            this.panelDeleteCertificate.Size = new System.Drawing.Size(362, 119);
            this.panelDeleteCertificate.TabIndex = 38;
            // 
            // labelCertWarningMessage
            // 
            this.labelCertWarningMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCertWarningMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelCertWarningMessage.ForeColor = System.Drawing.Color.DimGray;
            this.labelCertWarningMessage.Location = new System.Drawing.Point(0, 32);
            this.labelCertWarningMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCertWarningMessage.Name = "labelCertWarningMessage";
            this.labelCertWarningMessage.Size = new System.Drawing.Size(362, 51);
            this.labelCertWarningMessage.TabIndex = 35;
            this.labelCertWarningMessage.Text = "This will delete selected certificated permanently, there is no going back. Pleas" +
    "e be certain.";
            this.labelCertWarningMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDeleteCertificate
            // 
            this.labelDeleteCertificate.BorderColor = System.Drawing.Color.DimGray;
            this.labelDeleteCertificate.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.labelDeleteCertificate.BorderSize = 1;
            this.labelDeleteCertificate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDeleteCertificate.Enabled = false;
            this.labelDeleteCertificate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteCertificate.ForeColor = System.Drawing.Color.Red;
            this.labelDeleteCertificate.Location = new System.Drawing.Point(0, 0);
            this.labelDeleteCertificate.Margin = new System.Windows.Forms.Padding(5);
            this.labelDeleteCertificate.Multiline = false;
            this.labelDeleteCertificate.Name = "labelDeleteCertificate";
            this.labelDeleteCertificate.Padding = new System.Windows.Forms.Padding(5);
            this.labelDeleteCertificate.PasswordChar = false;
            this.labelDeleteCertificate.ReadOnly = true;
            this.labelDeleteCertificate.Size = new System.Drawing.Size(362, 32);
            this.labelDeleteCertificate.TabIndex = 36;
            this.labelDeleteCertificate.Texts = "Delete Certificate";
            this.labelDeleteCertificate.Underlined = true;
            // 
            // btnDeleteCertificate
            // 
            this.btnDeleteCertificate.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCertificate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteCertificate.FlatAppearance.BorderSize = 0;
            this.btnDeleteCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCertificate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCertificate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteCertificate.Location = new System.Drawing.Point(0, 83);
            this.btnDeleteCertificate.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteCertificate.Name = "btnDeleteCertificate";
            this.btnDeleteCertificate.Size = new System.Drawing.Size(362, 36);
            this.btnDeleteCertificate.TabIndex = 37;
            this.btnDeleteCertificate.Text = "Delete Certificate";
            this.btnDeleteCertificate.UseVisualStyleBackColor = false;
            this.btnDeleteCertificate.Click += new System.EventHandler(this.btnDeleteCertificate_Click);
            // 
            // StudentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 887);
            this.Controls.Add(this.grBoxDeleteCertificate);
            this.Controls.Add(this.grBoxCertificate);
            this.Controls.Add(this.grBoxDeleteStudent);
            this.Controls.Add(this.grBoxProfile);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StudentDetailForm";
            this.Text = "Student Detail";
            this.Load += new System.EventHandler(this.StudentDetailForm_Load);
            this.grBoxProfile.ResumeLayout(false);
            this.grBoxProfile.PerformLayout();
            this.grBoxDeleteStudent.ResumeLayout(false);
            this.panelDeleteAccount.ResumeLayout(false);
            this.grBoxCertificate.ResumeLayout(false);
            this.grBoxCertificate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).EndInit();
            this.grBoxDeleteCertificate.ResumeLayout(false);
            this.panelDeleteCertificate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxProfile;
        private CustomControls.Input inputCertUpdatedAt;
        private System.Windows.Forms.Label labelCertUpdatedAt;
        private CustomControls.Input inputCertCreatedAt;
        private System.Windows.Forms.Label labelCertCreatedAt;
        private System.Windows.Forms.Button btnStuReset;
        private System.Windows.Forms.Button btnStuAdd;
        private CustomControls.Input inputCourseYear;
        private System.Windows.Forms.Label labelCourseYear;
        private CustomControls.ComboBoxInput inputMajor;
        private System.Windows.Forms.Label labelMajor;
        private CustomControls.ComboBoxInput inputClass;
        private System.Windows.Forms.Label labelClass;
        private CustomControls.ComboBoxInput inputDepartment;
        private System.Windows.Forms.Label labelDepartment;
        private CustomControls.ComboBoxInput inputEduType;
        private System.Windows.Forms.Label labelEduType;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private CustomControls.DateTimeInput inputDoB;
        private System.Windows.Forms.Label labelDoB;
        private CustomControls.Input inputName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox grBoxDeleteStudent;
        private System.Windows.Forms.Panel panelDeleteAccount;
        private System.Windows.Forms.Label labelStuWarningMessage;
        private CustomControls.Input labelDeleteStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private CustomControls.Input inputStuID;
        private System.Windows.Forms.Label labelStuID;
        private System.Windows.Forms.GroupBox grBoxCertificate;
        private CustomControls.Input inputCertID;
        private CustomControls.Input inputCertTitle;
        private System.Windows.Forms.Label labelCertID;
        private System.Windows.Forms.Label labelTitle;
        private CustomControls.DateTimeInput inputCertIssueDate;
        private System.Windows.Forms.Label labelIssueDate;
        private CustomControls.DateTimeInput inputCertExpiredDate;
        private System.Windows.Forms.Label labelExpiredDate;
        private CustomControls.Input inputCertOrganization;
        private System.Windows.Forms.Label labelOrganization;
        private System.Windows.Forms.Label labelIsValid;
        private System.Windows.Forms.CheckBox inputCertIsValid;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnCertReset;
        private System.Windows.Forms.Button btnCertSave;
        private System.Windows.Forms.Label labelStuUpdatedAt;
        private System.Windows.Forms.Label labelStuCreatedAt;
        private CustomControls.Input inputStuCreatedAt;
        private CustomControls.Input inputStuUpdatedAt;
        private System.Windows.Forms.GroupBox grBoxDeleteCertificate;
        private System.Windows.Forms.Panel panelDeleteCertificate;
        private System.Windows.Forms.Label labelCertWarningMessage;
        private CustomControls.Input labelDeleteCertificate;
        private System.Windows.Forms.Button btnDeleteCertificate;
        private System.Windows.Forms.DataGridView gridViewCertificate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.BindingSource certificateBindingSource;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isValidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiry_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private CustomControls.Input inputDescription;
    }
}