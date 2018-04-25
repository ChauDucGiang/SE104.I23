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

        public DataTable XepLop(int mahs,string malop)
        {
            string query = "EXEC dbo.USP_XepLop @mahs = "+mahs+",@malop = '"+malop+"'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public List<HocSinh> GetHSNotInClass()
        {
            List<HocSinh> list = new List<HocSinh>();
            string query = "SELECT * FROM dbo.HocSinh WHERE CheckInClass=0";
            DataTable data= DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow r in data.Rows)
            {
                HocSinh hs = new HocSinh(r);
                list.Add(hs);
            }
            return list;
        }
        public List<HocSinh> GetHSHaveClass(string malop,string namhoc)
        {
            List<HocSinh> list = new List<HocSinh>();
            string query = "EXEC dbo.USP_GetHSByMaLopAndNamHoc @malop = '"+malop+"',@manamhoc = N'"+namhoc+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow r in data.Rows)
            {
                HocSinh hs = new HocSinh(r);
                list.Add(hs);
            }
            return list;
        }
    }
}
