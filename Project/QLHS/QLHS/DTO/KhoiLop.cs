using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class KhoiLop
    {
        public KhoiLop(string makhoi, string tenkhoi)
        {
            this.MaKhoi = makhoi;
            this.TenKhoi = tenkhoi;
        }

        public KhoiLop(DataRow row)
        {
            this.MaKhoi = row["MaKhoiLop"].ToString();
            this.TenKhoi = row["TenKhoiLop"].ToString();
        }


        private string tenKhoi;
        private string maKhoi;

        public string MaKhoi { get => maKhoi; set => maKhoi = value; }
        public string TenKhoi { get => tenKhoi; set => tenKhoi = value; }
    }
}
