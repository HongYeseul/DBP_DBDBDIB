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
    public partial class TodayWorkSaveChange : Form
    {
        private string CASE = "";
        GridViewManager gridView;
        int changeid;

        public TodayWorkSaveChange(GridViewManager View, string buttonText, int id = 0, string name="")
        {
            InitializeComponent();
            //등록인지 수정인지 버튼 수정
            buttonSaveANDChange.Text = buttonText;
            this.CASE = buttonText;
            gridView = View;

            
            InitCombo();//초기 부서 콤보박스


            //만약 수정이면 기본 combobox 세팅
            if (CASE.Equals("수정"))
            {
                labelName.Text = name + "님의 일일업무 수정";
                changeid = id;
                initChange();
            }
            else //수정아니면 본인 등록
            {
                labelName.Text = UserInfo.Getinstance().Name + "님의 일일업무 등록";
            }

        }
        void initChange()
        {
            //날짜!!!!******,
            string query = "SELECT 부서,업무종류,업무내용,날짜 FROM 일일업무등록,업무마스터 WHERE 업무마스터id=업무번호 AND id = " +changeid;
            MySqlDataReader rdr = DBManager.GetInstance().select(query);
            string com1="", com2="", com3="";
            
            while (rdr.Read())
            {
                com1 = rdr["부서"].ToString();
                com2 = rdr["업무종류"].ToString();
                com3 = rdr["업무내용"].ToString();
                dateTimePicker1.Value = (DateTime)rdr["날짜"];
            }

            comboBox소속.SelectedItem = com1; 
            comboBox업무종류.SelectedItem = com2;

            fill업무내용event(); //업무내용 콤보 채우기

            comboBox업무내용.SelectedItem = com3; 
            


        }
        



        void InitCombo() //부서 콤보 채우기
        {
            string query = "SELECT DISTINCT 부서 FROM 업무마스터 WHERE 업무유효성=1";
            MySqlDataReader rdr = DBManager.GetInstance().select(query);
            while (rdr.Read())
            {
                comboBox소속.Items.Add(rdr["부서"].ToString());
            }
            //나머지 콤보박스 비우기
            comboBox업무종류.Items.Clear();
            comboBox업무내용.Items.Clear();
        }
        
        
        
        
        //콤보박스 값들은 이벤트에 따라 바뀌여야함. 

        private void comboBox소속_SelectedIndexChanged(object sender, EventArgs e) //부서선택
        {
            //한번 닦기
            comboBox업무종류.Items.Clear();

            //업무 종류 세팅
            string com1 = comboBox소속.SelectedItem.ToString();

            string query = "SELECT DISTINCT 업무종류 FROM 업무마스터 WHERE 부서 LIKE '" + com1 + "' AND 업무유효성=1";
            MySqlDataReader rdr = DBManager.GetInstance().select(query);
            while (rdr.Read())
            {
                comboBox업무종류.Items.Add(rdr["업무종류"].ToString());
            }

            //첫번째 선택
            comboBox업무종류.SelectedIndex = 0;

            //나머지 콤보박스 비우기  
            comboBox업무내용.SelectedItem = null;
            comboBox업무내용.Items.Clear();
            

        }

        

        private void comboBox업무종류_SelectedIndexChanged(object sender, EventArgs e) //장기단기 선택
        {
            fill업무내용event(); //업무 내용 콤보 채우기

            //첫번째 선택
            comboBox업무내용.SelectedIndex = 0;

        }

        private void fill업무내용event()
        {
            //한번 닦기
            comboBox업무내용.Items.Clear();

            //업무 내용 세팅, 가끔씩 null 받아옴... 오류 많이생김 고치기
            string com1 = comboBox소속.SelectedItem.ToString();
            string com2 = comboBox업무종류.SelectedItem.ToString();

            string query = "SELECT DISTINCT 업무내용 FROM 업무마스터 WHERE 부서 LIKE '" + com1 + "' AND 업무종류 LIKE '" + com2 + "' AND 업무유효성=1";
            MySqlDataReader rdr = DBManager.GetInstance().select(query);
            while (rdr.Read())
            {
                comboBox업무내용.Items.Add(rdr["업무내용"].ToString());
            }
        }


        private void comboBox업무내용_SelectedIndexChanged(object sender, EventArgs e)
        {
            //의미없다
        }

        private void buttonSaveANDChange_Click(object sender, EventArgs e) //등록 혹인 수정 버튼 클릭
        {
            //날짜,등록자, 소분류에서 선택된 업무마스터 id 값 (button text에 따라 등록 || 수정)
            DateTime dt = dateTimePicker1.Value; //지정한 날자를 불러옴
            string date = string.Format("{0}-{1}-{2}", dt.Year, dt.Month, dt.Day);
            string com1 = comboBox소속.SelectedItem.ToString();
            string com2 = comboBox업무종류.SelectedItem.ToString();
            string com3 = comboBox업무내용.SelectedItem.ToString();

            if (com1.Equals(null) || com2.Equals(null) || com3.Equals(null))
            {
                MessageBox.Show("모든값을 선택해 주세요");
            }

            string query;
            if (CASE.Equals("수정")) //수정*****
            {
                query = "UPDATE 일일업무등록 SET 날짜='" +
                    date + "',업무마스터id=(SELECT 업무번호 FROM 업무마스터 WHERE 부서 LIKE '" + com1
                + "' AND 업무종류 LIKE '" + com2 + "' AND 업무내용 LIKE '" + com3 + "') WHERE id=" + changeid;
            }
            else //등록
            {
                query = "INSERT INTO 일일업무등록(등록자id,날짜,업무마스터id) VALUES(" +
                UserInfo.Getinstance().Id + " ,'" + date + "' ," + "(SELECT 업무번호 FROM 업무마스터 WHERE 부서 LIKE '" + com1
                + "' AND 업무종류 LIKE '" + com2 + "' AND 업무내용 LIKE '" + com3 + "') )";
            }

            DBManager.GetInstance().DBquery(query);

            this.Close();

        }

        private void TodayWorkSaveChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            //폼 닫힘
            //gridview 새로 그리기
            gridView.SettingGridView();
        }
    }
}
