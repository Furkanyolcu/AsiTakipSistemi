namespace AsiTakip
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.txtAsiAdi = new System.Windows.Forms.TextBox();
			this.lblAsiAdi = new System.Windows.Forms.Label();
			this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
			this.lblRandevuTarihi = new System.Windows.Forms.Label();
			this.dtpAsiSaati = new System.Windows.Forms.DateTimePicker();
			this.lblAsiSaati = new System.Windows.Forms.Label();
			this.txtDoz = new System.Windows.Forms.TextBox();
			this.lblDoz = new System.Windows.Forms.Label();
			this.btnRandevuEkle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtHastaAdi = new System.Windows.Forms.TextBox();
			this.lblHastaAdi = new System.Windows.Forms.Label();
			this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
			this.lblHastaSoyadi = new System.Windows.Forms.Label();
			this.comboBoxPersonel = new System.Windows.Forms.ComboBox();
			this.lblPersonel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAsiAdi
			// 
			this.txtAsiAdi.Location = new System.Drawing.Point(12, 25);
			this.txtAsiAdi.Name = "txtAsiAdi";
			this.txtAsiAdi.Size = new System.Drawing.Size(200, 22);
			this.txtAsiAdi.TabIndex = 0;
			// 
			// lblAsiAdi
			// 
			this.lblAsiAdi.AutoSize = true;
			this.lblAsiAdi.Location = new System.Drawing.Point(12, 9);
			this.lblAsiAdi.Name = "lblAsiAdi";
			this.lblAsiAdi.Size = new System.Drawing.Size(49, 16);
			this.lblAsiAdi.TabIndex = 1;
			this.lblAsiAdi.Text = "Aşı Adı";
			// 
			// dtpRandevuTarihi
			// 
			this.dtpRandevuTarihi.Location = new System.Drawing.Point(12, 64);
			this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
			this.dtpRandevuTarihi.Size = new System.Drawing.Size(200, 22);
			this.dtpRandevuTarihi.TabIndex = 2;
			// 
			// lblRandevuTarihi
			// 
			this.lblRandevuTarihi.AutoSize = true;
			this.lblRandevuTarihi.Location = new System.Drawing.Point(12, 48);
			this.lblRandevuTarihi.Name = "lblRandevuTarihi";
			this.lblRandevuTarihi.Size = new System.Drawing.Size(99, 16);
			this.lblRandevuTarihi.TabIndex = 3;
			this.lblRandevuTarihi.Text = "Randevu Tarihi";
			// 
			// dtpAsiSaati
			// 
			this.dtpAsiSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpAsiSaati.Location = new System.Drawing.Point(12, 103);
			this.dtpAsiSaati.Name = "dtpAsiSaati";
			this.dtpAsiSaati.ShowUpDown = true;
			this.dtpAsiSaati.Size = new System.Drawing.Size(200, 22);
			this.dtpAsiSaati.TabIndex = 4;
			// 
			// lblAsiSaati
			// 
			this.lblAsiSaati.AutoSize = true;
			this.lblAsiSaati.Location = new System.Drawing.Point(12, 87);
			this.lblAsiSaati.Name = "lblAsiSaati";
			this.lblAsiSaati.Size = new System.Drawing.Size(60, 16);
			this.lblAsiSaati.TabIndex = 5;
			this.lblAsiSaati.Text = "Aşı Saati";
			// 
			// txtDoz
			// 
			this.txtDoz.Location = new System.Drawing.Point(12, 142);
			this.txtDoz.Name = "txtDoz";
			this.txtDoz.Size = new System.Drawing.Size(200, 22);
			this.txtDoz.TabIndex = 6;
			// 
			// lblDoz
			// 
			this.lblDoz.AutoSize = true;
			this.lblDoz.Location = new System.Drawing.Point(12, 126);
			this.lblDoz.Name = "lblDoz";
			this.lblDoz.Size = new System.Drawing.Size(31, 16);
			this.lblDoz.TabIndex = 7;
			this.lblDoz.Text = "Doz";
			// 
			// btnRandevuEkle
			// 
			this.btnRandevuEkle.Location = new System.Drawing.Point(137, 301);
			this.btnRandevuEkle.Name = "btnRandevuEkle";
			this.btnRandevuEkle.Size = new System.Drawing.Size(75, 28);
			this.btnRandevuEkle.TabIndex = 8;
			this.btnRandevuEkle.Text = "Randevu Ekle";
			this.btnRandevuEkle.UseVisualStyleBackColor = true;
			this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuEkle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(230, 9);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(746, 320);
			this.dataGridView1.TabIndex = 9;
			// 
			// txtHastaAdi
			// 
			this.txtHastaAdi.Location = new System.Drawing.Point(12, 181);
			this.txtHastaAdi.Name = "txtHastaAdi";
			this.txtHastaAdi.Size = new System.Drawing.Size(200, 22);
			this.txtHastaAdi.TabIndex = 10;
			// 
			// lblHastaAdi
			// 
			this.lblHastaAdi.AutoSize = true;
			this.lblHastaAdi.Location = new System.Drawing.Point(12, 165);
			this.lblHastaAdi.Name = "lblHastaAdi";
			this.lblHastaAdi.Size = new System.Drawing.Size(66, 16);
			this.lblHastaAdi.TabIndex = 11;
			this.lblHastaAdi.Text = "Hasta Adı";
			// 
			// txtHastaSoyadi
			// 
			this.txtHastaSoyadi.Location = new System.Drawing.Point(12, 220);
			this.txtHastaSoyadi.Name = "txtHastaSoyadi";
			this.txtHastaSoyadi.Size = new System.Drawing.Size(200, 22);
			this.txtHastaSoyadi.TabIndex = 12;
			// 
			// lblHastaSoyadi
			// 
			this.lblHastaSoyadi.AutoSize = true;
			this.lblHastaSoyadi.Location = new System.Drawing.Point(12, 204);
			this.lblHastaSoyadi.Name = "lblHastaSoyadi";
			this.lblHastaSoyadi.Size = new System.Drawing.Size(89, 16);
			this.lblHastaSoyadi.TabIndex = 13;
			this.lblHastaSoyadi.Text = "Hasta Soyadı";
			// 
			// comboBoxPersonel
			// 
			this.comboBoxPersonel.FormattingEnabled = true;
			this.comboBoxPersonel.Location = new System.Drawing.Point(12, 259);
			this.comboBoxPersonel.Name = "comboBoxPersonel";
			this.comboBoxPersonel.Size = new System.Drawing.Size(200, 24);
			this.comboBoxPersonel.TabIndex = 14;
			// 
			// lblPersonel
			// 
			this.lblPersonel.AutoSize = true;
			this.lblPersonel.Location = new System.Drawing.Point(12, 243);
			this.lblPersonel.Name = "lblPersonel";
			this.lblPersonel.Size = new System.Drawing.Size(130, 16);
			this.lblPersonel.TabIndex = 15;
			this.lblPersonel.Text = "Personel Adı Soyadı";
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(1007, 361);
			this.Controls.Add(this.lblPersonel);
			this.Controls.Add(this.comboBoxPersonel);
			this.Controls.Add(this.lblHastaSoyadi);
			this.Controls.Add(this.txtHastaSoyadi);
			this.Controls.Add(this.lblHastaAdi);
			this.Controls.Add(this.txtHastaAdi);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnRandevuEkle);
			this.Controls.Add(this.lblDoz);
			this.Controls.Add(this.txtDoz);
			this.Controls.Add(this.lblAsiSaati);
			this.Controls.Add(this.dtpAsiSaati);
			this.Controls.Add(this.lblRandevuTarihi);
			this.Controls.Add(this.dtpRandevuTarihi);
			this.Controls.Add(this.lblAsiAdi);
			this.Controls.Add(this.txtAsiAdi);
			this.Name = "Form1";
			this.Text = "Aşı Takip Uygulaması";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.TextBox txtAsiAdi;
		private System.Windows.Forms.Label lblAsiAdi;
		private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
		private System.Windows.Forms.Label lblRandevuTarihi;
		private System.Windows.Forms.DateTimePicker dtpAsiSaati;
		private System.Windows.Forms.Label lblAsiSaati;
		private System.Windows.Forms.TextBox txtDoz;
		private System.Windows.Forms.Label lblDoz;
		private System.Windows.Forms.Button btnRandevuEkle;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtHastaAdi;
		private System.Windows.Forms.Label lblHastaAdi;
		private System.Windows.Forms.TextBox txtHastaSoyadi;
		private System.Windows.Forms.Label lblHastaSoyadi;
		private System.Windows.Forms.ComboBox comboBoxPersonel;
		private System.Windows.Forms.Label lblPersonel;
	}
}
