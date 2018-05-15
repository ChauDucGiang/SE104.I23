using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class HocLucDAO
    {
        private static HocLucDAO instance;

        public static HocLucDAO Instance { get { if (instance == null) instance = new HocLucDAO(); return instance; } set => instance = value; }
        private HocLucDAO() { }

        public DataTable LoadHocLuc()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocLuc");
            return data;
        }
        public bool ThemHocLuc(string mahocluc, string tenhocluc,float diemtoithieu, float diemtoida)
        {
            string query = "INSERT INTO dbo.HocLuc( MaHocLuc, TenHocLuc,DiemToiDa,DiemToiThieu) VALUES  ( '" + mahocluc + "',N'" + tenhocluc + "',"+diemtoithieu+","+diemtoida+")";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaHocLuc(string mahocluc)
        {
            string query = "DELETE dbo.HocLuc WHERE MaHocLuc = '" + mahocluc + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool SuaHocLuc(string mahocluc, string tenhocluc, float diemtoithieu, float diemtoida)
        {
            string query = "UPDATE dbo.HocLuc SET TenHocLuc = N'" + tenhocluc + "', DiemToiThieu = "+diemtoithieu+", DiemToiDa = "+diemtoida+" WHERE MaHocLuc = '" + mahocluc + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckHocLucExist(string mahocluc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocLuc WHERE MaHocLuc = '" + mahocluc + "'");
            return data.Rows.Count > 0;
        }
    }
}
