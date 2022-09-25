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
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();
        }

        ogrenciManager mngr = new ogrenciManager();

        private void ekleButton_Click(object sender, EventArgs e)
        {
            Ogrenci std = new Ogrenci();
            std.personId = Int32.Parse(textId.Text);
            std.adi = textName.Text;
            std.soyadi = txtSurname.Text;
            std.yas = Int32.Parse(txtAge.Text);
            mngr.Ekleme(std);
            List();
            temizle();
        }

        void List()
        {
            dataGridView1.Rows.Clear();
            foreach(var item in mngr.Listele())
            {
                dataGridView1.Rows.Add(item.personId, item.adi, item.soyadi, item.yas);
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textId.Text))
            {
                mngr.Silme(Int32.Parse(textId.Text));
                List();
                temizle();
            }
        }

      

        

        void temizle()
        {
            txtAge.Clear();
            textId.Clear();
            txtSurname.Clear();
            textName.Clear();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //grid üzerinde seçilen textleri aktarmak

            int secilenSatırNo = e.RowIndex;
            textId.Text = dataGridView1.Rows[secilenSatırNo].Cells[0].Value.ToString();
            textName.Text = dataGridView1.Rows[secilenSatırNo].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[secilenSatırNo].Cells[2].Value.ToString();
            txtAge.Text = dataGridView1.Rows[secilenSatırNo].Cells[3].Value.ToString();
        }
    }
}
