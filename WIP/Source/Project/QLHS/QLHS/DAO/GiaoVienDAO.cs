using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        internal static GiaoVienDAO Instance { get { if (instance == null) instance = new GiaoVienDAO(); return GiaoVienDAO.instance; } private set => instance = value; }

        private GiaoVienDAO() { }

        public List<GiaoVien> getListGV()
        {
            List<GiaoVien> listGV = new List<GiaoVien>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GiaoVien");

            foreach  (DataRow item in data.Rows)
            {
                GiaoVien gv = new GiaoVien(item);
                listGV.Add(gv);
            }
            return listGV;
        }
    }
}
