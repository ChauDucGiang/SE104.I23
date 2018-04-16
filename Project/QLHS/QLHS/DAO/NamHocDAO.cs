using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    class NamHocDAO
    {
        private static NamHocDAO instance;

        internal static NamHocDAO Instance { get{ if (instance == null) instance = new NamHocDAO(); return NamHocDAO.instance; } private set => instance = value; }

        private NamHocDAO() { }

        public List<NamHoc> getListNamHoc()
        {
            List<NamHoc> list = new List<NamHoc>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NamHoc");

            foreach (DataRow item in data.Rows)
            {
                NamHoc nh = new NamHoc(item);
                list.Add(nh);
            }
            return list;
        }
    }
}
