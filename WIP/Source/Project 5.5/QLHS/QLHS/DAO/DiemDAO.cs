using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    public class DiemDAO
    {
        private static DiemDAO instance;

        public static DiemDAO Instance
        {
            get
            {
                if (instance == null) instance = new DiemDAO(); return instance;
            }
            set => instance = value;
        }
        private DiemDAO() {}
        public DataTable GetMaHSFromBangDiem()
        {
            string query = "SELECT DISTINCT MaHS FROM dbo.BangDiem";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public bool KiemTraDiem(DataGridView dgv, string loaidiem)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[loaidiem].Value != null)
                {
                    string ChuoiChuaXuLy = row.Cells[loaidiem].Value.ToString();
                    string ChuoiDaXuLy = "";

                    int count = 0;
                    for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                    {
                        if (ChuoiChuaXuLy[i] != ';' && i != ChuoiChuaXuLy.Length - 1)
                        {
                            count++;
                        }
                        else
                        {
                            if (i == ChuoiChuaXuLy.Length - 1)
                            {
                                i++;
                                count++;

                            }

                            ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                            if (count != 0 && QuyDInhDiemDAO.Instance.KiemTraDiem(ChuoiDaXuLy) == false)
                            {
                                return false;
                            }
                            ChuoiDaXuLy = "";
                            count = 0;
                        }
                    }
                }
            }
            return true;
        }
        public void LuuDiem(string mahs, string malop, string macotdiem, float diemso, int hocki, string namhoc, string mamon)
        {
            string query = String.Format("EXEC dbo.InsertDiemAndMon @mahs = '{0}',@malop = N'{1}',@macotdiem = '{2}',@diem = {3},@hocki = {4},@namhoc = N'{5}',@monhoc = '{6}'", mahs, malop, macotdiem, Math.Round(diemso, 2), hocki, namhoc, mamon);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void XoaDIem(int mahs)
        {
            string query = "EXEC dbo.DeleteBangDiemByMaHS @mahs = " + mahs;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool KiemTraMaHSInBangDiem(string mahs)
        {
            string query = "SELECT COUNT(*) FROM dbo.BangDiem WHERE MaHS= '" + mahs+"'";
            int result = (int)DataProvider.Instance.ExecuteSchalar(query);
            return result > 0;
        }

        public DataTable LoadSTInClassByMaLopAndNamHoc(string malop, string namhoc)
        {
            string query = "EXEC dbo.USP_GetBangDiem @malop = '" + malop + "',@manamhoc = N'" + namhoc + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
