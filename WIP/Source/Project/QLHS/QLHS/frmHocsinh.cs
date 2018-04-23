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
        #region Constructor
        private string User = "";
        #endregion
        public frmHocsinh()
        {
            InitializeComponent();
            loadStu();
        }
        #region Event
        private void btnThemvaodanhsach_Click(object sender, EventArgs e)
        {
            if (txtMahocsinh.Text == "" || txtTenhocsinh.Text == "" ||txtNoisinh.Text==""
                &&txbDiaChi.Text==""||txbEmail.Text==""||txbSoDienThoai.Text==""|| txbEmail.Text==""
                || dtpNgaysinh.Value==null||(!radNam.Checked && !radNu.Checked))
            {
                MessageBox.Show("Thông tin trống kìa !!!", "Thông báo");
                return;
            }
                int maHS = Convert.ToInt32(txtMahocsinh.Text);
                string hoTen = ChangeDisplayString(txtTenhocsinh.Text);
                string gioiTinh = "";
                if (radNam.Checked)
                {
                    gioiTinh = radNam.Text;
                }
                else if (radNu.Checked)
                {
                    gioiTinh = radNu.Text;
                }
                DateTime ngaySinh = dtpNgaysinh.Value;
                string noiSinh = txtNoisinh.Text;
                string dienThoai = txbSoDienThoai.Text;
                string emaiL = txbEmail.Text;
                string diaChi = txbDiaChi.Text;
                if (!CheckType.Instance.CheckIsMail(emaiL))
                {
                    MessageBox.Show("Email dạng email rồi !!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (!CheckType.Instance.CheckIsPhone(dienThoai))
                {
                    MessageBox.Show("Số điện thoại định dạng sai rồi !!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    if (!HocSinhDAO.Instance.checkExistedStuByMaHS(maHS))
                    {
                        HocSinhDAO.Instance.ThemHocSinh(maHS, hoTen, gioiTinh, ngaySinh, noiSinh, dienThoai, emaiL, diaChi);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Mã học sinh đã tồn tại! Vui lòng nhập vào một mã học sinh mới!", "Thông báo", MessageBoxButtons.OK);
                    }
                    loadStu();
                }
                catch
                {
                    MessageBox.Show("Tuổi nhập vào phải lớn hơn 15 và nhỏ hơn 20 !", "Thông báo", MessageBoxButtons.OK);
                }

        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
                string inputData = txtNhapthongtincantimkiem.Text;
                if (inputData == "") return;
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
                }
                else if (radTimtheotenhocsinh.Checked)
                {
                    if (HocSinhDAO.Instance.checkExistedStuByName(inputData))
                        dGVHocsinh.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocSinh WHERE HoTen =N'" + inputData + "'");
                    else
                        MessageBox.Show("Học sinh không tồn tại !", "Thông báo");
                }

                if (!radTimtheomahocsinh.Checked && !radTimtheotenhocsinh.Checked)
                {
                    MessageBox.Show("Bạn chưa chọn thông tin tìm kiếm !", "Thông báo", MessageBoxButtons.OK);
                }
 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Tuổi phải từ 15 đến 20 tuổi !", "Thông báo", MessageBoxButtons.OK);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int mshs = (int)dGVHocsinh.CurrentRow.Cells["MaHS"].Value;
            if (HocSinhDAO.Instance.deleteHocSinh(mshs))
            {
                MessageBox.Show("Xóa thành công học sinh có mã "+mshs+" !", "Thông báo",MessageBoxButtons.OK);
                loadStu();
            }
        }


        #endregion

        #region Func
        private string ChangeDisplayString(string str)
        {
            string strchuyendoi = "";
            string[] laytu = str.Split(' ');
            string kytudau = "";
            for (int i = 0; i < laytu.Length; i++)
            {
                kytudau = laytu[i].Substring(0, 1);
                strchuyendoi += kytudau.ToUpper() + laytu[i].Remove(0, 1) + " ";
            }
            return strchuyendoi;
        }
        public void SaveU(string u)
        {
            this.User = u;
            string type = AccountDAO.Instance.GetType(User);
            if (!type.Equals("admin"))
            {
                navigationPageAddHocSinh.Enabled = false;
                bindingNavigatorAddHS.Enabled = false;
            }
        }
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if Enter is pressed
            if (keyData == Keys.Enter)
            {
                // If there isn't any selected row, do nothing
                if (dGVHocsinh.CurrentRow == null)
                {
                    return true;
                }

                // Display first cell's value
                dGVHocsinh.CurrentCell = dGVHocsinh.CurrentRow.Cells["MaHS"];
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
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
