﻿using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Dynamic.Core;

namespace Student_Management_System.Controllers
{
    public class StudentController : DAL<student>
    {
        public bool Add(student entity)
        {
            if (entity == null || string.IsNullOrEmpty(entity.id))
            {
                return false;
            }

            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    db.students.InsertOnSubmit(entity);
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public bool Delete(student entity)
        {
            if (entity == null || string.IsNullOrEmpty(entity.id))
            {
                Console.WriteLine("There is no student");
                return false;
            }

            try
            {
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    db.students.DeleteOnSubmit(entity);
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

        public student Get(string id)
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    return db.students.FirstOrDefault(s => s.id == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public ICollection<student> GetAll()
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                try
                {
                    var studentList = db.students.ToList();
                    List<student> students = (from s in studentList
                                              select new student
                                              {
                                                  id = s.id,
                                                  name = s.name,
                                                  gender = s.gender,
                                                  dob = s.dob,
                                                  className = s.className,
                                                  eduType = s.eduType,
                                                  Department1 = new Department { departId = s.Department1.departId, departName = s.Department1.departName },
                                                  Major1 = new Major { majorId = s.Major1.majorId, majorName = s.Major1.majorName },
                                                  courseYear = s.courseYear,
                                                  createdAt = s.createdAt,
                                                  updatedAt = s.updatedAt
                                              }).ToList();
                    return students;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool Update(student entity)
        {
            if (entity == null)
            {
                Console.WriteLine("No student");
                return false;
            }

            try
            {
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    student updatedStudent = Get(entity.id);

                    if (updatedStudent == null)
                    {
                        return false;
                    }

                    if (!string.IsNullOrEmpty(entity.name))
                    {
                        updatedStudent.name = entity.name;
                    }

                    if (!string.IsNullOrEmpty(entity.gender))
                    {
                        updatedStudent.gender = entity.gender;
                    }

                    if (!string.IsNullOrEmpty(entity.eduType))
                    {
                        updatedStudent.eduType = entity.eduType;
                    }

                    if (!string.IsNullOrEmpty(entity.className))
                    {
                        updatedStudent.eduType = entity.className;
                    }

                    if (!string.IsNullOrEmpty(entity.courseYear))
                    {
                        updatedStudent.eduType = entity.courseYear;
                    }

                    if (entity.dob != null)
                    {
                        updatedStudent.dob = entity.dob;
                    }

                    if (!string.IsNullOrEmpty(entity.department))
                    {
                        updatedStudent.department = entity.department;
                    }

                    if (!string.IsNullOrEmpty(entity.major))
                    {
                        updatedStudent.major = entity.major;
                    }

                    updatedStudent.updatedAt = DateTime.Now;
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

        public int TotalStudents()
        {
            using (var db = new MidTermDBDataContext(Program.ConnectionString))
            {
                return (from row in db.students select row).Count();
            }
        }

        public ICollection<student> SortByCriterion(string columnName, bool asc = true)
        {
            try
            {
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    string orderExpression = columnName + (asc ? " ascending" : " descending");

                    var orderedStudents = db.students.OrderBy(orderExpression).ToList();
                    return orderedStudents;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public ICollection<student> FilterStudents(string id, string name, string gender, string className, string departmentName, string majorName, int? courseYear, string eduType, DateTime? dob)
        {
            try
            {
                using (var db = new MidTermDBDataContext(Program.ConnectionString))
                {
                    var query = db.students.AsQueryable();

                    if (!string.IsNullOrEmpty(id))
                    {
                        query = query.Where(s => s.id.Equals(id));
                    }

                    if (!string.IsNullOrEmpty(name))
                    {
                        query = query.Where(s => s.name.Contains(name));
                    }

                    if (!string.IsNullOrEmpty(gender))
                    {
                        query = query.Where(s => s.gender.Equals(gender));
                    }

                    if (!string.IsNullOrEmpty(className))
                    {
                        query = query.Where(s => s.className.Equals(className));
                    }

                    if (!string.IsNullOrEmpty(departmentName))
                    {
                        query = query.Where(s => s.Department1.departName.Equals(departmentName));
                    }

                    if (!string.IsNullOrEmpty(majorName))
                    {
                        query = query.Where(s => s.Major1.majorName.Equals(majorName));
                    }

                    if (courseYear.HasValue && courseYear.Value >= 0 && courseYear.Value <= DateTime.Now.Year)
                    {
                        int year;
                        query = query.Where(s => int.TryParse(s.courseYear, out year) && year == courseYear);
                    }

                    if (dob != null)
                    {
                        var dobDate = dob.Value.Date;
                        query = query.Where(s => s.dob == dobDate);
                    }

                    var matchingStudents = query.ToList();
                    return matchingStudents;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
