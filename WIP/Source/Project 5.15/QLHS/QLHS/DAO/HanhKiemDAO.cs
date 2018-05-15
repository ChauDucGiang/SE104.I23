using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class HanhKiemDAO
    {
        private static HanhKiemDAO instance;

        public static HanhKiemDAO Instance { get { if (instance == null) instance = new HanhKiemDAO(); return instance; } set => instance = value; }
        private HanhKiemDAO() { }

        public DataTable LoadHanhKiem()
        {
            string query = "SELECT * FROM HanhKiem";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool ThemHanhKiem(string mahanhkiem, string tenhanhkiem)
        {
            string query = "INSERT INTO dbo.HanhKiem( MaHK, LoaiHK )VALUES  ( '"+mahanhkiem+"',N'"+tenhanhkiem+"')";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaHanhKiem(string mahanhkiem)
        {
            string query = "DELETE dbo.HanhKiem WHERE MaHK = '" + mahanhkiem + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool SuaHanhKiem(string mahanhkiem, string tenhanhkiem)
        {
            string query = "UPDATE dbo.CotDiem SET TenCotDiem = N'" + tenhanhkiem + "' WHERE MaHK = '" + mahanhkiem + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckHanhKiemExist(string mahanhkiem)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HanhKiem WHERE MaHK = '" + mahanhkiem + "'");
            return data.Rows.Count > 0;
        }
    }
}
