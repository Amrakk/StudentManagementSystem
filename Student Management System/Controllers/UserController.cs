using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Student_Management_System.Controllers
{
    public class UserController : DAL<user>
    {
        public bool Add(user entity)
        {
            if (entity == null)
            {
                return false;
            }

            Regex emailEx = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
            Regex passEx = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            Regex phoneEx = new Regex("^(?:\\d{10}|\\d{3}[-\\s]?\\d{3}[-\\s]?\\d{4})$");

            if (!string.IsNullOrEmpty(entity.email) &&
                emailEx.IsMatch(entity.email) &&
                !string.IsNullOrEmpty(entity.name) &&
                !string.IsNullOrEmpty(entity.password) &&
                passEx.IsMatch(entity.password) &&
                !string.IsNullOrEmpty(entity.phone) &&
                phoneEx.IsMatch(entity.phone) &&
                !string.IsNullOrEmpty(entity.role) &&
                (entity.age >= 0 && entity.age <= 100))
            {
                string hashPassword = BCrypt.Net.BCrypt.HashPassword(entity.password, 10);
                var newUser = new user
                {
                    email = entity.email,
                    name = entity.name,
                    password = hashPassword,
                    phone = entity.phone.Replace(" ", "").Replace("-", ""),
                    role = entity.role,
                    dob = entity.dob,
                    status = entity.status,
                    age = entity.age
                };

                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    try
                    {
                        db.users.InsertOnSubmit(newUser);
                        db.SubmitChanges();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return false;
        }

        public bool Delete(user entity)
        {
            if (entity == null || string.IsNullOrEmpty(entity.email))
            {
                return false;
            }

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    bool isDeletedAllLoginHistory = new LoginHistoryController().DeleteAllSameEmail(entity.email);

                    if (isDeletedAllLoginHistory)
                    {
                        var entityToDelete = db.users.FirstOrDefault(u => u.email.Equals(entity.email));

                        if (entityToDelete != null)
                        {
                            db.users.DeleteOnSubmit(entityToDelete);
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
        }

        public user Get(string email)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    return db.users.FirstOrDefault(u => u.email == email);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public ICollection<user> GetAll()
        {
            ICollection<user> users = new List<user>();
            try
            {
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    users = (from u in db.users select u).ToList();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return users;
        }

        public bool Update(user entity)
        {
            if (entity == null || string.IsNullOrEmpty(entity.email))
            {
                return false;
            }

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    var userToUpdate = Get(entity.email);
                    if (userToUpdate != null)
                    {
                        if (!string.IsNullOrEmpty(entity.email))
                        {
                            userToUpdate.email = entity.email;
                        }

                        if (!string.IsNullOrEmpty(entity.password))
                        {
                            userToUpdate.password = entity.password;
                        }

                        if (!string.IsNullOrEmpty(entity.role))
                        {
                            userToUpdate.role = entity.role;
                        }

                        if (!string.IsNullOrEmpty(entity.status))
                        {
                            userToUpdate.status = entity.status;
                        }

                        if (!string.IsNullOrEmpty(entity.name))
                        {
                            userToUpdate.name = entity.name;
                        }

                        if (!string.IsNullOrEmpty(entity.phone))
                        {
                            userToUpdate.phone = entity.phone;
                        }

                        if (entity.dob != null)
                        {
                            userToUpdate.dob = entity.dob.Value.Date;
                            int age = entity.dob.Value.Year - DateTime.Now.Year;
                            userToUpdate.age = age;
                        }

                        userToUpdate.updatedAt = DateTime.Now;

                        db.SubmitChanges();
                        return true;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return false;
        }
    }
}
