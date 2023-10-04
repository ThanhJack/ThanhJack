using LAB__05BUS;
using LAB__05DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Windows.Forms;


namespace LAB__05GUI
{
    public partial class frmStudent : Form
    {

        StudentModel contextDB = new StudentModel();
        public frmStudent()
        {
            InitializeComponent();
        }
        private readonly StudentService studentService = new StudentService();
        public readonly FacultyService facultyService = new FacultyService();


        private void setGridViewStyle(DataGridView gvListSV)
        {
            gvListSV.BorderStyle = BorderStyle.None;
            gvListSV.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gvListSV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gvListSV.BackgroundColor = Color.White;
            gvListSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void fillfacultyCBB(List<Faculty> listFaculty)
        {
            listFaculty.Insert(0, new Faculty());
            this.cbbFaculty.DataSource = listFaculty;
            this.cbbFaculty.DisplayMember = "FacultyName";
            this.cbbFaculty.ValueMember = "FacultyID";
        }


        public void fillListStudent(List<Student> listStudent)
        {
            gvListSV.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = gvListSV.Rows.Add();
                gvListSV.Rows[index].Cells[0].Value = item.StudentID;
                gvListSV.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    gvListSV.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                gvListSV.Rows[index].Cells[3].Value = item.AverageScore ;
                if (item.MajorID != null)
                    gvListSV.Rows[index].Cells[4].Value = item.Major.Name ;
                showAvata(item.Avatar);
            }
        }
        private void showAvata(string i)
        {
            if (string.IsNullOrEmpty(i))
                picAvata.Image = null;
            else
            {
                string parentDic = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imPat = Path.Combine(parentDic, "Images", i);
                picAvata.Image = Image.FromFile(imPat);
                picAvata.Refresh();
            }
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(gvListSV);
                var listFa = facultyService.GetAll();
                var listSt = studentService.GetAll();
                fillListStudent(listSt);
                fillfacultyCBB(listFa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool KTDataInput()
        {
            if (txtIdsv.Text == "" | txtName.Text == "" | txtAverageScore.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (txtIdsv.TextLength < 10)
            {
                MessageBox.Show("Mã số sinh viên phải đủ 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private int KiemTraIDExist(string idadd)
        {
            for (int i = 0; i < gvListSV.RowCount; i++)
            {
                if (gvListSV.Rows[i].Cells[0].Value != null)
                    if (gvListSV.Rows[i].Cells[0].Value.ToString() == idadd)
                        return i;
            }
            return -1;
        }
        private void chkUnreg_CheckedChanged(object sender, EventArgs e)
        {/*
            frmRegister frm = new frmRegister();
            frm.ShowDialog();*/
            var listst = new List<Student>();
            if (this.chkUnreg.Checked)
                listst = studentService.GetAllHasNoMajor();
            else listst = studentService.GetAll();
            fillListStudent(listst);
        }

        private void btnAddorUpdate_Click(object sender, EventArgs e)
        {

            if (KTDataInput())
                if (KiemTraIDExist(txtIdsv.Text) == -1)
                {
                    Student newStudent = new Student();
                    newStudent.StudentID = txtIdsv.Text;
                    newStudent.FullName = txtName.Text;
                    newStudent.AverageScore = float.Parse(txtAverageScore.Text);
                    newStudent.FacultyID = Convert.ToInt32(cbbFaculty.SelectedValue.ToString());
                    contextDB.Students.AddOrUpdate(newStudent);
                    contextDB.SaveChanges();
                    StartForm();
                    LoadGV();
                    MessageBox.Show($"thêm sinh viên {newStudent.FullName} vào danh sách thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($" sinh viên có{txtIdsv.Text} đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        public void StartForm()
        {
            txtIdsv.Clear();
            txtAverageScore.Clear();
            txtName.Clear();
        }

        public void LoadGV()
        {
            List<Student> afterUpdate = contextDB.Students.ToList();
            fillListStudent(afterUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (KiemTraIDExist(txtIdsv.Text) == -1)
            {
                MessageBox.Show($" Không tìm thấy sinh viên cần Xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            Student stDel = contextDB.Students.FirstOrDefault(p => p.StudentID == txtIdsv.Text);
            if (stDel != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có muốn xóa  {stDel.FullName} ko ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    contextDB.Students.Remove(stDel);
                    contextDB.SaveChanges();
                    LoadGV();
                    StartForm();
                    MessageBox.Show($"Xóa sinh viên {stDel.FullName}  thành công !", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog of=new OpenFileDialog();
            if(of.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(of.FileName);
                picAvata.Image = bitmap;
                picAvata.SizeMode=PictureBoxSizeMode.CenterImage;
            }
        }
    }
}
