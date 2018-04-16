using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class NamHocDAO
    {
        private static NamHocDAO instance;

        public static NamHocDAO Instance { get { if (instance == null) instance = new NamHocDAO(); return instance; } set => instance = value; }
        private NamHocDAO() { }

        public DataTable LoadNamHoc()
        {
            string query = "SELECT * FROM NamHoc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool ThemNamHoc(string manamhoc,string tennamhoc)
        {
            string query = "EXEC dbo.USP_ThemNamHoc @manamhoc = N'"+manamhoc+"',@tennamhoc = N'"+tennamhoc+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaNamHoc(string manamhoc)
        {
            string query = "EXEC dbo.USP_XoaNamHoc @manamhoc = N'"+manamhoc+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
    }
}
