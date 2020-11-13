using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBDBDIB
{
    class GridViewManager
    {
        private string select = "";
        private DataGridView dataGridView;

        public GridViewManager(DataGridView dg)
        {
            dataGridView = dg;
        }

        public void SettingSelect(string query)
        {
            select = query;
        }


        public void SettingGridView()
        {
            MySqlDataReader rdr = DBManager.GetInstance().select(select); //쿼리 결과 받아오기

            DataTable dt = new DataTable();
            dt.Load(rdr);

            dataGridView.DataSource = dt; //VIEW 직접 접근해서 그려주기
            rdr.Close();
        }
    }
}
