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
    public partial class formCariHesapHareketleri : Form
    {
        public formCariHesapHareketleri()
        {
            InitializeComponent();
            DBProcess db = new DBProcess();
            DataSet dsetCariler = db.SelectData("SELECT * FROM CARI_HESAPLAR ORDER BY CARIUNVAN");
            cmbCari.DataSource = dsetCariler.Tables[0];
            cmbCari.ValueMember = "CARIKOD";
            cmbCari.DisplayMember = "CARIUNVAN";
            cmbCari.SelectedIndex = -1;

            DataSet dsetStoklar = db.SelectData("SELECT * FROM STOKLAR ORDER BY STOKAD");
            cmbStok.DataSource = dsetStoklar.Tables[0];
            cmbStok.ValueMember = "STOKKOD";
            cmbStok.DisplayMember = "STOKAD";
            cmbStok.SelectedIndex = -1;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtEvrakSeri.Text = txtEvrakSira.Text = null;
            cmbCari.SelectedIndex = cmbStok.SelectedIndex = -1;
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            string evrakseri = txtEvrakSeri.Text;
            string evraksira = txtEvrakSira.Text;
            string carikod = null, stokkod = null;
            if(cmbCari.SelectedIndex != -1)
                carikod = cmbCari.SelectedValue.ToString();
            if(cmbStok.SelectedIndex != -1)
                stokkod=cmbStok.SelectedValue.ToString();


            DBProcess db = new DBProcess();

            string sqls = @"SELECT FATURATURU, KAYITNO, CARIKOD, CARIUNVAN, EVRAKSERI, EVRAKNO, STOKKOD, STOKAD, BIRIMFIYAT, MIKTAR, TOPLAMFIYAT FROM V_CARI_HESAP_HAREKETLERI WHERE 1=1";

            if (!string.IsNullOrEmpty(evrakseri))
                sqls += " AND EVRAKSERI LIKE '%" + evrakseri + "%'";

            if (!string.IsNullOrEmpty(evraksira))
                sqls += " AND EVRAKNO = " + evraksira;

            if (!string.IsNullOrEmpty(carikod))
                sqls += " AND CARIKOD = '" + carikod + "'";

            if (!string.IsNullOrEmpty(stokkod))
                sqls += "AND STOKKOD = '" + stokkod + "'";

            DataSet dset = db.SelectData(sqls);
            dgviewch.DataSource = dset.Tables[0];
        }
    }
}
