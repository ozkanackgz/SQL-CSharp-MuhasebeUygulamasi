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
    public partial class formCariListesi : Form
    {
        public formCariListesi()
        {
            InitializeComponent();

            DBProcess db = new DBProcess();
            DataSet dset = db.SelectData("SELECT CARIKOD, CARIUNVAN, TELEFON, EMAIL, EH_TEDARIKCI, ADRES FROM CARI_HESAPLAR");

            dgCari.DataSource = dset.Tables[0];
        }
    }
}
