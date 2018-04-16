using DevExpress.XtraEditors;
using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private string User = "";
        public frmMain()
        {
            InitializeComponent();
        }
        #region Event

        private void btNhapDiemRieng_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapdiemrieng form = new frmNhapdiemrieng();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void btNhapDiemChung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapdiemchung form = new frmNhapdiemchung();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void btnLophoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLop form = new frmLop();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void btnKhoilop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoilop form = new frmKhoilop();
            if (ExistForm(form)) return;
            form.MdiParent=this;
            form.Show();
        }
        private void btnHocki_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHocky f = new frmHocky();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btnNamhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNamhoc f = new frmNamhoc();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btnMonhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonhoc f = new frmMonhoc();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDiem f = new frmDiem();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btnKetqua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKetqua f = new frmKetqua();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btnHocluc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHocluc f = new frmHocluc();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btnHanhkiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHanhkiem f = new frmHanhkiem();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btnLienhe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("0989751783. Xin Liên hệ số điện thoại này. Chân thành cảm ơn", "Thông báo");
        }
        private void btnHocSinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHocsinh form = new frmHocsinh();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void btnPhanLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanlop f = new frmPhanlop();
            if (ExistForm(f)) return;
            f.MdiParent=this;
            f.Show();
        }
        #endregion

        #region Func
        public void SaveU(TextBox txb)
        {
            this.User = txb.Text;
            string type = AccountDAO.Instance.GetType(User);
            if (!type.Equals("admin")) rbQuyDinh.Visible = false;
        }
        public bool ExistForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        #endregion

        private void btGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

    }
}
