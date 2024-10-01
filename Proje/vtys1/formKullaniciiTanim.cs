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
    public partial class formKullaniciiTanim : Form
    {
        private Int32? KNO;
        public formKullaniciiTanim(Int32? KULLANICI_NO)
        {
            InitializeComponent();
            KNO = KULLANICI_NO;

            if(KULLANICI_NO != null)
            {
                // bilgi güncelleme
                string sql = "SELECT * FROM KULLANICILAR WHERE KNO = " + KULLANICI_NO.ToString();
                DBProcess db = new DBProcess();
                DataSet dset = db.SelectData(sql);
                if (dset != null && dset.Tables[0].Rows.Count == 1)
                {
                    txtKullaniciAdi.Text = dset.Tables[0].Rows[0]["KULLANICIADI"].ToString();
                    txtEposta.Text = dset.Tables[0].Rows[0]["EPOSTA"].ToString();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bilgisi Bulunamadı");
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool guncelleme = false;
            if(KNO != null)
            {
                // kullanıcı güncelleme işlemi
                guncelleme = true;
            }

            err.Clear();

            string kadi = txtKullaniciAdi.Text;
            string eposta = txtEposta.Text;
            string sifre = txtSifre.Text;
            string sifretekrar = txtSifreTekrar.Text;

            if(string.IsNullOrEmpty(kadi))
            {
                err.SetError(txtKullaniciAdi, "Boş Geçilemez");
                return;
            }

            if (string.IsNullOrEmpty(eposta))
            {
                err.SetError(txtEposta, "Boş Geçilemez");
                return;
            }

            if (string.IsNullOrEmpty(sifre))
            {
                err.SetError(txtSifre, "Boş Geçilemez");
                return;
            }

            if (string.IsNullOrEmpty(sifretekrar))
            {
                err.SetError(txtSifreTekrar, "Boş Geçilemez");
                return;
            }

            if (string.IsNullOrEmpty(sifretekrar))
            {
                err.SetError(txtSifreTekrar, "Şifreler Farklı");
                return;
            }

            string sql;
            if (guncelleme)
                sql = "UPDATE KULLANICILAR SET KULLANICIADI='" + kadi + "', SIFRE = '" + sifre + "', EPOSTA = '" + eposta + "' WHERE KNO = " + KNO;
            else
                sql = "INSERT INTO KULLANICILAR(KULLANICIADI, SIFRE, EPOSTA) VALUES('" + kadi + "', '" + sifre + "', '" + eposta + "')";

            DBProcess db = new DBProcess();
            int ks = db.InsertOrUpdateData(sql);
            if (ks > 0)
            {
                MessageBox.Show("Kullanıcı Kaydı Yapıldı");
                Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Eklenirken Hata Oluştu");
            }
        }

      
    }
}
