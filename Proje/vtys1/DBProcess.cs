using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vtys1
{
    public class DBProcess
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-GBIMF3E\\SQLEXPRESS;Database=DERSVTYS;User " +
                "Id=sa;Password=ybs2023ktü;");
        public DataSet SelectData(string sql)
        {
            
    
            try
            {
                conn.Open(); // bağlantı açılmaya çalışılıyor

                SqlDataAdapter da = new SqlDataAdapter(); // database işlemleri için sqldataadapter nesnesi oluşturulur
                da.SelectCommand = new SqlCommand(); // da içindeki sqlcommand nesnesi initialize edildi
                da.SelectCommand.Connection = conn; // da içindeki sqlcommand nesnesinin connection özelliği setlendi
                da.SelectCommand.CommandText = sql;

                DataSet dset = new DataSet();
                da.Fill(dset);
                conn.Close();
                return dset;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int InsertOrUpdateData(string sql)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                int es = cmd.ExecuteNonQuery();
                conn.Close();
                return es;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }
}
