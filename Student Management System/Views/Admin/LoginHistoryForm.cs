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

namespace Student_Management_System.Views.Admin
{
    public partial class LoginHistoryForm : Form
    {
        private user _user;
        LoginHistoryController _controller;
        public LoginHistoryForm(user _user)
        {
            InitializeComponent();
            this._user = _user;
            _controller = new LoginHistoryController();
        }

        private void LoginHistoryForm_Load(object sender, EventArgs e)
        {
            if (!_user.role.Equals("Admin"))
            {
                MessageBox.Show("You have no priority");
                return;
            }

            dataGridView1.DataSource = _controller.GetAll();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }
    }
}
