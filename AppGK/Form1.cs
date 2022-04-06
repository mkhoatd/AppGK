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
            dataGridView1.DataSource = QLSPInstance.GetAllSP;
        }
    }
}
