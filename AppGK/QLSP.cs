using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppGK
{
    class QLSP
    {
        public SanPham GetSanPhamByDataRow(DataRow i)
        {
            return new SanPham(
                i["MSSP"].ToString(),
                i["TenSanPham"].ToString(),
                i["NgayNhapHang"].ToString(),
                i["NhaSanXuat"].ToString(),
                i["TrangThai"].ToString(),
                i["TenMatHang"].ToString());
        }
        public List<SanPham> GetAllSP()
        {
            List<SanPham> data=new List<SanPham> ();
            foreach(DataRow dr in DBSP.Get().Rows)
            {
                data.Add(GetSanPhamByDataRow(dr));
            }
            return data;
        }
        public List<SanPham>
    }
}
