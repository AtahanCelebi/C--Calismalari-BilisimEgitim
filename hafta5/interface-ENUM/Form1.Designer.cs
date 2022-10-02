namespace interface_ENUM
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunKod = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboUrunDurum = new System.Windows.Forms.ComboBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridUrunListesi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.dataGridSiparisListesi = new System.Windows.Forms.DataGridView();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.txtSiparisKodu = new System.Windows.Forms.TextBox();
            this.txtSiparisUrunKodu = new System.Windows.Forms.TextBox();
            this.txtSiparisDurum = new System.Windows.Forms.TextBox();
            this.numericAdet = new System.Windows.Forms.NumericUpDown();
            this.txtSiparisTutar = new System.Windows.Forms.TextBox();
            this.txtSiparisIzlemeKodu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboSiparisDurum = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDegisikligiKaydet = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnYEni = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparisListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.btnYEni);
            this.groupBox1.Controls.Add(this.dataGridUrunListesi);
            this.groupBox1.Controls.Add(this.btnUrunEkle);
            this.groupBox1.Controls.Add(this.comboUrunDurum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUrunfiyat);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.txtUrunKod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.txtSiparisTutar);
            this.groupBox2.Controls.Add(this.numericAdet);
            this.groupBox2.Controls.Add(this.txtSiparisDurum);
            this.groupBox2.Controls.Add(this.txtSiparisUrunKodu);
            this.groupBox2.Controls.Add(this.txtSiparisKodu);
            this.groupBox2.Controls.Add(this.btnSepeteEkle);
            this.groupBox2.Controls.Add(this.dataGridSiparisListesi);
            this.groupBox2.Controls.Add(this.btnSiparisTamamla);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(409, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SİPARİŞ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Fiyat";
            // 
            // txtUrunKod
            // 
            this.txtUrunKod.Enabled = false;
            this.txtUrunKod.Location = new System.Drawing.Point(93, 26);
            this.txtUrunKod.Name = "txtUrunKod";
            this.txtUrunKod.Size = new System.Drawing.Size(273, 20);
            this.txtUrunKod.TabIndex = 3;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(93, 67);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(137, 20);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // txtUrunfiyat
            // 
            this.txtUrunfiyat.Location = new System.Drawing.Point(93, 106);
            this.txtUrunfiyat.Name = "txtUrunfiyat";
            this.txtUrunfiyat.Size = new System.Drawing.Size(58, 20);
            this.txtUrunfiyat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Durumu";
            // 
            // comboUrunDurum
            // 
            this.comboUrunDurum.FormattingEnabled = true;
            this.comboUrunDurum.Location = new System.Drawing.Point(93, 146);
            this.comboUrunDurum.Name = "comboUrunDurum";
            this.comboUrunDurum.Size = new System.Drawing.Size(121, 21);
            this.comboUrunDurum.TabIndex = 7;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Green;
            this.btnUrunEkle.Location = new System.Drawing.Point(271, 211);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(67, 56);
            this.btnUrunEkle.TabIndex = 8;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Tan;
            this.groupBox3.Controls.Add(this.btnDegisikligiKaydet);
            this.groupBox3.Controls.Add(this.comboSiparisDurum);
            this.groupBox3.Controls.Add(this.txtSiparisIzlemeKodu);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(700, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 426);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SİPARİŞ İZLEME";
            // 
            // dataGridUrunListesi
            // 
            this.dataGridUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridUrunListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridUrunListesi.Location = new System.Drawing.Point(3, 273);
            this.dataGridUrunListesi.Name = "dataGridUrunListesi";
            this.dataGridUrunListesi.RowHeadersWidth = 5;
            this.dataGridUrunListesi.Size = new System.Drawing.Size(393, 150);
            this.dataGridUrunListesi.TabIndex = 9;
            this.dataGridUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUrunListesi_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sipariş Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ürün Kodu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ürün Adı";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Adet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tutar";
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSiparisTamamla.Location = new System.Drawing.Point(161, 211);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(67, 56);
            this.btnSiparisTamamla.TabIndex = 10;
            this.btnSiparisTamamla.Text = "Sipariş Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = false;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // dataGridSiparisListesi
            // 
            this.dataGridSiparisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSiparisListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column8});
            this.dataGridSiparisListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridSiparisListesi.Location = new System.Drawing.Point(3, 273);
            this.dataGridSiparisListesi.Name = "dataGridSiparisListesi";
            this.dataGridSiparisListesi.Size = new System.Drawing.Size(293, 150);
            this.dataGridSiparisListesi.TabIndex = 15;
            this.dataGridSiparisListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSiparisListesi_CellClick);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.Gold;
            this.btnSepeteEkle.Location = new System.Drawing.Point(88, 211);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(67, 56);
            this.btnSepeteEkle.TabIndex = 16;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            // 
            // txtSiparisKodu
            // 
            this.txtSiparisKodu.Location = new System.Drawing.Point(91, 21);
            this.txtSiparisKodu.Name = "txtSiparisKodu";
            this.txtSiparisKodu.Size = new System.Drawing.Size(121, 20);
            this.txtSiparisKodu.TabIndex = 17;
            // 
            // txtSiparisUrunKodu
            // 
            this.txtSiparisUrunKodu.Location = new System.Drawing.Point(91, 60);
            this.txtSiparisUrunKodu.Name = "txtSiparisUrunKodu";
            this.txtSiparisUrunKodu.Size = new System.Drawing.Size(194, 20);
            this.txtSiparisUrunKodu.TabIndex = 18;
            // 
            // txtSiparisDurum
            // 
            this.txtSiparisDurum.Location = new System.Drawing.Point(91, 106);
            this.txtSiparisDurum.Name = "txtSiparisDurum";
            this.txtSiparisDurum.Size = new System.Drawing.Size(121, 20);
            this.txtSiparisDurum.TabIndex = 19;
            // 
            // numericAdet
            // 
            this.numericAdet.Location = new System.Drawing.Point(91, 141);
            this.numericAdet.Name = "numericAdet";
            this.numericAdet.Size = new System.Drawing.Size(54, 20);
            this.numericAdet.TabIndex = 20;
            this.numericAdet.ValueChanged += new System.EventHandler(this.numericAdet_ValueChanged);
            // 
            // txtSiparisTutar
            // 
            this.txtSiparisTutar.Enabled = false;
            this.txtSiparisTutar.Location = new System.Drawing.Point(88, 180);
            this.txtSiparisTutar.Name = "txtSiparisTutar";
            this.txtSiparisTutar.Size = new System.Drawing.Size(67, 20);
            this.txtSiparisTutar.TabIndex = 21;
            // 
            // txtSiparisIzlemeKodu
            // 
            this.txtSiparisIzlemeKodu.Location = new System.Drawing.Point(100, 19);
            this.txtSiparisIzlemeKodu.Name = "txtSiparisIzlemeKodu";
            this.txtSiparisIzlemeKodu.Size = new System.Drawing.Size(107, 20);
            this.txtSiparisIzlemeKodu.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sipariş Kodu";
            // 
            // comboSiparisDurum
            // 
            this.comboSiparisDurum.FormattingEnabled = true;
            this.comboSiparisDurum.Location = new System.Drawing.Point(100, 56);
            this.comboSiparisDurum.Name = "comboSiparisDurum";
            this.comboSiparisDurum.Size = new System.Drawing.Size(107, 21);
            this.comboSiparisDurum.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sipariş Durumu";
            // 
            // btnDegisikligiKaydet
            // 
            this.btnDegisikligiKaydet.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDegisikligiKaydet.Location = new System.Drawing.Point(112, 95);
            this.btnDegisikligiKaydet.Name = "btnDegisikligiKaydet";
            this.btnDegisikligiKaydet.Size = new System.Drawing.Size(95, 39);
            this.btnDegisikligiKaydet.TabIndex = 22;
            this.btnDegisikligiKaydet.Text = "Değişikliği Kaydet";
            this.btnDegisikligiKaydet.UseVisualStyleBackColor = false;
            this.btnDegisikligiKaydet.Click += new System.EventHandler(this.btnDegisikligiKaydet_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ürün Kodu";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fiyat";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Durum";
            this.Column4.Name = "Column4";
            // 
            // btnYEni
            // 
            this.btnYEni.BackColor = System.Drawing.Color.Green;
            this.btnYEni.Location = new System.Drawing.Point(198, 212);
            this.btnYEni.Name = "btnYEni";
            this.btnYEni.Size = new System.Drawing.Size(67, 56);
            this.btnYEni.TabIndex = 10;
            this.btnYEni.Text = "Yeni";
            this.btnYEni.UseVisualStyleBackColor = false;
            this.btnYEni.Click += new System.EventHandler(this.btnYEni_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SiparisKod";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "durum";
            this.Column8.Name = "Column8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparisListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ComboBox comboUrunDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunfiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrunKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridUrunListesi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.DataGridView dataGridSiparisListesi;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.NumericUpDown numericAdet;
        private System.Windows.Forms.TextBox txtSiparisDurum;
        private System.Windows.Forms.TextBox txtSiparisUrunKodu;
        private System.Windows.Forms.TextBox txtSiparisKodu;
        private System.Windows.Forms.TextBox txtSiparisTutar;
        private System.Windows.Forms.ComboBox comboSiparisDurum;
        private System.Windows.Forms.TextBox txtSiparisIzlemeKodu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDegisikligiKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnYEni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

