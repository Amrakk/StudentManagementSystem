using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_Management_System
{
    partial class AddUserForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.comboBoxInput1 = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.dateTimeInput1 = new Student_Management_System.Views.CustomControls.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 353);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 19);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbRole
            // 
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(139, 277);
            this.cbbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(406, 21);
            this.cbbRole.TabIndex = 26;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(139, 240);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(406, 20);
            this.tbPhone.TabIndex = 25;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(139, 208);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(406, 20);
            this.tbConfirmPassword.TabIndex = 24;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(139, 180);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(406, 20);
            this.tbPassword.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = " name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "confirmpassword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "email";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 146);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(406, 20);
            this.tbName.TabIndex = 15;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(139, 112);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(406, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(45, 308);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(65, 13);
            this.lblBirthdate.TabIndex = 29;
            this.lblBirthdate.Text = "Date of birth";
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(139, 308);
            this.dtpDob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(406, 20);
            this.dtpDob.TabIndex = 31;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(266, 9);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(82, 93);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 28;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // comboBoxInput1
            // 
            this.comboBoxInput1.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Manager",
            "Employee"});
            this.comboBoxInput1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxInput1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxInput1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboBoxInput1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxInput1.BorderColor = System.Drawing.Color.DimGray;
            this.comboBoxInput1.BorderSize = 1;
            this.comboBoxInput1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxInput1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInput1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxInput1.IconColor = System.Drawing.Color.DimGray;
            this.comboBoxInput1.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.comboBoxInput1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxInput1.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxInput1.Location = new System.Drawing.Point(48, 51);
            this.comboBoxInput1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxInput1.Name = "comboBoxInput1";
            this.comboBoxInput1.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxInput1.Size = new System.Drawing.Size(239, 36);
            this.comboBoxInput1.TabIndex = 32;
            this.comboBoxInput1.Texts = "";
            // 
            // dateTimeInput1
            // 
            this.dateTimeInput1.BorderColor = System.Drawing.Color.DimGray;
            this.dateTimeInput1.BorderSize = 1;
            this.dateTimeInput1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimeInput1.CustomFormat = "yyyy/MM/dd";
            this.dateTimeInput1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInput1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInput1.Location = new System.Drawing.Point(381, 52);
            this.dateTimeInput1.MinimumSize = new System.Drawing.Size(0, 35);
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(207, 35);
            this.dateTimeInput1.SkinColor = System.Drawing.SystemColors.Control;
            this.dateTimeInput1.TabIndex = 33;
            this.dateTimeInput1.TextColor = System.Drawing.Color.DimGray;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 379);
            this.Controls.Add(this.dateTimeInput1);
            this.Controls.Add(this.comboBoxInput1);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddUserForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Button btnAdd;
        private ComboBox cbbRole;
        private TextBox tbPhone;
        private TextBox tbConfirmPassword;
        private TextBox tbPassword;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbName;
        private TextBox tbEmail;
        private PictureBox pbAvatar;
        private Label lblBirthdate;
        private DateTimePicker dtpDob;
        private Views.CustomControls.ComboBoxInput comboBoxInput1;
        private Views.CustomControls.DateTimeInput dateTimeInput1;
    }
}