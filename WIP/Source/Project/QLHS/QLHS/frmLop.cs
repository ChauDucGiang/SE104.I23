﻿using QLHS.DAO;
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
        private string User = "";
        public frmLop()
        {
            InitializeComponent();
            loadClass();
            loadGVintoCombobox();
            loadKLintoCombobox();
            loadNHintoCombobox();
        }
        #region Methods
        public void SaveU(string u)
        {
            User = u;
            string type = AccountDAO.Instance.GetType(User);
            if (!type.Equals("admin"))
            {
                navAddClass.Enabled = false;
                bindingNavigatorClass.Enabled = false;
            }
    }
        void loadClass()
        {
            dGVLop.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MaLop, TenLop, TenKhoiLop, TenGV, TenNamHoc FROM dbo.Lop, dbo.GiaoVien, dbo.NamHoc, dbo.KhoiLop WHERE dbo.Lop.MaKhoiLop = dbo.KhoiLop.MaKhoiLop AND dbo.Lop.GVCN = dbo.GiaoVien.MaGV AND dbo.Lop.NamHoc = NamHoc.MaNamHoc");
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
        public List<NamHoc> getListNamHoc()
        {
            List<NamHoc> list = new List<NamHoc>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NamHoc");

            foreach (DataRow item in data.Rows)
            {
                NamHoc nh = new NamHoc(item);
                list.Add(nh);
            }
            return list;
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
            loadClass();
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
                MessageBox.Show("Lớp đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
            }
            loadClass();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string inputData = txtNhapthongtincantimkiem.Text;
            if (radTimtheomalop.Checked)
            {
                if (ClassDAO.Instance.getStatusClassbyMaLop(inputData) == false)
                {
                    dGVLop.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MaLop,TenLop,TenKhoiLop,TenGV,TenNamHoc FROM dbo.Lop, dbo.GiaoVien, dbo.NamHoc, dbo.KhoiLop WHERE dbo.Lop.MaKhoiLop=dbo.KhoiLop.MaKhoiLop AND dbo.Lop.GVCN = dbo.GiaoVien.MaGV AND dbo.Lop.NamHoc = NamHoc.MaNamHoc AND MaLop = " + inputData);
                }
                else
                {
                    MessageBox.Show("Lớp không tồn tại !", "Thông báo", MessageBoxButtons.OK);
                }


            }
            if (radTimtheotenlop.Checked)
            {

                if (ClassDAO.Instance.getStatusClassbyTenLop(inputData) == false)
                {

                    dGVLop.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MaLop,TenLop,TenKhoiLop,TenGV,TenNamHoc FROM dbo.Lop, dbo.GiaoVien, dbo.NamHoc, dbo.KhoiLop WHERE dbo.Lop.MaKhoiLop=dbo.KhoiLop.MaKhoiLop AND dbo.Lop.GVCN = dbo.GiaoVien.MaGV AND dbo.Lop.NamHoc = NamHoc.MaNamHoc AND TenLop =N'" + inputData + "'");
                }
                else
                {
                    MessageBox.Show("Lớp không tồn tại !", "Thông báo", MessageBoxButtons.OK);
                }
            }
            if (!radTimtheomalop.Checked && !radTimtheotenlop.Checked)
            {
                MessageBox.Show("Bạn quên chọn thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        #endregion
        #region Func
        //public void SaveU(TextBox txb)
        //{
        //    this.User = txb.Text;
        //    string type = AccountDAO.Instance.GetType(User);
        //    if (!type.Equals("admin"))
        //    {
        //        navAddClass.Enabled = false;
        //        btnDelete.Enabled = false;
        //        btnLuu.Enabled = false;
        //    }
        //}
        #endregion

        private void navigationPane1_Click(object sender, EventArgs e)
        {

        }
    }
}