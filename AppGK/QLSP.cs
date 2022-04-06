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
                i["MSP"].ToString(),
                i["TenSanPham"].ToString(),
                i["NgayNhapHang"].ToString(),
                i["NhaSanXuat"].ToString(),
                i["TinhTrang"].ToString(),
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
        public SanPham GetSanPham(string MSP)
        {
            foreach(SanPham s in GetAllSP())
            {
                if (s.MSP == MSP) return s;
            }
            return null;
        }
        public List<SanPham> GetSPByName(string TenSanPham)
        {
            if(TenSanPham == "") return GetAllSP();
            List<SanPham> data=new List<SanPham>();
            foreach(SanPham s in GetAllSP())
            {
                if (s.TenSanPham.Contains(TenSanPham)) data.Add(s);
            }
            return data;
        }
        public IEnumerable<String> GetMatHang()
        {
            List<string> data=new List<string>();
            foreach(SanPham s in GetAllSP())
            {
                data.Add(s.TenMatHang);
            }
            return data.Distinct();
        }
        public IEnumerable<string> GetNhaSanXuat(string TenMatHang)
        {
            List<string> data = new List<string>();
            if (TenMatHang == "")
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
            return data.Distinct();       
        }
        public void DelRow(string MSSP)
        {
            DBSP.Instance.DelRow(MSSP);
        }
        public void DelRow(SanPham s)
        {
            DBSP.Instance.DelRow(s.MSP);
        }
        public void AddRow(SanPham s)
        {
            DBSP.Instance.AddRow(s);
        }
        public void UpdateRow(SanPham s)
        {
            DBSP.Instance.UpdateRow(s);
        }
        public List<SanPham> Sort(string By)
        {
            bool CompareMSP(SanPham s1,SanPham s2)
            {
                int comparison = String.Compare(s1.MSP, s2.MSP, comparisonType: StringComparison.OrdinalIgnoreCase);
                if (comparison>0) return true;
                return false;
            }
            bool CompareTenSanPham(SanPham s1,SanPham s2)
            {
                int comparison = String.Compare(s1.TenSanPham, s2.TenSanPham, comparisonType: StringComparison.OrdinalIgnoreCase);
                if(comparison>0) return true;
                return false;
            }
            bool CompareNgayNhap(SanPham s1,SanPham s2)
            {
                int comparison=DateTime.Compare(Convert.ToDateTime(s1.NgayNhapHang),Convert.ToDateTime(s2.NgayNhapHang));
                if (comparison > 0) return true;
                return false;
            }
            Func<SanPham, SanPham, bool> Compare=null;
            List<SanPham> data = GetAllSP();
            switch (By)
            {
                case "STT":
                    return data;
                case "MSP":
                    Compare = CompareMSP;
                    break;
                case "TenSanPham":
                    Compare= CompareTenSanPham;
                    break;
                case "NgayNhap":
                    Compare=CompareNgayNhap;
                    break;
                default:
                    break;
            }
            for (int i = 0; i < data.Count; i++)
                for (int j = i + 1; j < data.Count; j++)
                    if (Compare(data[i], data[j]))
                    {
                        var temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
            return data;
        }
    }
}
