using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Controllers
{
    public class MajorController : DAL<Major>
    {
        public bool Add(Major entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Major entity)
        {
            throw new NotImplementedException();
        }

        public Major Get(string id)
        {
            using(var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    return db.Majors.SingleOrDefault(m => m.majorId == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public ICollection<Major> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<Major> GetAllByDepartment(String departID)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    return (from m in db.Majors where m.department == departID select m).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool Update(Major entity)
        {
            throw new NotImplementedException();
        }
    }
}
