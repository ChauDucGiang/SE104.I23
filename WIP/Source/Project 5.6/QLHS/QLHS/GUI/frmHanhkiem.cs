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
    public partial class frmHanhkiem : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmHanhkiem()
        {
            InitializeComponent();
            dGVHanhkiem.DataSource = bd;
        }
        #region Event
        private void frmHanhkiem_Load(object sender, EventArgs e)
        {
            bd.DataSource = HanhKiemDAO.Instance.LoadHanhKiem();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Func
        #endregion

    }
}
