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
    public partial class frmNhapdiemchung : Form
    {
        #region Constructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmNhapdiemchung()
        {
            InitializeComponent();
            dGVNhapdiemchung.DataSource = bd;
        }
        #region Event
        private void frmNhapdiemchung_Load(object sender, EventArgs e)
        {
            //bd.DataSource = DiemDAO.Instance.GetMaHSFromBangDiem();
            LoadIncbNamHocClass(cmbNamhoc1);
            LoadIncbHocKiClass(cmbHocky1);
            bindingNavigatorBangDiem.BindingSource = bd;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbLop1.SelectedValue != null)
            {
                if (DiemDAO.Instance.KiemTraDiem(dGVNhapdiemchung, "colDiemmieng") == true &&
                    DiemDAO.Instance.KiemTraDiem(dGVNhapdiemchung, "colDiem15phut") == true &&
                    DiemDAO.Instance.KiemTraDiem(dGVNhapdiemchung, "colDiem45phut") == true &&
                    DiemDAO.Instance.KiemTraDiem(dGVNhapdiemchung, "colDiemthi") == true
                    )
                {


                    foreach (DataGridViewRow row in dGVNhapdiemchung.Rows)
                    {
                        string str = dGVNhapdiemchung.Rows[row.Index].Cells["colMahocsinh"].Value.ToString();
                        if (string.IsNullOrEmpty(str) == false)
                        {
                            if (HocSinhDAO.Instance.CheckHSinClass(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString()) == false)
                            {
                                MessageBox.Show("Không có học sinh này rồi (Sai mã học sinh)", "Thông báo");
                                return;
                            }
                            else
                            {
                                if (HocSinhDAO.Instance.CheckNameStudentByMaHS(row.Cells["colTenhocsinh"].Value.ToString(),row.Cells["colMahocsinh"].Value.ToString()) == false)
                                {
                                    MessageBox.Show("Sai tên của học sinh rồi kìa !!!", "Thông báo");
                                    return;
                                }
                                    #region DiemMieng
                                    if (row.Cells["colDiemmieng"].Value != null)
                                    {
                                        string ChuoiChuaXuLy = row.Cells["colDiemmieng"].Value.ToString();
                                        string ChuoiDaXuLy = "";

                                        int count = 0;
                                        for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                                        {
                                            if (ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                                                count++;
                                            else
                                            {
                                                if (i == ChuoiChuaXuLy.Length - 1)
                                                {
                                                    i++;
                                                    count++;
                                                }
                                                ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                                                if (ChuoiDaXuLy != "")
                                                {
                                                    DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                                                                               cmbLop1.SelectedValue.ToString(), "M", float.Parse(ChuoiDaXuLy.ToString()),
                                                                               Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                                }
                                                ChuoiDaXuLy = null;
                                                count = 0;
                                            }
                                        }
                                    }
                                    #endregion

                                    #region Diem15P

                                    if (row.Cells["colDiem15phut"].Value != null)
                                    {
                                        string ChuoiChuaXuLy = row.Cells["colDiem15phut"].Value.ToString();
                                        string ChuoiDaXuLy = "";

                                        int count = 0;
                                        for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                                        {
                                            if (ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                                                count++;
                                            else
                                            {
                                                if (i == ChuoiChuaXuLy.Length - 1)
                                                {
                                                    i++;
                                                    count++;
                                                }
                                                ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                                                if (ChuoiDaXuLy != "")
                                                {
                                                    DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                                                                               cmbLop1.SelectedValue.ToString(), "15P", float.Parse(ChuoiDaXuLy.ToString()),
                                                                               Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                                }
                                                ChuoiDaXuLy = null;
                                                count = 0;
                                            }
                                        }
                                    }

                                    #endregion

                                    #region Diem45p

                                    if (row.Cells["colDiem45phut"].Value != null)
                                    {
                                        string ChuoiChuaXuLy = row.Cells["colDiem45phut"].Value.ToString();
                                        string ChuoiDaXuLy = "";

                                        int count = 0;
                                        for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                                        {
                                            if (ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                                                count++;
                                            else
                                            {
                                                if (i == ChuoiChuaXuLy.Length - 1)
                                                {
                                                    i++;
                                                    count++;
                                                }
                                                ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                                                if (ChuoiDaXuLy != "")
                                                {
                                                    DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                                                                               cmbLop1.SelectedValue.ToString(), "45P", float.Parse(ChuoiDaXuLy.ToString()),
                                                                               Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                                }
                                                ChuoiDaXuLy = null;
                                                count = 0;
                                            }
                                        }
                                    }

                                    #endregion

                                    #region DiemThi
                                    if (row.Cells["colDiemthi"].Value != null)
                                    {
                                        string ChuoiChuaXuLy = row.Cells["colDiemthi"].Value.ToString();
                                        string ChuoiDaXuLy = "";

                                        int count = 0;
                                        for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                                        {
                                            if (ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                                                count++;
                                            else
                                            {
                                                if (i == ChuoiChuaXuLy.Length - 1)
                                                {
                                                    i++;
                                                    count++;
                                                }
                                                ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                                                if (ChuoiDaXuLy != "")
                                                {
                                                    DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                                                                               cmbLop1.SelectedValue.ToString(), "THI", float.Parse(ChuoiDaXuLy.ToString()),
                                                                               Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                                }
                                                ChuoiDaXuLy = null;
                                                count = 0;
                                            }
                                        }
                                    }
                                #endregion

                                #region LuuKQ
                                KQMonHocHocKiDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(),cmbMonHoc1.SelectedValue.ToString(), Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString());

                                KQMonHocCaNamDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString());

                                KQTongHopHocKiDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), "G", cmbNamhoc1.SelectedValue.ToString());

                                KQTongHopDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString(), "G");
                                #endregion
                            }
                        }
                    }
                    MessageBox.Show("Đã Lưu Thành Công", "Thông báo");

                }

                HienThiDanhSachBangDiemHocSinh();

            }
            else MessageBox.Show("Chưa chọn lớp kìa !!!!");
        }
        private void cmbNamhoc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoc1.SelectedValue != null)
            {
                cmbLop1.DataSource = null;
                LoadIncbClass(cmbNamhoc1.SelectedValue.ToString(), cmbLop1);
                
            }
            
        }

        private void cmbLop1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop1.SelectedValue != null)
                LoadIncbMonHoc(cmbMonHoc1);
        }

        private void cmbHocky1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMonHoc1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if (cmbLop1.SelectedValue != null && cmbMonHoc1.SelectedValue != null && cmbNamhoc1.SelectedValue != null)
        //        bd.DataSource = DiemDAO.Instance.LoadSTInClassByMaLopAndNamHoc(cmbLop1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString());
        }
        private void btnHiemthidanhsach1_Click(object sender, EventArgs e)
        {
            HienThiDanhSachBangDiemHocSinh();
        }
        #endregion

        #region Func
        public void HienThiDanhSachBangDiemHocSinh()
        {
            if (cmbLop1.SelectedValue != null && cmbNamhoc1.SelectedValue != null && cmbMonHoc1.SelectedValue != null)
                bd.DataSource = HocSinhDAO.Instance.GetHocSinhByMaLopAndNamHoc(cmbLop1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString());

            foreach (DataGridViewRow rowHocSinh in dGVNhapdiemchung.Rows)
            {
                String[] diemMieng = new String[10];
                String[] diem15Phut = new String[10];
                String[] diem45Phut = new String[10];
                String diemThi = "";

                int soDiemMieng = 0;
                int soDiem15Phut = 0;
                int soDiem45Phut = 0;

                DataTable m_data = DiemDAO.Instance.LayDanhSachDiem(rowHocSinh.Cells["colMahocsinh"].Value.ToString(),
                                                                    cmbLop1.SelectedValue.ToString(),
                                                                    cmbNamhoc1.SelectedValue.ToString(),
                                                                    Int32.Parse(cmbHocky1.SelectedValue.ToString()),
                                                                    cmbMonHoc1.SelectedValue.ToString());
                foreach (DataRow rowDiem in m_data.Rows)
                {
                    if (rowDiem["MaCotDiem"].ToString() == "M")
                        diemMieng[soDiemMieng++] = rowDiem["Diem"].ToString();
                    else if (rowDiem["MaCotDiem"].ToString() == "15P")
                        diem15Phut[soDiem15Phut++] = rowDiem["Diem"].ToString();
                    else if (rowDiem["MaCotDiem"].ToString() == "45P")
                        diem45Phut[soDiem45Phut++] = rowDiem["Diem"].ToString();
                    else if (rowDiem["MaCotDiem"].ToString() == "THI")
                        diemThi = rowDiem["Diem"].ToString();
                }
                rowHocSinh.Cells["colDiemMieng"].Value = CheckType.Instance.ArrayToString(diemMieng, soDiemMieng);
                rowHocSinh.Cells["colDiem15Phut"].Value = CheckType.Instance.ArrayToString(diem15Phut, soDiem15Phut);
                rowHocSinh.Cells["colDiem45Phut"].Value = CheckType.Instance.ArrayToString(diem45Phut, soDiem45Phut);
                rowHocSinh.Cells["colDiemThi"].Value = diemThi;
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVNhapdiemchung.CurrentRow == null) return true;
                dGVNhapdiemchung.CurrentCell = dGVNhapdiemchung.CurrentRow.Cells["colMahocsinh"];
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


        #endregion


    }
}
