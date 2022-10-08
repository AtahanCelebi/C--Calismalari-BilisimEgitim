namespace WindowsFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridMarka = new System.Windows.Forms.DataGridView();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.txtMarkaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.btnModelEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.txtModelNo = new System.Windows.Forms.TextBox();
            this.txtModelAdi = new System.Windows.Forms.TextBox();
            this.dataGridModel = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbModelMarkalar = new System.Windows.Forms.ComboBox();
            this.cmbArabaMarkalar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnArabaEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.dataGridAraba = new System.Windows.Forms.DataGridView();
            this.cmbArabaModeller = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArabaAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbModelYili = new System.Windows.Forms.ComboBox();
            this.cmbCekis = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAraba)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Controls.Add(this.btnMarkaEkle);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMarkaNo);
            this.tabPage1.Controls.Add(this.txtMarkaAdi);
            this.tabPage1.Controls.Add(this.dataGridMarka);
            this.tabPage1.ForeColor = System.Drawing.Color.DimGray;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marka İşleri";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tabPage2.Controls.Add(this.cmbModelMarkalar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnModelEkle);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.s);
            this.tabPage2.Controls.Add(this.txtModelNo);
            this.tabPage2.Controls.Add(this.txtModelAdi);
            this.tabPage2.Controls.Add(this.dataGridModel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modelİşlevi";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Plum;
            this.tabPage3.Controls.Add(this.cmbYakit);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cmbCekis);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cmbModelYili);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtArabaAdi);
            this.tabPage3.Controls.Add(this.cmbArabaModeller);
            this.tabPage3.Controls.Add(this.cmbArabaMarkalar);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnArabaEkle);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtPlaka);
            this.tabPage3.Controls.Add(this.dataGridAraba);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Araba İşlevi";
            // 
            // dataGridMarka
            // 
            this.dataGridMarka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMarka.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridMarka.Location = new System.Drawing.Point(3, 264);
            this.dataGridMarka.Name = "dataGridMarka";
            this.dataGridMarka.Size = new System.Drawing.Size(786, 150);
            this.dataGridMarka.TabIndex = 0;
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(115, 84);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Size = new System.Drawing.Size(100, 26);
            this.txtMarkaAdi.TabIndex = 1;
            // 
            // txtMarkaNo
            // 
            this.txtMarkaNo.Location = new System.Drawing.Point(115, 40);
            this.txtMarkaNo.Name = "txtMarkaNo";
            this.txtMarkaNo.Size = new System.Drawing.Size(100, 26);
            this.txtMarkaNo.TabIndex = 2;
            this.txtMarkaNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marka Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marko NO";
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.ForeColor = System.Drawing.Color.Black;
            this.btnMarkaEkle.Location = new System.Drawing.Point(235, 40);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(100, 70);
            this.btnMarkaEkle.TabIndex = 5;
            this.btnMarkaEkle.Text = "KAYDET";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // btnModelEkle
            // 
            this.btnModelEkle.ForeColor = System.Drawing.Color.Black;
            this.btnModelEkle.Location = new System.Drawing.Point(268, 65);
            this.btnModelEkle.Name = "btnModelEkle";
            this.btnModelEkle.Size = new System.Drawing.Size(100, 70);
            this.btnModelEkle.TabIndex = 11;
            this.btnModelEkle.Text = "KAYDET";
            this.btnModelEkle.UseVisualStyleBackColor = true;
            this.btnModelEkle.Click += new System.EventHandler(this.btnModelEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Model No";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.ForeColor = System.Drawing.Color.Black;
            this.s.Location = new System.Drawing.Point(20, 72);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(88, 20);
            this.s.TabIndex = 9;
            this.s.Text = "Model Adı";
            // 
            // txtModelNo
            // 
            this.txtModelNo.Location = new System.Drawing.Point(115, 22);
            this.txtModelNo.Name = "txtModelNo";
            this.txtModelNo.Size = new System.Drawing.Size(121, 26);
            this.txtModelNo.TabIndex = 8;
            // 
            // txtModelAdi
            // 
            this.txtModelAdi.Location = new System.Drawing.Point(115, 66);
            this.txtModelAdi.Name = "txtModelAdi";
            this.txtModelAdi.Size = new System.Drawing.Size(121, 26);
            this.txtModelAdi.TabIndex = 7;
            // 
            // dataGridModel
            // 
            this.dataGridModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridModel.Location = new System.Drawing.Point(3, 264);
            this.dataGridModel.Name = "dataGridModel";
            this.dataGridModel.Size = new System.Drawing.Size(786, 150);
            this.dataGridModel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Markalar";
            // 
            // cmbModelMarkalar
            // 
            this.cmbModelMarkalar.FormattingEnabled = true;
            this.cmbModelMarkalar.Location = new System.Drawing.Point(115, 107);
            this.cmbModelMarkalar.Name = "cmbModelMarkalar";
            this.cmbModelMarkalar.Size = new System.Drawing.Size(121, 28);
            this.cmbModelMarkalar.TabIndex = 13;
            // 
            // cmbArabaMarkalar
            // 
            this.cmbArabaMarkalar.FormattingEnabled = true;
            this.cmbArabaMarkalar.Location = new System.Drawing.Point(115, 125);
            this.cmbArabaMarkalar.Name = "cmbArabaMarkalar";
            this.cmbArabaMarkalar.Size = new System.Drawing.Size(121, 28);
            this.cmbArabaMarkalar.TabIndex = 21;
            this.cmbArabaMarkalar.SelectedIndexChanged += new System.EventHandler(this.cmbArabaMarkalar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Markalar";
            // 
            // btnArabaEkle
            // 
            this.btnArabaEkle.ForeColor = System.Drawing.Color.Black;
            this.btnArabaEkle.Location = new System.Drawing.Point(426, 181);
            this.btnArabaEkle.Name = "btnArabaEkle";
            this.btnArabaEkle.Size = new System.Drawing.Size(100, 45);
            this.btnArabaEkle.TabIndex = 19;
            this.btnArabaEkle.Text = "KAYDET";
            this.btnArabaEkle.UseVisualStyleBackColor = true;
            this.btnArabaEkle.Click += new System.EventHandler(this.btnArabaEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Araba Plaka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Modeller";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(115, 13);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(121, 26);
            this.txtPlaka.TabIndex = 16;
            // 
            // dataGridAraba
            // 
            this.dataGridAraba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAraba.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridAraba.Location = new System.Drawing.Point(3, 264);
            this.dataGridAraba.Name = "dataGridAraba";
            this.dataGridAraba.Size = new System.Drawing.Size(786, 150);
            this.dataGridAraba.TabIndex = 14;
            // 
            // cmbArabaModeller
            // 
            this.cmbArabaModeller.FormattingEnabled = true;
            this.cmbArabaModeller.Location = new System.Drawing.Point(115, 181);
            this.cmbArabaModeller.Name = "cmbArabaModeller";
            this.cmbArabaModeller.Size = new System.Drawing.Size(121, 28);
            this.cmbArabaModeller.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Araba Adı";
            // 
            // txtArabaAdi
            // 
            this.txtArabaAdi.Location = new System.Drawing.Point(115, 56);
            this.txtArabaAdi.Name = "txtArabaAdi";
            this.txtArabaAdi.Size = new System.Drawing.Size(121, 26);
            this.txtArabaAdi.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(313, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Model Yılı";
            // 
            // cmbModelYili
            // 
            this.cmbModelYili.FormattingEnabled = true;
            this.cmbModelYili.Location = new System.Drawing.Point(405, 11);
            this.cmbModelYili.Name = "cmbModelYili";
            this.cmbModelYili.Size = new System.Drawing.Size(121, 28);
            this.cmbModelYili.TabIndex = 27;
            // 
            // cmbCekis
            // 
            this.cmbCekis.FormattingEnabled = true;
            this.cmbCekis.Location = new System.Drawing.Point(405, 62);
            this.cmbCekis.Name = "cmbCekis";
            this.cmbCekis.Size = new System.Drawing.Size(121, 28);
            this.cmbCekis.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(313, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Çekiş";
            // 
            // cmbYakit
            // 
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Location = new System.Drawing.Point(405, 125);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(121, 28);
            this.cmbYakit.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(313, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Yakıt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAraba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarkaNo;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.DataGridView dataGridMarka;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.Button btnModelEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.TextBox txtModelNo;
        private System.Windows.Forms.TextBox txtModelAdi;
        private System.Windows.Forms.DataGridView dataGridModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbModelMarkalar;
        private System.Windows.Forms.ComboBox cmbArabaMarkalar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnArabaEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.DataGridView dataGridAraba;
        private System.Windows.Forms.ComboBox cmbArabaModeller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArabaAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbModelYili;
        private System.Windows.Forms.ComboBox cmbCekis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.Label label11;
    }
}

