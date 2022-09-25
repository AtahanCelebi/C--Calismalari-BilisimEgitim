using personCalisma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            studentForm frm = new studentForm(); //studentForm'u tanımla
            frm.Show();               //buton tıklandığında git

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherForm frm = new teacherForm();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
