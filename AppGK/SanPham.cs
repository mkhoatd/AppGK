using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGK
{
    class SanPham
    {
        public string MSP { get; set; } 
        public string TenSanPham { get; set; }
        public DateTime NgayNhapHang;
        public string NhaSanXuat;
        public bool TinhTrang;
        public string TenMatHang;
        public SanPham(string MSP, string TenSanPham,string NgayNhapHang,string NhaSanXuat, string TinhTrang, string TenMatHang)
        {
            this.MSP = MSP;
            this.TenSanPham = TenSanPham;
            this.NgayNhapHang=Convert.ToDateTime(NgayNhapHang);
            this.NhaSanXuat = NhaSanXuat;
            this.TinhTrang=Convert.ToBoolean(TinhTrang);
            this.TenMatHang = TenMatHang;
        }

        public SanPham(string MSP, string TenSanPham, DateTime NgayNhapHang, string NhaSanXuat, bool TinhTrang, string TenMatHang)
        {
            this.MSP = MSP;
            this.TenSanPham = TenSanPham;
            this.NgayNhapHang = NgayNhapHang;
            this.NhaSanXuat = NhaSanXuat;
            this.TinhTrang= TinhTrang;
            this.TenMatHang = TenMatHang;
        }
    }
}
