using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_System.Views.Admin
{
    partial class UserForm
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
            this.labelUser = new System.Windows.Forms.Label();
            this.gridViewUser = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.inputStatus = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelStatus = new System.Windows.Forms.Label();
            this.inputRole = new Student_Management_System.Views.CustomControls.ComboBoxInput();
            this.labelRole = new System.Windows.Forms.Label();
            this.inputAge = new Student_Management_System.Views.CustomControls.Input();
            this.labelAge = new System.Windows.Forms.Label();
            this.inputSearch = new Student_Management_System.Views.CustomControls.Input();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(90, 30);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(118, 60);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User";
            // 
            // gridViewUser
            // 
            this.gridViewUser.AllowUserToAddRows = false;
            this.gridViewUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewUser.AutoGenerateColumns = false;
            this.gridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.gridViewUser.DataSource = this.userBindingSource;
            this.gridViewUser.Location = new System.Drawing.Point(98, 171);
            this.gridViewUser.Name = "gridViewUser";
            this.gridViewUser.ReadOnly = true;
            this.gridViewUser.RowHeadersWidth = 51;
            this.gridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewUser.Size = new System.Drawing.Size(1278, 524);
            this.gridViewUser.TabIndex = 1;
            this.gridViewUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewUser_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 290;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dobDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Width = 180;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 310;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 180;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 137;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 138;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Student_Management_System.Database.user);
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
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
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
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.btnApply);
            this.panelFilter.Controls.Add(this.btnClear);
            this.panelFilter.Controls.Add(this.inputStatus);
            this.panelFilter.Controls.Add(this.labelStatus);
            this.panelFilter.Controls.Add(this.inputRole);
            this.panelFilter.Controls.Add(this.labelRole);
            this.panelFilter.Controls.Add(this.inputAge);
            this.panelFilter.Controls.Add(this.labelAge);
            this.panelFilter.Location = new System.Drawing.Point(623, 150);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(224, 175);
            this.panelFilter.TabIndex = 8;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnApply.Location = new System.Drawing.Point(137, 134);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(72, 29);
            this.btnApply.TabIndex = 10;
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
            this.btnClear.Location = new System.Drawing.Point(59, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 29);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // inputStatus
            // 
            this.inputStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputStatus.BorderColor = System.Drawing.Color.DimGray;
            this.inputStatus.BorderSize = 1;
            this.inputStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStatus.ForeColor = System.Drawing.Color.DimGray;
            this.inputStatus.IconColor = System.Drawing.Color.DimGray;
            this.inputStatus.Items.AddRange(new object[] {
            "Normal",
            "Locked"});
            this.inputStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.inputStatus.Location = new System.Drawing.Point(71, 96);
            this.inputStatus.Margin = new System.Windows.Forms.Padding(0);
            this.inputStatus.MinimumSize = new System.Drawing.Size(100, 24);
            this.inputStatus.Name = "inputStatus";
            this.inputStatus.Padding = new System.Windows.Forms.Padding(1);
            this.inputStatus.Size = new System.Drawing.Size(138, 26);
            this.inputStatus.TabIndex = 76;
            this.inputStatus.Texts = "";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelStatus.Location = new System.Drawing.Point(17, 100);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 23);
            this.labelStatus.TabIndex = 75;
            this.labelStatus.Text = "Status";
            // 
            // inputRole
            // 
            this.inputRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputRole.BorderColor = System.Drawing.Color.DimGray;
            this.inputRole.BorderSize = 1;
            this.inputRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inputRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRole.ForeColor = System.Drawing.Color.DimGray;
            this.inputRole.IconColor = System.Drawing.Color.DimGray;
            this.inputRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.inputRole.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.inputRole.ListTextColor = System.Drawing.Color.DimGray;
            this.inputRole.Location = new System.Drawing.Point(71, 56);
            this.inputRole.Margin = new System.Windows.Forms.Padding(0);
            this.inputRole.MinimumSize = new System.Drawing.Size(100, 24);
            this.inputRole.Name = "inputRole";
            this.inputRole.Padding = new System.Windows.Forms.Padding(1);
            this.inputRole.Size = new System.Drawing.Size(138, 26);
            this.inputRole.TabIndex = 74;
            this.inputRole.Texts = "";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelRole.Location = new System.Drawing.Point(17, 60);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(45, 23);
            this.labelRole.TabIndex = 73;
            this.labelRole.Text = "Role";
            // 
            // inputAge
            // 
            this.inputAge.BorderColor = System.Drawing.Color.DimGray;
            this.inputAge.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputAge.BorderSize = 1;
            this.inputAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAge.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inputAge.Location = new System.Drawing.Point(71, 16);
            this.inputAge.Margin = new System.Windows.Forms.Padding(5);
            this.inputAge.Multiline = false;
            this.inputAge.Name = "inputAge";
            this.inputAge.Padding = new System.Windows.Forms.Padding(4);
            this.inputAge.PasswordChar = false;
            this.inputAge.ReadOnly = false;
            this.inputAge.Size = new System.Drawing.Size(70, 32);
            this.inputAge.TabIndex = 72;
            this.inputAge.Texts = "";
            this.inputAge.Underlined = false;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelAge.Location = new System.Drawing.Point(17, 20);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(59, 23);
            this.labelAge.TabIndex = 71;
            this.labelAge.Text = "Age ≥";
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
            this.inputSearch.TabIndex = 5;
            this.inputSearch.Texts = "";
            this.inputSearch.Underlined = false;
            this.inputSearch.Enter += new System.EventHandler(this.inputSearch_Enter);
            this.inputSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSearch_KeyDown);
            this.inputSearch.Leave += new System.EventHandler(this.inputSearch_Leave);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gridViewUser);
            this.Controls.Add(this.labelUser);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUser;
        private DataGridView gridViewUser;
        private Button btnExport;
        private Button btnImport;
        private Button btnCreate;
        private CustomControls.Input inputSearch;
        private Button btnSearch;
        private Button btnFilter;
        private Panel panelFilter;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private Label labelAge;
        private CustomControls.ComboBoxInput inputRole;
        private Label labelRole;
        private CustomControls.Input inputAge;
        private CustomControls.ComboBoxInput inputStatus;
        private Label labelStatus;
        private Button btnApply;
        private Button btnClear;
    }
}