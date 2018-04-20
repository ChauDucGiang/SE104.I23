using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class HocKiDAO
    {
        private static HocKiDAO instance;

        public static HocKiDAO Instance
        {
            get { if (instance == null) instance = new HocKiDAO(); return instance; }
            set => instance = value;
        }
        private HocKiDAO() { }
        
        public DataTable LoadHocKi()
        {
            string query = "SELECT * FROM dbo.HocKi";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
