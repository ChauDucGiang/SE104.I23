using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class XepLopDAO
    {
        private static XepLopDAO instance;

        public static XepLopDAO Instance { get { if (instance == null) instance = new XepLopDAO(); return instance; } set => instance = value; }
        private XepLopDAO() { }

        public bool XepLop(string mahs,string malop)
        {
            string query = "EXEC dbo.USP_XepLop @mahs = '"+mahs+"' ,@malop = '"+malop+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaXepLop(string mahs)
        {
            string query = "EXEC dbo.USP_DeleteXepLop @mahs = '" + mahs + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public DataTable GetHSNotInClass()
        {
            string query = "SELECT * FROM dbo.HocSinh WHERE CheckInClass=0";
            DataTable data= DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetHSHaveClass(string malop,string namhoc)
        {
            string query = "EXEC dbo.USP_GetHSByMaLopAndNamHoc @malop = '"+malop+"',@manamhoc = N'"+namhoc+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
           
            return data;
        }
        
         
    }
}
