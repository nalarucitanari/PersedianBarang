using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersedianBarang
{
    internal class Tabel
    {
        string namaTabel;
        DataTable dt;
        BindingSource bs;
        MySqlConnection conn;

        public Tabel(string namaTabel) 
        {
            this.namaTabel = namaTabel;
            this.dt = new DataTable();
            this.bs = new BindingSource();
            string conStr = "server=127.0.0.2;user id=root;password='';database=inv";
            this.conn = new MySqlConnection(conStr);
            isiDataTable();
        }

        public BindingSource getBS() 
        { 
            return bs; 
        }

        void isiDataTable()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + namaTabel,conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                bs.DataSource = dt;
                cmd.Dispose();
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            finally
            { 
                conn.Close();
            }

        }

        public void eksekusiSQL(String strSQL)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(strSQL,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.isiDataTable();
        }
        public long eksekusiSQL_getId(String strSQL)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            long noBaru = cmd.LastInsertedId; // <-- hasil auto increment
            conn.Close();
            this.isiDataTable();
            return noBaru;
        }

        public bool login(String username, String password )
        {
            string strSQL = $"SELECT COUNT(*) FROM {namaTabel} WHERE user_name = "+ 
                $"'{username}' AND password = PASSWORD('{password}')";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(strSQL, conn);
            bool valid = cmd.ExecuteScalar().ToString() == "1";
            conn.Close();
            return valid;
        }

    }
}
