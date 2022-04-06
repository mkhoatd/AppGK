using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGK
{
    class SanPham
    {
        public string Id { get; set; } 
        public string TenSanPham { get; set; }
        public DateTime NgayNhapHang;
        public string NhaSanXuat;
        public bool TrangThai;
        public string TenMatHang;
        public SanPham(string Id, string TenSanPham,string NgayNhapHang,string NhaSanXuat, string TrangThai, string TenMatHang)
        {
            this.Id = Id;
            this.TenSanPham = TenSanPham;
            this.NgayNhapHang=Convert.ToDateTime(NgayNhapHang);
            this.NhaSanXuat = NhaSanXuat;
            this.TrangThai=Convert.ToBoolean(TrangThai);
            this.TenMatHang = TenMatHang;
        }
    }
}
