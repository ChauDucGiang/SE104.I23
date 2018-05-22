using DevComponents.DotNetBar;
using QLHS.GUI;
using QLHS.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace QLHS
{
    public partial class frmLogin : Form
    {
        frmConnection m_Connection = null;
        frmLogin m_FrmLogin = null;
        public delegate void User(TextBox tb);
        private string user = "";
        public frmLogin()
        {
            InitializeComponent();
            Default();
        }
        #region Event
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (DataProvider.OpenConnection())
            {
                if (Properties.Settings.Default.user != String.Empty)
                {
                    txtTen.ForeColor = SystemColors.WindowText;
                    txtTen.Text = Properties.Settings.Default.user;
                    txtMatkhau.UseSystemPasswordChar = true;
                    txtMatkhau.ForeColor = SystemColors.WindowText;
                    txtMatkhau.Text = Properties.Settings.Default.pass;
                    chkGhinhodangnhap.Checked = Properties.Settings.Default.isCheck;

                }
                if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
                {
                    m_FrmLogin = new frmLogin();
                }
            }
            else
            {
                ReConnection();
            }
        }
        public void ReConnection()
        {
            MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            //m_Connection = new frmConnection();
            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new frmConnection();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
                return;
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string userName = txtTen.Text;
            user = txtTen.Text;
            string passWord = txtMatkhau.Text;
            if (_login(userName, passWord))
            {
                frmMain main = new frmMain();
                ; this.DialogResult = DialogResult.OK;
                this.Hide();
                User u = new User(main.SaveU);
                u(txtTen);
                main.ShowDialog();
                if (chkGhinhodangnhap.Checked)
                {
                    Properties.Settings.Default.user = txtTen.Text;

                    Properties.Settings.Default.pass = txtMatkhau.Text;
                    Properties.Settings.Default.isCheck = chkGhinhodangnhap.Checked;

                    Properties.Settings.Default.Save();
                }
                else
                {
                    Default();
                }
                this.Close();
            }
            else
            {
                lblThongbaodangnhap.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                lblThongbaodangnhap.ForeColor = Color.Red;
                Default();
            }

        }

        #endregion
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.ConSTR()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
                //return data;
            }
            catch ( Exception e)
            {
                //MessageBox.Show();
            }
            return data;
        }
        #region Func
        bool _login(string userName, string passWord)
        {
            string query = "EXEC dbo.USP_User_Login @userName , @passWord";

            DataTable result = ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }
        public void SaveU(string _user)
        {
            _user = this.user;
        }
        #endregion

        private void txtTen_Enter(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtTen.Text == "Please Enter Your Username")
            {
                txtTen.Text = "";
                txtTen.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            if (txtTen.Text.Length == 0)
            {
                txtTen.Text = "Please Enter Your Username";
                txtTen.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtMatkhau_Enter(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == "" || txtMatkhau.Text == "Please Enter Your Password")
            {
                txtMatkhau.UseSystemPasswordChar = true;
                txtMatkhau.Text = "";
                txtMatkhau.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            if (txtMatkhau.Text.Length == 0)
            {
                txtMatkhau.UseSystemPasswordChar = false;
                txtMatkhau.Text = "Please Enter Your Password";
                txtMatkhau.ForeColor = SystemColors.GrayText;
            }
        }

        public void Default()
        {
            Reset.ResetAllControls(grDangnhap);
            txtTen.Text = "Please Enter Your Username";
            txtTen.ForeColor = SystemColors.GrayText;
            txtMatkhau.UseSystemPasswordChar = false;
            txtMatkhau.Text = "Please Enter Your Password";
            txtMatkhau.ForeColor = SystemColors.GrayText;
            txtTen.Focus();
        }
    }
}
