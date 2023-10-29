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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEduType = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblCourseYear = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.cbbEduType = new System.Windows.Forms.ComboBox();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.cbbMajor = new System.Windows.Forms.ComboBox();
            this.tbCourseYear = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pRbtnGender = new System.Windows.Forms.Panel();
            this.inputDoB = new Student_Management_System.Views.CustomControls.DateTimeInput();
            this.pRbtnGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(43, 83);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(78, 16);
            this.lblDob.TabIndex = 1;
            this.lblDob.Text = "Date of birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(43, 135);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblEduType
            // 
            this.lblEduType.AutoSize = true;
            this.lblEduType.Location = new System.Drawing.Point(43, 185);
            this.lblEduType.Name = "lblEduType";
            this.lblEduType.Size = new System.Drawing.Size(102, 16);
            this.lblEduType.TabIndex = 3;
            this.lblEduType.Text = "Education Type";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(43, 286);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(41, 16);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(43, 233);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(77, 16);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(44, 338);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(41, 16);
            this.lblMajor.TabIndex = 6;
            this.lblMajor.Text = "Major";
            // 
            // lblCourseYear
            // 
            this.lblCourseYear.AutoSize = true;
            this.lblCourseYear.Location = new System.Drawing.Point(44, 388);
            this.lblCourseYear.Name = "lblCourseYear";
            this.lblCourseYear.Size = new System.Drawing.Size(82, 16);
            this.lblCourseYear.TabIndex = 7;
            this.lblCourseYear.Text = "Course Year";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(195, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(564, 22);
            this.tbName.TabIndex = 8;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(13, 9);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(58, 20);
            this.rbtnMale.TabIndex = 10;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(135, 9);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(74, 20);
            this.rbtnFemale.TabIndex = 11;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // cbbEduType
            // 
            this.cbbEduType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEduType.FormattingEnabled = true;
            this.cbbEduType.Location = new System.Drawing.Point(195, 182);
            this.cbbEduType.Name = "cbbEduType";
            this.cbbEduType.Size = new System.Drawing.Size(564, 24);
            this.cbbEduType.TabIndex = 12;
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(195, 233);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(564, 24);
            this.cbbDepartment.TabIndex = 13;
            this.cbbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbbDepartment_SelectedIndexChanged);
            // 
            // cbbClass
            // 
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(195, 283);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(564, 24);
            this.cbbClass.TabIndex = 14;
            // 
            // cbbMajor
            // 
            this.cbbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMajor.FormattingEnabled = true;
            this.cbbMajor.Location = new System.Drawing.Point(195, 335);
            this.cbbMajor.Name = "cbbMajor";
            this.cbbMajor.Size = new System.Drawing.Size(564, 24);
            this.cbbMajor.TabIndex = 15;
            // 
            // tbCourseYear
            // 
            this.tbCourseYear.Location = new System.Drawing.Point(195, 388);
            this.tbCourseYear.Name = "tbCourseYear";
            this.tbCourseYear.Size = new System.Drawing.Size(564, 22);
            this.tbCourseYear.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 32);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pRbtnGender
            // 
            this.pRbtnGender.Controls.Add(this.rbtnFemale);
            this.pRbtnGender.Controls.Add(this.rbtnMale);
            this.pRbtnGender.Location = new System.Drawing.Point(195, 125);
            this.pRbtnGender.Name = "pRbtnGender";
            this.pRbtnGender.Size = new System.Drawing.Size(216, 40);
            this.pRbtnGender.TabIndex = 19;
            // 
            // inputDoB
            // 
            this.inputDoB.BorderColor = System.Drawing.Color.DodgerBlue;
            this.inputDoB.BorderSize = 0;
            this.inputDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.inputDoB.Location = new System.Drawing.Point(195, 71);
            this.inputDoB.MinimumSize = new System.Drawing.Size(4, 35);
            this.inputDoB.Name = "inputDoB";
            this.inputDoB.Size = new System.Drawing.Size(564, 35);
            this.inputDoB.SkinColor = System.Drawing.Color.White;
            this.inputDoB.TabIndex = 9;
            this.inputDoB.TextColor = System.Drawing.Color.DimGray;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.pRbtnGender);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCourseYear);
            this.Controls.Add(this.cbbMajor);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.cbbDepartment);
            this.Controls.Add(this.cbbEduType);
            this.Controls.Add(this.inputDoB);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblCourseYear);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblEduType);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblName);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.pRbtnGender.ResumeLayout(false);
            this.pRbtnGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEduType;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblCourseYear;
        private System.Windows.Forms.TextBox tbName;
        private Views.CustomControls.DateTimeInput inputDoB;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.ComboBox cbbEduType;
        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.ComboBox cbbMajor;
        private System.Windows.Forms.TextBox tbCourseYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pRbtnGender;
    }
}