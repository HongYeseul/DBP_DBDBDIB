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
    public partial class ApprovalListForm : Form
    {
        private string what_Appr = ""; //불러올 테이블 조건
        private string query = "";
        int id = Convert.ToInt32(UserInfo.Getinstance().Id); //로그인 계정
        public ApprovalListForm()
        {
            InitializeComponent();
            combo_Appr.Text = "";
        }

        private void combo_Appr_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combo_Appr.Text) //콤보박스 선택 변경마다 조건 변경
            {
                case "모든 결재 내역":
                    what_Appr = "기안자 ='"+ id + "'";
                    query = "SELECT 기안자,제목,내용,관련업무,코멘트,진행상황,결재자수,제1결재자,제2결재자,제3결재자,기안자시간,1승인시간,2승인시간,3승인시간,반려메모 FROM 결재 WHERE " + what_Appr;
                    //내가 기안자인 모든 결재 내역 :: 기안자 = 로그인한 계정
                    break;
                case "결재 중 내역":
                    what_Appr = "기안자 ='" + id + "' AND 진행상황 < 결재자수";
                    query = "SELECT 기안자,제목,내용,관련업무,코멘트,제1결재자,제2결재자,제3결재자,기안자시간,1승인시간,2승인시간,3승인시간,반려메모 FROM 결재 WHERE " + what_Appr;
                    //내가 기안자인 결재 중 내역 :: 기안자 = 로그인한 계정 and 진행상황 != 결재자수
                    break;
                case "결재 완료 내역":
                    what_Appr = "기안자 ='" + id + "' AND 진행상황 = 결재자수";
                    query = "SELECT 기안자,제목,내용,관련업무,코멘트,제1결재자,제2결재자,제3결재자,기안자시간,1승인시간,2승인시간,3승인시간 FROM 결재 WHERE " + what_Appr;
                    //내가 기안자인 결재 완료 내역 :: 기안자 = 로그인한 계정 and 진행상황 = 결재자수
                    break;
                case "결재할 내역":
                    what_Appr = "진행상황 < 결재자수 AND ((진행상황 = 0 AND 제1결재자 = '" + id + "') OR" +
                        "(진행상황 = 1 AND 제2결재자 = '" + id + "') OR (진행상황 = 2 AND 제3결재자 = '" + id + "'))";
                    query = "SELECT 기안자,제목,내용,관련업무,코멘트,제1결재자,제2결재자,제3결재자,기안자시간,1승인시간,2승인시간,3승인시간,반려메모 FROM 결재 WHERE " + what_Appr;
                    //내가 결재할 차례인 모든 결재 내역 :: 결재자1 = 로그인한 계정 || 결재자2 = 로그인한 계정 || 결재자3 = 로그인한 계정
                    break;
            }
            MySqlDataReader rdr = DBManager.GetInstance().select(query); //테이블 가져오기

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dgv_MyApprList.DataSource = dt;
            rdr.Close();
        }
    }
}
