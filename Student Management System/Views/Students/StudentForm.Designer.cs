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
            labelStudent = new Label();
            SuspendLayout();
            // 
            // labelStudent
            // 
            labelStudent.AutoSize = true;
            labelStudent.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudent.ForeColor = SystemColors.ControlText;
            labelStudent.Location = new Point(90, 30);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(150, 47);
            labelStudent.TabIndex = 0;
            labelStudent.Text = "Student";
            // 
            // StudentForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 761);
            Controls.Add(labelStudent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForms";
            Text = "StudentForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStudent;
    }
}