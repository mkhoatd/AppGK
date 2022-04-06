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
        string MSSP;
        public delegate void MyDel(string Name);
        public MyDel d;
        public Form2(string m="")
        {
            InitializeComponent();
            MSSP = m;
            if (MSSP != null)
            {
                MaSanPhamTextBox.Enabled = false;

            }
        }

    }
}
