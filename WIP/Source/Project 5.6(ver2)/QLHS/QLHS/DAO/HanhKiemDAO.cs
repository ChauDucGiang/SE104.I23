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
    }
}
