using LAB__05DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB__05BUS
{
    public class MajorService
    {
        public List<Major> getAllbyFa(int faID)
        {
            StudentModel mo = new StudentModel();
            return mo.Majors.Where(p => p.FacultyID == faID).ToList();
        }
    }
}
