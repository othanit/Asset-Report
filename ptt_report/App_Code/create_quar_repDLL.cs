using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ptt_report.App_Code
{
    public class create_quar_repDLL
    {
        public DataTable GetRep(string year, string quarter)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblquarter_rep where year = '" + year + "' and quarter = '" + quarter + "' " +
                " and cus_type in ('Transmission','NGV','NGR') ";

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

            return dt;
        }
        public void Insert_tblquarter_rep(string year, string quarter, string cus_type, string status, string exe_status, string pm_cm_status, string external_status,
            string internal_status, string piping,string offshore,string  other_pro, string create_date, string update_date, string create_id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Insert Into tblquarter_rep(year,quarter,cus_type ,status, exe_status,pm_cm_status,external_status,internal_status,piping,offshore,other_pro,create_date,update_date,create_id,update_id, active) " +
                    " values('" + year + "','" + quarter + "','" + cus_type + "', '" + status + "','" + exe_status + "','" + pm_cm_status + "', " +
                    " '" + external_status + "','" + internal_status + "','" + piping + "','"+offshore+"','"+other_pro+"', " + 
                    " '" + create_date + "','" + update_date + "', '" + create_id + "','" + update_id + "', 1) ";


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







    }
}