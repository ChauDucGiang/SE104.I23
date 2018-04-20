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
        public GiaoVien(string magv, string tengv)
        {
            this.MaGV = magv;
            this.TenGV = tengv;
        }

        public GiaoVien(DataRow row)
        {
            this.MaGV = row["MaGV"].ToString();
            this.TenGV = row["TenGV"].ToString();
        }

        private string tenGV;

        private string maGV;

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
    }
}
