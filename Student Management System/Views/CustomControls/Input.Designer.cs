using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_System.Views.CustomControls
{
    partial class Input
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.Control;
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Dock = DockStyle.Fill;
            txtInput.Location = new Point(5, 5);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(236, 26);
            txtInput.TabIndex = 0;
            txtInput.Click += txtInput_Click;
            txtInput.TextChanged += txtInput_TextChanged;
            txtInput.Enter += txtInput_Enter;
            txtInput.Leave += txtInput_Leave;
            txtInput.MouseEnter += txtInput_MouseEnter;
            txtInput.MouseLeave += txtInput_MouseLeave;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // Input
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(txtInput);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.GrayText;
            Margin = new Padding(5);
            Name = "Input";
            Padding = new Padding(5);
            Size = new Size(246, 36);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox txtInput;
    }
}
