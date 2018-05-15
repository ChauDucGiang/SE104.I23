using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmNhapdiemrieng : Form
    {
        #region Constructor
        #endregion
        public frmNhapdiemrieng()
        {
            InitializeComponent();
        }
        #region Func
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVNhapdiemrieng.CurrentRow == null) return true;
                dGVNhapdiemrieng.CurrentCell = dGVNhapdiemrieng.CurrentRow.Cells["colMahocsinh"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void LoadIncbNamHocClass(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NamHoc");
            cb.DisplayMember = "TenNamHoc";
            cb.ValueMember = "MaNamHoc";

        }
        public void LoadIncbHocKiClass(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HocKi");
            cb.DisplayMember = "TenHocKi";
            cb.ValueMember = "MaHocKi";

        }
        public void LoadIncbClass(string namhoc, ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE NamHoc = N'" + namhoc + "'");
            cb.DisplayMember = "TenLop";
            cb.ValueMember = "MaLop";
        }
        public void LoadIncbMonHoc(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM MonHoc");
            cb.DisplayMember = "TenMon";
            cb.ValueMember = "MaMH";
        }
        public void LoadIncbHocSinh(string malop, ComboBox cb)
        {
            string query = "SELECT HocSinh.MaHS,HoTen FROM dbo.HocSinh,dbo.XepLop WHERE dbo.XepLop.MaHS=dbo.HocSinh.MaHS AND MaLop= N'" + malop + "'";
            cb.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cb.DisplayMember = "HoTen";
            cb.ValueMember = "MaHS";
        }
        public void LoadIncbLoaiDiem(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM CotDiem");
            cb.DisplayMember = "TenCotDiem";
            cb.ValueMember = "MaCotDiem";
        }
        #endregion

        #region Event
        private void frmNhapdiemrieng_Load(object sender, EventArgs e)
        {
            LoadIncbNamHocClass(cmbNamhoc);
            LoadIncbHocKiClass(cmbHocky);
            LoadIncbLoaiDiem(cmbLoaidiem);
            LoadIncbMonHoc(cmbMonhoc);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbNamhoc.SelectedValue != null &&
               cmbHocky.SelectedValue != null &&
               cmbLop.SelectedValue != null &&
               cmbHocsinh.SelectedValue != null &&
                cmbLoaidiem.SelectedValue != null &&
                cmbMonhoc.SelectedValue != null)
            {
                DiemDAO.Instance.LuuDiem(cmbHocsinh.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(),
                                         cmbLoaidiem.SelectedValue.ToString(), (float)Convert.ToDouble(txtDiem.Text), Int32.Parse(cmbHocky.SelectedValue.ToString()),
                                         cmbNamhoc.SelectedValue.ToString(), cmbMonhoc.SelectedValue.ToString());
                dGVNhapdiemrieng.DataSource = DiemDAO.Instance.LoadSTInBangDiem(cmbLop.SelectedValue.ToString());
                MessageBox.Show("It's OK", "Notice");
            }
            else MessageBox.Show("Thông tin trống !!!", "Thông báo");
        }

        private void cmbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoc.SelectedValue != null)
            {
                cmbLop.DataSource = null;
                LoadIncbClass(cmbNamhoc.SelectedValue.ToString(), cmbLop);
            }
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop.SelectedValue != null)
            {
                cmbHocsinh.DataSource = null;
                LoadIncbHocSinh(cmbLop.SelectedValue.ToString(), cmbHocsinh);
                dGVNhapdiemrieng.DataSource = DiemDAO.Instance.LoadSTInBangDiem(cmbLop.SelectedValue.ToString());
            }
        }

        #endregion



        private void btnSave_Click(object sender, EventArgs e)
        {
            string mahs = dGVNhapdiemrieng.CurrentRow.Cells["colMahocsinh"].Value.ToString();
            float diem = (float)Convert.ToDouble(dGVNhapdiemrieng.CurrentRow.Cells["colDiem"].Value.ToString());
            if (DiemDAO.Instance.UpdateDiem(mahs, diem))
            {
                MessageBox.Show("Sửa điểm thành công", "Thông báo");
                dGVNhapdiemrieng.DataSource = DiemDAO.Instance.LoadSTInBangDiem(cmbLop.SelectedValue.ToString());

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mahs = dGVNhapdiemrieng.CurrentRow.Cells["colMahocsinh"].Value.ToString();
            if (DiemDAO.Instance.XoaDIem(mahs))
            {
                MessageBox.Show("Sửa điểm thành công", "Thông báo");
                dGVNhapdiemrieng.DataSource = DiemDAO.Instance.LoadSTInBangDiem(cmbLop.SelectedValue.ToString());

            }
        }
    }
}
