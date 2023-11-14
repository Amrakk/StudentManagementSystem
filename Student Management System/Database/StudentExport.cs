using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Database
{
    public class StudentExport
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public string Department { get; set; }
        public string Major { get; set; }
        public string CourseYear { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string EducationType { get; set; }
    }
}
