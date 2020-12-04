using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBDBDIB
{
    public partial class Mainform : Form
    {
        //지연 시간 잴 변수... 
        DateTime dtDelayStart;

        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;

            if (UserInfo.Getinstance().loginON == false)
                this.Close();
            else
            {
                MessageBox.Show(UserInfo.Getinstance().Name + "님 로그인 되셨습니다.");
                labelpersonname.Text = UserInfo.Getinstance().Name;
                labelpersonnum.Text = UserInfo.Getinstance().Id;
            }

            loadMsgNotification();

        }

        //필요없는 코드(?)
        private void DelaySystem(int MS)
        { 
            /* 함수명 : DelaySystem * 1000ms = 1초 
             * * 전달인자 : 얼마나 지연시킬것인가에 대한 변수 * 
             */
            DateTime dtAfter = DateTime.Now; 
            TimeSpan dtDuration = new TimeSpan(0, 0, 0, 0, MS); 
            DateTime dtThis = dtAfter.Add(dtDuration); 
            while (dtThis >= dtAfter)
            { 
                //DoEvent () 를 사용 해서 지연 시간 동안 
                //버튼 클릭 이벤트 및 다른 윈도우 이벤트를 받을 수 있게끔 하는 역할 
                //없으면 지연 동안 다른 이벤트를 받지 못함... 
                System.Windows.Forms.Application.DoEvents(); 
                //현재 시간 얻어 오기... 
                dtAfter = DateTime.Now; 
            } 
        }


        private void loadMsgNotification()
        {
            if (UserInfo.Getinstance().loginON == false)
                return;
            string query = "SELECT COUNT(*) as cnt FROM 쪽지 WHERE 수신확인 = '읽지않음' AND 받는사람 = " + UserInfo.Getinstance().Id;
            MySqlDataReader rdr = DBManager.GetInstance().select(query);

            rdr.Read();
            string cnt = rdr["cnt"].ToString();
            Console.WriteLine(cnt);

            if (Convert.ToInt32(cnt) != 0)
            {
                MessageBox.Show("아직 읽지않은 쪽지가 있습니다.");
                /*
                dtDelayStart = DateTime.Now;

                MsgNotify.Visible = true;
                //5초간 지연 
                DelaySystem(3000);
                MsgNotify.Visible = false;
                */
            }

            rdr.Close();
        }

        private void hideSubMenu() //상위 버튼(인사/업무/결재) 클릭 시 숨기는 용도
        {
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
            if (panel6.Visible == true)
                panel6.Visible = false;

        }

        private void showSubMenu(Panel submenu) //하위 메뉴 보임 숨김 토글
        {
            if (submenu.Visible == false)
            {
                hideSubMenu(); // 다른 하위 패널이 열려있을 때 닫아줌
                submenu.Visible = true;
            }
            else 
                submenu.Visible = false;

        }

        private void buttonHR_Click(object sender, EventArgs e) //인사 버튼
        {
            showSubMenu(panel3); //인사 하위 메뉴 보임 숨김
        }

        private void buttonEmp_Click(object sender, EventArgs e) //인사>사원등록 버튼
        {
            showChildForm(new Personnel());
        }

        private void buttonDept_Click(object sender, EventArgs e)//인사>부서/사원 관리 버튼
        {
            showChildForm(new Approval());
        }

        private void buttonAtt_Click(object sender, EventArgs e)//인사>급여내역서 버튼
        {
            showChildForm(new Attend());

        }
        private void buttonSalary_Click(object sender, EventArgs e)
        {
            showChildForm(new SalaryDetail());
        }
        private void button5_Click(object sender, EventArgs e)//업무 버튼
        {
            showSubMenu(panel4); //업무 하위 메뉴 보임 숨김
        }

        private Form activateForm = null;
        private void showChildForm(Form child) // 오른쪽 창에 다른 폼(매개변수) 열기
        {
            if (activateForm != null)
                activateForm.Close(); //열려는 폼 외에 다른 폼이 열려있다면 먼저 닫아줌
            activateForm = child; //열고 싶은 폼을 엶
            
            //서브 폼의 꾸밈 설정
            child.TopLevel = false; // 최상위가 아님> 왜 하는거지
            child.FormBorderStyle = FormBorderStyle.None; //테두리 없음
            child.Dock = DockStyle.Fill; //(패널)중앙에 고정

            panel5.Controls.Add(child); //패널에 열려는 폼 추가
            panel5.Tag = child; //폼 설정..
            child.BringToFront();
            child.Show(); // 폼 보이기

            //열려는 폼은 패널의 크기에 맞춰서 만들기
        }

        private void buttonTodayWork_Click(object sender, EventArgs e)
        {
            showChildForm(new TodayWork());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panel6);
        }

        private void buttonForPaymentReg_Click(object sender, EventArgs e)
        {
            showChildForm(new Payment_Registration1());
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            showChildForm(new taskmasterform());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showChildForm(new paymentform());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showChildForm(new ApprovalListForm());
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            showChildForm(new MessageMainForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Console.WriteLine("로그아웃");
            Properties.Settings.Default.ID = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();

            UserInfo.Getinstance().loginON = false;
            LoginForm loginForm = new LoginForm(); //새로운 로그인 폼 생성
            loginForm.Show(); //폼 보여주기
            Program.ac.MainForm = loginForm; //새로만든 폼을 program.cs의 메인 폼으로 교체
            this.Close(); //열려져 있던 메인 폼을 닫아줌
        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnChatting_Click(object sender, EventArgs e)
        {
            Chatting newForm = new Chatting();
            newForm.Show();
        }
    }
}
