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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
            loadClass();
            loadGVintoCombobox();
            loadKLintoCombobox();
            loadNHintoCombobox();
        }
        #region Methods
        void loadClass()
        {
            dGVLop.DataSource=DataProvider.Instance.ExecuteQuery("SELECT MaLop, TenLop, MaKhoiLop,NamHoc FROM Lop");
        }

        void loadGVintoCombobox()
        {
            List<GiaoVien> listGV = GiaoVienDAO.Instance.getListGV();
            cmbGiaovienchunhiem.DataSource = listGV;
            cmbGiaovienchunhiem.DisplayMember = "TenGV";
            
        }

        void loadKLintoCombobox()
        {
            List<KhoiLop> listKL = KhoiLopDAO.Instance.getListKhoiLop();
            cmbKhoilop.DataSource = listKL;
            cmbKhoilop.DisplayMember = "TenKhoiLop";
        }

        void loadNHintoCombobox()
        {
            List<NamHoc> listNH = NamHocDAO.Instance.getListNamHoc();
            cmbNamHoc.DataSource = listNH;
            cmbNamHoc.DisplayMember = "TenNamHoc";
        }

        

        #endregion

        #region Events
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLop_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLop = txtMalop.Text;
            string tenLop = txtTenlop.Text;
            int siSo = Convert.ToInt32(txtSiso.Text);
            string khoiLop = (cmbKhoilop.SelectedItem as KhoiLop).MaKhoiLop;
            string namHoc = (cmbNamHoc.SelectedItem as NamHoc).MaNamHoc;
            string gvCN = (cmbGiaovienchunhiem.SelectedItem as GiaoVien).MaGV;


            if (ClassDAO.Instance.getStatusClassbyMaLop(maLop))
            {
                ClassDAO.Instance.InsertClass(maLop, tenLop, khoiLop, namHoc, gvCN);
            }
            else
            {
                MessageBox.Show("Lớp đã tồn tại!","Thông báo");
            }
            loadClass();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string inputData = txtNhapthongtincantimkiem.Text;
            if (radTimtheomalop.Checked)
            {
                if (ClassDAO.Instance.getStatusClassbyMaLop(inputData)==false) {
                    dGVLop.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MaLop, TenLop, NamHoc, MaKhoiLop FROM Lop WHERE MaLop = " + inputData);
                }
                else
                {
                    MessageBox.Show("Lớp không tồn tại !", "Thông báo");
                }


            }
            if (radTimtheotenlop.Checked)
            {

                if (ClassDAO.Instance.getStatusClassbyTenLop(inputData) == false)
                {

                    dGVLop.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MaLop, TenLop, NamHoc, MaKhoiLop FROM Lop WHERE TenLop=N'" + inputData+"'");
                }
                else
                {
                    MessageBox.Show("Lớp không tồn tại !", "Thông báo");
                }
            }

        }

        #endregion
        #region Func

        #endregion

    }
}
