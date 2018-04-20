using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class MonHocDAO
    {
        private static MonHocDAO instance;

        public static MonHocDAO Instance { get { if (instance == null) instance = new MonHocDAO(); return instance; } set => instance = value; }
        private MonHocDAO() { }

        public DataTable LoadMonHoc()
        {
            string query = "SELECT * FROM MonHoc";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
