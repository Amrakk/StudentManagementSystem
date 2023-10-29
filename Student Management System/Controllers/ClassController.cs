using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Controllers
{
    public class ClassController : DAL<Class>
    {
        public bool Add(Class entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Class entity)
        {
            throw new NotImplementedException();
        }

        public Class Get(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Class> GetAll()
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    return (from c in db.Classes select c).ToList();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool Update(Class entity)
        {
            throw new NotImplementedException();
        }
    }
}
