namespace vtys1
{
    partial class formStokTanim
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
            this.txtStokKodu = new System.Windows.Forms.Label();
            this.txtStokAdı = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.Label();
            this.txtGüncelFiyat = new System.Windows.Forms.Label();
            this.txtStokKod = new System.Windows.Forms.TextBox();
            this.txtMıktar = new System.Windows.Forms.TextBox();
            this.txtGüncelFıyat = new System.Windows.Forms.TextBox();
            this.txtStokAd = new System.Windows.Forms.TextBox();
            this.txtKaydet = new System.Windows.Forms.Button();
            this.txtKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(12, 9);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(100, 23);
            this.txtStokKodu.TabIndex = 0;
            this.txtStokKodu.Text = "Stok Kodu:";
            this.txtStokKodu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStokAdı
            // 
            this.txtStokAdı.Location = new System.Drawing.Point(12, 46);
            this.txtStokAdı.Name = "txtStokAdı";
            this.txtStokAdı.Size = new System.Drawing.Size(100, 23);
            this.txtStokAdı.TabIndex = 1;
            this.txtStokAdı.Text = "Stok Adı:";
            this.txtStokAdı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(12, 127);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 23);
            this.txtMiktar.TabIndex = 2;
            this.txtMiktar.Text = "Miktar:";
            this.txtMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGüncelFiyat
            // 
            this.txtGüncelFiyat.Location = new System.Drawing.Point(12, 85);
            this.txtGüncelFiyat.Name = "txtGüncelFiyat";
            this.txtGüncelFiyat.Size = new System.Drawing.Size(100, 23);
            this.txtGüncelFiyat.TabIndex = 3;
            this.txtGüncelFiyat.Text = "Güncel Fiyat:";
            this.txtGüncelFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStokKod
            // 
            this.txtStokKod.Location = new System.Drawing.Point(118, 9);
            this.txtStokKod.Name = "txtStokKod";
            this.txtStokKod.Size = new System.Drawing.Size(100, 20);
            this.txtStokKod.TabIndex = 4;
            // 
            // txtMıktar
            // 
            this.txtMıktar.Location = new System.Drawing.Point(118, 127);
            this.txtMıktar.Name = "txtMıktar";
            this.txtMıktar.Size = new System.Drawing.Size(100, 20);
            this.txtMıktar.TabIndex = 5;
            // 
            // txtGüncelFıyat
            // 
            this.txtGüncelFıyat.Location = new System.Drawing.Point(118, 85);
            this.txtGüncelFıyat.Name = "txtGüncelFıyat";
            this.txtGüncelFıyat.Size = new System.Drawing.Size(100, 20);
            this.txtGüncelFıyat.TabIndex = 6;
            // 
            // txtStokAd
            // 
            this.txtStokAd.Location = new System.Drawing.Point(118, 46);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Size = new System.Drawing.Size(212, 20);
            this.txtStokAd.TabIndex = 7;
            // 
            // txtKaydet
            // 
            this.txtKaydet.Location = new System.Drawing.Point(118, 164);
            this.txtKaydet.Name = "txtKaydet";
            this.txtKaydet.Size = new System.Drawing.Size(75, 23);
            this.txtKaydet.TabIndex = 8;
            this.txtKaydet.Text = "KAYDET";
            this.txtKaydet.UseVisualStyleBackColor = true;
            this.txtKaydet.Click += new System.EventHandler(this.txtKaydet_Click);
            // 
            // txtKapat
            // 
            this.txtKapat.Location = new System.Drawing.Point(255, 164);
            this.txtKapat.Name = "txtKapat";
            this.txtKapat.Size = new System.Drawing.Size(75, 23);
            this.txtKapat.TabIndex = 9;
            this.txtKapat.Text = "KAPAT";
            this.txtKapat.UseVisualStyleBackColor = true;
            this.txtKapat.Click += new System.EventHandler(this.txtKapat_Click);
            // 
            // formStokTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKapat);
            this.Controls.Add(this.txtKaydet);
            this.Controls.Add(this.txtStokAd);
            this.Controls.Add(this.txtGüncelFıyat);
            this.Controls.Add(this.txtMıktar);
            this.Controls.Add(this.txtStokKod);
            this.Controls.Add(this.txtGüncelFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtStokAdı);
            this.Controls.Add(this.txtStokKodu);
            this.Name = "formStokTanim";
            this.Text = "Stok Tanım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtStokKodu;
        private System.Windows.Forms.Label txtStokAdı;
        private System.Windows.Forms.Label txtMiktar;
        private System.Windows.Forms.Label txtGüncelFiyat;
        private System.Windows.Forms.TextBox txtStokKod;
        private System.Windows.Forms.TextBox txtMıktar;
        private System.Windows.Forms.TextBox txtGüncelFıyat;
        private System.Windows.Forms.TextBox txtStokAd;
        private System.Windows.Forms.Button txtKaydet;
        private System.Windows.Forms.Button txtKapat;
    }
}