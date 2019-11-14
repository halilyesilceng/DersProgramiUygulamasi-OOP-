namespace DersProgramiUygulamasi
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
            this.lblDersKodu = new System.Windows.Forms.Label();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.txtDersHocasi = new System.Windows.Forms.TextBox();
            this.lblDersHocasi = new System.Windows.Forms.Label();
            this.txtDersBaslamaSaati = new System.Windows.Forms.TextBox();
            this.lblDersBaslamaSaati = new System.Windows.Forms.Label();
            this.txtDersBitisSaati = new System.Windows.Forms.TextBox();
            this.lblDersBitisSaati = new System.Windows.Forms.Label();
            this.btnDersleriListele = new System.Windows.Forms.Button();
            this.txtListele = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDersKodu
            // 
            this.lblDersKodu.AutoSize = true;
            this.lblDersKodu.Location = new System.Drawing.Point(83, 33);
            this.lblDersKodu.Name = "lblDersKodu";
            this.lblDersKodu.Size = new System.Drawing.Size(83, 17);
            this.lblDersKodu.TabIndex = 0;
            this.lblDersKodu.Text = "Ders Kodu :";
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(172, 28);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(271, 22);
            this.txtDersKodu.TabIndex = 1;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(172, 243);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(271, 23);
            this.btnDersEkle.TabIndex = 2;
            this.btnDersEkle.Text = "DERS EKLE";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(172, 69);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(271, 22);
            this.txtDersAdi.TabIndex = 4;
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Location = new System.Drawing.Point(96, 69);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(70, 17);
            this.lblDersAdi.TabIndex = 3;
            this.lblDersAdi.Text = "Ders Adı :";
            // 
            // txtDersHocasi
            // 
            this.txtDersHocasi.Location = new System.Drawing.Point(172, 113);
            this.txtDersHocasi.Name = "txtDersHocasi";
            this.txtDersHocasi.Size = new System.Drawing.Size(271, 22);
            this.txtDersHocasi.TabIndex = 6;
            // 
            // lblDersHocasi
            // 
            this.lblDersHocasi.AutoSize = true;
            this.lblDersHocasi.Location = new System.Drawing.Point(73, 116);
            this.lblDersHocasi.Name = "lblDersHocasi";
            this.lblDersHocasi.Size = new System.Drawing.Size(93, 17);
            this.lblDersHocasi.TabIndex = 5;
            this.lblDersHocasi.Text = "Ders Hocası :";
            // 
            // txtDersBaslamaSaati
            // 
            this.txtDersBaslamaSaati.Location = new System.Drawing.Point(172, 151);
            this.txtDersBaslamaSaati.Name = "txtDersBaslamaSaati";
            this.txtDersBaslamaSaati.Size = new System.Drawing.Size(271, 22);
            this.txtDersBaslamaSaati.TabIndex = 8;
            // 
            // lblDersBaslamaSaati
            // 
            this.lblDersBaslamaSaati.AutoSize = true;
            this.lblDersBaslamaSaati.Location = new System.Drawing.Point(26, 156);
            this.lblDersBaslamaSaati.Name = "lblDersBaslamaSaati";
            this.lblDersBaslamaSaati.Size = new System.Drawing.Size(140, 17);
            this.lblDersBaslamaSaati.TabIndex = 7;
            this.lblDersBaslamaSaati.Text = "Ders Başlama Saati :";
            // 
            // txtDersBitisSaati
            // 
            this.txtDersBitisSaati.Location = new System.Drawing.Point(172, 196);
            this.txtDersBitisSaati.Name = "txtDersBitisSaati";
            this.txtDersBitisSaati.Size = new System.Drawing.Size(271, 22);
            this.txtDersBitisSaati.TabIndex = 10;
            // 
            // lblDersBitisSaati
            // 
            this.lblDersBitisSaati.AutoSize = true;
            this.lblDersBitisSaati.Location = new System.Drawing.Point(54, 199);
            this.lblDersBitisSaati.Name = "lblDersBitisSaati";
            this.lblDersBitisSaati.Size = new System.Drawing.Size(112, 17);
            this.lblDersBitisSaati.TabIndex = 9;
            this.lblDersBitisSaati.Text = "Ders Bitiş Saati :";
            // 
            // btnDersleriListele
            // 
            this.btnDersleriListele.Location = new System.Drawing.Point(57, 291);
            this.btnDersleriListele.Name = "btnDersleriListele";
            this.btnDersleriListele.Size = new System.Drawing.Size(386, 23);
            this.btnDersleriListele.TabIndex = 11;
            this.btnDersleriListele.Text = "DERSLERİ LİSTELE ";
            this.btnDersleriListele.UseVisualStyleBackColor = true;
            this.btnDersleriListele.Click += new System.EventHandler(this.btnDersleriListele_Click);
            // 
            // txtListele
            // 
            this.txtListele.Enabled = false;
            this.txtListele.Location = new System.Drawing.Point(57, 336);
            this.txtListele.Multiline = true;
            this.txtListele.Name = "txtListele";
            this.txtListele.Size = new System.Drawing.Size(386, 223);
            this.txtListele.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 572);
            this.Controls.Add(this.txtListele);
            this.Controls.Add(this.btnDersleriListele);
            this.Controls.Add(this.txtDersBitisSaati);
            this.Controls.Add(this.lblDersBitisSaati);
            this.Controls.Add(this.txtDersBaslamaSaati);
            this.Controls.Add(this.lblDersBaslamaSaati);
            this.Controls.Add(this.txtDersHocasi);
            this.Controls.Add(this.lblDersHocasi);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.lblDersKodu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDersKodu;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.TextBox txtDersHocasi;
        private System.Windows.Forms.Label lblDersHocasi;
        private System.Windows.Forms.TextBox txtDersBaslamaSaati;
        private System.Windows.Forms.Label lblDersBaslamaSaati;
        private System.Windows.Forms.TextBox txtDersBitisSaati;
        private System.Windows.Forms.Label lblDersBitisSaati;
        private System.Windows.Forms.Button btnDersleriListele;
        private System.Windows.Forms.TextBox txtListele;
    }
}

