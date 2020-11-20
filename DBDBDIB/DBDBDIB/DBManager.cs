using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBDBDIB
{
    class DBManager
    {
        private static DBManager instance = new DBManager();
        string strConn = "Server=49.50.174.201;Database=erp_school;Uid=dbdbdib;Pwd=123123;Charset=utf8";
        public static DBManager GetInstance() { return instance; }

        //객체 생성 제한
        private DBManager() { }

        public void DBquery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public MySqlDataReader select(string query)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                //conn.Close();
                return rdr;
            }
            catch
            {
                MessageBox.Show("time over");
                return null;
            }

        }

    }
}
