using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinhVienDAL.Modells;
using SinhVien.BUS;

namespace frmSinhvien
{
    public partial class frmSinhvien : Form
    {

        Model1 contextDB = new Model1();

        private readonly SinhVienService sv = new SinhVienService();
        public readonly LopService lsv = new LopService();

        public frmSinhvien()
        {
            InitializeComponent();
            
        }

        private void TaoHeaderCol()
        {
            lvSinhvien.Columns.Add("Mã SV");
            lvSinhvien.Columns.Add("Họ và tên");
            lvSinhvien.Columns.Add("Ngày sinh");
            lvSinhvien.Columns.Add("Lớp");
        }

        DataTable dataTable = new DataTable();
        public void showlv()
        {
            var dl=contextDB.Sinhviens.ToList();

            foreach (var item in dl)
            {
                ListViewItem listIt=new ListViewItem(item.MaSV.ToString());
                listIt.SubItems.Add(item.HotenSV.ToString());
                listIt.SubItems.Add(item.Lop.ToString());
                listIt.SubItems.Add(item.Ngaysinh.ToString());
                lvSinhvien.Items.Add(listIt);
            }
        }


        /*
                private void loadLop()
                {
                    lvSinhvien.Items.Clear();
                    cboLop.Items.Add=lsv.GetAll().ToList();
                }*/
        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            TaoHeaderCol();
            dtNgaysinh.Format = DateTimePickerFormat.Short;
            dtNgaysinh.Value = DateTime.Now;
            showlv();
        }
/*
        private void additem(Object obj)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = obj.;
            lvSinhvien.Items.Add
        }
*/

        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem item=new ListViewItem(txtHotenSV.Text);
            item.SubItems.Add(txtHotenSV.Text);
            item.SubItems.Add(cboLop.Text);
            item.SubItems.Add(dtNgaysinh.Value.ToString());
            lvSinhvien.Items.Add(item);
        }
    }
}
