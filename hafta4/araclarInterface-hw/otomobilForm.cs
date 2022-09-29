using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araclarInterface
{
    public partial class otomobilForm : Form
    {
        public otomobilForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        otomobilManager mngr = new otomobilManager();

        private void button1_Click(object sender, EventArgs e)
        {
            otomobil arac = new otomobil();
            arac.seriNo = Int32.Parse(seriNoTextBox.Text);
            arac.fiyat = Int32.Parse(fiyatTextBox.Text);
            arac.modelYili = Int32.Parse(yilTextBox.Text);
            arac.marka = modelTextBox.Text;

            mngr.Ekle(arac);
            List();
            Temizle();

        }

        void List()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in mngr.Listele())
            {
                dataGridView1.Rows.Add(item.marka,item.modelYili,item.seriNo,item.fiyat);

            }
        }

        void Temizle()
        {
            seriNoTextBox.Clear();
            modelTextBox.Clear();
            yilTextBox.Clear();
            fiyatTextBox.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenNo = e.RowIndex;
            seriNoTextBox.Text = dataGridView1.Rows[secilenNo].Cells[0].Value.ToString();
            fiyatTextBox.Text = dataGridView1.Rows[secilenNo].Cells[1].Value.ToString();
            modelTextBox.Text = dataGridView1.Rows[secilenNo].Cells[2].Value.ToString();
            yilTextBox.Text = dataGridView1.Rows[secilenNo].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(seriNoTextBox.Text))
            {
                mngr.Sil(Int32.Parse(seriNoTextBox.Text));
                List();
                Temizle();
            }
        }
    }
}
