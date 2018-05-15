using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class KQTongHopHocKiDAO
    {
        private static KQTongHopHocKiDAO instance;

        public static KQTongHopHocKiDAO Instance { get { if (instance == null) instance = new KQTongHopHocKiDAO(); return instance; } set => instance = value; }
        private KQTongHopHocKiDAO() { }

        public bool LuuKetQua(string mahs, string malop, int mahocki, string mahocluc,string mahanhkiem, string namhoc)
        {
            float diemTB = (float)Math.Round(DiemDAO.Instance.DiemTBMonHocKiCacMon(mahs, malop, namhoc, mahocki),2);
            string query = "INSERT INTO dbo.KQ_HocKi_TongHop( MaHS,MaLop,MaHocKi,NamHoc,MaHocLuc,MaHK,DiemTBHocKi)" +
                           " VALUES  ( '"+mahs+"',N'"+malop+"',"+mahocki+",N'"+namhoc+"','"+mahocluc+"','"+mahanhkiem+"',"+diemTB+")";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaKetQua(string mahs,string malop,int mahocki,string namhoc)
        {
            string query = "DELETE dbo.KQ_HocKi_TongHop WHERE MaHS='" + mahs + "' AND MaLop=N'" + malop + "' AND NamHoc=N'" + namhoc + "' AND MaHocKi=" + mahocki + "";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
    }
}
