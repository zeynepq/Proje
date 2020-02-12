namespace AracAlisSatis
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtIlanAdi = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbVakitTuru = new System.Windows.Forms.ComboBox();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.cmbYakitTuru = new System.Windows.Forms.ComboBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(831, 416);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIlanAdi
            // 
            this.txtIlanAdi.Location = new System.Drawing.Point(150, 162);
            this.txtIlanAdi.Name = "txtIlanAdi";
            this.txtIlanAdi.Size = new System.Drawing.Size(121, 22);
            this.txtIlanAdi.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(150, 219);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 22);
            this.txtMarka.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 22);
            this.textBox1.TabIndex = 3;
            // 
            // cmbVakitTuru
            // 
            this.cmbVakitTuru.FormattingEnabled = true;
            this.cmbVakitTuru.Location = new System.Drawing.Point(150, 283);
            this.cmbVakitTuru.Name = "cmbVakitTuru";
            this.cmbVakitTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbVakitTuru.TabIndex = 4;
            // 
            // cmbRenk
            // 
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Location = new System.Drawing.Point(150, 343);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(121, 24);
            this.cmbRenk.TabIndex = 5;
            // 
            // cmbYakitTuru
            // 
            this.cmbYakitTuru.FormattingEnabled = true;
            this.cmbYakitTuru.Location = new System.Drawing.Point(406, 283);
            this.cmbYakitTuru.Name = "cmbYakitTuru";
            this.cmbYakitTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbYakitTuru.TabIndex = 6;
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(406, 343);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(121, 24);
            this.cmbSehir.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ILAN ADI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ILAN FİYATI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "MARKA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "MODEL";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(406, 162);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(121, 22);
            this.txtKm.TabIndex = 13;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(406, 223);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 22);
            this.txtModel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "VITES TURU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "RENK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "YAKIT TURU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "SEHIR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(577, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 221);
            this.dataGridView1.TabIndex = 19;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(150, 89);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(377, 22);
            this.dtpTarih.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "TARIH";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "ArabaListe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(831, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "IlanListele";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(1039, 82);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(170, 23);
            this.btnSilme.TabIndex = 24;
            this.btnSilme.Text = "SecilenVeriSilme";
            this.btnSilme.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 549);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.cmbYakitTuru);
            this.Controls.Add(this.cmbRenk);
            this.Controls.Add(this.cmbVakitTuru);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtIlanAdi);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtIlanAdi;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbVakitTuru;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.ComboBox cmbYakitTuru;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSilme;
    }
}

