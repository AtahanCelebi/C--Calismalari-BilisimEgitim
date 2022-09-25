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
    public partial class teacherForm : Form
    {
        public teacherForm()
        {
            InitializeComponent();
        }

        ogretmenManager mngr = new ogretmenManager();

        private void ekleButton_Click(object sender, EventArgs e)
        {
            Ogretmen ogr = new Ogretmen();
            ogr.adi = textName.Text;
            ogr.soyadi = txtSurname.Text;
            ogr.yas = Int32.Parse(txtAge.Text);
            ogr.personId = Int32.Parse(textId.Text);
            mngr.Ekleme(ogr);
            List();

        }

        void List()
        {
            teacherGrid.Rows.Clear();
            foreach (var item in mngr.Listele())
            {
                teacherGrid.Rows.Add(item.personId, item.adi, item.soyadi, item.yas);
            }
        }

        void temizle()
        {
            txtAge.Clear();
            textId.Clear();
            txtSurname.Clear();
            textName.Clear();
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

        private void teacherGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid üzerinde seçilen textleri aktarmak

            int secilenSatırNo = e.RowIndex;
            textId.Text = teacherGrid.Rows[secilenSatırNo].Cells[0].Value.ToString();
            textName.Text = teacherGrid.Rows[secilenSatırNo].Cells[1].Value.ToString();
            txtSurname.Text = teacherGrid.Rows[secilenSatırNo].Cells[2].Value.ToString();
            txtAge.Text = teacherGrid.Rows[secilenSatırNo].Cells[3].Value.ToString();
        }
    }
}
