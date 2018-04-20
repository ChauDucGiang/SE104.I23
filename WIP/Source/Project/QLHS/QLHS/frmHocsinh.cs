using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmHocsinh : Form
    {
        public frmHocsinh()
        {
            InitializeComponent();
            loadStu();
        }
        #region Event
        private void btnThemvaodanhsach_Click(object sender, EventArgs e)
        {
             int maHS = Convert.ToInt32(txtMahocsinh.Text);
             string hoTen= txtTenhocsinh.Text;
            string gioiTinh = "";
            if (radNam.Checked)
            {
                gioiTinh = radNam.Text;
            }else if (radNu.Checked)
            {
                gioiTinh = radNu.Text;
            }
             DateTime ngaySinh = dtpNgaysinh.Value;
             string noiSinh= txtNoisinh.Text;
             string dienThoai= txbSoDienThoai.Text;
             string emaiL = txbEmail.Text;
             string diaChi = txbDiaChi.Text;

            if (!HocSinhDAO.Instance.checkExistedStuByMaHS(maHS))
            {
                HocSinhDAO.Instance.ThemHocSinh(maHS, hoTen, gioiTinh,ngaySinh, noiSinh, dienThoai,emaiL, diaChi);
            }
            else
            {
                MessageBox.Show("Mã học sinh đã tồn tại! Vui lòng nhập vào một mã học sinh mới!", "Thông báo");
            }
            loadStu();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string inputData = txtNhapthongtincantimkiem.Text;
            if (radTimtheomahocsinh.Checked)
            {

                if (isNumber(inputData))
                {
                    int mahs = Convert.ToInt32(inputData);
                    if (HocSinhDAO.Instance.checkExistedStuByMaHS(mahs))
                        dGVHocsinh.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocSinh WHERE MaHS = " + mahs);
                    else
                        MessageBox.Show("Học sinh không tồn tại !", "Thông báo");
                }
                else
                    MessageBox.Show("Học sinh không tồn tại !", "Thông báo");
            }else if (radTimtheotenhocsinh.Checked)
            {
                if (HocSinhDAO.Instance.checkExistedStuByName(inputData))
                    dGVHocsinh.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocSinh WHERE HoTen =N'" + inputData + "'");
                else
                    MessageBox.Show("Học sinh không tồn tại !", "Thông báo");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {       
                
                int mahs = (int)dGVHocsinh.CurrentRow.Cells["MaHS"].Value;
                string hoten = dGVHocsinh.CurrentRow.Cells["HoTen"].Value.ToString();
                string gioitinh = dGVHocsinh.CurrentRow.Cells["GioiTinh"].Value.ToString();
                DateTime ngaysinh = (DateTime)dGVHocsinh.CurrentRow.Cells["NgSinh"].Value;
                string noisinh = dGVHocsinh.CurrentRow.Cells["NoiSinh"].Value.ToString();
                string dienthoai = dGVHocsinh.CurrentRow.Cells["DienThoai"].Value.ToString();
                string email = dGVHocsinh.CurrentRow.Cells["Email"].Value.ToString();
                string diachi = dGVHocsinh.CurrentRow.Cells["DiaChi"].Value.ToString();

                if (HocSinhDAO.Instance.updateHocSinh(mahs, hoten, gioitinh, ngaysinh, noisinh, dienthoai, email, diachi))
                {
                    MessageBox.Show("Đã thay đổi học sinh có mã " + mahs + " thành công !", "Thông báo", MessageBoxButtons.OK);
                    loadStu();
                }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int mshs = (int)dGVHocsinh.CurrentRow.Cells["MaHS"].Value;
            if (HocSinhDAO.Instance.deleteHocSinh(mshs))
            {
                MessageBox.Show("Xóa thành công !", "Thông báo");
                loadStu();
            }
        }
        private void dGVHocsinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int CurrentIndex = dGVHocsinh.CurrentCell.RowIndex;

            //int mahs = (int)dGVHocsinh.Rows[CurrentIndex].Cells["MaHS"].Value;
            //string hoten = dGVHocsinh.Rows[CurrentIndex].Cells["HoTen"].Value.ToString();
            //string gioitinh = dGVHocsinh.Rows[CurrentIndex].Cells["GioiTinh"].Value.ToString();
            //DateTime ngaysinh = (DateTime)dGVHocsinh.Rows[CurrentIndex].Cells["NgSinh"].Value;
            //string noisinh = dGVHocsinh.Rows[CurrentIndex].Cells["NoiSinh"].Value.ToString();
            //string dienthoai = dGVHocsinh.Rows[CurrentIndex].Cells["DienThoai"].Value.ToString();
            //string email = dGVHocsinh.Rows[CurrentIndex].Cells["Email"].Value.ToString();
            //string diachi = dGVHocsinh.Rows[CurrentIndex].Cells["DiaChi"].Value.ToString();

            //if (HocSinhDAO.Instance.updateHocSinh(mahs, hoten, gioitinh, ngaysinh, noisinh, dienthoai, email, diachi))
            //{
            //    MessageBox.Show("Đã thay đổi học sinh có mã " + mahs + " thành công !", "Thông báo", MessageBoxButtons.OK);
            //    loadStu();
            //}
            int mahs = (int)dGVHocsinh.CurrentRow.Cells["MaHS"].Value;
            string hoten = dGVHocsinh.CurrentRow.Cells["HoTen"].Value.ToString();
            string gioitinh = dGVHocsinh.CurrentRow.Cells["GioiTinh"].Value.ToString();
            DateTime ngaysinh = (DateTime)dGVHocsinh.CurrentRow.Cells["NgSinh"].Value;
            string noisinh = dGVHocsinh.CurrentRow.Cells["NoiSinh"].Value.ToString();
            string dienthoai = dGVHocsinh.CurrentRow.Cells["DienThoai"].Value.ToString();
            string email = dGVHocsinh.CurrentRow.Cells["Email"].Value.ToString();
            string diachi = dGVHocsinh.CurrentRow.Cells["DiaChi"].Value.ToString();

            if (HocSinhDAO.Instance.updateHocSinh(mahs, hoten, gioitinh, ngaysinh, noisinh, dienthoai, email, diachi))
            {
                MessageBox.Show("Đã thay đổi học sinh có mã " + mahs + " thành công !", "Thông báo", MessageBoxButtons.OK);
                loadStu();
            }
        }

        #endregion

        #region Func
        void loadStu()
        {
            dGVHocsinh.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocSinh");
        }
        bool isNumber(string value)
        {
            foreach (Char item in value)
            {
                if (!Char.IsDigit(item))
                    return false;
            }
            return true;
        }

        //private void dGVHocsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    public int currentMahs= .CurrentRow.Cells["MaHS"].Value;
            
        //}

    private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }





    #endregion

    //private void dGVHocsinh_KeyDown(object sender, KeyEventArgs e)
    //{
    //    if (e.KeyCode == Keys.Enter)
    //        e.SuppressKeyPress = true;
    //}

    //private void dGVHocsinh_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    //{

    //}
}
}
