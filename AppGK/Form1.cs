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
            sortComboBox.Items.Add("STT");
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
            dataGridView1.DataSource=QLSPInstance.Sort(sortComboBox.SelectedItem.ToString());
        }
        public void Reload(string name)
        {
            List<SanPham> data;
            if (name == "") data = QLSPInstance.GetAllSP();
            else data = QLSPInstance.GetSPByName(name);
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(data))
            {
                table.Load(reader);
            }
            dataGridView1.DataSource=table;
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
    }
}
