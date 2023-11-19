using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Controllers
{
    public class LoginHistoryController : DAL<loginhistory>
    {
        public bool Add(loginhistory entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(loginhistory entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllSameEmail (string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    var loginHistoryRecordsToDelete = db.loginhistories.Where(lh => lh.email.Equals(email));
                    db.loginhistories.DeleteAllOnSubmit(loginHistoryRecordsToDelete);
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

        public loginhistory Get(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<loginhistory> GetAll()
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString)) 
            {
                try
                {
                    var loginList = db.loginhistories.ToList();
                    var loginHistories = (from lh in loginList
                                          select new loginhistory
                                          {
                                              id = lh.id,
                                              email = lh.email,
                                              history = lh.history
                                          }).ToList();

                    return loginHistories;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool Update(loginhistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
