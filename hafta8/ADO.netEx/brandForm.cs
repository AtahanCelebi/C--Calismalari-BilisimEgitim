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
    public partial class brandForm : Form
    {
        public brandForm()
        {
            InitializeComponent();
        }
        branManager mngr = new branManager();
        private void btnBrandEkle_Click(object sender, EventArgs e)
        {
            Brand brnd = new Brand() { brandName = txtBrandName.Text };
            mngr.Add(brnd);
            List();
        }

        void List()
        {
            dataGridBrand.DataSource = mngr.GetAll();
        }

        private void dataGridBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtBrandId.Text = dataGridBrand.Rows[row].Cells[0].Value.ToString();
            txtBrandName.Text = dataGridBrand.Rows[row].Cells[1].Value.ToString();
        }

        private void brandForm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBrandId.Text))
            {
                
                DialogResult result = MessageBox.Show("Brand Silme", "seçiminiz silinsin mi?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    mngr.Delete(Int32.Parse(txtBrandId.Text));
                    List();
                }
            }
        }
    }
}
