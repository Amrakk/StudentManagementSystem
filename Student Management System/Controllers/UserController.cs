using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

            Regex phoneEx = new Regex("^[0-9]{10,}$");
            Regex passEx = new Regex("^[a-zA-Z0-9]{8,}$");
            Regex emailEx = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
            
            if (!string.IsNullOrEmpty(entity.email) &&
                !string.IsNullOrEmpty(entity.role) &&
                !string.IsNullOrEmpty(entity.name) &&
                !string.IsNullOrEmpty(entity.phone) &&
                !string.IsNullOrEmpty(entity.status) &&
                !string.IsNullOrEmpty(entity.password) &&
                emailEx.IsMatch(entity.email) &&
                phoneEx.IsMatch(entity.phone) &&
                passEx.IsMatch(entity.password) &&
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
                    age = entity.age,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
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
                        MessageBox.Show(ex.Message);
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
                    MessageBox.Show(ex.Message);
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

        public ICollection<user> GetUserByName(string text)
        {
            using(var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    return db.users.Where(u => u.name.Contains(text)).ToList();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public ICollection<user> GetUserByCriteria(int age = 0, string status = "", string role = "")
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    var users = db.users.AsQueryable();
                    if (age > 0)
                    {
                        users = users.Where(u => u.age >= age);
                    }

                    if (!string.IsNullOrEmpty(status))
                    {
                        users = users.Where(u => u.status == status);
                    }

                    if (!string.IsNullOrEmpty(role))
                    {
                        users = users.Where(u => u.role == role);
                    }

                    return users.ToList();
                    
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
                    var userToUpdate = db.users.FirstOrDefault(u => u.email.Equals(entity.email));
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
                            int age = DateTime.Now.Year - entity.dob.Value.Year;
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
