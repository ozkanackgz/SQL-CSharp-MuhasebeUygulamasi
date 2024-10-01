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
    public partial class formLog : Form
    {
        public formLog()
        {
            InitializeComponent();

            DBProcess db = new DBProcess();
            DataSet dset = db.SelectData("SELECT * FROM V_LOG ORDER BY TARIH DESC");
            dgView.DataSource = dset.Tables[0];
        }

        
    }
}
