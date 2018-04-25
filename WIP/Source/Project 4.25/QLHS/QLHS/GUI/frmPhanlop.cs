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
    public partial class frmPhanlop : Form
    {
        #region Constructor
        BindingSource bs = new BindingSource();
        //private string User = "";
        #endregion
        public frmPhanlop()
        {
            InitializeComponent();
            
        }
        #region Func
        //public void SaveU(string u, ref DevExpress.XtraBars.BarButtonItem b)
        //{
        //    User = u;
        //    string type = AccountDAO.Instance.GetType(User);
        //    if (!type.Equals("admin")) b.Enabled = false;
        //}
        public void LoadListHS()
        {
            lvLopcu.Items.Clear();
            List<HocSinh> lhs = XepLopDAO.Instance.GetHSHaveClass(cmbLopcu.SelectedValue.ToString(), cmbNamhoccu.SelectedValue.ToString());
            foreach (HocSinh item in lhs)
            {
                ListViewItem lsvItem = new ListViewItem(item.MaHS.ToString());
                lsvItem.SubItems.Add(item.HoTen.ToString());
                lvLopcu.Items.Add(lsvItem);
            }
        }
        public void LoadIncbNamHoc()
        {
            cmbNamhoccu.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM NamHoc");
            cmbNamhoccu.DisplayMember = "TenNamHoc";
            cmbNamhoccu.ValueMember = "MaNamHoc";

            cmbNamhocmoi.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM NamHoc");
            cmbNamhocmoi.DisplayMember = "TenNamHoc";
            cmbNamhocmoi.ValueMember = "MaNamHoc";
        }
        public void LoadIncbKhoiLop()
        {
            cmbKhoilopcu.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhoiLop");
            cmbKhoilopcu.DisplayMember = "TenKhoiLop";
            cmbKhoilopcu.ValueMember = "MaKhoiLop";

            cmbKhoilopmoi.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhoiLop");
            cmbKhoilopmoi.DisplayMember = "TenKhoiLop";
            cmbKhoilopmoi.ValueMember = "MaKhoiLop";
        }
        public void LoadIncbLopByMaKhoiLopAndNamHoc(string manamhoc, string makhoilop)
        {
            cmbLopcu.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE NamHoc =N'" + manamhoc + "' AND MaKhoiLop =N'" + makhoilop + "'");
            cmbLopcu.DisplayMember = "TenLop";
            cmbLopcu.ValueMember = "MaLop";
        }
        #endregion
        #region Event
        private void frmPhanlop_Load(object sender, EventArgs e)
        {
            LoadIncbNamHoc();
            LoadIncbKhoiLop();
        }
        private void cmbNamhoccu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLopcu.DataBindings.Clear();
            cmbLopcu.DataSource = null;
        }

        private void cmbKhoilopcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoccu.SelectedValue != null && cmbKhoilopcu.SelectedValue != null)
                LoadIncbLopByMaKhoiLopAndNamHoc(cmbNamhoccu.SelectedValue.ToString(), cmbKhoilopcu.SelectedValue.ToString());
            cmbLopcu.DataBindings.Clear();
            
        }

        private void cmbLopcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoccu.SelectedValue != null && cmbKhoilopcu.SelectedValue != null && cmbLopcu.SelectedValue != null)
                LoadListHS();

        }

        private void cbNewStudent_CheckedChanged(object sender, EventArgs e)
        {
  
            if (cbNewStudent.Checked==true)
            {
                lvLopcu.Items.Clear();
                List<HocSinh> lhs = XepLopDAO.Instance.GetHSNotInClass();
                foreach (HocSinh item in lhs)
                {
                    ListViewItem lsvItem = new ListViewItem(item.MaHS.ToString());
                    lsvItem.SubItems.Add(item.HoTen.ToString());
                    lvLopcu.Items.Add(lsvItem);
                }
            }else lvLopcu.Items.Clear();
        }


        #endregion

        private void btnChuyentatca_Click(object sender, EventArgs e)
        {

        }

        private void btnChuyentungnguoimot_Click(object sender, EventArgs e)
        {

        }
    }
}
