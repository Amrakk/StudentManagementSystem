using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_System
{
    partial class ViewListUsers
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
            dGVUsers = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVUsers).BeginInit();
            SuspendLayout();
            // 
            // dGVUsers
            // 
            dGVUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVUsers.Location = new Point(12, 12);
            dGVUsers.Name = "dGVUsers";
            dGVUsers.RowHeadersWidth = 51;
            dGVUsers.RowTemplate.Height = 29;
            dGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVUsers.Size = new Size(776, 431);
            dGVUsers.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 454);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ViewListUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(btnDelete);
            Controls.Add(dGVUsers);
            Name = "ViewListUsers";
            Text = "ViewListUsers";
            Load += ViewListUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dGVUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGVUsers;
        private Button btnDelete;
    }
}