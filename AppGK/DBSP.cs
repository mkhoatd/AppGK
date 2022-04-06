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
        private DBSP()
        {
            DTSP = new DataTable();
            DTSP.Columns.AddRange(new DataColumn[] {
                new DataColumn("STT",typeof(string)),
                new DataColumn("MSSP",typeof(string)),
                new DataColumn("TenSanPham",typeof(string)),
                new DataColumn("NgayNhapHang",typeof(DateTime)),
                new DataColumn("NhaSanXuat",typeof(string)),
                new DataColumn("TrangThai",typeof(bool)),
                new DataColumn("TenMatHang",typeof(string)),
            });
            DTSP.Rows.Add("01", "101", "A", DateTime.Now, "MSI", 1, "Laptop");
            DTSP.Rows.Add("02", "69", "B", DateTime.Now, "ASUS", 1, "Laptop");
            DTSP.Rows.Add("03", "96", "C", DateTime.Now, "Samsung", 1, "Stupidphone");
            SoSanPham = 3;
        }
        
        public void AddRow(SanPham s)
        {
            SoSanPham++;
            DTSP.Rows.Add(Convert.ToInt32(SoSanPham), s.MSSP, s.TenSanPham, s.NgayNhapHang, s.NhaSanXuat, s.TrangThai, s.TenMatHang);
        }
        public void UpdateRow(SanPham s)
        {
            foreach(DataRow dr in DTSP.Rows)
            {
                if (dr["MSSP"].ToString() == s.MSSP)
                {

                }
            }
        }
    }
}
