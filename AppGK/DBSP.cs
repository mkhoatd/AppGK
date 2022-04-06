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
        private DBSP()
        {
            DTSP = new DataTable();
            DTSP.Columns.AddRange(new DataColumn[] {
                new DataColumn("MSP",typeof(string)),
                new DataColumn("TenSanPham",typeof(string)),
                new DataColumn("NgayNhapHang",typeof(DateTime)),
                new DataColumn("NhaSanXuat",typeof(string)),
                new DataColumn("TinhTrang",typeof(bool)),
                new DataColumn("TenMatHang",typeof(string)),
            });
            DTSP.Rows.Add( "101", "A", DateTime.Now, "MSI", 1, "Laptop");
            DTSP.Rows.Add( "169", "B", DateTime.Now, "ASUS", 1, "Laptop");
            DTSP.Rows.Add( "196", "Iphone 1", DateTime.Now, "Apple", 1, "Smartphone");
            DTSP.Rows.Add( "102", "Iphone 2", DateTime.Now, "Apple", 0, "Smartphone");
            DTSP.Rows.Add( "103", "Macbook 1", DateTime.Now, "Apple", 1, "Laptop");
        }
        
        public void AddRow(SanPham s)
        {
            DTSP.Rows.Add( s.MSP, s.TenSanPham, s.NgayNhapHang, s.NhaSanXuat, s.TinhTrang, s.TenMatHang);
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
                    dr["TinhTrang"] = s.TinhTrang;
                    dr["TenMatHang"] = s.TenMatHang;
                }
            }
        }
        public void DelRow(string MSP)
        {
            for(int i = DTSP.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr=DTSP.Rows[i];
                if(dr["MSP"].ToString()==MSP) dr.Delete();
            }
            DTSP.AcceptChanges();
        }
        public static DataTable Get()
        {
            return DBSP.Instance.DTSP;
        }
    }
}
