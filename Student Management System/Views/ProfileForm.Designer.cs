using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_System.Views
{
    partial class ProfileForm
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
            this.labelAccount = new System.Windows.Forms.Label();
            this.grBoxAvatar = new System.Windows.Forms.GroupBox();
            this.btnChangeAvatar = new System.Windows.Forms.Button();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.grBoxAdmin = new System.Windows.Forms.GroupBox();
            this.btnLoginHistory = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.grBoxProfile = new System.Windows.Forms.GroupBox();
            this.labelUpdatedAt = new System.Windows.Forms.Label();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDoB = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.grBoxSercurity = new System.Windows.Forms.GroupBox();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.inputConfirmPassword = new Student_Management_System.Views.CustomControls.Input();
            this.inputNewPassword = new Student_Management_System.Views.CustomControls.Input();
            this.inputStatus = new Student_Management_System.Views.CustomControls.Input();
            this.inputUpdatedAt = new Student_Management_System.Views.CustomControls.Input();
            this.inputCreatedAt = new Student_Management_System.Views.CustomControls.Input();
            this.inputRole = new Student_Management_System.Views.CustomControls.Input();
            this.inputDoB = new Student_Management_System.Views.CustomControls.Input();
            this.inputPhone = new Student_Management_System.Views.CustomControls.Input();
            this.inputEmail = new Student_Management_System.Views.CustomControls.Input();
            this.inputName = new Student_Management_System.Views.CustomControls.Input();
            this.grBoxAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.grBoxAdmin.SuspendLayout();
            this.grBoxProfile.SuspendLayout();
            this.grBoxSercurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccount.Location = new System.Drawing.Point(86, 9);
            this.labelAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(156, 47);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "Account";
            // 
            // grBoxAvatar
            // 
            this.grBoxAvatar.Controls.Add(this.btnChangeAvatar);
            this.grBoxAvatar.Controls.Add(this.picBoxAvatar);
            this.grBoxAvatar.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.grBoxAvatar.Location = new System.Drawing.Point(90, 90);
            this.grBoxAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxAvatar.Name = "grBoxAvatar";
            this.grBoxAvatar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxAvatar.Size = new System.Drawing.Size(309, 352);
            this.grBoxAvatar.TabIndex = 1;
            this.grBoxAvatar.TabStop = false;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnChangeAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAvatar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnChangeAvatar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnChangeAvatar.Location = new System.Drawing.Point(6, 297);
            this.btnChangeAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(298, 50);
            this.btnChangeAvatar.TabIndex = 2;
            this.btnChangeAvatar.Text = "CHANGE AVATAR";
            this.btnChangeAvatar.UseVisualStyleBackColor = true;
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAvatar.Image = global::Student_Management_System.Properties.Resources.defaultAvatar;
            this.picBoxAvatar.Location = new System.Drawing.Point(6, 28);
            this.picBoxAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(298, 240);
            this.picBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAvatar.TabIndex = 0;
            this.picBoxAvatar.TabStop = false;
            // 
            // grBoxAdmin
            // 
            this.grBoxAdmin.Controls.Add(this.btnLoginHistory);
            this.grBoxAdmin.Controls.Add(this.btnUserManagement);
            this.grBoxAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grBoxAdmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.grBoxAdmin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grBoxAdmin.Location = new System.Drawing.Point(90, 500);
            this.grBoxAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxAdmin.Name = "grBoxAdmin";
            this.grBoxAdmin.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxAdmin.Size = new System.Drawing.Size(309, 223);
            this.grBoxAdmin.TabIndex = 2;
            this.grBoxAdmin.TabStop = false;
            this.grBoxAdmin.Text = "Admin";
            // 
            // btnLoginHistory
            // 
            this.btnLoginHistory.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLoginHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoginHistory.Location = new System.Drawing.Point(6, 147);
            this.btnLoginHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoginHistory.Name = "btnLoginHistory";
            this.btnLoginHistory.Size = new System.Drawing.Size(298, 54);
            this.btnLoginHistory.TabIndex = 1;
            this.btnLoginHistory.Text = "Login History";
            this.btnLoginHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginHistory.UseVisualStyleBackColor = false;
            this.btnLoginHistory.Click += new System.EventHandler(this.btnLoginHistory_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUserManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserManagement.Location = new System.Drawing.Point(6, 66);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(298, 54);
            this.btnUserManagement.TabIndex = 0;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // grBoxProfile
            // 
            this.grBoxProfile.Controls.Add(this.inputStatus);
            this.grBoxProfile.Controls.Add(this.inputUpdatedAt);
            this.grBoxProfile.Controls.Add(this.labelUpdatedAt);
            this.grBoxProfile.Controls.Add(this.inputCreatedAt);
            this.grBoxProfile.Controls.Add(this.labelCreatedAt);
            this.grBoxProfile.Controls.Add(this.labelStatus);
            this.grBoxProfile.Controls.Add(this.inputRole);
            this.grBoxProfile.Controls.Add(this.labelRole);
            this.grBoxProfile.Controls.Add(this.inputDoB);
            this.grBoxProfile.Controls.Add(this.inputPhone);
            this.grBoxProfile.Controls.Add(this.labelPhone);
            this.grBoxProfile.Controls.Add(this.inputEmail);
            this.grBoxProfile.Controls.Add(this.labelEmail);
            this.grBoxProfile.Controls.Add(this.labelDoB);
            this.grBoxProfile.Controls.Add(this.inputName);
            this.grBoxProfile.Controls.Add(this.labelName);
            this.grBoxProfile.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.grBoxProfile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grBoxProfile.Location = new System.Drawing.Point(460, 90);
            this.grBoxProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxProfile.Name = "grBoxProfile";
            this.grBoxProfile.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxProfile.Size = new System.Drawing.Size(950, 318);
            this.grBoxProfile.TabIndex = 3;
            this.grBoxProfile.TabStop = false;
            this.grBoxProfile.Text = "Profile";
            // 
            // labelUpdatedAt
            // 
            this.labelUpdatedAt.AutoSize = true;
            this.labelUpdatedAt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelUpdatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelUpdatedAt.Location = new System.Drawing.Point(562, 265);
            this.labelUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdatedAt.Name = "labelUpdatedAt";
            this.labelUpdatedAt.Size = new System.Drawing.Size(127, 25);
            this.labelUpdatedAt.TabIndex = 14;
            this.labelUpdatedAt.Text = "UPDATED AT";
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.AutoSize = true;
            this.labelCreatedAt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelCreatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCreatedAt.Location = new System.Drawing.Point(562, 200);
            this.labelCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(121, 25);
            this.labelCreatedAt.TabIndex = 12;
            this.labelCreatedAt.Text = "CREATED AT";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelStatus.Location = new System.Drawing.Point(562, 135);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(81, 25);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "STATUS";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelRole.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelRole.Location = new System.Drawing.Point(562, 70);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(58, 25);
            this.labelRole.TabIndex = 9;
            this.labelRole.Text = "ROLE";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPhone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPhone.Location = new System.Drawing.Point(34, 265);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 25);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "PHONE";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEmail.Location = new System.Drawing.Point(34, 200);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(69, 25);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "EMAIL";
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDoB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDoB.Location = new System.Drawing.Point(34, 135);
            this.labelDoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(50, 25);
            this.labelDoB.TabIndex = 2;
            this.labelDoB.Text = "DoB";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelName.Location = new System.Drawing.Point(34, 70);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "NAME";
            // 
            // grBoxSercurity
            // 
            this.grBoxSercurity.Controls.Add(this.labelErrorMessage);
            this.grBoxSercurity.Controls.Add(this.btnChangePassword);
            this.grBoxSercurity.Controls.Add(this.inputConfirmPassword);
            this.grBoxSercurity.Controls.Add(this.labelConfirmPassword);
            this.grBoxSercurity.Controls.Add(this.inputNewPassword);
            this.grBoxSercurity.Controls.Add(this.labelNewPassword);
            this.grBoxSercurity.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.grBoxSercurity.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grBoxSercurity.Location = new System.Drawing.Point(460, 432);
            this.grBoxSercurity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxSercurity.Name = "grBoxSercurity";
            this.grBoxSercurity.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxSercurity.Size = new System.Drawing.Size(950, 292);
            this.grBoxSercurity.TabIndex = 8;
            this.grBoxSercurity.TabStop = false;
            this.grBoxSercurity.Text = "Sercurity";
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(215, 190);
            this.labelErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(514, 32);
            this.labelErrorMessage.TabIndex = 5;
            this.labelErrorMessage.Text = "Password only include (A-Z), (a-z), (1-9) and must be at least 8 characters";
            this.labelErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.DimGray;
            this.btnChangePassword.Location = new System.Drawing.Point(215, 225);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(514, 45);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "CHANGE PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelConfirmPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelConfirmPassword.Location = new System.Drawing.Point(215, 140);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(209, 25);
            this.labelConfirmPassword.TabIndex = 2;
            this.labelConfirmPassword.Text = "CONFIRM PASSWORD";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNewPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelNewPassword.Location = new System.Drawing.Point(215, 74);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(166, 25);
            this.labelNewPassword.TabIndex = 0;
            this.labelNewPassword.Text = "NEW PASSWORD";
            // 
            // inputConfirmPassword
            // 
            this.inputConfirmPassword.BorderColor = System.Drawing.Color.DimGray;
            this.inputConfirmPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputConfirmPassword.BorderSize = 1;
            this.inputConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputConfirmPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputConfirmPassword.Location = new System.Drawing.Point(450, 135);
            this.inputConfirmPassword.Margin = new System.Windows.Forms.Padding(5);
            this.inputConfirmPassword.Multiline = false;
            this.inputConfirmPassword.Name = "inputConfirmPassword";
            this.inputConfirmPassword.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.inputConfirmPassword.PasswordChar = true;
            this.inputConfirmPassword.ReadOnly = false;
            this.inputConfirmPassword.Size = new System.Drawing.Size(280, 36);
            this.inputConfirmPassword.TabIndex = 3;
            this.inputConfirmPassword.Texts = "";
            this.inputConfirmPassword.Underlined = true;
            this.inputConfirmPassword.Enter += new System.EventHandler(this.inputConfirmPassword_Enter);
            this.inputConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputConfirmPassword_KeyDown);
            // 
            // inputNewPassword
            // 
            this.inputNewPassword.BorderColor = System.Drawing.Color.DimGray;
            this.inputNewPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputNewPassword.BorderSize = 1;
            this.inputNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputNewPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputNewPassword.Location = new System.Drawing.Point(450, 69);
            this.inputNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.inputNewPassword.Multiline = false;
            this.inputNewPassword.Name = "inputNewPassword";
            this.inputNewPassword.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.inputNewPassword.PasswordChar = true;
            this.inputNewPassword.ReadOnly = false;
            this.inputNewPassword.Size = new System.Drawing.Size(280, 36);
            this.inputNewPassword.TabIndex = 1;
            this.inputNewPassword.Texts = "";
            this.inputNewPassword.Underlined = true;
            this.inputNewPassword.Enter += new System.EventHandler(this.inputNewPassword_Enter);
            // 
            // inputStatus
            // 
            this.inputStatus.BorderColor = System.Drawing.SystemColors.Control;
            this.inputStatus.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputStatus.BorderSize = 1;
            this.inputStatus.Enabled = false;
            this.inputStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputStatus.Location = new System.Drawing.Point(724, 130);
            this.inputStatus.Margin = new System.Windows.Forms.Padding(5);
            this.inputStatus.Multiline = false;
            this.inputStatus.Name = "inputStatus";
            this.inputStatus.Padding = new System.Windows.Forms.Padding(5);
            this.inputStatus.PasswordChar = false;
            this.inputStatus.ReadOnly = true;
            this.inputStatus.Size = new System.Drawing.Size(170, 36);
            this.inputStatus.TabIndex = 16;
            this.inputStatus.Texts = "Normal";
            this.inputStatus.Underlined = false;
            // 
            // inputUpdatedAt
            // 
            this.inputUpdatedAt.BorderColor = System.Drawing.SystemColors.Control;
            this.inputUpdatedAt.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputUpdatedAt.BorderSize = 1;
            this.inputUpdatedAt.Enabled = false;
            this.inputUpdatedAt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputUpdatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputUpdatedAt.Location = new System.Drawing.Point(724, 260);
            this.inputUpdatedAt.Margin = new System.Windows.Forms.Padding(5);
            this.inputUpdatedAt.Multiline = false;
            this.inputUpdatedAt.Name = "inputUpdatedAt";
            this.inputUpdatedAt.Padding = new System.Windows.Forms.Padding(5);
            this.inputUpdatedAt.PasswordChar = false;
            this.inputUpdatedAt.ReadOnly = true;
            this.inputUpdatedAt.Size = new System.Drawing.Size(215, 36);
            this.inputUpdatedAt.TabIndex = 15;
            this.inputUpdatedAt.Texts = "10-10-2023";
            this.inputUpdatedAt.Underlined = false;
            // 
            // inputCreatedAt
            // 
            this.inputCreatedAt.BorderColor = System.Drawing.SystemColors.Control;
            this.inputCreatedAt.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputCreatedAt.BorderSize = 1;
            this.inputCreatedAt.Enabled = false;
            this.inputCreatedAt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputCreatedAt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputCreatedAt.Location = new System.Drawing.Point(724, 195);
            this.inputCreatedAt.Margin = new System.Windows.Forms.Padding(5);
            this.inputCreatedAt.Multiline = false;
            this.inputCreatedAt.Name = "inputCreatedAt";
            this.inputCreatedAt.Padding = new System.Windows.Forms.Padding(5);
            this.inputCreatedAt.PasswordChar = false;
            this.inputCreatedAt.ReadOnly = true;
            this.inputCreatedAt.Size = new System.Drawing.Size(215, 36);
            this.inputCreatedAt.TabIndex = 13;
            this.inputCreatedAt.Texts = "10-10-2023";
            this.inputCreatedAt.Underlined = false;
            // 
            // inputRole
            // 
            this.inputRole.BorderColor = System.Drawing.SystemColors.Control;
            this.inputRole.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputRole.BorderSize = 1;
            this.inputRole.Enabled = false;
            this.inputRole.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputRole.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputRole.Location = new System.Drawing.Point(724, 65);
            this.inputRole.Margin = new System.Windows.Forms.Padding(5);
            this.inputRole.Multiline = false;
            this.inputRole.Name = "inputRole";
            this.inputRole.Padding = new System.Windows.Forms.Padding(5);
            this.inputRole.PasswordChar = false;
            this.inputRole.ReadOnly = true;
            this.inputRole.Size = new System.Drawing.Size(170, 36);
            this.inputRole.TabIndex = 10;
            this.inputRole.Texts = "Admin";
            this.inputRole.Underlined = false;
            // 
            // inputDoB
            // 
            this.inputDoB.BorderColor = System.Drawing.SystemColors.Control;
            this.inputDoB.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputDoB.BorderSize = 1;
            this.inputDoB.Enabled = false;
            this.inputDoB.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputDoB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputDoB.Location = new System.Drawing.Point(181, 130);
            this.inputDoB.Margin = new System.Windows.Forms.Padding(5);
            this.inputDoB.Multiline = false;
            this.inputDoB.Name = "inputDoB";
            this.inputDoB.Padding = new System.Windows.Forms.Padding(5);
            this.inputDoB.PasswordChar = false;
            this.inputDoB.ReadOnly = true;
            this.inputDoB.Size = new System.Drawing.Size(246, 36);
            this.inputDoB.TabIndex = 8;
            this.inputDoB.Texts = "12-08-2003";
            this.inputDoB.Underlined = false;
            // 
            // inputPhone
            // 
            this.inputPhone.BorderColor = System.Drawing.SystemColors.Control;
            this.inputPhone.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputPhone.BorderSize = 1;
            this.inputPhone.Enabled = false;
            this.inputPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputPhone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputPhone.Location = new System.Drawing.Point(181, 260);
            this.inputPhone.Margin = new System.Windows.Forms.Padding(5);
            this.inputPhone.Multiline = false;
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Padding = new System.Windows.Forms.Padding(5);
            this.inputPhone.PasswordChar = false;
            this.inputPhone.ReadOnly = true;
            this.inputPhone.Size = new System.Drawing.Size(270, 36);
            this.inputPhone.TabIndex = 7;
            this.inputPhone.Texts = "0123456789";
            this.inputPhone.Underlined = false;
            // 
            // inputEmail
            // 
            this.inputEmail.BorderColor = System.Drawing.SystemColors.Control;
            this.inputEmail.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputEmail.BorderSize = 1;
            this.inputEmail.Enabled = false;
            this.inputEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputEmail.Location = new System.Drawing.Point(181, 195);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(5);
            this.inputEmail.Multiline = false;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Padding = new System.Windows.Forms.Padding(5);
            this.inputEmail.PasswordChar = false;
            this.inputEmail.ReadOnly = true;
            this.inputEmail.Size = new System.Drawing.Size(270, 36);
            this.inputEmail.TabIndex = 5;
            this.inputEmail.Texts = "nguyenhoangduy@gmail.com";
            this.inputEmail.Underlined = false;
            // 
            // inputName
            // 
            this.inputName.BorderColor = System.Drawing.SystemColors.Control;
            this.inputName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputName.BorderSize = 1;
            this.inputName.Enabled = false;
            this.inputName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.inputName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputName.Location = new System.Drawing.Point(181, 65);
            this.inputName.Margin = new System.Windows.Forms.Padding(5);
            this.inputName.Multiline = false;
            this.inputName.Name = "inputName";
            this.inputName.Padding = new System.Windows.Forms.Padding(5);
            this.inputName.PasswordChar = false;
            this.inputName.ReadOnly = true;
            this.inputName.Size = new System.Drawing.Size(270, 36);
            this.inputName.TabIndex = 1;
            this.inputName.Texts = "Nguyen Hoang Duy";
            this.inputName.Underlined = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.grBoxSercurity);
            this.Controls.Add(this.grBoxProfile);
            this.Controls.Add(this.grBoxAdmin);
            this.Controls.Add(this.grBoxAvatar);
            this.Controls.Add(this.labelAccount);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileForm_FormClosing);
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.grBoxAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.grBoxAdmin.ResumeLayout(false);
            this.grBoxProfile.ResumeLayout(false);
            this.grBoxProfile.PerformLayout();
            this.grBoxSercurity.ResumeLayout(false);
            this.grBoxSercurity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAccount;
        private GroupBox grBoxAvatar;
        private PictureBox picBoxAvatar;
        private Button btnChangeAvatar;
        private GroupBox grBoxAdmin;
        private Button btnLoginHistory;
        private Button btnUserManagement;
        private GroupBox grBoxProfile;
        private Label labelName;
        private CustomControls.Input inputName;
        private CustomControls.Input inputPhone;
        private Label labelPhone;
        private CustomControls.Input inputEmail;
        private Label labelEmail;
        private Label labelDoB;
        private GroupBox grBoxSercurity;
        private Button btnChangePassword;
        private CustomControls.Input inputConfirmPassword;
        private Label labelConfirmPassword;
        private CustomControls.Input inputNewPassword;
        private Label labelNewPassword;
        private Label labelErrorMessage;
        private CustomControls.Input inputDoB;
        private CustomControls.Input inputStatus;
        private CustomControls.Input inputUpdatedAt;
        private Label labelUpdatedAt;
        private CustomControls.Input inputCreatedAt;
        private Label labelCreatedAt;
        private Label labelStatus;
        private CustomControls.Input inputRole;
        private Label labelRole;
    }
}