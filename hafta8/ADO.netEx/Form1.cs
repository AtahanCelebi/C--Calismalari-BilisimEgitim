using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.netEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brandForm brand = new brandForm();
            brand.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productForm prd = new productForm();
            prd.Show();
        }
    }
}
