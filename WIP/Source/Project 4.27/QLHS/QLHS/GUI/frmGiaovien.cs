using QLHS.DAO;
using QLHS.DTO;
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
    public partial class frmGiaovien : Form
    {
        #region Constructor
        private string User = "";
        BindingSource bd = new BindingSource();
        #endregion
        public frmGiaovien()
        {
            InitializeComponent();
            dGVGiaovien.DataSource = bd;
            
        }
        #region Event
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (radTimtheomagiaovien.Checked == false && radTimtheotengiaovien.Checked == false)
            {
                MessageBox.Show("Bạn quên chọn cách tìm rồi kìa !!!", "Thông báo");
                return;
            }
            else
            {
                if (radTimtheomagiaovien.Checked)
                {
                    bd.DataSource = SearchGVByMaGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
                }
                else if (radTimtheotengiaovien.Checked)
                {
                    bd.DataSource = SearchGVByTenGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
                }
            }
            dGVGiaovien.DataSource = bd;
        }
        private void frmGiaovien_Load(object sender, EventArgs e)
        {
            bd.DataSource = GiaoVienDAO.Instance.LoadGiaoVien();
            bindingNavigatorGiaoVien.BindingSource = bd;
            LoadInCbMonHoc(cmbMamonhoc);
        }
        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVGiaovien.CurrentRow == null) return true;
                dGVGiaovien.CurrentCell = dGVGiaovien.CurrentRow.Cells["colMagiaovien"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnThemvaodanhsach_Click(object sender, EventArgs e)
        {
            string magv = CheckType.chuanHoaMa(txtMagiaovien.Text);
            string tengv = CheckType.chuanHoaTen(txtTengiaovien.Text);
            string sdt = txtDienthoai.Text;
            string diachi = txbDiaChi.Text;
            string mamh = cmbMamonhoc.SelectedValue.ToString();
            if (CheckType.Instance.CheckMaGV(magv) == false)
            {
                MessageBox.Show("Mã giáo viên có dạng GVXXX", "Thông báo");
                txtMagiaovien.ResetText();
                txtMagiaovien.Focus();
                return;
            }
            if (!CheckType.Instance.CheckIsPhone(sdt))
            {
                MessageBox.Show("Sai định dạng số điện thoại rồi !!!", "Thông báo");
                txtDienthoai.ResetText();
                txtDienthoai.Focus();
                return;
            }
            if (magv != null && tengv != null && sdt != null && diachi != null && mamh != null)
            {
                if (!GiaoVienDAO.Instance.CheckGiaoVienExist(magv))
                {
                    if (GiaoVienDAO.Instance.ThemGiaoVien(magv, tengv, sdt, diachi, mamh))
                    {
                        MessageBox.Show("Thêm thành công!!", "Thông báo");
                        LoadGiaoVien();
                        Reset.ResetAllControls(navigationPage1);
                        txtMagiaovien.Focus();
                    }
                    else MessageBox.Show("Thêm thất bại!!", "Thông bóa");
                }
                else
                {
                    MessageBox.Show("Mã giáo viên đã tồn tại rồi !!!", "Thông báo");
                    txtMagiaovien.ResetText();
                    txtMagiaovien.Focus();
                }
            }
            else MessageBox.Show("Có thông tin trống kìa", "Thông báo");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string magv = dGVGiaovien.CurrentRow.Cells["colMagiaovien"].Value.ToString();
            if (magv != "")
            {
                if (GiaoVienDAO.Instance.XoaGiaoVien(magv))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadGiaoVien();
                    Reset.ResetAllControls(navigationPaneAddGV);
                    Reset.ResetAllControls(navigationPage2);
                }
                else MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else MessageBox.Show("Trống rồi sao xóa đây !!!", "Thông báo");
            Reset.ResetFocus(txtMagiaovien, txtNhapthongtincantimkiem);
        }
        #endregion

        #region Func
        public void SaveU(string u)
        {
            User = u;
            string type = AccountDAO.Instance.GetType(User);
            if (!type.Equals("admin")) navigationPaneAddGV.Enabled = false;
        }
        public void SaveItem()
        {
            string magv = CheckType.chuanHoaMa(dGVGiaovien.CurrentRow.Cells["colMagiaovien"].Value.ToString());
            string tengv = CheckType.chuanHoaTen(dGVGiaovien.CurrentRow.Cells["colTengiaovien"].Value.ToString());
            string sdt = dGVGiaovien.CurrentRow.Cells["colDienthoai"].Value.ToString();
            string diachi = dGVGiaovien.CurrentRow.Cells["colDiachi"].Value.ToString();
            string mamh = GiaoVienDAO.Instance.ChangeTenMontoMaMH(CheckType.chuanHoaMa(dGVGiaovien.CurrentRow.Cells["colTenmonhoc"].Value.ToString()));

            if (CheckType.Instance.CheckMaGV(magv) == false)
            {
                MessageBox.Show("Sai r");
                return;
            }
            if (!CheckType.Instance.CheckIsPhone(sdt))
            {
                MessageBox.Show("Sai định dạng số điện thoại rồi !!!", "Thông báo");
                return;
            }
            if (magv != null && tengv != null && sdt != null && diachi != null && mamh != null)
            {
                if (!GiaoVienDAO.Instance.CheckGiaoVienExist(magv))
                {
                    if (GiaoVienDAO.Instance.ThemGiaoVien(magv, tengv, sdt, diachi, mamh))
                    {
                        MessageBox.Show("Thêm thành công!!", "Thông báo");
                        LoadGiaoVien();
                    }
                    else MessageBox.Show("Thêm thất bại!!", "Thông bóa");
                }
                else
                {
                    if(GiaoVienDAO.Instance.SuaGiaoVien(magv,tengv,sdt,diachi,mamh))
                    {
                        MessageBox.Show("Sửa thành công!!", "Thông báo");
                        LoadGiaoVien();
                    }
                    else MessageBox.Show("Sửa thất bại!!", "Thông bóa");
                }
            }
            else MessageBox.Show("Trống thông tin rồi kìa hoặc thông tin sai định dạng nè !!", "Thông báo");
            Reset.ResetFocus(txtMagiaovien, txtNhapthongtincantimkiem);
        }
        public void LoadInCbMonHoc(ComboBox cb)
        {
            cb.DataSource = MonHocDAO.Instance.LoadMonHoc();
            cb.DisplayMember = "TenMon";
            cb.ValueMember = "MaMH";
        }
        public void LoadGiaoVien()
        {
           dGVGiaovien.DataSource = GiaoVienDAO.Instance.LoadGiaoVien();
        }
        public List<GiaoVien> SearchGVByMaGV(string magv)
        {
            return GiaoVienDAO.Instance.SearchGVByMaGV(magv);
        }
        public List<GiaoVien> SearchGVByTenGV(string tengv)
        {
            return  GiaoVienDAO.Instance.SearchGVByTenGV(tengv);
        }

        #endregion

        private void navigationPaneAddGV_Click(object sender, EventArgs e)
        {
            LoadGiaoVien();
            Reset.ResetAllControls(navigationPage2);
            Reset.ResetFocus(txtMagiaovien, txtNhapthongtincantimkiem);
        }
    }
}
