using LAB__05BUS;
using LAB__05DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using System.Security.Cryptography;


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
                gvListSV.ClearSelection();
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
                Image image = Image.FromFile(imPat);
                picAvata.Image = image;
                picAvata.Refresh();
                image.Dispose();
            }
        }

        private void RefereshData()
        {
            var liststudent = studentService.GetAll();
            fillListStudent(liststudent);
            txtName.Text = "";
            txtIdsv.Text = "";
            cbbFaculty.SelectedValue = 0;
            txtAverageScore.Text = "";
            picAvata.Image = null;
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
                        return 1;
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
        private Student getStudent()
        {
            Student s = new Student();
            s.FullName = txtName.Text.ToString();
            s.StudentID = txtIdsv.Text.ToString();
            s.FacultyID = int.Parse(cbbFaculty.SelectedValue.ToString());
            s.AverageScore = float.Parse(txtAverageScore.Text);
            /*if (str != null)
            {
                if (studentService.checkNullAvatar(s.StudentID) == false)
                {
                    deletePicture();
                    savePicture(str);
                }
                else
                    savePicture(str);
                string avatar = txtIdsv.Text.ToString() + "." + splitString(str);
                s.Avatar = avatar;*/
            s.Avatar = str;
            

            return s;
        }
        private void btnAddorUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (!KTDataInput())
                {
                    MessageBox.Show("Vui long nhap day du thong tin");
                }
                else
                {

                    try
                    {
                        studentService.AddUpdate(getStudent());
                        MessageBox.Show("Them Sua Sinh Vien Thanh Cong");
                        RefereshData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Lỗi validation: ";
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    RefereshData();
                    MessageBox.Show($"Xóa sinh viên {stDel.FullName}  thành công !", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        public string str = null;
        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog of=new OpenFileDialog();
            if(of.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    picAvata.Image = new Bitmap(of.FileName);
                    str = of.FileName;
                    MessageBox.Show("Mo tep anh thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khong the mo tep anh! " + ex.Message);
                }
                
            }
        }

        private void gvListSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int r = gvListSV.CurrentCell.RowIndex;
                txtIdsv.Text = gvListSV.Rows[r].Cells[0].Value?.ToString() ?? "";
                txtName.Text = gvListSV.Rows[r].Cells[1].Value.ToString();
                cbbFaculty.Text = gvListSV.Rows[r].Cells[2].Value.ToString();
                txtAverageScore.Text = gvListSV.Rows[r].Cells[3].Value.ToString();
                var liststudent = studentService.GetAll();
                var s = liststudent.FirstOrDefault(p => p.StudentID == txtIdsv.Text);
                if (s != null)
                    showAvata(s.Avatar);
            }
            catch (Exception ex)
            {
                RefereshData();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
