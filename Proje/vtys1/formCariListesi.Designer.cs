namespace vtys1
{
    partial class formCariListesi
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
            this.dgCari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCari
            // 
            this.dgCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCari.Location = new System.Drawing.Point(0, 0);
            this.dgCari.Name = "dgCari";
            this.dgCari.Size = new System.Drawing.Size(800, 450);
            this.dgCari.TabIndex = 0;
            // 
            // formCariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgCari);
            this.Name = "formCariListesi";
            this.Text = "Cari Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgCari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCari;
    }
}