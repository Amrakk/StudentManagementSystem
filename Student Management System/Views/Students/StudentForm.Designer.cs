using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_System.Views.Students
{
    partial class StudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelStudent = new System.Windows.Forms.Label();
            this.gridViewStudent = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eduType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.inputMajor = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelMajor = new System.Windows.Forms.Label();
            this.inputDepartment = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.inputEduType = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelEduType = new System.Windows.Forms.Label();
            this.inputGender = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelGender = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.inputSearch = new Student_Management_System.Views.CustomControls.Input();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStudent.Location = new System.Drawing.Point(90, 30);
            this.labelStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(188, 60);
            this.labelStudent.TabIndex = 0;
            this.labelStudent.Text = "Student";
            // 
            // gridViewStudent
            // 
            this.gridViewStudent.AllowUserToAddRows = false;
            this.gridViewStudent.AllowUserToDeleteRows = false;
            this.gridViewStudent.AutoGenerateColumns = false;
            this.gridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.gender,
            this.departmentDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.eduType,
            this.courseYearDataGridViewTextBoxColumn});
            this.gridViewStudent.DataSource = this.studentBindingSource;
            this.gridViewStudent.Location = new System.Drawing.Point(98, 171);
            this.gridViewStudent.Name = "gridViewStudent";
            this.gridViewStudent.ReadOnly = true;
            this.gridViewStudent.RowHeadersWidth = 51;
            this.gridViewStudent.RowTemplate.Height = 24;
            this.gridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewStudent.Size = new System.Drawing.Size(1278, 524);
            this.gridViewStudent.TabIndex = 1;
            this.gridViewStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewStudent_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 205;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dobDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dobDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Width = 145;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gender.DefaultCellStyle = dataGridViewCellStyle4;
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 95;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.departmentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Width = 210;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "major";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.majorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.ReadOnly = true;
            this.majorDataGridViewTextBoxColumn.Width = 210;
            // 
            // eduType
            // 
            this.eduType.DataPropertyName = "eduType";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eduType.DefaultCellStyle = dataGridViewCellStyle7;
            this.eduType.HeaderText = "Edu Type";
            this.eduType.MinimumWidth = 6;
            this.eduType.Name = "eduType";
            this.eduType.ReadOnly = true;
            this.eduType.Width = 120;
            // 
            // courseYearDataGridViewTextBoxColumn
            // 
            this.courseYearDataGridViewTextBoxColumn.DataPropertyName = "courseYear";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.courseYearDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.courseYearDataGridViewTextBoxColumn.HeaderText = "Course Year";
            this.courseYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseYearDataGridViewTextBoxColumn.Name = "courseYearDataGridViewTextBoxColumn";
            this.courseYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Student_Management_System.Database.student);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.btnApply);
            this.panelFilter.Controls.Add(this.btnClear);
            this.panelFilter.Controls.Add(this.inputMajor);
            this.panelFilter.Controls.Add(this.labelMajor);
            this.panelFilter.Controls.Add(this.inputDepartment);
            this.panelFilter.Controls.Add(this.labelDepartment);
            this.panelFilter.Controls.Add(this.inputEduType);
            this.panelFilter.Controls.Add(this.labelEduType);
            this.panelFilter.Controls.Add(this.inputGender);
            this.panelFilter.Controls.Add(this.labelGender);
            this.panelFilter.Location = new System.Drawing.Point(623, 150);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(283, 224);
            this.panelFilter.TabIndex = 12;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnApply.Location = new System.Drawing.Point(188, 179);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(72, 29);
            this.btnApply.TabIndex = 84;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DimGray;
            this.btnClear.Location = new System.Drawing.Point(110, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 29);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // inputMajor
            // 
            this.inputMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputMajor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputMajor.BorderColor = System.Drawing.Color.DimGray;
            this.inputMajor.BorderSize = 1;
            this.inputMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputMajor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMajor.ForeColor = System.Drawing.Color.DimGray;
            this.inputMajor.IconColor = System.Drawing.Color.DimGray;
            this.inputMajor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputMajor.ListTextColor = System.Drawing.Color.DimGray;
            this.inputMajor.Location = new System.Drawing.Point(105, 137);
            this.inputMajor.Margin = new System.Windows.Forms.Padding(0);
            this.inputMajor.MinimumSize = new System.Drawing.Size(100, 24);
            this.inputMajor.Name = "inputMajor";
            this.inputMajor.Padding = new System.Windows.Forms.Padding(1);
            this.inputMajor.Size = new System.Drawing.Size(155, 26);
            this.inputMajor.TabIndex = 82;
            this.inputMajor.Texts = "";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMajor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelMajor.Location = new System.Drawing.Point(14, 141);
            this.labelMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(57, 23);
            this.labelMajor.TabIndex = 81;
            this.labelMajor.Text = "Major";
            // 
            // inputDepartment
            // 
            this.inputDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputDepartment.BorderColor = System.Drawing.Color.DimGray;
            this.inputDepartment.BorderSize = 1;
            this.inputDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.inputDepartment.IconColor = System.Drawing.Color.DimGray;
            this.inputDepartment.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputDepartment.ListTextColor = System.Drawing.Color.DimGray;
            this.inputDepartment.Location = new System.Drawing.Point(105, 97);
            this.inputDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.inputDepartment.MinimumSize = new System.Drawing.Size(100, 24);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Padding = new System.Windows.Forms.Padding(1);
            this.inputDepartment.Size = new System.Drawing.Size(155, 26);
            this.inputDepartment.TabIndex = 80;
            this.inputDepartment.Texts = "";
            this.inputDepartment.OnSelectedIndexChanged += new System.EventHandler(this.inputDepartment_OnSelectedIndexChanged);
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDepartment.Location = new System.Drawing.Point(14, 101);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(108, 23);
            this.labelDepartment.TabIndex = 79;
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
            this.inputEduType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEduType.ForeColor = System.Drawing.Color.DimGray;
            this.inputEduType.IconColor = System.Drawing.Color.DimGray;
            this.inputEduType.Items.AddRange(new object[] {
            "Standard",
            "High Quality"});
            this.inputEduType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputEduType.ListTextColor = System.Drawing.Color.DimGray;
            this.inputEduType.Location = new System.Drawing.Point(105, 57);
            this.inputEduType.Margin = new System.Windows.Forms.Padding(0);
            this.inputEduType.MinimumSize = new System.Drawing.Size(100, 24);
            this.inputEduType.Name = "inputEduType";
            this.inputEduType.Padding = new System.Windows.Forms.Padding(1);
            this.inputEduType.Size = new System.Drawing.Size(155, 26);
            this.inputEduType.TabIndex = 78;
            this.inputEduType.Texts = "";
            // 
            // labelEduType
            // 
            this.labelEduType.AutoSize = true;
            this.labelEduType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEduType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEduType.Location = new System.Drawing.Point(14, 61);
            this.labelEduType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEduType.Name = "labelEduType";
            this.labelEduType.Size = new System.Drawing.Size(78, 23);
            this.labelEduType.TabIndex = 77;
            this.labelEduType.Text = "EduType";
            // 
            // inputGender
            // 
            this.inputGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputGender.BorderColor = System.Drawing.Color.DimGray;
            this.inputGender.BorderSize = 1;
            this.inputGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGender.ForeColor = System.Drawing.Color.DimGray;
            this.inputGender.IconColor = System.Drawing.Color.DimGray;
            this.inputGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.inputGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputGender.ListTextColor = System.Drawing.Color.DimGray;
            this.inputGender.Location = new System.Drawing.Point(105, 17);
            this.inputGender.Margin = new System.Windows.Forms.Padding(0);
            this.inputGender.MinimumSize = new System.Drawing.Size(100, 24);
            this.inputGender.Name = "inputGender";
            this.inputGender.Padding = new System.Windows.Forms.Padding(1);
            this.inputGender.Size = new System.Drawing.Size(155, 26);
            this.inputGender.TabIndex = 76;
            this.inputGender.Texts = "";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelGender.Location = new System.Drawing.Point(14, 21);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(68, 23);
            this.labelGender.TabIndex = 75;
            this.labelGender.Text = "Gender";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.DimGray;
            this.btnFilter.Location = new System.Drawing.Point(623, 119);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(117, 32);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Location = new System.Drawing.Point(509, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreate.Location = new System.Drawing.Point(1259, 41);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 41);
            this.btnCreate.TabIndex = 7;
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
            this.btnImport.Location = new System.Drawing.Point(1124, 41);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(117, 41);
            this.btnImport.TabIndex = 6;
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
            this.btnExport.Location = new System.Drawing.Point(990, 41);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(117, 41);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.BorderColor = System.Drawing.Color.DimGray;
            this.inputSearch.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputSearch.BorderSize = 1;
            this.inputSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSearch.ForeColor = System.Drawing.Color.DimGray;
            this.inputSearch.Location = new System.Drawing.Point(98, 119);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(5);
            this.inputSearch.Multiline = false;
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.inputSearch.PasswordChar = false;
            this.inputSearch.ReadOnly = false;
            this.inputSearch.Size = new System.Drawing.Size(412, 39);
            this.inputSearch.TabIndex = 9;
            this.inputSearch.Texts = "";
            this.inputSearch.Underlined = false;
            this.inputSearch.Enter += new System.EventHandler(this.inputSearch_Enter);
            this.inputSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSearch_KeyDown);
            this.inputSearch.Leave += new System.EventHandler(this.inputSearch_Leave);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 205;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Width = 145;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 95;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Width = 210;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.ReadOnly = true;
            this.majorDataGridViewTextBoxColumn.Width = 210;
            // 
            // eduType
            // 
            this.eduType.DataPropertyName = "eduType";
            this.eduType.HeaderText = "Edu Type";
            this.eduType.Name = "eduType";
            this.eduType.ReadOnly = true;
            this.eduType.Width = 120;
            // 
            // courseYearDataGridViewTextBoxColumn
            // 
            this.courseYearDataGridViewTextBoxColumn.DataPropertyName = "courseYear";
            this.courseYearDataGridViewTextBoxColumn.HeaderText = "Course Year";
            this.courseYearDataGridViewTextBoxColumn.Name = "courseYearDataGridViewTextBoxColumn";
            this.courseYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.gridViewStudent);
            this.Controls.Add(this.labelStudent);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.Text = "StudentForms";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelStudent;
        private DataGridView gridViewStudent;
        private Panel panelFilter;
        private Button btnFilter;
        private Button btnSearch;
        private CustomControls.Input inputSearch;
        private BindingSource studentBindingSource;
        private Button btnCreate;
        private Button btnImport;
        private Button btnExport;
        private CustomControls.ComboBoxInput inputMajor;
        private Label labelMajor;
        private CustomControls.ComboBoxInput inputDepartment;
        private Label labelDepartment;
        private CustomControls.ComboBoxInput inputEduType;
        private Label labelEduType;
        private CustomControls.ComboBoxInput inputGender;
        private Label labelGender;
        private Button btnApply;
        private Button btnClear;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eduType;
        private DataGridViewTextBoxColumn courseYearDataGridViewTextBoxColumn;
    }
}