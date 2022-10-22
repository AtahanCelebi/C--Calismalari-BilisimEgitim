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
    public partial class productForm : Form
    {
        public productForm()
        {
            InitializeComponent();
        }

        productManager productManager = new productManager();
        categoryManager categoryManager = new categoryManager();
        branManager brandManager = new branManager();

        private void productForm_Load(object sender, EventArgs e)
        {
            listBrand.DataSource = brandManager.GetAll();
            listBrand.DisplayMember = "brandName";
            listBrand.ValueMember = "brandId";

            listCategory.DataSource = categoryManager.GetAll();
            listCategory.DisplayMember = "categoryName";
            listCategory.ValueMember = "categoryId";

            List();

            ////alternatif
            //cmbCategory.DataSource = categoryManager.GetAll();
            //listCategory.DisplayMember = "categoryName";
            //listCategory.ValueMember = "categoryId";
        }

        void List()
        {
            dataGridProduct.DataSource = productManager.GetAll();
        }

        private void btnproductEkle_Click(object sender, EventArgs e)
        {
            Product model = new Product();
            model.productName = txtProductName.Text;
            model.brandId = (int)listBrand.SelectedValue;
            model.categoryId = (int)listCategory.SelectedValue;

            productManager.Add(model);
            List();
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtProductNo.Text = dataGridProduct.Rows[row].Cells[0].Value.ToString();
            txtProductName.Text = dataGridProduct.Rows[row].Cells[1].Value.ToString();

            // cat id productDataGrid'de 3. index'de
            int? brandIdgrid = (int?)dataGridProduct.Rows[row].Cells[3].Value; //? int null'da olabilir demek
            listBrand.SelectedValue = brandIdgrid??1;

            // cat id productDataGrid'de 2. index'de
            int catIdgrid = (int)dataGridProduct.Rows[row].Cells[2].Value;
            listBrand.SelectedValue = catIdgrid;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductNo.Text))
            {

                DialogResult result = MessageBox.Show("Product Silme", "seçiminiz silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    productManager.Delete(Int32.Parse(txtProductNo.Text));
                    List();
                }
            }
        }
    }
}
