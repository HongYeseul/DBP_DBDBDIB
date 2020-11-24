using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Specialized;
using System.Buffers;

namespace DBDBDIB
{
    /*
     * 필요한 것: Datagridview에 띄울거 보내주는 애 / 텍스트박스 받아서 쿼리 DB매니져로 보내주는애-사원등록 수정 삭제에만 관여/ 받아서 값 주는애:이건 datagrid로 받아서 주는편이 좋을지도. 
     * 
     * */
    class HRInfo
    {
        #region define forEmp
        public string searchDept { get; set; }
        public string searchYear { get; set; }
        public string searchName { get; set; }
        public string empID { get; set; }
        public string empName { get; set; }
        public string empgender { get; set; }
        public string empBirth { get; set; }
        public string empPhone { get; set; }
        public string empCategory { get; set; }
        public string empRank { get; set; }
        public string empPost { get; set; }
        public string empAddress1 { get; set; }
        public string empAddress2 { get; set; }
        public string empPassword { get; set; }
        public string empPasswordCheck { get; set; }
        public string empEmail { get; set; }
        #endregion
        #region dept forDept
        public string deptID { get; set; }
        public string deptName { get; set; }
        public string deptMaster { get; set; }
        #endregion

        public DataTable selectDGV(string select, string from, string where)
        {
            string query = "SELECT "+select+" FROM "+from+where;
            MySqlDataReader rdr = DBManager.GetInstance().select(query);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            rdr.Close();
            return dt;
        }
        public void insertHRData(string table, string column, string data)
        {
            string query = "INSERT INTO "+table+" ("+column+") VALUES ("+data+")";
            DBManager.GetInstance().DBquery(query);
        }
        public void updateHRData(string extra,string table, string data)
        {
            string query = "UPDATE " + table + " SET " + data;
            DBManager.GetInstance().DBquery(extra+query);
        }
        public void deleteHRData(string table, string need)
        {
            string query = "";
            query += "DELETE FROM " + table + " WHERE " + need;
            DBManager.GetInstance().DBquery(query);
        }
        public string insertQuery(int type)
        {
            string query = "";
            string add = "";
            string dept = "";

            switch (type)
            {
                case 1:
                    dept = Convert.ToString(selectDGV("ID", "부서", " WHERE 부서명='" + empCategory + "'").Rows[0][0]);
                    add = empPost + "/" + empAddress1 + "/" + empAddress2 ;
                    query = "'"+empPassword+"', '"+empName+ "', '"+empgender+ "', '"+empBirth+ "','"+empPhone+ "',"+dept+ ",'"+empRank+ "','"+add+ "','"+empEmail+"',1";
                    break;
                case 2:
                    query = "'"+deptName+"',"+deptMaster+",1";
                    break;
            }
            return query;
        }
        public string updateQuery(int type)
        {
            string query = "";
            string add = "";
            string dept = "";

            switch (type)
            {
                case 1:
                    dept=Convert.ToString(selectDGV("ID", "부서", " WHERE 부서명='" + empCategory + "'").Rows[0][0]);
                    add =empPost+"/"+empAddress1+"/"+empAddress2;
                    query = @"name='" + empName + "', gender='" + empgender + "', birthDay='" + empBirth + "', phoneNum='" + empPhone + "', department=" + dept+ ", position='" + empRank + "', address ='" + add + "', password='" + empPassword + "' WHERE identification="+empID;
                    break;
                case 2:
                    query = @"부서명='" + deptName + "',부서장='" + deptMaster + "' WHERE ID=" + deptID;
                    break;
                case 3:
                    query = @"valid=0 WHERE ID=" + deptID;
                    break;
                case 4:
                    query= @"valid=0 WHERE identification="+empID;
                    break;
            }
            return query;
        }
        public string searchQuery(int type)
        {
            string query = "";
            switch (type)
            {
                case 0:
                    query += " ";
                    break;
                case 1:
                    query += " AND department=" + searchDept;
                    break;
                case 2:
                    query += " AND YEAR(birthDay)='" + searchYear + "'";
                    break;
                case 3:
                    query += " AND department=" + searchDept + " AND YEAR(birthDay)='" + searchYear+"'";
                    break;
                case 4:
                    query += " AND name='" + searchName + "'";
                    break;
                case 5:
                    query += " AND department=" + searchDept + " AND name='" + searchName + "'";
                    break;
                case 6:
                    query += " AND YEAR(birthDay)='" + searchYear + "' AND name='" + searchName + "'";
                    break;
                case 7:
                    query += " AND department=" + searchDept + " AND YEAR(birthDay)='" + searchYear + "' AND name='" + searchName + "'";
                    break;
                case 8:
                    query += " WHERE department = ID AND department="+deptID+" AND identification=" + deptMaster ;
                    break;
                case 10:
                    query += " WHERE department>1 AND ID = (SELECT MAX(ID) FROM 부서)";
                    break;
            }
            return query;
        }
        
        public string deleteQuery()
        {//DELETE FROM erp_school.Employee WHERE identification = (SELECT identification FROM (SELECT identification FROM erp_school.부서,erp_school.Employee WHERE identification = 5500003 AND department = ID AND 부서명='소속없음')as 직원)
            string query= "identification in (SELECT identification FROM erp_school.부서,erp_school.Employee WHERE identification = "+empID+" AND department = ID AND 부서명='"+empCategory+"')";
            return query;
        }
        public void ChangeDept(string ID,int parameter)
        {
            string query = "";
            switch (parameter)
            {
                case 1:
                    query = @"UPDATE Employee SET position='부서장',department=" + ID + " WHERE identification=" + deptMaster;
                    break;
                case 2:
                    query = @"UPDATE Employee SET position='부서장',department=" + ID + " WHERE identification=" + deptMaster + ";" +
                           "UPDATE Employee SET position='사원' WHERE identification in (SELECT Identification FROM (SELECT identification FROM Employee WHERE identification <> " + deptMaster + " AND position='부서장' AND department=" + deptID + ") AS 사원)";
                    break;
            }                          
            DBManager.GetInstance().DBquery(query);
        }
    }
}
