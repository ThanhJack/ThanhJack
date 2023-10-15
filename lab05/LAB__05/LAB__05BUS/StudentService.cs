using LAB__05DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB__05BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            StudentModel context = new StudentModel();
            return context.Students.ToList();
        }

        public List<Student> GetAllHasNoMajor()
        {
            StudentModel cont = new StudentModel();
            return cont.Students.Where(p => p.MajorID == null).ToList();
        }

        public List<Student> GetAllHasNoMajor(int fa)
        {
            StudentModel con = new StudentModel();
            return con.Students.Where(p => p.MajorID == null && p.FacultyID == fa).ToList();
        }

        public Student FindByID(string id)
        {
            StudentModel model1 = new StudentModel();
            return model1.Students.FirstOrDefault(p => p.StudentID == id);
        }

        public void AddUpdate(Student student)
        {
            StudentModel model1 = new StudentModel();
            model1.Students.AddOrUpdate(student);
            model1.SaveChanges();
        }

    }
}
