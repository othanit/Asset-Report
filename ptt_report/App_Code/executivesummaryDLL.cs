using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ptt_report.App_Code
{
    public class executivesummaryDLL
    {

        public DataTable GetExistRep(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblExecutive_summary where quarter_rep_id = '" + master_rep_id + "' ";

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

        public DataTable GetExecutiveOtherRep(string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblExecutive_summary_other where excutive_rep_id =  '" + id + "' ";

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

        public DataTable InsertExecutive_selectid(string quarter_rep_id, string partolling_info1, string partolling_info2, string partolling_info3, string partolling_info4, string rov_info1, string rov_info2, string rov_info3,
                        string rov_info4, string da_info1, string da_info2, string da_info3, string da_info4, string erosion_info1, string erosion_info2, string erosion_info3, string erosion_info4, string subsite_info1, string subsite_info2, string subsite_info3,
                        string subsite_info4, string ec_info1, string ec_info2, string ec_info3, string ec_info4, string exterCorr_info1, string exterCorr_info2, string exterCorr_info3, string exterCorr_info4, string exterCorr_info5, string interCorr_info1,
                        string interCorr_info2, string interCorr_info3, string interCorr_info4, string interCorr_info5, string da2_info1, string da2_info2, string da2_info3, string da2_info4, string offshore_info1, string offshore_info2, string offshore_info3,
                        string offshore_info4, string offshore2_info1, string offshore2_info2, string offshore2_info3, string offshore2_info4)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Insert Into tblExecutive_summary(quarter_rep_id,partolling_info1,partolling_info2,partolling_info3,partolling_info4,rov_info1,rov_info2,rov_info3, " +
                    " rov_info4,da_info1,da_info2,da_info3,da_info4,erosion_info1,erosion_info2,erosion_info3,erosion_info4,subsite_info1,subsite_info2,subsite_info3, " +
                    " subsite_info4,ec_info1,ec_info2,ec_info3,ec_info4,exterCorr_info1,exterCorr_info2,exterCorr_info3,exterCorr_info4,exterCorr_info5,interCorr_info1, " +
                    " interCorr_info2,interCorr_info3,interCorr_info4,interCorr_info5,da2_info1,da2_info2,da2_info3,da2_info4,offshore_info1,offshore_info2,offshore_info3, " +
                    " offshore_info4,offshore2_info1,offshore2_info2,offshore2_info3,offshore2_info4) " +
                    " values('" + quarter_rep_id + "', '" + partolling_info1 + "', '" + partolling_info2 + "', '" + partolling_info3 + "', '" + partolling_info4 + "', '" + rov_info1 + "', '" + rov_info2 + "', '" + rov_info3 + "', " +
                    " '" + rov_info4 + "', '" + da_info1 + "', '" + da_info2 + "', '" + da_info3 + "', '" + da_info4 + "', '" + erosion_info1 + "', '" + erosion_info2 + "', '" + erosion_info3 + "', '" + erosion_info4 + "', '" + subsite_info1 + "', '" + subsite_info2 + "', '" + subsite_info3 + "', " +
                    " '" + subsite_info4 + "', '" + ec_info1 + "', '" + ec_info2 + "', '" + ec_info3 + "', '" + ec_info4 + "', '" + exterCorr_info1 + "', '" + exterCorr_info2 + "', '" + exterCorr_info3 + "', '" + exterCorr_info4 + "', '" + exterCorr_info5 + "', '" + interCorr_info1 + "', " +
                    " '" + interCorr_info2 + "', '" + interCorr_info3 + "', '" + interCorr_info4 + "', '" + interCorr_info5 + "', '" + da2_info1 + "', '" + da2_info2 + "', '" + da2_info3 + "', '" + da2_info4 + "', '" + offshore_info1 + "', '" + offshore_info2 + "', '" + offshore_info3 + "', " +
                    " '" + offshore_info4 + "', '" + offshore2_info1 + "', '" + offshore2_info2 + "', '" + offshore2_info3 + "', '" + offshore2_info4 + "'); select @@IDENTITY as id; ";

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

        public void Update_info1(string partolling_info1, string partolling_info2, string partolling_info3, string partolling_info4, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = "  update tblExecutive_summary set partolling_info1 = '" + partolling_info1 + "',partolling_info2 = '" + partolling_info2 + "', " +
                    " partolling_info3 = '" + partolling_info3 + "',partolling_info4 = '" + partolling_info4 + "' " +
                    " where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "';  " +

                    "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public void Update_info2(string rov_info1, string rov_info2, string rov_info3, string rov_info4, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary set rov_info1 = '" + rov_info1 + "',rov_info2 = '" + rov_info2 + "',rov_info3 = '" + rov_info3 + "',rov_info4 = '" + rov_info4 + "' " +
                    "  where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "'   " +

                      "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public void Update_info3(string da_info1, string da_info2, string da_info3, string da_info4, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary set da_info1 = '" + da_info1 + "',da_info2 = '" + da_info2 + "',da_info3 = '" + da_info3 + "',da_info4 = '" + da_info4 + "' " +
                    "  where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "'   " +

                    "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public void Update_info4(string erosion_info1, string erosion_info2, string erosion_info3, string erosion_info4, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary set erosion_info1 = '" + erosion_info1 + "',erosion_info2 = '" + erosion_info2 + "',erosion_info3 = '" + erosion_info3 + "',erosion_info4 = '" + erosion_info4 + "' " +
                    "  where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "'   " +

                    "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public void Update_info5(string subsite_info1, string subsite_info2, string subsite_info3, string subsite_info4, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary set subsite_info1 = '" + subsite_info1 + "',subsite_info2 = '" + subsite_info2 + "',subsite_info3 = '" + subsite_info3 + "',subsite_info4 = '" + subsite_info4 + "' " +
                    "  where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "'   " +

                    "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public void Update_info6(string exterCorr_info1, string exterCorr_info2, string exterCorr_info3, string exterCorr_info4, string exterCorr_info5, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary set exterCorr_info1 = '" + exterCorr_info1 + "',exterCorr_info2 = '" + exterCorr_info2 + "',exterCorr_info3 = '" + exterCorr_info3 + "',exterCorr_info4 = '" + exterCorr_info4 + "', " +
                    "  exterCorr_info5 = '" + exterCorr_info5 + "' where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "'   " +

                    "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public void Update_info7(string interCorr_info1, string interCorr_info2, string interCorr_info3, string interCorr_info4, string interCorr_info5, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary set interCorr_info1 = '" + interCorr_info1 + "',interCorr_info2 = '" + interCorr_info2 + "',interCorr_info3 = '" + interCorr_info3 + "',interCorr_info4 = '" + interCorr_info4 + "', " +
                    "  interCorr_info5 = '" + interCorr_info5 + "' where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "'   " +

                    "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public void Update_info8(string da2_info1, string da2_info2, string da2_info3, string da2_info4, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary set da2_info1 = '" + da2_info1 + "',da2_info2 = '" + da2_info2 + "',da2_info3 = '" + da2_info3 + "',da2_info4 = '" + da2_info4 + "' " +
                    "   where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "'   " +

                    "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public void Update_info9(string offshore_info1, string offshore_info2, string offshore_info3,
            string offshore_info4, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary set offshore_info1 = '" + offshore_info1 + "',offshore_info2 = '" + offshore_info2 + "',offshore_info3 = '" + offshore_info3 + "',offshore_info4 = '" + offshore_info4 + "' " +
                    "   where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "'   " +

                    "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public void Update_info10(string offshore2_info1, string offshore2_info2, string offshore2_info3, string offshore2_info4, string mas_rep_id, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary set offshore2_info1 = '" + offshore2_info1 + "',offshore2_info2 = '" + offshore2_info2 + "',offshore2_info3 = '" + offshore2_info3 + "',offshore2_info4 = '" + offshore2_info4 + "' " +
                    "   where quarter_rep_id = '" + mas_rep_id + "' and id = '" + id + "'   " +

                    "  update tblquarter_rep set status = 'In Process', exe_status = 'In Process',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  ";

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

        public DataTable InsertOtherProject(string excutive_rep_id, string project_name, string other_info1, string other_info2, string other_info3, string other_info4)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tblExecutive_summary_other(excutive_rep_id,project_name,other_info1,other_info2,other_info3,other_info4) " +
                    " values('" + excutive_rep_id + "','" + project_name + "','" + other_info1 + "','" + other_info2 + "','" + other_info3 + "','" + other_info4 + "'); select @@IDENTITY as id; ";

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

        public void UpdateOtherPro(string id, string excutive_rep_id, string project_name, string other_info1, string other_info2, string other_info3, string other_info4)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tblExecutive_summary_other  " +
                    " set project_name = '" + project_name + "', other_info1 = '" + other_info1 + "', other_info2 = '" + other_info2 + "', other_info3 = '" + other_info3 + "', other_info4 = '" + other_info4 + "' " +
                    " where excutive_rep_id = '" + excutive_rep_id + "' and id = '" + id + "' ";

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

        public void DeleteOtherPro(string excutive_rep_id, string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " delete from  tblExecutive_summary_other  " +
                    " where excutive_rep_id = '" + excutive_rep_id + "' and id = '" + id + "' ";

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

        public DataTable GetExistRep_j(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblili_pig where quarter_rep_id = '"
                + master_rep_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"].ConnectionString;

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

        public DataTable GetExistRep_k(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblchemical_treatment where quarter_rep_id = '"
                + master_rep_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"].ConnectionString;

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

        public DataTable InsertHistory(string last_update, string createid, string filename, string uri, string rep_type, string version, string quarter_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Insert into tbl_history_rep(last_update,createid,filename,uri,rep_type,version, quarter_rep_id) " +
                    " values('" + last_update + "', '" + createid + "', '" + filename + "', '" 
                    + uri + "', '" + rep_type + "', '" + version + "', '" + quarter_rep_id + "'); select @@IDENTITY as id; ";

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

        public DataTable GetExistRep_L(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbl_piping where quarter_rep_id = '" + master_rep_id + "' ";

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

        public DataTable Get_tbl_piping_qurter_plan1(string piping_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbl_piping_qurter_plan1 where pipg_id = '" + piping_id + "' ";

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

        public DataTable Get_tbl_piping_qurter_plan2(string piping_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbl_piping_qurter_plan2 where pipg_id = '" + piping_id + "' ";

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

        public DataTable GetSub6(string piping_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbl_piping_sub6 where pipg_id = '" + piping_id + "' ";

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

        public void UpdateHistory(string version,string filename, string id, string quarter_rep_id,string uri)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Update tbl_history_rep set version = '" + version + "',filename = '" + filename + "', quarter_rep_id = '" + quarter_rep_id + "'" + ", uri = '" + uri + "'" +
                    " where id = '" + id + "' ";

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

        public DataTable GetTempRep()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbl_tem_file where flag_active =  'y' and report_type = '1' ";

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

        public DataTable GetRep_HisALL()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select top(1) * from tbl_history_rep where rep_type ='1' order by version desc  ; ";

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

        public void UpdateStatus_rep(string mas_rep_id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = "  update tblquarter_rep set  exe_status = 'Approve',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  " +

                " update tblquarter_rep set status = 'Approve' " +
                " where exe_status  = 'Approve' and pm_cm_status = 'Approve' and external_status = 'Approve' and internal_status = 'Approve' " +
                " and piping = 'Approve' and offshore = 'Approve' and other_pro = 'Approve' ";

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
        public void UpdateStatus_Reject(string mas_rep_id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = "  update tblquarter_rep set  exe_status = 'Reject',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "' and exe_status in ('Assign','In Process');  " +

                " update tblquarter_rep set status = 'Reject' " +
                " where exe_status  = 'Reject' and pm_cm_status = 'Reject' and external_status = 'Reject' and internal_status = 'Reject' " +
                " and piping = 'Reject' and offshore = 'Reject' and other_pro = 'Reject' ";

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
        public DataTable GetExistRep1(string master_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select top(1)* from [dbo].[tblpatrolling] where [quarter_rep_id] = '" + master_id + "' ";

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
        public DataTable GetExistRep2(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbldirect_assessment where quarter_rep_id = '" + master_rep_id + "' ";

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
        public DataTable GetDARep_sub(string da_sub_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from [dbo].[tbldirect_assessment_sub] where da_sub_id = '" + da_sub_id + "'  " +
                    " and(dainfo1 <> '' or dainfo2 <> '' or dainfo3 <> '' or dainfo4 <> '' or dainfo5 <> '' or dainfo6 <> '') ";

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
        public DataTable GetExistRep3(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblsoil_erosion where quarter_rep_id = '" + master_rep_id + "' ";

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

        public DataTable GetExistRep3_sub(string soil_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblsoil_erosion_sub where soil_id = '" + soil_id + "' ";

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

        public DataTable GetExistRep4(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblsettlement_survey where quarter_rep_id = '" + master_rep_id + "' ";

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

        public DataTable GetExistRep4_sub(string ss_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblsettlement_survey_sub where ss_id = '" + ss_id + "' ";

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

        public DataTable GetExistRep5(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblrov where quarter_rep_id = '" + master_rep_id + "' ";

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

        public DataTable GetExistRep6(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblfreespan where quarter_rep_id = '" + master_rep_id + "' ";

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

        public DataTable GetExistRep_h(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblexternal_corrosion where quarter_rep_id = '"
                + master_rep_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"].ConnectionString;

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

        public DataTable GetExistRep_sub_cathodicresult(string ec_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblexternalcorrosion_sub_cathodicresult where ec_id = '"
                + ec_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"]
                .ConnectionString;

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

        public DataTable GetExistRep_sub_cipsstatus(string ec_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblexternalcorrosion_sub_cipsstatus where ec_id = '"
                + ec_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"]
                .ConnectionString;

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

        public DataTable GetExistRep_sub_cipsstatus_activity(string ec_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblexternalcorrosion_sub_cipsstatus_activity where ec_id = '"
                + ec_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"]
                .ConnectionString;

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
        public DataTable GetExistRep_i(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblcleaning_pig where quarter_rep_id = '"
                + master_rep_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"].ConnectionString;

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

        public DataTable GetExistRep_sub_pigresult(string cp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblcleaningpig_sub_pigresult where cp_id = '"
                + cp_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"]
                .ConnectionString;

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

        public DataTable GetExistRep_sub_replan(string cp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblcleaningpig_sub_replan where cp_id = '"
                + cp_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"]
                .ConnectionString;

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

        public DataTable GetExistRep_M(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblrbi where quarter_rep_id = '"
                + master_rep_id + "' ";

            objConn.ConnectionString = ConfigurationManager
                .ConnectionStrings["dbptt_repConnectionString"].ConnectionString;

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

        public DataTable GetExistRep_G(string master_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblother_projects where quarter_rep_id = '" + master_rep_id + "' ";

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

        public DataTable GetExistRep_sub_G(string op_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblother_project_sub where op_id = '" + op_id + "'  ";

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


    }
}