namespace ADO.netEx
{
    partial class brandForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.asd2 = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtBrandId = new System.Windows.Forms.TextBox();
            this.btnBrandEkle = new System.Windows.Forms.Button();
            this.dataGridBrand = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // asd2
            // 
            this.asd2.AutoSize = true;
            this.asd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asd2.Location = new System.Drawing.Point(59, 50);
            this.asd2.Name = "asd2";
            this.asd2.Size = new System.Drawing.Size(77, 20);
            this.asd2.TabIndex = 8;
            this.asd2.Text = "brand Adı";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asd.Location = new System.Drawing.Point(59, 13);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(74, 20);
            this.asd.TabIndex = 9;
            this.asd.Text = "brand No";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrandName.Location = new System.Drawing.Point(180, 47);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(100, 26);
            this.txtBrandName.TabIndex = 6;
            // 
            // txtBrandId
            // 
            this.txtBrandId.Enabled = false;
            this.txtBrandId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrandId.HideSelection = false;
            this.txtBrandId.Location = new System.Drawing.Point(180, 13);
            this.txtBrandId.Name = "txtBrandId";
            this.txtBrandId.Size = new System.Drawing.Size(100, 26);
            this.txtBrandId.TabIndex = 7;
            // 
            // btnBrandEkle
            // 
            this.btnBrandEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrandEkle.Location = new System.Drawing.Point(286, 16);
            this.btnBrandEkle.Name = "btnBrandEkle";
            this.btnBrandEkle.Size = new System.Drawing.Size(80, 57);
            this.btnBrandEkle.TabIndex = 5;
            this.btnBrandEkle.Text = "Ekle";
            this.btnBrandEkle.UseVisualStyleBackColor = true;
            this.btnBrandEkle.Click += new System.EventHandler(this.btnBrandEkle_Click);
            // 
            // dataGridBrand
            // 
            this.dataGridBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBrand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridBrand.Location = new System.Drawing.Point(0, 132);
            this.dataGridBrand.Name = "dataGridBrand";
            this.dataGridBrand.Size = new System.Drawing.Size(800, 318);
            this.dataGridBrand.TabIndex = 4;
            this.dataGridBrand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBrand_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(286, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 38);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // brandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.asd2);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtBrandId);
            this.Controls.Add(this.btnBrandEkle);
            this.Controls.Add(this.dataGridBrand);
            this.Name = "brandForm";
            this.Text = "brandForm";
            this.Load += new System.EventHandler(this.brandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asd2;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.TextBox txtBrandId;
        private System.Windows.Forms.Button btnBrandEkle;
        private System.Windows.Forms.DataGridView dataGridBrand;
        private System.Windows.Forms.Button btnDelete;
    }
}