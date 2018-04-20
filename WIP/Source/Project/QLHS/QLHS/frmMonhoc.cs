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
    public partial class frmMonhoc : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmMonhoc()
        {
            InitializeComponent();
            dGVMonhoc.DataSource = bd;
        }
        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            bd.DataSource = MonHocDAO.Instance.LoadMonHoc();
        }
        #endregion

        #region Func
        #endregion


    }
}
