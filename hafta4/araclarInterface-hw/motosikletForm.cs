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
    public partial class motosikletForm : Form
    {
        public motosikletForm()
        {
            InitializeComponent();
        }

        motosiklesManager mngr = new motosiklesManager();

        private void ekleButton_Click(object sender, EventArgs e)
        {
            motosiklet arac = new motosiklet();
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
                dataGridView1.Rows.Add(item.seriNo, item.marka, item.modelYili, item.fiyat);
            }
        }

        void Temizle()
        {
            seriNoTextBox.Clear();
            fiyatTextBox.Clear();
            modelTextBox.Clear();
            yilTextBox.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSeriNo = e.RowIndex;
            seriNoTextBox.Text = dataGridView1.Rows[secilenSeriNo].Cells[0].Value.ToString();
            modelTextBox.Text = dataGridView1.Rows[secilenSeriNo].Cells[1].Value.ToString();
            yilTextBox.Text = dataGridView1.Rows[secilenSeriNo].Cells[2].Value.ToString();
            fiyatTextBox.Text = dataGridView1.Rows[secilenSeriNo].Cells[3].Value.ToString();
        }

        private void silButton_Click(object sender, EventArgs e)
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
