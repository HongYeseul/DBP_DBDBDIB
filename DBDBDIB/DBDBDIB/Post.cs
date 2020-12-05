using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace DBDBDIB
{
    public partial class Post : Form
    {
        string currentPage ="";  //현재 페이지
        string countPerPage = string.Empty; //1페이지당 출력 갯수
        string confmKey = "devU01TX0FVVEgyMDIwMTExODAxMTA1MjExMDQzMjE="; //테스트 Key
        string keyword = string.Empty;
        string apiurl = string.Empty;
        Personnel main;

        public Post(Personnel form) {
            InitializeComponent();
            initVariable();
            main = form;
        }

        public Post(){
            InitializeComponent();
        }
        private void initVariable()
        {
            currentPage = "1";
            countPerPage = "20";
            dgvResult.Columns.Add("", "주소");
            dgvResult.Columns.Add("", "우편번호");
        }
        private void getAddress()
        {
            dgvResult.Rows.Clear();
            keyword = tbKey.Text.Trim();
            apiurl = "http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage=" + currentPage + "&countPerPage=" + countPerPage + "&keyword=" + keyword + "&confmKey=" + confmKey;
            WebClient wc = new WebClient();//웹클라이언트
            XmlReader read = new XmlTextReader(wc.OpenRead(apiurl));//xml reader
            DataSet ds = new DataSet();
            int pageNumber;

            ds.ReadXml(read);

            dataGridView2.DataSource = ds.Tables[0];

            DataRow[] rows = ds.Tables[0].Select();

            if (Convert.ToInt32(rows[0]["totalCount"]) > 400)
            {
                MessageBox.Show("검색어를 구체적이게 입력하십시오.\r\n(검색결과 400개 이상)","Caution");
                return;
            }

            if (rows[0]["totalCount"].ToString() == "0") {
                MessageBox.Show("검색결과가 없습니다.");
                return;
            }
            DataTable post = ds.Tables[1];
            //dataGridView1.DataSource = ds.Tables[1];
            for (int i = 0; i < post.Rows.Count; i++) 
                dgvResult.Rows.Add(post.Rows[i][0].ToString(), post.Rows[i][5].ToString());
            dgvResult.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
             pageNumber = Convert.ToInt32(rows[0]["totalCount"]) / Convert.ToInt32(countPerPage);
             if (Convert.ToInt32(rows[0]["totalCount"]) % Convert.ToInt32(countPerPage) != 0)
             pageNumber++;           

            dynamicLabel(pageNumber);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            getAddress();
        }
        private void dynamicLabel(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                Label label = new Label();
                label = new System.Windows.Forms.Label();
                label.Location = new System.Drawing.Point(100+20*(i-1), 440);
                label.Name = i.ToString()+"Page";
                label.Size = new System.Drawing.Size(50, 23);
                label.TabIndex = 1;
                label.Text = i.ToString();
                label.Tag = i;
                label.ForeColor = Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
                //label.Visible = true;
                label.Click += new System.EventHandler(this.label_Click);

                this.Controls.Add(label);
                label.BringToFront();

            }
        }
        private void label_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            currentPage = lb.Tag.ToString();
            Console.WriteLine(lb.Name);
            getAddress();
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Personnel pr = new Personnel();

            main.tbInsertPost.Text = dgvResult.Rows[dgvResult.SelectedRows[0].Index].Cells[1].Value.ToString();
            main.tbInsertAddress1.Text = dgvResult.Rows[dgvResult.SelectedRows[0].Index].Cells[0].Value.ToString();

            this.Hide();    
        }
    }
}
