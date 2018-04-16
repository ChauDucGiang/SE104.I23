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
    public partial class frmHocky : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmHocky()
        {
            InitializeComponent();
            dGVHocky.DataSource = bd;
        }
        #region Event
        private void frmHocky_Load(object sender, EventArgs e)
        {
            bd.DataSource = HocKiDAO.Instance.LoadHocKi();
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
