using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys1
{
    public partial class formStokTanim : Form
    {
        public formStokTanim()
        {
            InitializeComponent();
        }

        private void txtKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKaydet_Click(object sender, EventArgs e)
        {
            string kod = txtStokKod.Text;
            string ad = txtStokAd.Text;
            decimal fiyat = Convert.ToDecimal(txtGüncelFıyat.Text.Replace(',','.'));
            Int64 miktar = Convert.ToInt64(txtMıktar.Text);


            string sql = "INSERT INTO STOKLAR(STOKKOD, STOKAD, GUNCELFIYAT, MIKTAR, EKLEYEN_KNO) VALUES('" + kod + "', '" + ad + "', " + fiyat + ", " + miktar + ", " + Program._KNO + ")";

            DBProcess db = new DBProcess();
            int satir = db.InsertOrUpdateData(sql);
            if (satir != -1)
                MessageBox.Show("Ürün Eklendi");
            else
                MessageBox.Show("Ürün Eklenmedi");
        }

        
    }
}
