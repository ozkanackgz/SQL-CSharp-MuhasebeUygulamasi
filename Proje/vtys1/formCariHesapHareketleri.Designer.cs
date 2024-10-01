namespace vtys1
{
    partial class formCariHesapHareketleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.cmbStok = new System.Windows.Forms.ComboBox();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.txtEvrakSira = new System.Windows.Forms.TextBox();
            this.txtEvrakSeri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgviewch = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btn_Listele);
            this.groupBox1.Controls.Add(this.cmbStok);
            this.groupBox1.Controls.Add(this.cmbCari);
            this.groupBox1.Controls.Add(this.txtEvrakSira);
            this.groupBox1.Controls.Add(this.txtEvrakSeri);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme";
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(691, 33);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(87, 28);
            this.btn_Listele.TabIndex = 1;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // cmbStok
            // 
            this.cmbStok.FormattingEnabled = true;
            this.cmbStok.Location = new System.Drawing.Point(370, 53);
            this.cmbStok.Name = "cmbStok";
            this.cmbStok.Size = new System.Drawing.Size(178, 21);
            this.cmbStok.TabIndex = 6;
            // 
            // cmbCari
            // 
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Location = new System.Drawing.Point(370, 19);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(178, 21);
            this.cmbCari.TabIndex = 1;
            // 
            // txtEvrakSira
            // 
            this.txtEvrakSira.Location = new System.Drawing.Point(112, 54);
            this.txtEvrakSira.Name = "txtEvrakSira";
            this.txtEvrakSira.Size = new System.Drawing.Size(126, 20);
            this.txtEvrakSira.TabIndex = 5;
            // 
            // txtEvrakSeri
            // 
            this.txtEvrakSeri.Location = new System.Drawing.Point(112, 18);
            this.txtEvrakSeri.Name = "txtEvrakSeri";
            this.txtEvrakSeri.Size = new System.Drawing.Size(126, 20);
            this.txtEvrakSeri.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(264, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cari :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(264, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Evrak Sıra :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ervak Seri :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgviewch
            // 
            this.dgviewch.AllowUserToAddRows = false;
            this.dgviewch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewch.Location = new System.Drawing.Point(0, 100);
            this.dgviewch.Name = "dgviewch";
            this.dgviewch.Size = new System.Drawing.Size(800, 350);
            this.dgviewch.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(584, 33);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 28);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // formCariHesapHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgviewch);
            this.Controls.Add(this.groupBox1);
            this.Name = "formCariHesapHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cari Hesap Hareketleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.ComboBox cmbStok;
        private System.Windows.Forms.ComboBox cmbCari;
        private System.Windows.Forms.TextBox txtEvrakSira;
        private System.Windows.Forms.TextBox txtEvrakSeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgviewch;
        private System.Windows.Forms.Button btnTemizle;
    }
}