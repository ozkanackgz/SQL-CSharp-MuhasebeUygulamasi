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
using System.Security.Policy;

namespace vtys1
{
    public partial class formStokListesi : Form
    {
        public formStokListesi()
        {
            InitializeComponent();

            DBProcess db = new DBProcess();
            DataSet dset = db.SelectData("SELECT STOKKOD, STOKAD, GUNCELFIYAT, MIKTAR FROM STOKLAR");
            
            dview.DataSource = dset.Tables[0];
        }

        
    }
}
