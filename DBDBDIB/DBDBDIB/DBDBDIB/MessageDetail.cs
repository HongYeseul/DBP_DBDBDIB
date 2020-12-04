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
    public partial class MessageDetail : Form
    {
        DBManager DBmanager = DBManager.GetInstance();
        string messageId;
        public MessageDetail()
        {
            InitializeComponent();
        }

        public MessageDetail(string messageId)
        {
            this.messageId = messageId;
            InitializeComponent();
            findDetail();
        }

        public void findDetail()
        {
            string query = "SELECT * FROM 쪽지 join Employee on 쪽지.보낸사람 = Employee.identification WHERE id = " + messageId;
            MySqlDataReader rdr = DBmanager.select(query);
            rdr.Read();

            Console.WriteLine(rdr["제목"].ToString() + rdr["내용"].ToString());
            txtTitle.Text = rdr["제목"].ToString();
            txtContent.Text = rdr["내용"].ToString();
            txtWhoSent.Text = rdr["name"].ToString();

            rdr.Close();
        }
    }
}
