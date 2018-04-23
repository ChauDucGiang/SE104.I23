using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class GiaoVien
    {
        private string maGV;
        private string tenGV;
        private string sDT;
        private string diaChi;
        private string maMon;

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaMon { get => maMon; set => maMon = value; }

        public GiaoVien(string magv,string tengv,string diachi,string sdt,string mamon)
        {
            this.MaGV = magv;
            this.TenGV = tengv;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.MaMon = mamon;
        }
        public GiaoVien(DataRow r)
        {
            this.MaGV = r["MaGV"].ToString();
            this.TenGV = r["TenGV"].ToString();
            this.SDT = r["SDT"].ToString();
            this.DiaChi = r["DiaChi"].ToString();
            this.MaMon = r["MaMH"].ToString();
        }
    }
}
