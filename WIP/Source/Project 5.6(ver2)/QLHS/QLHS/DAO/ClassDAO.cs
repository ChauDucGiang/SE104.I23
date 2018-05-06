using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    class ClassDAO
    {
        private static ClassDAO instance;

        internal static ClassDAO Instance { get { if (instance == null) instance = new ClassDAO(); return ClassDAO.instance; } private set => instance = value; }

        private ClassDAO() { }

        
        public void InsertClass(string malop, string tenlop, string makhoilop, string namhoc, string gvcn)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC ThemLop @malop , @tenlop , @makhoilop , @namhoc , @gvcn", new object[] {malop,tenlop,makhoilop,namhoc,gvcn});
        }

        //Get list class is existed, Existed return true else return false
        public bool getStatusClassbyMaLop(string malop)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE MaLop='"+malop+"'");
            if (data.Rows.Count > 0)
                return true;

            return false;
        }
        //Get list class is existed, Existed return true else return false
        public bool getStatusClassbyTenLop(string tenlop)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE TenLop= N'"+ tenlop+"'");
            if (data.Rows.Count > 0)
                return true;

            return false;
        }
        //public List<ClassDTO> getClass(string malop)
        //{
        //    List<ClassDTO> listCL = new List<ClassDTO>();

        //    DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaLop, TenLop, NamHoc, GVCN FROM Lop WHERE MaLop="+malop);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        ClassDTO cl = new ClassDTO(item);
        //        listCL.Add(cl);
        //    }

        //    return listCL;

        //}
        public bool updateClass(string malop, string tenlop, string tenkhoilop, string tengiaovien, string tennamhoc)
        {
            string query = "EXEC dbo.USP_UpdateLop @malop = '" + malop + "' , @tenlop = N'" + tenlop + "', @tenkhoilop = N'" + tenkhoilop + "' , @tengiaovien = N'" + tengiaovien + "', @tennamhoc = N'" + tennamhoc + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool deleteClass(string malop)
        {
            string query = "EXEC dbo.DeleteClass @malop = '" + malop+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckGVCNinClass(string magv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE GVCN ='" + magv + "'");
            if (data.Rows.Count > 0) return true;
            return false;
        }
    }
}
