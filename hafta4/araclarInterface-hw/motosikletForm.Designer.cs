namespace araclarInterface
{
    partial class motosikletForm
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
            this.ekleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seriNoTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yilTextBox = new System.Windows.Forms.TextBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(198, 255);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(138, 64);
            this.ekleButton.TabIndex = 0;
            this.ekleButton.Text = "EKLE";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(24, 255);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(138, 64);
            this.silButton.TabIndex = 1;
            this.silButton.Text = "SİL";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(342, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 279);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "seriNo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Yıl";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fiyat";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "seriNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yıl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat";
            // 
            // seriNoTextBox
            // 
            this.seriNoTextBox.Location = new System.Drawing.Point(77, 33);
            this.seriNoTextBox.Name = "seriNoTextBox";
            this.seriNoTextBox.Size = new System.Drawing.Size(197, 20);
            this.seriNoTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(77, 90);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(197, 20);
            this.modelTextBox.TabIndex = 8;
            // 
            // yilTextBox
            // 
            this.yilTextBox.Location = new System.Drawing.Point(77, 153);
            this.yilTextBox.Name = "yilTextBox";
            this.yilTextBox.Size = new System.Drawing.Size(197, 20);
            this.yilTextBox.TabIndex = 9;
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.Location = new System.Drawing.Point(77, 207);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(197, 20);
            this.fiyatTextBox.TabIndex = 10;
            // 
            // motosikletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(this.yilTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.seriNoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Name = "motosikletForm";
            this.Text = "motosikletForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox seriNoTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yilTextBox;
        private System.Windows.Forms.TextBox fiyatTextBox;
    }
}