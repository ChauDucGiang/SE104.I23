﻿using DevExpress.XtraEditors;
using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QLHS.Report;
using QLHS.GUI;
using DevExpress.XtraBars;
using DevComponents.DotNetBar;

namespace QLHS
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public delegate void GetUser(string u);
        private string User = "";
        public frmMain()
        {
            InitializeComponent();
        }
        #region Event
        private void btnDoimatkhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoimatkhau f = new frmDoimatkhau();
            f.ShowDialog();
        }

        private void btnQLND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNguoidung f = new frmNguoidung();
            f.ShowDialog();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }
        private void btntracuuHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXemdiem f = new frmXemdiem();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btnQDsiso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuydinhvesiso f = new frmQuydinhvesiso();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btnQDthangdiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuydinhvethangdiem f = new frmQuydinhvethangdiem();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btnQDtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuydinhdotuoi f = new frmQuydinhdotuoi();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGiaovien f = new frmGiaovien();
            if (ExistForm(f)) return;
            GetUser g = new GetUser(f.SaveU);
            g(User);
            f.MdiParent = this;
            f.Show();
        }
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
            GetUser g = new GetUser(form.SaveU);
            g(User);
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
            GetUser g = new GetUser(form.SaveU);
            g(User);
            form.MdiParent = this;
            form.Show();
        }
        private void btnPhanLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPL f = new frmPL();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btmQuiDInhCHung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuydinhchung f = new frmQuydinhchung();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btnDSHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DSHS ds = new DSHS();
            ds.ShowPreviewDialog();
        }

        private void btnDSGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DSGV ds = new DSGV();
            ds.ShowPreviewDialog();
        }

        private void btnDSlop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DSLop ds = new DSLop();
            ds.ShowPreviewDialog();
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhancong f = new frmPhancong();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btnSaoluudulieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (backupDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + Utilities.DatabaseName + " TO DISK = '" + backupDialog.FileName.ToString() + "'");
                DataProvider.Instance.Load(cmd);
                MessageBoxEx.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void btnPhuchoidulieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (restoreDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("USE master RESTORE DATABASE " + Utilities.DatabaseName + " FROM DISK = '" + restoreDialog.FileName.ToString() + "'");
                DataProvider.Instance.Load(cmd);
                MessageBoxEx.Show("Phục hồi dữ liệu thành công!", "RESTORE COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }
        private void btnKNCSDL_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConnection rad = new frmConnection();
            {
                if (rad.ShowDialog() == DialogResult.OK)
                {
                    MessageBoxEx.Show("Kết nối CSDL mới thành công ! \n Khởi động lại chương trình .");
                    Application.Restart();
                }
                else rad.Close();
            }
        }
        #endregion

        #region Func
        public void SaveU(TextBox txb)
        {
            this.User = txb.Text;
            string type = AccountDAO.Instance.GetType(User);
            if (!type.Equals("admin"))
            {
                btnPhanLop.Visibility = BarItemVisibility.Never;
                btmQuiDInhCHung.Visibility = BarItemVisibility.Never;
                barButtonItem7.Visibility = BarItemVisibility.Never;
            }
            
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

    }
}
