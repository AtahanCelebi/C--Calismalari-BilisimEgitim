using ClassKavramlar.Managers;
using ClassKavramlar.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassKavramlar
{
    public partial class FormKategori : Form
    {
        int? Id;
        string fileName;
      
        public FormKategori()
        {
            InitializeComponent();
        }

        CategoryManager mngr = new CategoryManager();
        private void button4_Click(object sender, EventArgs e)
        {
            // Yeni
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            // Kategori Id verebilmek için
            // Ternary(?)
            Id = mngr.GetAll().Count > 0 ? mngr.GetAll().Max(o => o.catId) : 0; //kategorilerin içindeki en büyük kategori Id getir
            if (Id > 0)
                Id++;
            else
                Id = 1;
          

            txtCatId.Text = Id.ToString();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //  Dosya seçmek iin bir pencere
            ofd.ShowDialog();
            fileName = ofd.FileName;
            pictureBox1.ImageLocation = fileName;

        }

        void List()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in mngr.GetAll())
            {
                dataGridView1.Rows.Add(item.catId,item.catName,Image.FromFile(item.catImage));
            }
        }
        void Clear()
        {
            txtCatId.Clear();
            txtCatName.Clear();
            pictureBox1.Image = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            category cat = new category();

            cat.catId = Int32.Parse(txtCatId.Text);
            cat.catImage = fileName;
            cat.catName = txtCatName.Text;
            
            mngr.Add(cat);  // Kayıt ekle
            List();            // Kayıt Listele
            Clear();            // Alanları Temizle
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; // sectiğiniz satrın index no veriyor.
            txtCatId.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtCatName.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            pictureBox1.Image= (Image)dataGridView1.Rows[row].Cells[2].Value;
            //fileName=pictureBox1.Image.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCatId.Text))
            {
                mngr.Remove(Int32.Parse(txtCatId.Text));
                List();
                Clear();
            }
        }
    }
}
