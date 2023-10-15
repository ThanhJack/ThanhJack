using LAB__05DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB__05BUS
{
    public class FacultyService
    {        public List<Faculty> GetAll()
        {
            StudentModel con = new StudentModel();
            return con.Faculties.ToList();
        }
    }
}
