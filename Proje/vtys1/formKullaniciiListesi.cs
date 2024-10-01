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
    public partial class formKullaniciiListesi : Form
    {
        public formKullaniciiListesi()
        {
            InitializeComponent();
            LoadData();
            
        }

        private void LoadData()
        {
            string sql = @"SELECT KNO,KULLANICIADI,EPOSTA FROM KULLANICILAR";
            DBProcess db = new DBProcess();
            DataSet dset = db.SelectData(sql);

            if (dset != null)
            {
                dgKullanicilar.DataSource = dset.Tables[0];
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int rowindex = dgKullanicilar.CurrentCell.RowIndex;
            string KNO = dgKullanicilar.Rows[rowindex].Cells[0].Value.ToString();
            formKullaniciiTanim tanim = new formKullaniciiTanim(Convert.ToInt32(KNO));
            tanim.ShowDialog();
            tanim.Dispose();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int rowindex = dgKullanicilar.CurrentCell.RowIndex;
            string KNO = dgKullanicilar.Rows[rowindex].Cells[0].Value.ToString();

            string sql = "DELETE FROM KULLANICILAR WHERE KNO=" + KNO;
            DBProcess db = new DBProcess();
            int ks = db.InsertOrUpdateData(sql);
            if (ks > 0)
            {
                MessageBox.Show("Kullanıcı Kaydı Silindi");
                LoadData();
            }
        }
    }
}
