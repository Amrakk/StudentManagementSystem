namespace Student_Management_System.Views.Admin
{
    partial class LoginHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginhistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginhistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.historyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginhistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 36;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 487);
            this.dataGridView1.TabIndex = 1;
            // 
            // loginhistoryBindingSource
            // 
            this.loginhistoryBindingSource.DataSource = typeof(Student_Management_System.Database.loginhistory);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 245;
            // 
            // historyDataGridViewTextBoxColumn
            // 
            this.historyDataGridViewTextBoxColumn.DataPropertyName = "history";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.historyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.historyDataGridViewTextBoxColumn.HeaderText = "Accessed";
            this.historyDataGridViewTextBoxColumn.Name = "historyDataGridViewTextBoxColumn";
            this.historyDataGridViewTextBoxColumn.ReadOnly = true;
            this.historyDataGridViewTextBoxColumn.Width = 225;
            // 
            // LoginHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 511);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginHistoryForm";
            this.Text = "Login History";
            this.Load += new System.EventHandler(this.LoginHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginhistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loginhistoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyDataGridViewTextBoxColumn;
    }
}