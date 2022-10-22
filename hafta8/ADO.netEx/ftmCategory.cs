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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        categoryManager mngr = new categoryManager();
        void List()
        {
            dataGridView1.DataSource = mngr.GetAll();
        }
        private void frmCategory_Load(object sender, EventArgs e)
        {
            List();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category cat = new Category() { categoryName = txtCatName.Text };
            mngr.Add(cat);
            List();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtCatId.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtCatName.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCatId.Text))
            {

                DialogResult result = MessageBox.Show("Silme Penceresi", "Kayıt Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    mngr.Delete(Int32.Parse(txtCatId.Text));
                    List();
                }

            }
            
            
        }
    }
}
