using SinhVienDAL.Modells;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.BUS
{
    public class SinhVienService
    {
        public List<Sinhvien> GetAll()
        {
            Model1 context = new Model1();
            return context.Sinhviens.ToList();
        }


        public Sinhvien FindByID(string id)
        {
            Model1 model1 = new Model1();
            return model1.Sinhviens.FirstOrDefault(p => p.MaSV == id);
        }

        public void AddUpdate(Sinhvien student)
        {
            Model1 model1 = new Model1();
            model1.Sinhviens.AddOrUpdate(student);
            model1.SaveChanges();
        }
    }
}
