namespace formUygulama
{
    partial class teacherForm
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
            this.teacherGrid = new System.Windows.Forms.DataGridView();
            this.silButton = new System.Windows.Forms.Button();
            this.ekleButton = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherGrid
            // 
            this.teacherGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.teacherGrid.Location = new System.Drawing.Point(278, 44);
            this.teacherGrid.Name = "teacherGrid";
            this.teacherGrid.Size = new System.Drawing.Size(476, 169);
            this.teacherGrid.TabIndex = 21;
            this.teacherGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherGrid_CellClick);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(57, 190);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(75, 23);
            this.silButton.TabIndex = 20;
            this.silButton.Text = "SİL";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(138, 190);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(75, 23);
            this.ekleButton.TabIndex = 19;
            this.ekleButton.Text = "EKLE";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(114, 137);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "yaş";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(114, 102);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 16;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(114, 73);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ad";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(114, 44);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "personNo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "TEACHER FORM";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "surname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "age";
            this.Column4.Name = "Column4";
            // 
            // teacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teacherGrid);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Name = "teacherForm";
            this.Text = "teacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.teacherGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView teacherGrid;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}