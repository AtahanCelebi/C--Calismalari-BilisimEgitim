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
    public partial class FormProduct : Form
    {
        int Id;
        public FormProduct()
        {
            InitializeComponent();
        }
        ProductManager mngr = new ProductManager();
      
        private void btnNew_Click(object sender, EventArgs e)
        {
            Id = mngr.GetAll().Count > 0 ? mngr.GetAll().Max(o => o.productId) : 0;
            if (Id > 0)
                Id++;
            else
                Id = 1;

            btnAdd.Enabled = true;
            btnRemove.Enabled = true;

            txtProductId.Text = Id.ToString();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            pictureBox1.ImageLocation = ofd.FileName;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        void Clear()
        {
            txtPrice.Clear();
            txtProductId.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            cmbCategory.Text = "";
            pictureBox1.Image = null;

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // form ilk açıldığında comboBox 'a tüm kategorileri  doldur
            cmbCategory.DataSource = CategoryManager.GetAllCategory();
            cmbCategory.DisplayMember = "catName";   // combobox' ta görünecek Alan için kategori adı
            cmbCategory.ValueMember = "catId";       // combobox' ta Id değeri için kategori No
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            product prd = new product()
            {
                productId = Int32.Parse(txtProductId.Text),
                productName = txtProductName.Text,
                Price = decimal.Parse(txtPrice.Text),
                stockQuantity = Int32.Parse(txtQuantity.Text),
                productImage = pictureBox1.ImageLocation,
                categoryId = (int)cmbCategory.SelectedValue
            };
            mngr.Add(prd);
            List();
            Clear();
        }

        void List()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in mngr.GetAll())
            {
                dataGridView1.Rows.Add(item.productId,item.productName,item.categoryId,item.Price,item.stockQuantity,Image.FromFile(item.productImage));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtProductId.Text           = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtProductName.Text         = dataGridView1.Rows[row].Cells[1].Value.ToString();
            cmbCategory.SelectedValue   = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text               = dataGridView1.Rows[row].Cells[3].Value.ToString();
            txtQuantity.Text            = dataGridView1.Rows[row].Cells[4].Value.ToString();
            pictureBox1.Image           =(Image) dataGridView1.Rows[row].Cells[5].Value;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductId.Text))
            {
                mngr.Remove(Int32.Parse(txtProductId.Text));
                List();
                Clear();
            }
        }
    }
}
