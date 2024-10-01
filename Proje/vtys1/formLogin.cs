using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vtys1
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kadi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string sql = "SELECT * FROM KULLANICILAR WHERE KULLANICIADI = '" + kadi + "' AND SIFRE = '" + sifre + "'";

            DBProcess db = new DBProcess();
            DataSet dset = db.SelectData(sql);



            if (dset != null)
            {
                if (dset.Tables[0].Rows.Count == 1)
                {
                    // kullanıcı kimlik doğrulaması yapıldı
                    Program._KNO = Convert.ToInt32(dset.Tables[0].Rows[0][0]);
                    formAna fmain = new formAna();
                    fmain.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Kullanıcı adı ve şifrenizi kontrol ediniz");

            }
            
            
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
