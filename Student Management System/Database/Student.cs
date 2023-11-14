using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Database
{
    public class Student
    {
        public string SID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Class { get; set; }
        public string Type { get; set; }
        public string Department { get; set; }
        public string Major { get; set; }
        public string CourseYear { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
