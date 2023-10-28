using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Views.Students
{
    public partial class StudentForm : Form
    {
        private user _user;
        public StudentForm(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                var users = (from u in db.students select u).ToList();

                dataGridView1.DataSource = users;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userRole = _user.role.ToLower() ?? "";
            if (!userRole.Equals("admin") && !userRole.Equals("manager")) 
            {
                MessageBox.Show("You have no priority");
                return;
            }

            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("No cell is selected", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedId = dataGridView1.SelectedCells[0].Value?.ToString();

            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("The selected cell does not contain a valid Student ID", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                student existingStudent = db.students.FirstOrDefault(p => p.id == selectedId);

                if (existingStudent == null)
                {
                    MessageBox.Show("There is no student");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        db.students.DeleteOnSubmit(existingStudent);
                        db.SubmitChanges();

                        MessageBox.Show("Deleted student");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
