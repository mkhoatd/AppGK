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
    public partial class Form2 : Form
    {
        private QLSP QLSPInstance=new QLSP();
        string MSP;
        public delegate void MyDel(string Name);
        public MyDel d;
        public void FillNhaSX(string mathang)
        {
            NhaSanXuatComboBox.Items.Clear();
            foreach(string s in QLSPInstance.GetNhaSanXuat(mathang))
            {
                NhaSanXuatComboBox.Items.Add(s);
            }
        }
        public Form2(string m="")
        {
            InitializeComponent();
            MSP = m;
            foreach(string mathang in QLSPInstance.GetMatHang())
            {
                MatHangComboBox.Items.Add(mathang);
            }   
            if (MSP != "")
            {
                MaSanPhamTextBox.Enabled = false;
                SanPham s = QLSPInstance.GetSanPham(MSP);
                MaSanPhamTextBox.Text = s.MSP;
                TenSanPhamTextBox.Text=s.TenSanPham;
                NgayNhapDateTimePicker.Value = s.NgayNhapHang;
                MatHangComboBox.SelectedItem = s.TenMatHang;
                FillNhaSX(s.TenMatHang);
                NhaSanXuatComboBox.SelectedItem = s.NhaSanXuat;
                bool TinhTrang = s.TinhTrang;
                if(TinhTrang) radioButton1.Checked = true;
                else radioButton2.Checked = false;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            bool TinhTrang;
            if (radioButton1.Checked) TinhTrang=true;
            else TinhTrang=false;
            SanPham s = new SanPham(MaSanPhamTextBox.Text, TenSanPhamTextBox.Text, NgayNhapDateTimePicker.Value, NhaSanXuatComboBox.SelectedItem.ToString(), TinhTrang, MatHangComboBox.SelectedItem.ToString());
            if(MSP=="") QLSPInstance.AddRow(s);
            else QLSPInstance.UpdateRow(s);
            d("");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MatHangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNhaSX(MatHangComboBox.SelectedItem.ToString());
        }
    }
}
