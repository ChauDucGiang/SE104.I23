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
    public partial class frmThongtintruonghoc : Form
    {
        public frmThongtintruonghoc()
        {
            InitializeComponent();
        }

        #region Func
        #endregion
        #region Event
        #endregion
        private void lblTentruong_Click(object sender, EventArgs e)
        {

        }

        private void frmThongtintruonghoc_Load(object sender, EventArgs e)
        {
            lblTentruong.Text = DataProvider.Instance.ExecuteSchalar("SELECT TenTruong FROM QuyDinhTruong").ToString();
            lblMatruong.Text = DataProvider.Instance.ExecuteSchalar("SELECT MaTruong FROM QuyDinhTruong").ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
