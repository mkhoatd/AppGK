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
        public List<SanPham> GetSPByName(string TenSanPham)
        {
            if(TenSanPham == null) return GetAllSP();
            List<SanPham> data=new List<SanPham>();
            foreach(SanPham s in GetAllSP())
            {
                if (s.TenSanPham.Contains(TenSanPham)) data.Add(s);
            }
            return data;
        }
        public List<string> GetNhaSanXuat(string TenMatHang)
        {
            List<string> data = new List<string>();
            if (TenMatHang == null)
            {
                foreach (SanPham s in GetAllSP())
                {
                    data.Add(s.NhaSanXuat);
                }
            }
            else
            {
                foreach(SanPham s in GetAllSP())
                {
                    if (s.TenMatHang.Contains(TenMatHang)) data.Add(s.NhaSanXuat);
                }
            }
            return (List<string>)data.Distinct();       
        }
        public void DelRow(string MSSP)
        {
            DBSP.Instance.DelRow(MSSP);
        }
        public void AddRow(SanPham s)
        {
            DBSP.Instance.AddRow(s);
        }
    }
}
