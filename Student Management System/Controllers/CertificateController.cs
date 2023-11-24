using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Student_Management_System.Controllers
{
    public class CertificateController : DAL<certificate>
    {
        public bool Add(certificate entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    db.certificates.InsertOnSubmit(entity);
                    db.SubmitChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(certificate entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    var entityToDelete = db.certificates.FirstOrDefault(c => c.id.Equals(entity.id));

                    if (entityToDelete != null)
                    {
                        db.certificates.DeleteOnSubmit(entityToDelete);
                        db.SubmitChanges();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public certificate Get(string id)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    return db.certificates.FirstOrDefault(c => c.id == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public ICollection<certificate> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<certificate> GetAllByStudent(student std)
        {
            if (std == null)
            {
                return null;
            }

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    var certificates = (from c in db.certificates.ToList()
                                        where c.sid == std.id
                                        select new certificate
                                        {
                                            id = c.id,
                                            title = c.title,
                                            description = c.description,
                                            issue_date = c.issue_date,
                                            expiry_date = c.expiry_date,
                                            organization_name = c.organization_name,
                                            isValid = c.isValid,
                                            sid = c.sid,
                                            createdAt = c.createdAt,
                                            updatedAt = c.updatedAt
                                        }).ToList();

                    return certificates;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool Update(certificate entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    certificate updatedCertificate = db.certificates.FirstOrDefault(c => c.id.Equals(entity.id));

                    if (updatedCertificate == null)
                    {
                        return false;
                    }

                    if (!string.IsNullOrEmpty(entity.title))
                    {
                        updatedCertificate.title = entity.title;
                    }

                    if (!string.IsNullOrEmpty(entity.description))
                    {
                        updatedCertificate.description = entity.description;
                    }

                    if (entity.issue_date != null)
                    {
                        updatedCertificate.issue_date = entity.issue_date;
                    }

                    if (entity.expiry_date != null)
                    {
                        updatedCertificate.expiry_date = entity.expiry_date;
                    }

                    if (!string.IsNullOrEmpty(entity.organization_name))
                    {
                        updatedCertificate.organization_name = entity.organization_name;
                    }

                    if (entity.isValid != null)
                    {
                        updatedCertificate.isValid = entity.isValid;
                    }

                    if (entity.sid != null)
                    {
                        updatedCertificate.sid = entity.sid;
                    }

                    updatedCertificate.updatedAt = entity.updatedAt;
                    db.SubmitChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool DeleteCertificateBySID(string sid)
        {
            if (string.IsNullOrEmpty(sid))
            {
                return false;
            }

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    var certificatesToDelete = db.certificates.Where(c => c.sid.Equals(sid));
                    db.certificates.DeleteAllOnSubmit(certificatesToDelete);
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }
}
