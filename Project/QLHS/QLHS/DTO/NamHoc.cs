using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    class NamHoc
    {
        public NamHoc(string maNamHoc, string tenNamHoc)
        {
            this.MaNamHoc = MaNamHoc;
            this.TenNamHoc = tenNamHoc;
        }

        public NamHoc(DataRow row)
        {
            this.MaNamHoc = row["MaNamHoc"].ToString();
            this.TenNamHoc = row["tenNamHoc"].ToString();
        }

        private string maNamHoc;
        private string tenNamHoc;

        public string TenNamHoc { get => tenNamHoc; set => tenNamHoc = value; }
        public string MaNamHoc { get => maNamHoc; set => maNamHoc = value; }
    }
}
