using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Controllers
{
    public interface DAL<T>
    {
        ICollection<T> GetAll();
        T Get(string id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
