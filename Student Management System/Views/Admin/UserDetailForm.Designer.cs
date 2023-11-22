namespace Student_Management_System.Views.Admin
{
    partial class UserDetailForm
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
            this.grBoxProfile = new System.Windows.Forms.GroupBox();
            this.inputUpdatedAt = new Student_Management_System.Views.CustomControls.Input();
            this.labelUpdatedAt = new System.Windows.Forms.Label();
            this.inputCreatedAt = new Student_Management_System.Views.CustomControls.Input();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.btnChangeAvatar = new System.Windows.Forms.Button();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.inputStatus = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.inputRole = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.inputDoB = new Student_Management_System.Views.CustomControls.DateTimeInput();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.inputPhone = new Student_Management_System.Views.CustomControls.Input();
            this.labelPhone = new System.Windows.Forms.Label();
            this.inputEmail = new Student_Management_System.Views.CustomControls.Input();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDoB = new System.Windows.Forms.Label();
            this.inputName = new Student_Management_System.Views.CustomControls.Input();
            this.labelName = new System.Windows.Forms.Label();
            this.grBoxSercurity = new System.Windows.Forms.GroupBox();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.inputNewPassword = new Student_Management_System.Views.CustomControls.Input();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.panelDeleteAccount = new System.Windows.Forms.Panel();
            this.labelWarningMessage = new System.Windows.Forms.Label();
            this.labelDeleteAccount = new Student_Management_System.Views.CustomControls.Input();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.labelFormStatus = new System.Windows.Forms.Label();
            this.grBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.grBoxSercurity.SuspendLayout();
            this.panelDeleteAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxProfile
            // 
            this.grBoxProfile.Controls.Add(this.inputUpdatedAt);
            this.grBoxProfile.Controls.Add(this.labelUpdatedAt);
            this.grBoxProfile.Controls.Add(this.inputCreatedAt);
            this.grBoxProfile.Controls.Add(this.labelCreatedAt);
            this.grBoxProfile.Controls.Add(this.btnChangeAvatar);
            this.grBoxProfile.Controls.Add(this.picBoxAvatar);
            this.grBoxProfile.Controls.Add(this.btnReset);
            this.grBoxProfile.Controls.Add(this.btnSave);
            this.grBoxProfile.Controls.Add(this.inputStatus);
            this.grBoxProfile.Controls.Add(this.inputRole);
            this.grBoxProfile.Controls.Add(this.inputDoB);
            this.grBoxProfile.Controls.Add(this.labelStatus);
            this.grBoxProfile.Controls.Add(this.labelRole);
            this.grBoxProfile.Controls.Add(this.inputPhone);
            this.grBoxProfile.Controls.Add(this.labelPhone);
            this.grBoxProfile.Controls.Add(this.inputEmail);
            this.grBoxProfile.Controls.Add(this.labelEmail);
            this.grBoxProfile.Controls.Add(this.labelDoB);
            this.grBoxProfile.Controls.Add(this.inputName);
            this.grBoxProfile.Controls.Add(this.labelName);
            this.grBoxProfile.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxProfile.ForeColor = System.Drawing.Color.DimGray;
            this.grBoxProfile.Location = new System.Drawing.Point(25, 22);
            this.grBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.grBoxProfile.Name = "grBoxProfile";
            this.grBoxProfile.Padding = new System.Windows.Forms.Padding(4);
            this.grBoxProfile.Size = new System.Drawing.Size(888, 533);
            this.grBoxProfile.TabIndex = 0;
            this.grBoxProfile.TabStop = false;
            this.grBoxProfile.Text = "Profile";
            // 
            // inputUpdatedAt
            // 
            this.inputUpdatedAt.BorderColor = System.Drawing.SystemColors.Control;
            this.inputUpdatedAt.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputUpdatedAt.BorderSize = 1;
            this.inputUpdatedAt.Enabled = false;
            this.inputUpdatedAt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUpdatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputUpdatedAt.Location = new System.Drawing.Point(764, 470);
            this.inputUpdatedAt.Margin = new System.Windows.Forms.Padding(5);
            this.inputUpdatedAt.Multiline = false;
            this.inputUpdatedAt.Name = "inputUpdatedAt";
            this.inputUpdatedAt.Padding = new System.Windows.Forms.Padding(5);
            this.inputUpdatedAt.PasswordChar = false;
            this.inputUpdatedAt.ReadOnly = true;
            this.inputUpdatedAt.Size = new System.Drawing.Size(89, 28);
            this.inputUpdatedAt.TabIndex = 28;
            this.inputUpdatedAt.Texts = "29-10-2023";
            this.inputUpdatedAt.Underlined = false;
            // 
            // labelUpdatedAt
            // 
            this.labelUpdatedAt.AutoSize = true;
            this.labelUpdatedAt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelUpdatedAt.Location = new System.Drawing.Point(658, 476);
            this.labelUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdatedAt.Name = "labelUpdatedAt";
            this.labelUpdatedAt.Size = new System.Drawing.Size(88, 17);
            this.labelUpdatedAt.TabIndex = 30;
            this.labelUpdatedAt.Text = "UPDATED AT";
            // 
            // inputCreatedAt
            // 
            this.inputCreatedAt.BorderColor = System.Drawing.SystemColors.Control;
            this.inputCreatedAt.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputCreatedAt.BorderSize = 1;
            this.inputCreatedAt.Enabled = false;
            this.inputCreatedAt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputCreatedAt.Location = new System.Drawing.Point(764, 445);
            this.inputCreatedAt.Margin = new System.Windows.Forms.Padding(5);
            this.inputCreatedAt.Multiline = false;
            this.inputCreatedAt.Name = "inputCreatedAt";
            this.inputCreatedAt.Padding = new System.Windows.Forms.Padding(5);
            this.inputCreatedAt.PasswordChar = false;
            this.inputCreatedAt.ReadOnly = true;
            this.inputCreatedAt.Size = new System.Drawing.Size(89, 28);
            this.inputCreatedAt.TabIndex = 27;
            this.inputCreatedAt.Texts = "29-10-2023";
            this.inputCreatedAt.Underlined = false;
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.AutoSize = true;
            this.labelCreatedAt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCreatedAt.Location = new System.Drawing.Point(658, 451);
            this.labelCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(84, 17);
            this.labelCreatedAt.TabIndex = 29;
            this.labelCreatedAt.Text = "CREATED AT";
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnChangeAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAvatar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnChangeAvatar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnChangeAvatar.Location = new System.Drawing.Point(555, 340);
            this.btnChangeAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(298, 50);
            this.btnChangeAvatar.TabIndex = 8;
            this.btnChangeAvatar.Text = "RESET AVATAR";
            this.btnChangeAvatar.UseVisualStyleBackColor = true;
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAvatar.Image = global::Student_Management_System.Properties.Resources.defaultAvatar;
            this.picBoxAvatar.Location = new System.Drawing.Point(555, 71);
            this.picBoxAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(298, 240);
            this.picBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAvatar.TabIndex = 25;
            this.picBoxAvatar.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DimGray;
            this.btnReset.Location = new System.Drawing.Point(189, 462);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(329, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "EDIT";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // inputStatus
            // 
            this.inputStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputStatus.BorderColor = System.Drawing.Color.DimGray;
            this.inputStatus.BorderSize = 1;
            this.inputStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStatus.ForeColor = System.Drawing.Color.DimGray;
            this.inputStatus.IconColor = System.Drawing.Color.DimGray;
            this.inputStatus.Items.AddRange(new object[] {
            "Normal",
            "Locked"});
            this.inputStatus.ListBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.inputStatus.Location = new System.Drawing.Point(189, 396);
            this.inputStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputStatus.Name = "inputStatus";
            this.inputStatus.Padding = new System.Windows.Forms.Padding(1);
            this.inputStatus.Size = new System.Drawing.Size(220, 36);
            this.inputStatus.TabIndex = 5;
            this.inputStatus.Texts = "";
            // 
            // inputRole
            // 
            this.inputRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputRole.BorderColor = System.Drawing.Color.DimGray;
            this.inputRole.BorderSize = 1;
            this.inputRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRole.ForeColor = System.Drawing.Color.DimGray;
            this.inputRole.IconColor = System.Drawing.Color.DimGray;
            this.inputRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.inputRole.ListBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputRole.ListTextColor = System.Drawing.Color.DimGray;
            this.inputRole.Location = new System.Drawing.Point(189, 326);
            this.inputRole.MinimumSize = new System.Drawing.Size(200, 30);
            this.inputRole.Name = "inputRole";
            this.inputRole.Padding = new System.Windows.Forms.Padding(1);
            this.inputRole.Size = new System.Drawing.Size(220, 36);
            this.inputRole.TabIndex = 4;
            this.inputRole.Texts = "";
            // 
            // inputDoB
            // 
            this.inputDoB.BorderColor = System.Drawing.Color.DimGray;
            this.inputDoB.BorderSize = 1;
            this.inputDoB.CustomFormat = "dd-MM-yyyy";
            this.inputDoB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDoB.Location = new System.Drawing.Point(189, 136);
            this.inputDoB.MinimumSize = new System.Drawing.Size(4, 35);
            this.inputDoB.Name = "inputDoB";
            this.inputDoB.Size = new System.Drawing.Size(270, 35);
            this.inputDoB.SkinColor = System.Drawing.SystemColors.Control;
            this.inputDoB.TabIndex = 1;
            this.inputDoB.TextColor = System.Drawing.Color.DimGray;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelStatus.Location = new System.Drawing.Point(42, 396);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(81, 25);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "STATUS";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelRole.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelRole.Location = new System.Drawing.Point(42, 331);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(58, 25);
            this.labelRole.TabIndex = 17;
            this.labelRole.Text = "ROLE";
            // 
            // inputPhone
            // 
            this.inputPhone.BorderColor = System.Drawing.Color.DimGray;
            this.inputPhone.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputPhone.BorderSize = 1;
            this.inputPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputPhone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputPhone.Location = new System.Drawing.Point(189, 266);
            this.inputPhone.Margin = new System.Windows.Forms.Padding(5);
            this.inputPhone.Multiline = false;
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Padding = new System.Windows.Forms.Padding(5);
            this.inputPhone.PasswordChar = false;
            this.inputPhone.ReadOnly = false;
            this.inputPhone.Size = new System.Drawing.Size(270, 36);
            this.inputPhone.TabIndex = 3;
            this.inputPhone.Texts = "0123456789";
            this.inputPhone.Underlined = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPhone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPhone.Location = new System.Drawing.Point(42, 271);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 25);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "PHONE";
            // 
            // inputEmail
            // 
            this.inputEmail.BorderColor = System.Drawing.Color.DimGray;
            this.inputEmail.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputEmail.BorderSize = 1;
            this.inputEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputEmail.Location = new System.Drawing.Point(189, 201);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(5);
            this.inputEmail.Multiline = false;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Padding = new System.Windows.Forms.Padding(5);
            this.inputEmail.PasswordChar = false;
            this.inputEmail.ReadOnly = false;
            this.inputEmail.Size = new System.Drawing.Size(270, 36);
            this.inputEmail.TabIndex = 2;
            this.inputEmail.Texts = "nguyenhoangduy@gmail.com";
            this.inputEmail.Underlined = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEmail.Location = new System.Drawing.Point(42, 206);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(69, 25);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "EMAIL";
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDoB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDoB.Location = new System.Drawing.Point(42, 141);
            this.labelDoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(50, 25);
            this.labelDoB.TabIndex = 11;
            this.labelDoB.Text = "DoB";
            // 
            // inputName
            // 
            this.inputName.BorderColor = System.Drawing.Color.DimGray;
            this.inputName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputName.BorderSize = 1;
            this.inputName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputName.Location = new System.Drawing.Point(189, 71);
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
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelName.Location = new System.Drawing.Point(42, 76);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "NAME";
            // 
            // grBoxSercurity
            // 
            this.grBoxSercurity.Controls.Add(this.labelErrorMessage);
            this.grBoxSercurity.Controls.Add(this.btnChangePassword);
            this.grBoxSercurity.Controls.Add(this.inputNewPassword);
            this.grBoxSercurity.Controls.Add(this.labelNewPassword);
            this.grBoxSercurity.Controls.Add(this.panelDeleteAccount);
            this.grBoxSercurity.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxSercurity.ForeColor = System.Drawing.Color.DimGray;
            this.grBoxSercurity.Location = new System.Drawing.Point(946, 22);
            this.grBoxSercurity.Name = "grBoxSercurity";
            this.grBoxSercurity.Size = new System.Drawing.Size(328, 421);
            this.grBoxSercurity.TabIndex = 1;
            this.grBoxSercurity.TabStop = false;
            this.grBoxSercurity.Text = "Sercurity";
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(29, 145);
            this.labelErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(270, 31);
            this.labelErrorMessage.TabIndex = 33;
            this.labelErrorMessage.Text = "Password only include (A-Z), (a-z), (1-9) and must be at least 8 characters";
            this.labelErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangePassword.Location = new System.Drawing.Point(29, 185);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(270, 36);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "CHANGE PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // inputNewPassword
            // 
            this.inputNewPassword.BorderColor = System.Drawing.Color.DimGray;
            this.inputNewPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputNewPassword.BorderSize = 1;
            this.inputNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputNewPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputNewPassword.Location = new System.Drawing.Point(29, 100);
            this.inputNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.inputNewPassword.Multiline = false;
            this.inputNewPassword.Name = "inputNewPassword";
            this.inputNewPassword.Padding = new System.Windows.Forms.Padding(5);
            this.inputNewPassword.PasswordChar = false;
            this.inputNewPassword.ReadOnly = false;
            this.inputNewPassword.Size = new System.Drawing.Size(270, 36);
            this.inputNewPassword.TabIndex = 9;
            this.inputNewPassword.Texts = "";
            this.inputNewPassword.Underlined = false;
            this.inputNewPassword.Enter += new System.EventHandler(this.inputNewPassword_Enter);
            this.inputNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputNewPassword_KeyDown);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNewPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelNewPassword.Location = new System.Drawing.Point(24, 60);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(166, 25);
            this.labelNewPassword.TabIndex = 32;
            this.labelNewPassword.Text = "NEW PASSWORD";
            // 
            // panelDeleteAccount
            // 
            this.panelDeleteAccount.Controls.Add(this.labelWarningMessage);
            this.panelDeleteAccount.Controls.Add(this.labelDeleteAccount);
            this.panelDeleteAccount.Controls.Add(this.btnDeleteAccount);
            this.panelDeleteAccount.Location = new System.Drawing.Point(29, 271);
            this.panelDeleteAccount.Name = "panelDeleteAccount";
            this.panelDeleteAccount.Size = new System.Drawing.Size(270, 119);
            this.panelDeleteAccount.TabIndex = 38;
            // 
            // labelWarningMessage
            // 
            this.labelWarningMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWarningMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelWarningMessage.ForeColor = System.Drawing.Color.DimGray;
            this.labelWarningMessage.Location = new System.Drawing.Point(0, 32);
            this.labelWarningMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarningMessage.Name = "labelWarningMessage";
            this.labelWarningMessage.Size = new System.Drawing.Size(270, 51);
            this.labelWarningMessage.TabIndex = 35;
            this.labelWarningMessage.Text = "Once you delete the account, there is no going back. Please be certain.";
            this.labelWarningMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDeleteAccount
            // 
            this.labelDeleteAccount.BorderColor = System.Drawing.Color.DimGray;
            this.labelDeleteAccount.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.labelDeleteAccount.BorderSize = 1;
            this.labelDeleteAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDeleteAccount.Enabled = false;
            this.labelDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteAccount.ForeColor = System.Drawing.Color.Red;
            this.labelDeleteAccount.Location = new System.Drawing.Point(0, 0);
            this.labelDeleteAccount.Margin = new System.Windows.Forms.Padding(5);
            this.labelDeleteAccount.Multiline = false;
            this.labelDeleteAccount.Name = "labelDeleteAccount";
            this.labelDeleteAccount.Padding = new System.Windows.Forms.Padding(5);
            this.labelDeleteAccount.PasswordChar = false;
            this.labelDeleteAccount.ReadOnly = true;
            this.labelDeleteAccount.Size = new System.Drawing.Size(270, 32);
            this.labelDeleteAccount.TabIndex = 36;
            this.labelDeleteAccount.Texts = "Delete Account";
            this.labelDeleteAccount.Underlined = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAccount.Location = new System.Drawing.Point(0, 83);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(270, 36);
            this.btnDeleteAccount.TabIndex = 37;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // labelFormStatus
            // 
            this.labelFormStatus.AutoSize = true;
            this.labelFormStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFormStatus.Location = new System.Drawing.Point(1179, 530);
            this.labelFormStatus.Name = "labelFormStatus";
            this.labelFormStatus.Size = new System.Drawing.Size(95, 25);
            this.labelFormStatus.TabIndex = 2;
            this.labelFormStatus.Text = "Editing ...";
            this.labelFormStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 579);
            this.Controls.Add(this.labelFormStatus);
            this.Controls.Add(this.grBoxSercurity);
            this.Controls.Add(this.grBoxProfile);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserDetailForm";
            this.Text = "UserDetailForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDetailForm_FormClosing);
            this.Load += new System.EventHandler(this.UserDetailForm_Load);
            this.grBoxProfile.ResumeLayout(false);
            this.grBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.grBoxSercurity.ResumeLayout(false);
            this.grBoxSercurity.PerformLayout();
            this.panelDeleteAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxProfile;
        private CustomControls.Input inputPhone;
        private System.Windows.Forms.Label labelPhone;
        private CustomControls.Input inputEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDoB;
        private CustomControls.Input inputName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelRole;
        private CustomControls.ComboBoxInput inputRole;
        private CustomControls.DateTimeInput inputDoB;
        private CustomControls.ComboBoxInput inputStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private CustomControls.Input inputUpdatedAt;
        private System.Windows.Forms.Label labelUpdatedAt;
        private CustomControls.Input inputCreatedAt;
        private System.Windows.Forms.Label labelCreatedAt;
        private System.Windows.Forms.Button btnChangeAvatar;
        private System.Windows.Forms.PictureBox picBoxAvatar;
        private System.Windows.Forms.GroupBox grBoxSercurity;
        private CustomControls.Input inputNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Button btnDeleteAccount;
        private CustomControls.Input labelDeleteAccount;
        private System.Windows.Forms.Label labelWarningMessage;
        private System.Windows.Forms.Label labelFormStatus;
        private System.Windows.Forms.Panel panelDeleteAccount;
    }
}