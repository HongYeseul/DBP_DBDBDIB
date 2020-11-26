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
    public partial class TodayWork : Form
    {
        private string radiobuttonNow=null;//현재 선택된 라디오 버튼, (날짜,키워드,등록자)
        GridViewManager gridView;

        public TodayWork()
        {
            InitializeComponent();
            SettingValue();
        }

        public void SettingValue() //gridview 전부 출력
        {
            gridView = new GridViewManager(dataGridViewSelect); // gridview 세팅
            string query = "Select id AS '번호'," +
                "(SELECT name FROM Employee WHERE 등록자id=identification) AS 등록자" +
                ",날짜,부서,업무종류,업무내용,SUBSTR(시작시간,12) AS 시작시간,SUBSTR(종료시간,12) AS 종료시간 FROM 일일업무등록,업무마스터 WHERE 업무마스터id=업무번호";


            gridView.SettingSelect(query); //select 세팅
            gridView.SettingGridView(); // gridview 그려주기

            //컬럼 사이즈 설정
            dataGridViewSelect.Columns[0].FillWeight = 50;
            dataGridViewSelect.Columns[3].FillWeight = 80;
            dataGridViewSelect.Columns[5].FillWeight = 250;


            //dataGridView1.Columns[6].Visible = false; // 화면에 보여주고 싶지 않은 칼럼 지정
        }


        private void buttonSave_Click(object sender, EventArgs e) //등록버튼
        {
            //등록 창 불러오기
            TodayWorkSaveChange todayWorkSaveChange = new TodayWorkSaveChange(gridView,"등록");
            todayWorkSaveChange.Show();
        }

        private void buttonChange_Click(object sender, EventArgs e) //수정버튼
        {
            //MessageBox.Show(UserInfo.Getinstance().Id);
            try
            {
                //수정시 선택한 값, id
                int id = Int32.Parse(dataGridViewSelect.Rows[dataGridViewSelect.CurrentCellAddress.Y].Cells[0].Value.ToString());
                //수정시 수정되는 업무 등록자
                string name = dataGridViewSelect.Rows[dataGridViewSelect.CurrentCellAddress.Y].Cells[1].Value.ToString();

                //수정 창 불러오기
                TodayWorkSaveChange todayWorkSaveChange = new TodayWorkSaveChange(gridView, "수정", id, name);
                todayWorkSaveChange.Show();
            }
            catch
            {
                MessageBox.Show("선택후 진행해 주세요");
            }

            
        }

        private void buttonDelete_Click(object sender, EventArgs e) //삭제 버튼
        {

            try
            {
                //선택된 값 삭제
                //id(pk)값 가지고 삭제
                int id = Int32.Parse(dataGridViewSelect.Rows[dataGridViewSelect.CurrentCellAddress.Y].Cells[0].Value.ToString());
                MessageBox.Show("" + id);

                //삭제 쿼리 보내기
                string query = "DELETE FROM 일일업무등록 WHERE id = " + id;
                DBManager.GetInstance().DBquery(query);


                //화면 닦이는지 확인
                gridView.SettingGridView();
            }
            catch
            {
                MessageBox.Show("선택후 진행해 주세요");
            }
            

        }

        private void buttonSelcet_Click(object sender, EventArgs e) //검색버튼
        {
            string textbox = textBoxSelect.Text;

            //라디오 버튼에 따라 쿼리 보내기
            string query = "";

            //textbox에 아무것도 없을때, 날짜 검색 x
            if (textbox==""&&radioButtonDate.Checked==false)
            {
                MessageBox.Show("전체 검색");

                query = "Select id AS '번호'," +
                        "(SELECT name FROM Employee WHERE 등록자id=identification) AS 등록자" +
                        ",날짜,부서,업무종류,업무내용,SUBSTR(시작시간,12) AS 시작시간,SUBSTR(종료시간,12) AS 종료시간 FROM 일일업무등록,업무마스터 WHERE 업무마스터id=업무번호"; //전체검색

                gridView.SettingSelect(query);
                gridView.SettingGridView();

                return;

            }

            if (radiobuttonNow == null) //아무것도 선택 안했을때
            {
                MessageBox.Show("검색 항목을 선택해주세요");
                return;
            }

 

            switch (radiobuttonNow)
            {
                case "날짜": //날짜로 select로 쿼리
                    //타임피커에서 값 가져오기
                    DateTime dt = dateTimePicker1.Value; //지정한 날자를 불러옴
                    string date = string.Format("{0}-{1}-{2}", dt.Year, dt.Month, dt.Day);//가져온 날짜의 모양 변경
                    //타임 피커를 날짜 튜플에서 겁색 쿼리
                    
                    query = "Select id AS '번호'," +
                            "(SELECT name FROM Employee WHERE 등록자id=identification) AS 등록자" +
                            ",날짜,부서,업무종류,업무내용,SUBSTR(시작시간,12) AS 시작시간,SUBSTR(종료시간,12) AS 종료시간 FROM 일일업무등록,업무마스터 WHERE 업무마스터id=업무번호 AND 날짜='" + date + "'";

                    break;
                case "키워드": //키워드로 select 쿼리 **
                    //소분류에서 키워드 검색 *** 중분류,대분류 검색해야할 수 도 있음 *** 수정 주의

                    query = "Select id AS '번호'," +
                            "(SELECT name FROM Employee WHERE 등록자id=identification) AS 등록자" +
                            ",날짜,부서,업무종류,업무내용,SUBSTR(시작시간,12) AS 시작시간,SUBSTR(종료시간,12) AS 종료시간 FROM 일일업무등록,업무마스터 WHERE 업무마스터id=업무번호 AND 업무내용 LIKE '%" + textbox + "%'";


                    break;
                case "등록자": //등록자 기반 검색 select
                    //유저 이름으로 검색
                      
                    query = "Select id AS '번호',name AS '등록자',날짜," +
                        "(SELECT 부서 FROM 업무마스터 WHERE 업무마스터id=업무번호) AS 부서," +
                        "(SELECT 업무종류 FROM 업무마스터 WHERE 업무마스터id=업무번호) AS 업무종류," +
                        "(SELECT 업무내용 FROM 업무마스터 WHERE 업무마스터id=업무번호) AS 업무내용" +
                        ",SUBSTR(시작시간,12) AS 시작시간,SUBSTR(종료시간,12) AS 종료시간 FROM 일일업무등록,Employee WHERE 등록자id=identification AND name LIKE '%" + textbox + "%'";

                    break;
            }

            //검색 쿼리 보내기
            gridView.SettingSelect(query);

            //gridview 새로 그리기
            gridView.SettingGridView();

        }


        #region 라디오 버튼 이벤트
   
        private void radioButtonDate_CheckedChanged(object sender, EventArgs e) // 날짜
        {
            //타임 피커 보이기, text 안보이기
            dateTimePicker1.Visible = true;
            textBoxSelect.Visible = false;
            textBoxSelect.Text = ""; //text지우기
            radiobuttonNow = "날짜";
        }

        private void radioButtonKeyword_CheckedChanged(object sender, EventArgs e) //키워드
        {
            //text 보이기, 타임피커 안보이기
            dateTimePicker1.Visible = false;
            textBoxSelect.Visible = true;
            radiobuttonNow = "키워드";
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e) // 등록자
        {
            //text 보이기, 타임피커 안보이기
            dateTimePicker1.Visible = false;
            textBoxSelect.Visible = true;
            radiobuttonNow = "등록자";
        }

        #endregion

       
    }
}
