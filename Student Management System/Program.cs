using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public static class Program
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["Student_Management_System.Properties.Settings.midtermdotnetConnectionString"].ConnectionString;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.Auth.LoginForm());
            //Application.Run(new AddUserForm(new user() { email = "admin@gmail.com" }));
        }
    }
}
