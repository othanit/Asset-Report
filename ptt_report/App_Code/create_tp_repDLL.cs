using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ptt_report.App_Code
{
    public class create_tp_repDLL
    {

        public void inserttbl_tp_Rep(string year,string permit,string status, string patrolling_status,string cp_status,                        string ilipig_status, string wall_thick_status, string project_status, string apendixB_status, string apendixD_status, string apendixH_status, string apendixI_status, string create_date, string update_date, string create_id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " INSERT INTO tblt_p_rep (year,permit,status,patrolling_status,cp_status,ilipig_status,wall_thick_status,project_status,apendixB_status,apendixD_status,apendixH_status,apendixI_status,create_date,update_date,create_id,update_id,active)" +
              "VALUES('"
              + year + "', '"
              + permit + "', '"
              + status + "', '"
              + patrolling_status + "', '"
              + cp_status + "', '"
              + ilipig_status + "','"
              + wall_thick_status + "','"
              + project_status + "','"
              + apendixB_status + "','"
              + apendixD_status + "','"
              + apendixH_status + "', '"
              + apendixI_status + "', '"
              + create_date + "','"
              + update_date + "','"
              + create_id + "','"
              + update_id + "',1)";
    
           objConn.ConnectionString = ConfigurationManager.ConnectionStrings["dbptt_repConnectionString"].ConnectionString;
            objConn.Open();
            var _with1 = objCmd;
            _with1.Connection = objConn;
            _with1.CommandText = strSQL;
            _with1.CommandType = CommandType.Text;

            objCmd.ExecuteNonQuery();

            dtAdapter = null;
            objConn.Close();
            objConn = null;
        }

        public bool CheckExistingTPRep(string year, string permit)
        {

            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select top(1)* from tblt_p_rep where year = '" + year + "' and permit = '" + permit + "' ";

            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["dbptt_repConnectionString"].ConnectionString;
            var _with1 = objCmd;
            _with1.Connection = objConn;
            _with1.CommandText = strSQL;
            _with1.CommandType = CommandType.Text;
            dtAdapter.SelectCommand = objCmd;

            dtAdapter.Fill(ds);
            dt = ds.Tables[0];

            dtAdapter = null;
            objConn.Close();
            objConn = null;

            //dt

            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

    }
}