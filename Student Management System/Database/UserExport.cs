using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Database
{
    public class UserExport
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string DateOfBirth { get; set; }
        public string Role { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
