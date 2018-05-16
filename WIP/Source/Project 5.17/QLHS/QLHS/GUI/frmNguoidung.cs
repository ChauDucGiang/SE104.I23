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

namespace QLHS.GUI
{
    public partial class frmNguoidung : Form
    {
        BindingSource bd = new BindingSource();
        public frmNguoidung()
        {
            InitializeComponent();

            dgvAccount.DataSource = bd;
        }


        #region Events

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void frmNguoidung_Load(object sender, EventArgs e)
        {
            bd.DataSource = AccountDAO.Instance.loadAccount();
            navAccount.BindingSource = bd;
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            dgvAccount.CurrentRow.Cells["UserName"].ReadOnly = false;

        }
        private void Save_Click(object sender, EventArgs e)
        {
            //string username = dgvAccount.CurrentRow.Cells["UserName"].Value.ToString();
            //string tenguoidung = dgvAccount.CurrentRow.Cells["TenNguoiDung"].Value.ToString();
            //string loai = dgvAccount.CurrentRow.Cells["Type"].Value.ToString();
            //AccountDAO.Instance.UpdateAccount(username, tenguoidung, loai);
            //MessageBox.Show("Đã chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK);
            SaveItem();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string username = dgvAccount.CurrentRow.Cells["UserName"].Value.ToString();
            AccountDAO.Instance.DeleteAccount(username);
            MessageBox.Show("Đã xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
        }
        #endregion

        #region func
        public void LoadAccount()
        {
            dgvAccount.DataSource = AccountDAO.Instance.loadAccount();
        }
        public void SaveItem()
        {
            for (int i = 0; i < dgvAccount.Rows.Count; i++)
            {
                string username = dgvAccount.CurrentRow.Cells["UserName"].Value.ToString();
                string tenguoidung = dgvAccount.CurrentRow.Cells["TenNguoiDung"].Value.ToString();
                string loai = dgvAccount.CurrentRow.Cells["Type"].Value.ToString();
                if (username == "")
                {
                    MessageBox.Show("Mã năm học trống !", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (tenguoidung == "")
                {
                    MessageBox.Show("Tên người dùng trống !", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (loai == "")
                {
                    MessageBox.Show("Loại người dùng trống !", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (!AccountDAO.Instance.checkExistAccountbyUsername(username))
                    AccountDAO.Instance.AddAccount(username, tenguoidung, loai);
                if (AccountDAO.Instance.checkExistAccountbyUsername(username) && AccountDAO.Instance.CheckUsernameInDGV(username, dgvAccount) == false)
                    AccountDAO.Instance.UpdateAccount(username, tenguoidung, loai);
            }

            MessageBox.Show("Đã lưu thành công !", "Thông báo", MessageBoxButtons.OK);
            LoadAccount();

        }
        #endregion
        #region Others
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if Enter is pressed
            if (keyData == Keys.Enter)
            {
                // If there isn't any selected row, do nothing
                if (dgvAccount.CurrentRow == null)
                {
                    return true;
                }

                // Display first cell's value
                dgvAccount.CurrentCell = dgvAccount.CurrentRow.Cells["TenNguoiDung"];
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        #endregion


    }
}