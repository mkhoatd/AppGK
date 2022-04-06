using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGK
{
    
    public partial class Form1 : Form
    {
        private QLSP QLSPInstance = new QLSP();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns=true;
            sortComboBox.Items.Add("MSP");
            sortComboBox.Items.Add("TenSanPham");
            sortComboBox.Items.Add("NgayNhap");
            Reload("");

        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<SanPham> data=QLSPInstance.Sort(sortComboBox.SelectedItem.ToString());
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("STT",typeof(string)),
                new DataColumn("Mã sản phẩm",typeof(string)),
                new DataColumn("Tên sản phẩm",typeof(string)),
                new DataColumn("Nhà sản xuất",typeof(string)),
                new DataColumn("Ngày nhập",typeof(DateTime)),
                new DataColumn("Mặt hàng",typeof(string)),
                new DataColumn("Tình trạng",typeof(bool)),
            });
            int i = 0;
            foreach (SanPham s in data)
            {
                i++;
                dt.Rows.Add(i.ToString(), s.MSP, s.TenSanPham, s.NhaSanXuat, s.NgayNhapHang, s.TenMatHang, s.TinhTrang);
            }
            dataGridView1.DataSource = dt;
        }
        public void Reload(string name="")
        {
            List<SanPham> data;
            if (name == "") data = QLSPInstance.GetAllSP();
            else data = QLSPInstance.GetSPByName(name);
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("STT",typeof(string)),
                new DataColumn("Mã sản phẩm",typeof(string)),
                new DataColumn("Tên sản phẩm",typeof(string)),
                new DataColumn("Nhà sản xuất",typeof(string)),
                new DataColumn("Ngày nhập",typeof(DateTime)),
                new DataColumn("Mặt hàng",typeof(string)),
                new DataColumn("Tình trạng",typeof(bool)),
            });
            int i = 0;
            foreach(SanPham s in data)
            {
                i++;
                dt.Rows.Add(i.ToString(),s.MSP,s.TenSanPham,s.NhaSanXuat,s.NgayNhapHang,s.TenMatHang,s.TinhTrang);
            }
            dataGridView1.DataSource=dt;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2("");
            f.d = Reload;
            f.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Reload(searchTextBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    QLSPInstance.DelRow(dr.Cells[1].Value.ToString());
                }
            }
            Reload();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form2 f = new Form2(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                f.d = Reload;
                f.Show();
            }
        }
    }
}
