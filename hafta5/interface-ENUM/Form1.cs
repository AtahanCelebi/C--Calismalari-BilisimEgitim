using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_ENUM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        UrunListManager urunListMngr = new UrunListManager();
        Guid yeniUrunKod;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun yeniUrun = new Urun();
            yeniUrun.urunKod = yeniUrunKod;
            yeniUrun.urunAdi = txtUrunAdi.Text;
            yeniUrun.fiyat = Convert.ToDecimal(txtUrunfiyat.Text);
            //(UrunDurumu) parantez içinde yazarak unboxing yaptık
            yeniUrun.durum = (UrunDurumu) Enum.Parse(typeof(UrunDurumu), comboUrunDurum.SelectedItem.ToString()); //Enum değerini
                                                                                                        //parse ettik ilk parametre
                                                                                                        //typeof girilcek, ikincisi değer

            urunListMngr.Ekle(yeniUrun);
            UrunList();

        }


        void UrunList()
        {
            dataGridUrunListesi.Rows.Clear();
            foreach (var item in urunListMngr.Liste())
            {
                if(comboUrunDurum.SelectedItem.ToString() == UrunDurumu.stoktaVar.ToString())
                dataGridUrunListesi.Rows.Add(item.urunKod, item.urunAdi, item.fiyat, item.durum.ToString());
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //ilk basta ürün durumlarını ilgili combobox'a yükle

            comboUrunDurum.DataSource = Enum.GetNames(typeof(UrunDurumu));
            comboSiparisDurum.DataSource = Enum.GetNames(typeof(SiparisDurumu));
        }

        private void dataGridUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = e.RowIndex;
            txtUrunKod.Text = dataGridUrunListesi.Rows[secilenSatir].Cells[0].Value.ToString();
            txtSiparisUrunKodu.Text = dataGridUrunListesi.Rows[secilenSatir].Cells[0].Value.ToString();
            txtUrunAdi.Text = dataGridUrunListesi.Rows[secilenSatir].Cells[1].Value.ToString();
            txtSiparisDurum.Text = dataGridUrunListesi.Rows[secilenSatir].Cells[1].Value.ToString();

            txtUrunfiyat.Text = dataGridUrunListesi.Rows[secilenSatir].Cells[2].Value.ToString();
            comboUrunDurum.SelectedItem = dataGridUrunListesi.Rows[secilenSatir].Cells[3].Value; 
        }

        private void btnYEni_Click(object sender, EventArgs e)
        {
            yeniUrunKod = Guid.NewGuid();
            txtUrunKod.Text = yeniUrunKod.ToString();
        }

        private void numericAdet_ValueChanged(object sender, EventArgs e)
        {
            decimal fiyat = urunListMngr.Liste().FirstOrDefault(x => x.urunKod.ToString() == txtSiparisKodu.Text.ToString()).fiyat;
            txtSiparisTutar.Text = (fiyat*numericAdet.Value).ToString();
            
            
            //txtSiparisTutar.Text = (urunListMngr.Liste().FirstOrDefault(x => x.urunKod.ToString() == txtSiparisKodu.Text).fiyat * numericAdet.Value).ToString();
        }


        #region Sepet

        List<Sepet> sepetListesi = new List<Sepet>();

        void sepeteEkle(Urun urun, int adet)
        {
            int yeniSepetId = sepetListesi.Count > 0 ? sepetListesi.Max(x => x.sepetId) : 0;

            if (yeniSepetId > 0)
            {
                yeniSepetId++;
            }
            else
            {
                yeniSepetId = 1;
            }

            Sepet yeniSepet = new Sepet()
            {
                sepetId = sepetteVarMi(urun) ? sepetListesi.FirstOrDefault(x => x.urun.urunKod == urun.urunKod).sepetId : yeniSepetId,
                urun = urun,
                adet = adet
            };

            sepetListesi.Add(yeniSepet);

        }


        bool sepetteVarMi(Urun urunSorgu)
        {  //sepetin içindeki ürün kodu daha önce mevcutsa onu bulmalı
            return sepetListesi.Exists(x => x.urun.urunKod == urunSorgu.urunKod);
        }


        void sepetiTemizle()
        {
            sepetListesi.Clear();
        }


        #endregion
        SiparisListManager siparisListmngr = new SiparisListManager();
        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            List<Urun> sepettekiUrunList = new List<Urun>();
            sepetListesi.ForEach(x => { sepettekiUrunList.Add(x.urun); }) ;
            //yukardakiyle aynı işlemi yapıyor 
            //foreach (var item in sepetListesi)
            //{
            //    sepettekiUrunList.Add(item.urun);
            //}
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.urun = sepettekiUrunList;
            yeniSiparis.siparisKodu = Int32.Parse(txtSiparisKodu.Text);
            yeniSiparis.durum = SiparisDurumu.siparisAlindi;
            siparisListmngr.Ekle(yeniSiparis);
        }

        void SiparisList()
        {
            dataGridSiparisListesi.Rows.Clear();
            foreach (var item in siparisListmngr.Liste())
            {
                dataGridSiparisListesi.Rows.Add(item.siparisKodu,item.durum);
            }
        }

        private void dataGridSiparisListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliIndex = e.RowIndex;
            txtSiparisIzlemeKodu.Text = dataGridSiparisListesi.Rows[seciliIndex].Cells[0].Value.ToString();
            comboSiparisDurum.SelectedIndex = (int)(SiparisDurumu)dataGridSiparisListesi.Rows[seciliIndex].Cells[1].Value;
        }

        private void btnDegisikligiKaydet_Click(object sender, EventArgs e)
        {
            Siparis mevcutSiparis = siparisListmngr.Liste().FirstOrDefault(x => x.siparisKodu == Int32.Parse(txtSiparisKodu.Text));
            mevcutSiparis.durum = (SiparisDurumu)comboSiparisDurum.SelectedItem;
            SiparisList();
        }
    }
}
