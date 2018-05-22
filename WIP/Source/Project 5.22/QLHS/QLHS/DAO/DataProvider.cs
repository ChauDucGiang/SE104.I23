using System;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using QLHS;
using static QLHS.Utilities;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
using System.Configuration;
using System.Data.Common;

namespace QLHS.DAO
{
    class DataProvider : DataTable
    {
        private static SqlConnection m_Connection;
        public static String m_ConnectString = "";
        private SqlCommand m_Command;
        private SqlDataAdapter m_DataAdapter;
        #region Field
        #endregion
        private static DataProvider instance;
        private static XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
        private static XmlElement xmlEle = xmlDoc.DocumentElement;
        internal static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider(); return DataProvider.instance;
            }

            private set
            {
                DataProvider.instance = value;
            }
        }

        private DataProvider() { }
        #region OpenConnection
        public static bool OpenConnection()
        {
            if (m_ConnectString == "")
                ConnectionString();
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectString);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch
            {
                m_Connection.Close();
                return false;
            }
        }
        #endregion
        #region Hàm lấy lệnh connection
        public static void ConnectionString()
        {
            try
            {
                if (xmlEle.SelectSingleNode("costatus").InnerText == "true")
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";

                }
                else
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }

                Utilities.DatabaseName = xmlEle.SelectSingleNode("database").InnerText;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion
        public static String ConSTR()
        {
            XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
            XmlElement xmlEle = xmlDoc.DocumentElement;
            String connectionST = "";
            try
            {
                if (xmlEle.SelectSingleNode("costatus").InnerText == "true")
                {
                    connectionST = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";

                }
                else
                {
                    connectionST = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }

                Utilities.DatabaseName = xmlEle.SelectSingleNode("database").InnerText;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return connectionST;
        }


        //private string connectionSTR = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        //Thực hiện các câu lệnh Select
        public string connectionSTR = ConSTR();
        #region
        public DataTable Load(SqlCommand m_Sql)
        {
            m_Command = m_Sql;
            try
            {
                m_Command.Connection = new SqlConnection(connectionSTR);

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                this.Clear();
                m_DataAdapter.Fill(this);
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            }
            return this;
        }
        #endregion

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
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
            catch (Exception e)
            {
                MessageBox.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return data;
        }

        //Liên quan đến số lượng
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
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

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteSchalar(string query, object[] parameter = null)
        {

            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
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
                data = command.ExecuteScalar();
                connection.Close();

            }
            return data;
        }

    }
}
