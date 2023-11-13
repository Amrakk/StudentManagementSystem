namespace Student_Management_System
{
    partial class AddStudentForm
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
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.inputName = new Student_Management_System.Views.CustomControls.Input();
            this.labelDoB = new System.Windows.Forms.Label();
            this.inputDoB = new Student_Management_System.Views.CustomControls.DateTimeInput();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelEduType = new System.Windows.Forms.Label();
            this.inputEduType = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.inputDepartment = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelClass = new System.Windows.Forms.Label();
            this.inputClass = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelMajor = new System.Windows.Forms.Label();
            this.inputMajor = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelCourseYear = new System.Windows.Forms.Label();
            this.inputCourseYear = new Student_Management_System.Views.CustomControls.Input();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rbtnMale.Location = new System.Drawing.Point(180, 165);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(72, 29);
            this.rbtnMale.TabIndex = 2;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rbtnFemale.Location = new System.Drawing.Point(265, 165);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(90, 29);
            this.rbtnFemale.TabIndex = 3;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelName.Location = new System.Drawing.Point(50, 45);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "NAME";
            // 
            // inputName
            // 
            this.inputName.BorderColor = System.Drawing.Color.DimGray;
            this.inputName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputName.BorderSize = 1;
            this.inputName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputName.Location = new System.Drawing.Point(180, 40);
            this.inputName.Margin = new System.Windows.Forms.Padding(5);
            this.inputName.Multiline = false;
            this.inputName.Name = "inputName";
            this.inputName.Padding = new System.Windows.Forms.Padding(5);
            this.inputName.PasswordChar = false;
            this.inputName.ReadOnly = false;
            this.inputName.Size = new System.Drawing.Size(270, 36);
            this.inputName.TabIndex = 0;
            this.inputName.Texts = "Nguyen Hoang Duy";
            this.inputName.Underlined = false;
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDoB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDoB.Location = new System.Drawing.Point(50, 105);
            this.labelDoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(50, 25);
            this.labelDoB.TabIndex = 21;
            this.labelDoB.Text = "DoB";
            // 
            // inputDoB
            // 
            this.inputDoB.BorderColor = System.Drawing.Color.DimGray;
            this.inputDoB.BorderSize = 1;
            this.inputDoB.CustomFormat = "dd-MM-yyyy";
            this.inputDoB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDoB.Location = new System.Drawing.Point(180, 100);
            this.inputDoB.MinimumSize = new System.Drawing.Size(4, 35);
            this.inputDoB.Name = "inputDoB";
            this.inputDoB.Size = new System.Drawing.Size(270, 35);
            this.inputDoB.SkinColor = System.Drawing.SystemColors.Control;
            this.inputDoB.TabIndex = 1;
            this.inputDoB.TextColor = System.Drawing.Color.DimGray;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelGender.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelGender.Location = new System.Drawing.Point(50, 165);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(78, 25);
            this.labelGender.TabIndex = 23;
            this.labelGender.Text = "Gender";
            // 
            // labelEduType
            // 
            this.labelEduType.AutoSize = true;
            this.labelEduType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelEduType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEduType.Location = new System.Drawing.Point(530, 165);
            this.labelEduType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEduType.Name = "labelEduType";
            this.labelEduType.Size = new System.Drawing.Size(148, 25);
            this.labelEduType.TabIndex = 24;
            this.labelEduType.Text = "Education Type";
            // 
            // inputEduType
            // 
            this.inputEduType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputEduType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputEduType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputEduType.BorderColor = System.Drawing.Color.DimGray;
            this.inputEduType.BorderSize = 1;
            this.inputEduType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputEduType.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputEduType.ForeColor = System.Drawing.Color.DimGray;
            this.inputEduType.IconColor = System.Drawing.Color.DimGray;
            this.inputEduType.Items.AddRange(new object[] {
            "Standard",
            "High Quality"});
            this.inputEduType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputEduType.ListTextColor = System.Drawing.Color.DimGray;
            this.inputEduType.Location = new System.Drawing.Point(700, 160);
            this.inputEduType.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputEduType.Name = "inputEduType";
            this.inputEduType.Padding = new System.Windows.Forms.Padding(1);
            this.inputEduType.Size = new System.Drawing.Size(225, 36);
            this.inputEduType.TabIndex = 7;
            this.inputEduType.Texts = "";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDepartment.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDepartment.Location = new System.Drawing.Point(530, 45);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(120, 25);
            this.labelDepartment.TabIndex = 26;
            this.labelDepartment.Text = "Department";
            // 
            // inputDepartment
            // 
            this.inputDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputDepartment.BorderColor = System.Drawing.Color.DimGray;
            this.inputDepartment.BorderSize = 1;
            this.inputDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.inputDepartment.IconColor = System.Drawing.Color.DimGray;
            this.inputDepartment.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputDepartment.ListTextColor = System.Drawing.Color.DimGray;
            this.inputDepartment.Location = new System.Drawing.Point(700, 40);
            this.inputDepartment.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Padding = new System.Windows.Forms.Padding(1);
            this.inputDepartment.Size = new System.Drawing.Size(380, 36);
            this.inputDepartment.TabIndex = 5;
            this.inputDepartment.Texts = "";
            this.inputDepartment.OnSelectedIndexChanged += new System.EventHandler(this.inputDepartment_OnSelectedIndexChanged);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelClass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelClass.Location = new System.Drawing.Point(530, 225);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(55, 25);
            this.labelClass.TabIndex = 28;
            this.labelClass.Text = "Class";
            // 
            // inputClass
            // 
            this.inputClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputClass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputClass.BorderColor = System.Drawing.Color.DimGray;
            this.inputClass.BorderSize = 1;
            this.inputClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputClass.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputClass.ForeColor = System.Drawing.Color.DimGray;
            this.inputClass.IconColor = System.Drawing.Color.DimGray;
            this.inputClass.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputClass.ListTextColor = System.Drawing.Color.DimGray;
            this.inputClass.Location = new System.Drawing.Point(700, 220);
            this.inputClass.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputClass.Name = "inputClass";
            this.inputClass.Padding = new System.Windows.Forms.Padding(1);
            this.inputClass.Size = new System.Drawing.Size(225, 36);
            this.inputClass.TabIndex = 8;
            this.inputClass.Texts = "";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelMajor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelMajor.Location = new System.Drawing.Point(530, 105);
            this.labelMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(65, 25);
            this.labelMajor.TabIndex = 30;
            this.labelMajor.Text = "Major";
            // 
            // inputMajor
            // 
            this.inputMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputMajor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputMajor.BorderColor = System.Drawing.Color.DimGray;
            this.inputMajor.BorderSize = 1;
            this.inputMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputMajor.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputMajor.ForeColor = System.Drawing.Color.DimGray;
            this.inputMajor.IconColor = System.Drawing.Color.DimGray;
            this.inputMajor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputMajor.ListTextColor = System.Drawing.Color.DimGray;
            this.inputMajor.Location = new System.Drawing.Point(700, 100);
            this.inputMajor.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputMajor.Name = "inputMajor";
            this.inputMajor.Padding = new System.Windows.Forms.Padding(1);
            this.inputMajor.Size = new System.Drawing.Size(380, 36);
            this.inputMajor.TabIndex = 6;
            this.inputMajor.Texts = "";
            // 
            // labelCourseYear
            // 
            this.labelCourseYear.AutoSize = true;
            this.labelCourseYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelCourseYear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCourseYear.Location = new System.Drawing.Point(50, 225);
            this.labelCourseYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseYear.Name = "labelCourseYear";
            this.labelCourseYear.Size = new System.Drawing.Size(117, 25);
            this.labelCourseYear.TabIndex = 32;
            this.labelCourseYear.Text = "Course Year";
            // 
            // inputCourseYear
            // 
            this.inputCourseYear.BorderColor = System.Drawing.Color.DimGray;
            this.inputCourseYear.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputCourseYear.BorderSize = 1;
            this.inputCourseYear.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputCourseYear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputCourseYear.Location = new System.Drawing.Point(180, 220);
            this.inputCourseYear.Margin = new System.Windows.Forms.Padding(5);
            this.inputCourseYear.Multiline = false;
            this.inputCourseYear.Name = "inputCourseYear";
            this.inputCourseYear.Padding = new System.Windows.Forms.Padding(5);
            this.inputCourseYear.PasswordChar = false;
            this.inputCourseYear.ReadOnly = false;
            this.inputCourseYear.Size = new System.Drawing.Size(130, 36);
            this.inputCourseYear.TabIndex = 4;
            this.inputCourseYear.Texts = "2021";
            this.inputCourseYear.Underlined = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DimGray;
            this.btnReset.Location = new System.Drawing.Point(813, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 36);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(953, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 364);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputCourseYear);
            this.Controls.Add(this.labelCourseYear);
            this.Controls.Add(this.inputMajor);
            this.Controls.Add(this.labelMajor);
            this.Controls.Add(this.inputClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.inputDepartment);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.inputEduType);
            this.Controls.Add(this.labelEduType);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.inputDoB);
            this.Controls.Add(this.labelDoB);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "AddStudentForm";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label labelName;
        private Views.CustomControls.Input inputName;
        private System.Windows.Forms.Label labelDoB;
        private Views.CustomControls.DateTimeInput inputDoB;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEduType;
        private Views.CustomControls.ComboBoxInput inputEduType;
        private System.Windows.Forms.Label labelDepartment;
        private Views.CustomControls.ComboBoxInput inputDepartment;
        private System.Windows.Forms.Label labelClass;
        private Views.CustomControls.ComboBoxInput inputClass;
        private System.Windows.Forms.Label labelMajor;
        private Views.CustomControls.ComboBoxInput inputMajor;
        private System.Windows.Forms.Label labelCourseYear;
        private Views.CustomControls.Input inputCourseYear;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
    }
}