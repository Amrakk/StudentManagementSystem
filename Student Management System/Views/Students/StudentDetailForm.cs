using Student_Management_System.Controllers;
using Student_Management_System.Database;
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
    public partial class StudentDetailForm : Form
    {
        private user _user;
        private student _student;
        private StudentController stdController;

        public StudentDetailForm(user user, string SID)
        {
            InitializeComponent();
            this._user = user;
            stdController = new StudentController();
            _student = stdController.Get(SID);
        }

        private void grBoxProfile_Enter(object sender, EventArgs e)
        {

        }
    }
}
