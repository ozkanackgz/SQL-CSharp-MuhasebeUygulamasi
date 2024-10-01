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
    public partial class formCariTanim : Form
    {
        public formCariTanim()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string carikod = txtCariKod.Text;
            string cariunvan = txtCariUnvan.Text;
            Int64 telefon = Convert.ToInt64(txtTelefon.Text);
            string eposta = txtEposta.Text;
            Int64 tedarikci = Convert.ToInt64(txtTedarikci.Text);
            string adres = txtAdres.Text;


            string sql = "INSERT INTO CARI_HESAPLAR(CARIKOD, CARIUNVAN, TELEFON, EMAIL, EH_TEDARIKCI, ADRES) VALUES('" + carikod + "', '" + cariunvan + "', " + telefon + ", '" + eposta + "', " + tedarikci + ", '" + adres + "')";

            DBProcess db = new DBProcess();
            int satir1 = db.InsertOrUpdateData(sql);
            if (satir1 != -1)
                MessageBox.Show("Kayıt Eklendi");
            else
                MessageBox.Show("Kayıt Eklenmedi");
        }
    }
}
