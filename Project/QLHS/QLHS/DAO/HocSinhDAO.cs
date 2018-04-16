using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class HocSinhDAO
    {
        private static HocSinhDAO instance;

        public static HocSinhDAO Instance
        {
            get { if (instance == null) instance = new HocSinhDAO(); return instance; }
            set => instance = value;
        }
        private HocSinhDAO() { }

        public bool ThemHocSinh(int mahs, string hoten, string gioitinh, DateTime ngaysinh, string noisinh, string dienthoai, string email,string diachi)
        {
            string query = "EXEC dbo.USP_ThemHocSinh @mahs = " + mahs + ",@hoten = N'" + hoten + "',@gioitinh = N'" + gioitinh + "',@ngaysinh = '" + ngaysinh + "',@noisinh = N'" + noisinh + "',@dienthoai = N'" + dienthoai + "',@email = N'" + email + "',@diachi = N'" + diachi + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
