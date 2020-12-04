using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBDBDIB
{
    public partial class MessageAck : Form
    {
        UserInfo UserManager = UserInfo.Getinstance();
        public MessageAck()
        {
            InitializeComponent();
        }

        private void MessageAck_Load(object sender, EventArgs e)
        {
            
            string query = "SELECT 수신확인, name AS 받는사람, 제목, 내용 FROM 쪽지 join Employee on 쪽지.받는사람 = Employee.Identification WHERE 보낸사람 = " + UserManager.Id;

            MySqlDataReader rdr = DBManager.GetInstance().select(query);

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;

            rdr.Close();
        }
    }
}
