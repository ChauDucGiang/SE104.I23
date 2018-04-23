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
    public partial class frmNamhoc : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        //private string User = "";
        #endregion
        public frmNamhoc()
        {
            InitializeComponent();
            dGVNamhoc.DataSource = bd;
        }
        #region Event
        private void frmNamhoc_Load(object sender, EventArgs e)
        {
            bd.DataSource = NamHocDAO.Instance.LoadNamHoc();
            bindingNavigatorNamHoc.BindingSource = bd;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            string manamhoc = dGVNamhoc.CurrentRow.Cells["colManamhoc"].Value.ToString();
            if (manamhoc != "")
            {
                if (NamHocDAO.Instance.XoaNamHoc(manamhoc))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadNamHoc();
                }
                else MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData==Keys.Enter)
            {
                if (dGVNamhoc.CurrentRow == null) return true;
                dGVNamhoc.CurrentCell = dGVNamhoc.CurrentRow.Cells["colManamhoc"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Func
        //public void SaveU(string u)
        //{
        //    User = u;
        //    string type = AccountDAO.Instance.GetType(User);
        //    if (!type.Equals("admin"))
        //    {
        //        bindingNavigatorNamHoc.Enabled = false;
        //    }
        //}
        public void LoadNamHoc()
        {
            dGVNamhoc.DataSource = NamHocDAO.Instance.LoadNamHoc();
        }
        public void SaveItem()
        {
            
            string manamhoc = dGVNamhoc.CurrentRow.Cells["colManamhoc"].Value.ToString();
            string tennamhoc = dGVNamhoc.CurrentRow.Cells["colTennamhoc"].Value.ToString();
            if(!CheckType.Instance.CheckMaNamHoc(manamhoc))
            {
                MessageBox.Show("Sai định dạng mã năm học rồi !!!", "Thông báo");
                return;
            }
            if (manamhoc != "" && tennamhoc != "")
            {
                if (!NamHocDAO.Instance.CheckNamHocExist(manamhoc))
                    if (NamHocDAO.Instance.ThemNamHoc(manamhoc, tennamhoc))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadNamHoc();
                    }
                    else MessageBox.Show("Thêm thất bại", "Thông báo");
                else
                {
                    if (NamHocDAO.Instance.SuaNamHoc(manamhoc, tennamhoc))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        LoadNamHoc();
                    }
                    else MessageBox.Show("Sửa thất bại", "Thông báo");
                }
            }
            else MessageBox.Show("Trống thông tin rồi kìa!!", "Thông báo");
        }
        #endregion


    }
}
