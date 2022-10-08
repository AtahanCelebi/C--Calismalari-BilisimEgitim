using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        markaManager markaMngr = new markaManager();
        modelManager modelMngr = new modelManager();
        arabaManager arabaMngr = new arabaManager();


        //MARKA İŞLEV KISMI 1. TAB EKRANI

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMarkaNo.Text))
            {
                markaMngr.Ekle(new Marka() {markaNo=Int32.Parse(txtMarkaNo.Text),markaAdi=txtMarkaAdi.Text});
                MarkaList();
            }
        }

        void MarkaList()
        {
            dataGridMarka.DataSource = markaMngr.List();
        }


        //MODEL İŞLEV KISMI 2. TAB EKRANI

        private void Form1_Load(object sender, EventArgs e)
        {
            //itemler nerden datasource alıyor onu tanımla
            cmbModelMarkalar.DataSource = markaMngr.List();
            cmbModelMarkalar.ValueMember = "Marka no";  //combobax'da selectedvalue karşılığı --> 1,2,3 gibi
            cmbModelMarkalar.DisplayMember = "Marka adi"; //combobax'da selecteditem karşılığı --> inputa girilen değer

            cmbArabaMarkalar.DataSource = markaMngr.List();
            cmbArabaMarkalar.ValueMember = "Marka no";
            cmbArabaMarkalar.DisplayMember = "Marka adi";

            

            //model yılını ekle
            for (int i = 2022; i > 1990; i--)
            {
                cmbModelYili.Items.Add(i);
            }

            //enumslar'ı ekle - datasource göster

            cmbYakit.DataSource = Enum.GetNames(typeof(Yakit));
            cmbCekis.DataSource = Enum.GetNames(typeof(Cekis));

        }

        void modelList()
        {
            dataGridModel.DataSource = modelMngr.List();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtModelAdi.Text))
            {
                modelMngr.Ekle(new Model()
                { modelNo = Int32.Parse(txtModelNo.Text), modelAdi = txtModelAdi.Text,markaID=(int)cmbModelMarkalar.SelectedValue
                });
                modelList();
            }
        }
        //araba işlev kısmı 3. sekme

        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            arabaMngr.Ekle(new Araba()
            {
                plaka = txtPlaka.Text,
                modelID = (int)cmbArabaModeller.SelectedValue,
                markaID = (int)cmbArabaMarkalar.SelectedValue,
                modelYili = Int32.Parse(cmbModelYili.Text),
                cekisGucu = (Cekis)Enum.Parse(typeof(Cekis),cmbCekis.SelectedItem.ToString()),
                yakitTuru = (Yakit)Enum.Parse(typeof(Yakit),cmbYakit.SelectedItem.ToString()),
                arabaAdi = txtArabaAdi.Text
            }
                );
            ArabaList();
        }

        void ArabaList()
        {
            dataGridAraba.DataSource = arabaMngr.List();
        }

        private void cmbArabaMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbArabaModeller.DataSource = modelMngr.List();
            cmbArabaModeller.ValueMember = "Model No";
            cmbArabaModeller.DisplayMember = "Model Adı";
        }
    }
}
