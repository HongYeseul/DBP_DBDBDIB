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
    /*B.(10) 나의 결재 리스트 확인 기능 
        i.	내가 등록한 결재들의 진행 사항
        ii.	결재 중 내역
        iii.	결재 완료 내역
        iv.	내가 결재해야 할 업무 리스트 
    */

    public partial class ApprovalListForm : Form
    {
        private string what_Appr = ""; //불러올 테이블 조건
        //int id = Convert.ToInt32(UserInfo.Getinstance().Id); //로그인 계정
        int id = 5500001;
        public ApprovalListForm()
        {
            InitializeComponent();
            combo_Appr.Text = "";
            dgv_MyApprList.Columns.Clear();
            dgv_MyApprList.Rows.Clear();
        }

        private void combo_Appr_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_MyApprList.Rows.Clear();
            switch (combo_Appr.Text) //콤보박스 선택 변경마다 조건 변경
            {
                case "모든 결재 내역":
                    what_Appr = "기안자 ='"+ id + "'"; 
                    //내가 기안자인 모든 결재 내역 :: 기안자 = 로그인한 계정
                    break;
                case "결재 중 내역":
                    what_Appr = "기안자 ='" + id + "' AND 진행상황 < 결재자수";
                    //내가 기안자인 결재 중 내역 :: 기안자 = 로그인한 계정 and 진행상황 != 결재자수
                    break;
                case "결재 완료 내역":
                    what_Appr = "기안자 ='" + id + "' AND 진행상황 = 결재자수";
                    //내가 기안자인 결재 완료 내역 :: 기안자 = 로그인한 계정 and 진행상황 = 결재자수
                    break;
                case "결재할 내역":
                    what_Appr = "제1결재자 = '" + id + "' OR 제2결재자 = '" + id + "' OR 제3결재자 = '" + id + "'";  
                    //내가 결재할 차례인 모든 결재 내역 :: 결재자1 = 로그인한 계정 || 결재자2 = 로그인한 계정 || 결재자3 = 로그인한 계정
                    break;
            }
            string query = "SELECT * FROM 결재 WHERE " + what_Appr ;
            MySqlDataReader rdr = DBManager.GetInstance().select(query); //테이블 가져오기

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dgv_MyApprList.DataSource = dt;
            rdr.Close();
        }
    }
}
