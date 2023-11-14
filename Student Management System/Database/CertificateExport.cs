using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Database
{
    public class CertificateExport
    {
        public string CertificateID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IssueDate { get; set; }
        public string ExpiryDate { get; set; }
        public string OrganizationName { get; set; }
        public bool? IsValid { get; set; }
        public string SID { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
