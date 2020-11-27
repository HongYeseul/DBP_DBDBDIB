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
    public partial class Payment_Registration1 : Form
    {
        //1페이지
        string id = UserInfo.Getinstance().Id;//기안자의 id
        string title="";//결재 제목
        string content="";//결재 내용
        int selectedId=0;//선택된 업무내용
        string coment="";//결재자 코멘트

        //2페이지
        int Approvercnt = 0;//몇번째 결재자를 선택했는지를 나타남 추가 버튼을 눌렀을때 이게 뭐냐의따라 호출함수가 달라짐
        int Apartid = 0;//부서 id
        string rank = "";//선택 직급
        int Approver1 = 0;//1결재자 id 0이면 안됨
        int Approver2 = 0;//2결재자 id 0이면 안됨
        Nullable<int>Approver3 = 0;//3결재자 id 널값일수 있어서 Nullable로 선언


        ForPaymentReg user = new ForPaymentReg();
        
        public Payment_Registration1()
        {
            InitializeComponent();
            SetForm1();
            //1번그룹박스보여주기 설정
            groupBoxForpay1.Visible = true;
            groupBoxForpay2.Visible = false;
        }
        
        public void SetForm1()
        {
            textBoxTitle.Text = "";
            textBoxContent.Text = "";
            textBoxSelected.Text = "";
            DataLoad();
            textBoxComent.Text = "";
           // groupBoxForpay1.Visible = true;
           // groupBoxForpay2.Visible = false;
        }
        public void SetForm2()
        {
            Approvercnt = 0;
            rank = "";
            Approver1 = 0;
            Approver2 = 0;
            Approver3 = 0;
            결재자1부서.Text = "";
            결재자1직급.Text = "";
            결재자1사원명.Text = "";
            결재자2부서.Text = "";
            결재자2직급.Text = "";
            결재자2사원명.Text = "";
            결재자3부서.Text = "";
            결재자3직급.Text = "";
            결재자3사원명.Text = "";
            listLoad_apart();
        }
        public void DataLoad()//1 페이지 그리드뷰 로드
        {
            DataTable work = user.SetWork();
            dataGridViewWork.DataSource = work;
           
        }
        
       private void dataGridViewWork_CellClick(object sender, DataGridViewCellEventArgs e)//그리드뷰에서 열 선택했을때
        {
            //int rowIndex = dataGridViewWork.CurrentRow.Index;
            int rowIndex = dataGridViewWork.CurrentCellAddress.Y;
            string num = dataGridViewWork.Rows[rowIndex].Cells[0].Value.ToString();
            selectedId = Convert.ToInt32(num);
            string work= dataGridViewWork.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxSelected.Text = work;
        }
        private void buttonNext_Click(object sender, EventArgs e)//다음 버튼눌렀을때
        {
            //제목, 코멘트, 관련업무가 null이 아님을 확인하는 변수
            int check = 0;
            //title,content,selectedId는 null즉 빈값이면 안됨
            title = textBoxTitle.Text;
            content = textBoxContent.Text;
            coment = textBoxComent.Text;
            if (title.Equals(""))
                ++check;
            if (content.Equals(""))
                ++check;
            if (selectedId == 0)
                ++check;
            if (check == 0)
            { //2번 그룹박스 보여주기
                groupBoxForpay1.Visible = false;
                groupBoxForpay2.Visible = true;
                SetForm2();
            }
            else
            {
                MessageBox.Show("제목, 내용, 업무선택은 필수 항목입니다.","재작성 요청");
            }
        }

        private void buttonPayment_Click(object sender, EventArgs e)//결재 버튼눌렀을때
        {
            int chckapprovernum = 0;
            if (coment.Equals(""))
                coment = null;
            if (Approver1 == 0)//1결재자 비었는지 체크
            {
                MessageBox.Show("1결재자와 2결재자는 필수 항목입니다.", "결재자 추가 요청");
                return;
            }
            else
                ++chckapprovernum;
            if (Approver2 == 0)//2결재자 비었는지 체크
            {
                MessageBox.Show("1결재자와 2결재자는 필수 항목입니다.", "결재자 추가 요청");
                return;
            }
            else
                ++chckapprovernum;
            if (Approver3 == 0)
                Approver3 = null;
            else
                ++chckapprovernum;

            if(chckapprovernum<2)
            {
                MessageBox.Show("1결재자와 2결재자는 필수 항목입니다.", "결재자 추가 요청");
                return;
            }
            else
            {
                 user.Insert_payment(Convert.ToInt32(id), title, content, selectedId, coment, chckapprovernum, Approver1, Approver2, Approver3);
                 MessageBox.Show("결재가 등록되었습니다.", "확인");
                 SetForm1();
                 SetForm2();
                 groupBoxForpay1.Visible = true;
                 groupBoxForpay2.Visible = false;
              
            }

            //초기화
            
        }

        private void listBoxApart_SelectedIndexChanged(object sender, EventArgs e)//부서 선택시
        {
            string Apart = listBoxApart.SelectedItem.ToString();
            MySqlDataReader apart = user.SearchApartId(Apart);
            while (apart.Read()) { 
            Apartid = Convert.ToInt32(apart["ID"]);
            }
            listLoad_rank(Apartid);//직급 세팅 호출
        }
        public void listLoad_apart()//부서 세팅
        {
            listBoxApart.Items.Clear();
            listBoxRank.Items.Clear();
            listBoxName.Items.Clear();
            MySqlDataReader apart = user.SetApart();
            while (apart.Read())
            {
                listBoxApart.Items.Add(apart["부서명"].ToString());
            }

        }
        public void listLoad_rank(int num)//직급 세팅
        {
            listBoxRank.Items.Clear();
            MySqlDataReader rank = user.SetRank(num);
            while (rank.Read())
            {
                listBoxRank.Items.Add(rank["position"].ToString());//position이 rank임
            }
        }

        private void listBoxRank_SelectedIndexChanged(object sender, EventArgs e)//직급 선택시 사원세팅
        {
            listBoxName.Items.Clear();
            rank = listBoxRank.SelectedItem.ToString();
            MySqlDataReader name = user.SetName(Apartid, rank);
            while(name.Read())
            {
                listBoxName.Items.Add(name["name"].ToString());
            }
        }

        private void radioButtonfirst_CheckedChanged(object sender, EventArgs e)//1결재자 체크시
        {
            Approvercnt = 1;
        }

        private void radioButtonSec_CheckedChanged(object sender, EventArgs e)//2결재자 체크시
        {
            Approvercnt = 2;
        }

        private void radioButtonThir_CheckedChanged(object sender, EventArgs e)//3결재자 체크시
        {
            Approvercnt = 3;
        }

        private void buttonAdd_Click(object sender, EventArgs e)//추가 버튼 클릭시
        {
            if (Approvercnt == 1)
            { SetApprover1(); }
            else if(Approvercnt==2)
            { SetApprover2(); }
            else if (Approvercnt==3)
            { SetApprover3(); }
        }
        public void SetApprover1()//1결재자 세팅
        {
            if (listBoxRank.SelectedItem == null || listBoxName.SelectedItem == null)
            {
                MessageBox.Show("1결재자의 부서, 직급, 나이를 선택해 부세요", "결재자 선택 요청");
                return; }
            rank = listBoxRank.SelectedItem.ToString();
            string name= listBoxName.SelectedItem.ToString();
           
            결재자1부서.Text= listBoxApart.SelectedItem.ToString();
            결재자1직급.Text = rank;
            결재자1사원명.Text = name;
            MySqlDataReader id = user.SearchId(Apartid,rank,name);
            while (id.Read())
            {
                Approver1=Convert.ToInt32(id["identification"]);
            }
            listLoad_apart();
        }
        public void SetApprover2()//2결재자 세팅
        {
            if (listBoxRank.SelectedItem == null || listBoxName.SelectedItem == null)
            {
                MessageBox.Show("2결재자의 부서, 직급, 나이를 선택해 부세요", "결재자 선택 요청");
                return; }
            rank = listBoxRank.SelectedItem.ToString();
            string name = listBoxName.SelectedItem.ToString();
          
            결재자2부서.Text = listBoxApart.SelectedItem.ToString();
            결재자2직급.Text = rank;
            결재자2사원명.Text = name;
            MySqlDataReader id = user.SearchId(Apartid, rank, name);
            while (id.Read())
            {
                Approver2 = Convert.ToInt32(id["identification"]);
            }
            listLoad_apart();
        }
        public void SetApprover3()//3결재자 세팅
        {
            if (listBoxRank.SelectedItem == null || listBoxName.SelectedItem == null)
            {
                MessageBox.Show("3결재자의 부서, 직급, 나이를 선택해 부세요", "결재자 선택 요청");
                return;
            }           rank = listBoxRank.SelectedItem.ToString();
            string name = listBoxName.SelectedItem.ToString();
        
            결재자3부서.Text = listBoxApart.SelectedItem.ToString();
            결재자3직급.Text = rank;
            결재자3사원명.Text = name;
            MySqlDataReader id = user.SearchId(Apartid, rank, name);
            while (id.Read())
            {
                Approver3 = Convert.ToInt32(id["identification"]);
            }
            listLoad_apart();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)//수정 클릭시
        {
            if (Approvercnt == 1 )
            { SetApprover1(); }
            else if (Approvercnt == 2 )
            { SetApprover2(); }
            else if (Approvercnt == 3 )
            { SetApprover3(); }
            else
                return;
        }

        private void buttonDel_Click(object sender, EventArgs e)//삭제 클릭시
        {
            if (Approvercnt == 1)
            { DelApprover1(); }
            else if (Approvercnt == 2)
            { DelApprover2(); }
            else if (Approvercnt == 3)
            { DelApprover3(); }
        }
        public void DelApprover1()//1결재자 삭제
        {
            if(Approver1==0)
            {
                MessageBox.Show("1결재자의 부서, 직급, 나이를 선택해 부세요", "결재자 선택 요청");
                return;
            }
            Approver1 = 0;
            결재자1부서.Text = "";
            결재자1직급.Text = "";
            결재자1사원명.Text = "";
        }
        public void DelApprover2()//2결재자 삭제
        {
            if (Approver2==0)
            {
                MessageBox.Show("2결재자의 부서, 직급, 나이를 선택해 부세요", "결재자 선택 요청");
                return;
            }
            Approver2 = 0;
            결재자2부서.Text = "";
            결재자2직급.Text = "";
            결재자2사원명.Text = "";
        }
        public void DelApprover3()//3결재자 삭제
        {
            if (Approver3==0)
            {
                MessageBox.Show("3결재자의 부서, 직급, 나이를 선택해 부세요", "결재자 선택 요청");
                return;
            }
            Approver3 = 0;
            결재자3부서.Text = "";
            결재자3직급.Text = "";
            결재자3사원명.Text = "";
        }
    }
}
