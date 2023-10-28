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
        public LoginHistoryForm(user _user)
        {
            InitializeComponent();
            this._user = _user;
        }

        private void LoginHistoryForm_Load(object sender, EventArgs e)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                db.DeferredLoadingEnabled = false;
                string userRole = _user.role?.ToLower() ?? "";
                if (!userRole.Equals("admin"))
                {
                    MessageBox.Show("You have no priority");
                    return;
                }

                var histories = (from u in db.loginhistories
                                 select new
                                 {
                                     u.id,
                                     u.email,
                                     u.history
                                 }).ToList();

                dataGridView1.DataSource = histories;
            }
        }
    }
}
