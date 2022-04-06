using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppGK
{
    class DBSP
    {
        private static DBSP _Instance;
        public static DBSP Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new DBSP();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable DTSP;
        private int SoSanPham;
        private int Deleted;
        private DBSP()
        {
            DTSP = new DataTable();
            DTSP.Columns.AddRange(new DataColumn[] {
                new DataColumn("STT",typeof(string)),
                new DataColumn("MSP",typeof(string)),
                new DataColumn("TenSanPham",typeof(string)),
                new DataColumn("NgayNhapHang",typeof(DateTime)),
                new DataColumn("NhaSanXuat",typeof(string)),
                new DataColumn("TrangThai",typeof(bool)),
                new DataColumn("TenMatHang",typeof(string)),
            });
            DTSP.Rows.Add("01", "101", "A", DateTime.Now, "MSI", 1, "Laptop");
            DTSP.Rows.Add("02", "69", "B", DateTime.Now, "ASUS", 1, "Laptop");
            DTSP.Rows.Add("03", "96", "Iphone 1", DateTime.Now, "Apple", 1, "Smartphone");
            DTSP.Rows.Add("03", "102", "Iphone 2", DateTime.Now, "Apple", 0, "Smartphone");
            DTSP.Rows.Add("03", "103", "Macbook 1", DateTime.Now, "Apple", 1, "Laptop");
            Deleted = 0;
            SoSanPham = 3;
        }
        
        public void AddRow(SanPham s)
        {
            SoSanPham++;
            DTSP.Rows.Add(Convert.ToInt32(SoSanPham), s.MSP, s.TenSanPham, s.NgayNhapHang, s.NhaSanXuat, s.TrangThai, s.TenMatHang);
        }
        public void UpdateRow(SanPham s)
        {
            foreach(DataRow dr in DTSP.Rows)
            {
                if (dr["MSP"].ToString() == s.MSP)
                {
                    dr["TenSanPham"] = s.TenSanPham;
                    dr["NgayNhapHang"] = s.NgayNhapHang;
                    dr["NhaSanXuat"] = s.NhaSanXuat;
                    dr["TrangThai"] = s.TrangThai;
                    dr["TenMatHang"]=s.TenMatHang;
                }
            }
        }
        private void UpdateSTT()
        {
            if (Deleted == 0) return;
            for(int i=0;i< DTSP.Rows.Count; i++)
            {
                DataRow dr = DTSP.Rows[i];
                dr["STT"] = (i + 1).ToString();
            }
            Deleted = 0;
        }
        public void DelRow(string MSSP)
        {
            SoSanPham--;
            Deleted = 1;
            for(int i = DTSP.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr=DTSP.Rows[i];
                if(dr["MSP"].ToString()==MSSP) dr.Delete();
            }
            DTSP.AcceptChanges();
        }
        public static DataTable Get()
        {
            DBSP.Instance.UpdateSTT();
            return DBSP.Instance.DTSP;
        }
    }
}
