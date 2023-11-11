using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Controllers
{
    public class DepartmentController : DAL<Department>
    {
        public bool Add(Department entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public Department Get(string id)
        {
            using(var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    return (from dp in db.Departments where dp.departId == id select dp).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public ICollection<Department> GetAll()
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    return (from dp in db.Departments select dp).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }    
            }
        }

        public bool Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
