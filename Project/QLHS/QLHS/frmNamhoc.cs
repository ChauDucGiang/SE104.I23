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
            string manamhoc = dGVNamhoc.CurrentRow.Cells["colManamhoc"].Value.ToString();
            string tennamhoc = dGVNamhoc.CurrentRow.Cells["colTennamhoc"].Value.ToString();
            
                if (NamHocDAO.Instance.ThemNamHoc(manamhoc, tennamhoc))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                else MessageBox.Show("Thêm thất bại", "Thông báo");
            
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
                }
                else MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
        }
        #endregion

        #region Func
        #endregion


    }
}
