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
    public partial class UserDetailForm : Form
    {

        // Add new user
        public UserDetailForm()
        {
            InitializeComponent();
            inputNewPassword.Texts = "User Phone number";
        }

        // Edit user
        public UserDetailForm(String userID)
        {
            InitializeComponent();
        }

    }
}
