using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class KQTongHopDAO
    {
        private static KQTongHopDAO instance;

        public static KQTongHopDAO Instance { get { if (instance == null) instance = new KQTongHopDAO(); return instance; } set => instance = value; }
        private KQTongHopDAO() { }

        public bool LuuKetQua(string mahs,string malop,string namhoc,string mahocluc,string mahanhkiem)
        {
            float diemTB = (float)Math.Round(DiemDAO.Instance.DiemTBMonCaNamCacMon(mahs, malop, namhoc),2);
            string query = "INSERT INTO dbo.KQ_TongHop( MaHS,MaLop,NamHoc,MaHocLuc,MaHK,DiemTBNam)" +
                            " VALUES  ( '" + mahs + "' ,N'" + malop + "',N'" + namhoc + "','" + mahocluc + "','" + mahanhkiem + "'," + diemTB + ")";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool XoaKetQua(string mahs,string malop,string namhoc)
        {
            string query = "DELETE dbo.KQ_TongHop WHERE MaHS='" + mahs + "' AND MaLop=N'" + malop + "' AND NamHoc = N'" + namhoc + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
    }
}
