using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bakiye = 0;
        int gunlukMiktar = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            if (checkInteger(txtTutar.Text))
            {
                if (Int32.Parse(txtTutar.Text) > 0)
                {
                    bakiye = Int32.Parse(txtBakiye.Text) + Int32.Parse(txtTutar.Text);
                    gunlukMiktar += Int32.Parse(txtTutar.Text);
                    txtBakiye.Text = bakiye.ToString();
                    dataGridBakiye.Rows.Add("Para Yatırıldı", txtTutar.Text + "TL", bakiye + "TL", DateTime.Now);
                    txtTutar.Text = "";
                }
                else
                {
                    MessageBox.Show("Negatif Değer Giremezsiniz", "Geçersiz İşlem", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz değer integer olmalı", "Yanlış Değer Girdiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            if (checkInteger(txtTutar.Text))
            {
                if (bakiye > 0 && Int32.Parse(txtTutar.Text) <= bakiye)
                {
                    if (Int32.Parse(txtLimit.Text) > 0)
                    {
                        txtLimit.Text = (Int32.Parse(txtLimit.Text) - Int32.Parse(txtTutar.Text)).ToString();

                        bakiye = Int32.Parse(txtBakiye.Text) - Int32.Parse(txtTutar.Text);
                        txtBakiye.Text = bakiye.ToString();
                        dataGridBakiye.Rows.Add("Para Çekildi", txtTutar.Text + "TL", bakiye + "TL", DateTime.Now);
                        txtTutar.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("limit yetersiz", "Geçersiz İşlem", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                    }


                }
                else
                {
                    MessageBox.Show("Bakiyeniz Yetersiz\nTekrar Deneyiniz!!!", "Geçersiz İşlem", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz değer integer olmalı","Yanlış Değer Girdiniz",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        bool checkInteger(string theValue)
        {
            return int.TryParse(theValue ,out int n);
        }
    }
}
