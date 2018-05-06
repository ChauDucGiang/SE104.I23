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
            Reset.ResetAllControls(navigationPage1);
        }
        #region Event
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if(txtNhapthongtincantimkiem.Text =="Nhập thông tin cần tìm kiếm")
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm kiếm", "Thông báo");
                return;
            }
            if (radTimtheomagiaovien.Checked == false && radTimtheotengiaovien.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm", "Thông báo");
                return;
            }
            else
            {
                if (radTimtheomagiaovien.Checked)
                {
                    if (HocSinhDAO.Instance.checkExistedStuByMaHS(txtNhapthongtincantimkiem.Text))
                        bd.DataSource = SearchGVByMaGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
                    else
                    {
                        MessageBox.Show("Giáo viên không tồn tại", "Thông báo");
                        Reset.ResetAllControls(navigationPage2);
                        txtNhapthongtincantimkiem.Focus();
                    }
                    //bd.DataSource = SearchGVByMaGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
                }
                else if (radTimtheotengiaovien.Checked)
                {
                    if (HocSinhDAO.Instance.checkExistedStuByName(CheckType.chuanHoaTen(txtNhapthongtincantimkiem.Text)))
                        bd.DataSource = SearchGVByTenGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
                    else
                    {
                        MessageBox.Show("Giáo viên không tồn tại", "Thông báo");
                        Reset.ResetAllControls(navigationPage2);
                        txtNhapthongtincantimkiem.Focus();
                    }
                    //bd.DataSource = SearchGVByTenGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
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
            if (Reset.CheckTextControl(navigationPage1) == true)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Thông báo");
                Reset.ChangeFocus(navigationPage1);
                return;
            }
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
            else
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Thông báo");
                //Reset.CheckTextControl(navigationPage1);
                //Reset.ChangeFocus(navigationPage1);
            }
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
                if (ClassDAO.Instance.CheckGVCNinClass(magv) == false)
                {
                    if (GiaoVienDAO.Instance.XoaGiaoVien(magv))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        LoadGiaoVien();
                    }
                    else MessageBox.Show("Xóa thất bại", "Thông báo");
                }
                else MessageBox.Show("Giáo viên hiện tại đã chủ nhiệm không thể xóa", "Thông báo");
            }
            else MessageBox.Show("Trống rồi sao xóa đây !!!", "Thông báo");
            Reset.ResetFocus(txtMagiaovien, txtNhapthongtincantimkiem);
        }
        private void navigationPaneAddGV_Click(object sender, EventArgs e)
        {
            LoadGiaoVien();
            Reset.ResetAllControls(navigationPage2);
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
            string mamh = GiaoVienDAO.Instance.ChangeTenMontoMaMH(dGVGiaovien.CurrentRow.Cells["colTenmonhoc"].Value.ToString());

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

        private void txtMagiaovien_TextChanged(object sender, EventArgs e)
        {
            if (txtMagiaovien.Text =="")
            {
                lblCheckmaGV.Text = "Mã giáo viên có dạng: GVxxx";
                lblCheckmaGV.ForeColor = SystemColors.GrayText;
                picMGVOk.Hide();
                picMGVFalse.Hide();
            }
            else
            {
                lblCheckmaGV.Text = "";
                picMGVOk.Hide();
                picMGVFalse.Hide();
            }
            if (GiaoVienDAO.Instance.CheckGiaoVienExist(CheckType.chuanHoaMa(txtMagiaovien.Text)))
            {
                lblCheckmaGV.Text = "Mã giáo viên đã tồn tại";
                lblCheckmaGV.ForeColor = Color.Red;
                picMGVFalse.Show();
                picMGVOk.Hide();
                //txtMagiaovien.Focus();
            }
            else
            {
                if (CheckType.Instance.CheckMaGV(CheckType.chuanHoaMa(txtMagiaovien.Text)))
                {
                    picMGVOk.Show();
                    picMGVFalse.Hide();
                }
                else if (txtMagiaovien.Text != "")
                {
                    lblCheckmaGV.Text = "Sai định dạng mã giáo viên";
                    lblCheckmaGV.ForeColor = Color.Red;
                    picMGVFalse.Show();
                    picMGVOk.Hide();
                }
            }
        }

        private void txtDienthoai_TextChanged(object sender, EventArgs e)
        {
            if (!CheckType.Instance.CheckIsPhone(txtDienthoai.Text) && txtDienthoai.Text.Length !=0)                   
            {
                lblCheckSDT.Text = "Sai định dạng số điện thoại ";
                lblCheckSDT.ForeColor = Color.Red;
                picFalse.Show();
                picOk.Hide();
            }
           
            else
            {
                lblCheckSDT.Text = "";
                picOk.Hide();
                picFalse.Hide();
            }
            if (CheckType.Instance.CheckIsPhone(txtDienthoai.Text))
            {
                lblCheckSDT.Text = "";
                picOk.Show();
                picFalse.Hide();
            }

        }

        private void txtNhapthongtincantimkiem_Leave(object sender, EventArgs e)
        {
            if (txtNhapthongtincantimkiem.Text.Length == 0)
            {
                txtNhapthongtincantimkiem.Text = "Nhập thông tin cần tìm kiếm";
                txtNhapthongtincantimkiem.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtNhapthongtincantimkiem_Enter(object sender, EventArgs e)
        {
            if (txtNhapthongtincantimkiem.Text == "" || txtNhapthongtincantimkiem.Text == "Nhập thông tin cần tìm kiếm")
            {
                txtNhapthongtincantimkiem.Text = "";
                txtNhapthongtincantimkiem.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
