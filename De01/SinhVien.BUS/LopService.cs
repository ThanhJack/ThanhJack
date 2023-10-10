using SinhVienDAL.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.BUS
{
    public class LopService
    {
        public List<Lop> GetAll()
        {
            Model1 con = new Model1();
            return con.Lops.ToList();
        }

    }
}
