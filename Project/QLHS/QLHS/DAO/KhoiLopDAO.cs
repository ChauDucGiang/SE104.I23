using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    class KhoiLopDAO
    {
        private static KhoiLopDAO instance;

        internal static KhoiLopDAO Instance { get { if (instance == null) instance = new KhoiLopDAO(); return KhoiLopDAO.instance; } set => instance = value; }

        private KhoiLopDAO() { }

        public List<KhoiLop> getListKhoiLop()
        {
            List<KhoiLop> listKhoiLop = new List<KhoiLop>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhoiLop");

            foreach (DataRow item in data.Rows)
            {
                KhoiLop kl = new KhoiLop(item);
                listKhoiLop.Add(kl);
            }
            return listKhoiLop;
        }
    }
}
