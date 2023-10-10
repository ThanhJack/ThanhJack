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

        

        DataTable dataTable = new DataTable();
        public void showlv()
        {
            lvSinhvien.Items.Clear();
            var dl=contextDB.Sinhviens.ToList();

            foreach (var item in dl)
            {
                ListViewItem listIt=new ListViewItem(item.MaSV.ToString());
                listIt.SubItems.Add(item.HotenSV.ToString());
                listIt.SubItems.Add(item.Ngaysinh.ToString());
                listIt.SubItems.Add(item.Lop.TenLop.ToString());
                lvSinhvien.Items.Add(listIt);
            }
        }

        public void showlop()
        {
            var lop=contextDB.Lops.ToList();
            this.cboLop.DataSource= lop;
            this.cboLop.DisplayMember = "TenLop";
            this.cboLop.ValueMember = "MaLop";
        }
       
        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            btLuu.Enabled = false;
            btKhong.Enabled = false;
            dtNgaysinh.Format = DateTimePickerFormat.Short;
            dtNgaysinh.Value = DateTime.Now;
            showlv();
            showlop();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true; btKhong.Enabled = true;
            addsql();
            showlv();
        }

        public void addsql()
        {
            Sinhvien sv = new Sinhvien();
            sv.MaSV = txtMaSV.Text;
            sv.HotenSV = txtHotenSV.Text;
            sv.MALOP = (cboLop.SelectedValue.ToString());
            sv.Ngaysinh = dtNgaysinh.Value;
            contextDB.Sinhviens.Add(sv);
            contextDB.SaveChanges();
        }

        public void xoa(string sv)
        {
            var svdel = contextDB.Sinhviens.Find(sv);
            if (svdel != null) 
            { 
                contextDB.Sinhviens.Remove(svdel);
                contextDB.SaveChanges();
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            Sinhvien sv=new Sinhvien();
            if (lvSinhvien.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                   xoa(txtMaSV.Text);
                    lvSinhvien.Items.Remove(lvSinhvien.SelectedItems[0]);
                    contextDB.SaveChanges();
                }
                    
            }
            else MessageBox.Show("Xóa lỗi");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien();
            if (lvSinhvien.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn muốn sửa ?", "canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    xoa(txtMaSV.Text);
                    addsql();
                    showlv();
                }

            }
            else MessageBox.Show("Sửa lỗi");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn thoat ?", "canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void lvSinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhvien.SelectedItems.Count > 0)
            {
                btLuu.Enabled = true; btKhong.Enabled = true;
                txtHotenSV.Text = lvSinhvien.SelectedItems[0].SubItems[1].Text;
                txtMaSV.Text = lvSinhvien.SelectedItems[0].SubItems[0].Text;
                dtNgaysinh.Text = lvSinhvien.SelectedItems[0].SubItems[2].Text;
                cboLop.Text = lvSinhvien.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            lvSinhvien.Items.Clear();
            List<Sinhvien> lstSinhvien = contextDB.Sinhviens.Where(p => p.HotenSV.Contains(txtHotenSV.Text)).ToList();
            foreach (var item in lstSinhvien)
            {
                ListViewItem listIt = new ListViewItem(item.MaSV.ToString());
                listIt.SubItems.Add(item.HotenSV.ToString());
                listIt.SubItems.Add(item.Ngaysinh.ToString());
                listIt.SubItems.Add(item.Lop.TenLop.ToString());
                lvSinhvien.Items.Add(listIt);
            }
        }
    }
}
