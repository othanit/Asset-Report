using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ptt_report.App_Code
{
    public class tpreportDLL
    {
        public DataTable GetRep_year()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select distinct(year) from tblquarter_rep order by year desc ; ";

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

        public DataTable GetRep_quarter()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select distinct(quarter) from tblquarter_rep order by quarter desc ; ";

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
        public DataTable GetRep_cus_type()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select distinct(cus_type) from tblquarter_rep; ";

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
        public DataTable GetRep_status()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select distinct(status) from tblquarter_rep; ";

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
        public DataTable GetRep_list(string cus_type, string year, string quarter, string status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblquarter_rep where cus_type like '%" + cus_type + "%' ";

            if (year != "")
            {
                strSQL += " and year = '" + year + "' ";
            }
            if (quarter != "")
            {
                strSQL += " and quarter = '" + quarter + "' ";
            }
            if (status != "")
            {
                strSQL += " and status = '" + status + "'  ";
            }



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
        public DataTable GetHistoryLinkByIdDelete(string id)
        {

            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from dbo.tblt_p_rep WHERE id = " + id + " and patrolling_status  in ('Assign','In Process') and cp_status in ('Assign','In Process') and ilipig_status in ('Assign','In Process') and wall_thick_status in ('Assign','In Process') " +
                " and project_status in ('Assign','In Process') and apendixB_status in ('Assign','In Process') and apendixD_status in ('Assign','In Process') and apendixH_status in ('Assign','In Process') and apendixI_status in ('Assign','In Process') ";


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
        public DataTable GetHistoryLinkByIdApprove(string id,string f_status)
        {

            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from dbo.tblt_p_rep WHERE id = " + id + " and " + f_status + " in ('Assign','In Process','Reject') ";


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
        public DataTable GetHistoryLinkByIdReject(string id,string f_status)
        {

            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from dbo.tblt_p_rep WHERE id = " + id + " and " + f_status + " in ('Assign','In Process')";


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
        public void delete_tblquarter_rep(string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " delete tblquarter_rep where id = '" + id + "' ";


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

        public DataTable GetTPPermit(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tppermit where tp_rep_id =  '" + tp_id + "' ";

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

        public DataTable Inserttppermit(string tp_rep_id, string gaspipemaintain, string projectname, string pipepath, string cerfno)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tppermit(tp_rep_id,gaspipemaintain,projectname,pipepath,cerfno) " +
                    " values('" +

                    tp_rep_id + "','"
                    + gaspipemaintain + "','"
                    + projectname + "','"
                    + pipepath + "','"
                    + cerfno +

                    "'); select @@IDENTITY as id; ";

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

        public void Updatetppermit(string tp_rep_id, string gaspipemaintain, string projectname, string pipepath, string cerfno, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tppermit set gaspipemaintain = '" + gaspipemaintain +
                "',projectname = '" + projectname +
                "',pipepath = '" + pipepath +
                "',cerfno = '" + cerfno +
                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; ";

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

        public DataTable GetTPExecutiveSummary(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpexecutivesummary where tp_rep_id =  '" + tp_id + "' ";

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

        public DataTable Inserttpexecutivesummary(string tp_rep_id, string detail)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpexecutivesummary(tp_rep_id,detail) " +
                    " values('" +

                    tp_rep_id + "','"
                    + detail +

                    "'); select @@IDENTITY as id; ";

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

        public void Updatetpexecutivesummary(string tp_rep_id, string detail, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tpexecutivesummary set detail = '" + detail +

                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; ";

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

        public DataTable GetTPPatrolling(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tppatrolling where tp_rep_id =  '" + tp_id + "' ";

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

        public DataTable InserttpPatrolling(string tp_rep_id, string gasdetector, string gassiteamount, string gassitedetail, string labelandstealamount, string labelandstealdetail, string testpostdamageamount, string testpostdamagedetail, string scourareaamount, string scourareadetail, string buildingpipepathamount, string buildingpipepathdetail, string rovfreespanamount, string rovfreespandetail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tppatrolling(tp_rep_id,gasdetector,gassiteamount,gassitedetail,labelandstealamount,labelandstealdetail,testpostdamageamount,testpostdamagedetail,scourareaamount,scourareadetail,buildingpipepathamount,buildingpipepathdetail,rovfreespanamount,rovfreespandetail,opinion) " +
                    " values('"

                    + tp_rep_id + "','"
                    + gasdetector + "','"
                    + gassiteamount + "','"
                    + gassitedetail + "','"
                    + labelandstealamount + "','"
                    + labelandstealdetail + "','"
                    + testpostdamageamount + "','"
                    + testpostdamagedetail + "','"
                    + scourareaamount + "','"
                    + scourareadetail + "','"
                    + buildingpipepathamount + "','"
                    + buildingpipepathdetail + "','"
                    + rovfreespanamount + "','"
                    + rovfreespandetail + "','"
                    + opinion +

                    "'); select @@IDENTITY as id; ";

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

        public void UpdatetpPatrolling(string tp_rep_id, string gasdetector, string gassiteamount, string gassitedetail, string labelandstealamount, string labelandstealdetail, string testpostdamageamount, string testpostdamagedetail, string scourareaamount, string scourareadetail, string buildingpipepathamount, string buildingpipepathdetail, string rovfreespanamount, string rovfreespandetail, string opinion, string id, string update_id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tppatrolling set gasdetector = '" + gasdetector +

                "',gassiteamount = '" + gassiteamount +
                "',gassitedetail = '" + gassitedetail +
                "',labelandstealamount = '" + labelandstealamount +

                                "',labelandstealdetail = '" + labelandstealdetail +
                "',testpostdamageamount = '" + testpostdamageamount +
                "',testpostdamagedetail = '" + testpostdamagedetail +

                                "',scourareaamount = '" + scourareaamount +
                "',scourareadetail = '" + scourareadetail +
                "',buildingpipepathamount = '" + buildingpipepathamount +

                                "',buildingpipepathdetail = '" + buildingpipepathdetail +
                "',rovfreespanamount = '" + rovfreespanamount +
                "',rovfreespandetail = '" + rovfreespandetail +


                                "',opinion = '" + opinion +
                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; "+
                "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + tp_rep_id + "' where id = '" + tp_rep_id + "';  ";

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


        public DataTable GetTPCP(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpcp where tp_rep_id =  '" + tp_id + "' ";

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

        public DataTable InserttpCP(string tp_rep_id, string cipsdetail, string cipsopinion, string dcvgdetail, string dcvgopinion, string ptsdetail, string ptsopinion, string rovdetail, string rovopinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpcp(tp_rep_id,cipsdetail,cipsopinion,dcvgdetail,dcvgopinion,ptsdetail,ptsopinion,rovdetail,rovopinion) " +
                    " values('"

                    + tp_rep_id + "','"
                    + cipsdetail + "','"
                    + cipsopinion + "','"
                    + dcvgdetail + "','"
                    + dcvgopinion + "','"
                    + ptsdetail + "','"
                    + ptsopinion + "','"
                    + rovdetail + "','"
                    + rovopinion +

                    "'); select @@IDENTITY as id; ";

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

        public void UpdatetpCP(string tp_rep_id, string cipsdetail, string cipsopinion, string dcvgdetail, string dcvgopinion, string ptsdetail, string ptsopinion, string rovdetail, string rovopinion, string id, string update_id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tpcp set cipsdetail = '" + cipsdetail +

                "',cipsopinion = '" + cipsopinion +
                "',dcvgdetail = '" + dcvgdetail +
                "',dcvgopinion = '" + dcvgopinion +

                                "',ptsdetail = '" + ptsdetail +
                "',ptsopinion = '" + ptsopinion +
                "',rovdetail = '" + rovdetail +

                                "',rovopinion = '" + rovopinion +

                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; "+
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + tp_rep_id + "' where id = '" + tp_rep_id + "';  ";
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

        public DataTable GetRep_HisALL()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select top(1) * from tbl_history_rep where rep_type ='2' order by version desc  ; ";

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

        public DataTable GetTempRep()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbl_tem_file where flag_active =  'y' and report_type = '2' ";

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

        public DataTable InsertHistory(string last_update, string createid, string filename, string uri, string rep_type, string version,string quarter_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Insert into tbl_history_rep(last_update,createid,filename,uri,rep_type,version,t_p_rep_id) " +
                    " values('" + last_update + "', '" + createid + "', '" + filename + "', '" + uri + "', '" + rep_type + "', '" + version + "','" + quarter_rep_id + "'); select @@IDENTITY as id; ";

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
        public void UpdateStatus_rep(string mas_rep_id, string update_id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = "  update tblt_p_rep set  " + f_status +" = 'Approve',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "';  " +


                " update tblt_p_rep set status = 'Approve' " +
                " where patrolling_status  = 'Approve' and cp_status = 'Approve' and ilipig_status = 'Approve' and wall_thick_status = 'Approve' " +
                " and project_status = 'Approve' and apendixB_status = 'Approve' and apendixD_status = 'Approve' and apendixH_status = 'Approve' and apendixI_status = 'Approve' ";

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
        public void UpdateStatus_Reject(string mas_rep_id, string update_id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = "  update tblt_p_rep set  " + f_status +"= 'Reject',update_date = getdate(),update_id = '" + update_id + "' where id = '" + mas_rep_id + "' and wall_thick_status in ('Assign','In Process') ;  " +

                " update tblt_p_rep set status = 'Reject' " +
                " where patrolling_status  = 'Reject' and cp_status = 'Reject' and ilipig_status = 'Reject' and wall_thick_status = 'Reject' " +
                " and project_status = 'Reject' and apendixB_status = 'Reject' and apendixD_status = 'Reject' and apendixH_status = 'Reject' and apendixI_status = 'Reject' ";

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
        //public void UpdateHistory(string version, string filename, string id, string uri)
        //{
        //    SqlConnection objConn = new SqlConnection();
        //    SqlCommand objCmd = new SqlCommand();
        //    SqlDataAdapter dtAdapter = new SqlDataAdapter();

        //    DataSet ds = new DataSet();
        //    DataTable dt = null;
        //    string strSQL = null;

        //    strSQL = " Update tbl_history_rep set version = '" + version + "',filename = '" + filename + "' " + ", uri = '" + uri + "'" +
        //            " where id = '" + id + "' ";

        //    objConn.ConnectionString = ConfigurationManager.ConnectionStrings["dbptt_repConnectionString"].ConnectionString;
        //    objConn.Open();
        //    var _with1 = objCmd;
        //    _with1.Connection = objConn;
        //    _with1.CommandText = strSQL;
        //    _with1.CommandType = CommandType.Text;

        //    objCmd.ExecuteNonQuery();

        //    dtAdapter = null;
        //    objConn.Close();
        //    objConn = null;

        //}
        public void UpdateHistory(string version, string filename, string id, string quarter_rep_id, string uri)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Update tbl_history_rep set version = '" + version + "',filename = '" + filename + "', t_p_rep_id = '" + quarter_rep_id + "'" + ", uri = '" + uri + "'" +
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












        public DataTable GetTPILIPIG(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpilipig where tp_rep_id =  '" + tp_id + "' ";

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


        public DataTable Inserttpilipig(string tp_rep_id, string externalmetalloss, string internalmetalloss, string mechanicaldamage, string remark, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpilipig(tp_rep_id,externalmetalloss,internalmetalloss,mechanicaldamage,remark,opinion) " +
                    " values('"

                    + tp_rep_id + "','"
                    + externalmetalloss + "','"
                    + internalmetalloss + "','"
                    + mechanicaldamage + "','"
                    + remark + "','"
                    + opinion +
                    "'); select @@IDENTITY as id; ";

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

        public void Updatetpilipig(string tp_rep_id, string externalmetalloss, string internalmetalloss, string mechanicaldamage, string remark, string opinion, string id, string update_id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tpilipig set externalmetalloss = '" + externalmetalloss +

                "',internalmetalloss = '" + internalmetalloss +
                "',mechanicaldamage = '" + mechanicaldamage +
                "',remark = '" + remark +
                "',opinion = '" + opinion +

                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; "+
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + tp_rep_id + "' where id = '" + tp_rep_id + "';  ";
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

        public DataTable GetTPwtn(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpwallthickness where tp_rep_id =  '" + tp_id + "' ";

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


        public DataTable GetTPwtn_sub(string wtn_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpwallthickness_sub where wtn_id = '" + wtn_id + "' ";

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

        public DataTable Inserttpwtm(string tp_rep_id, string checkresult, string pipe, string station, string pipeposition, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpwallthickness(tp_rep_id,checkresult,pipe,station,pipeposition,opinion) " +
                    " values('"

                    + tp_rep_id + "','"
                    + checkresult + "','"
                    + pipe + "','"
                    + station + "','"
                    + pipeposition + "','"
                    + opinion +
                    "'); select @@IDENTITY as id; ";

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

        public void Updatetpwtn(string tp_rep_id, string checkresult, string pipe, string station, string pipeposition, string opinion, string id, string update_id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tpwallthickness set checkresult = '" + checkresult +

                "',pipe = '" + pipe +
                "',station = '" + station +
                "',pipeposition = '" + pipeposition +
                "',opinion = '" + opinion +

                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; "+
            
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + tp_rep_id + "' where id = '" + tp_rep_id + "';  ";
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

        public void Inserttpwtn_sub(string wtn_id, string bvstation, string routecode, string inspectiondate, string point, string diameter, string tavg, string tmin)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpwallthickness_sub(wtn_id,bvstation,routecode,inspectiondate,point,diameter,tavg,tmin) " +
                    " values('" +

                    wtn_id + "','"
                    + bvstation + "','"
                    + routecode + "','"
                    + inspectiondate + "','"
                    + point + "','"
                    + diameter + "','"
                    + tavg + "','"
                    + tmin +

                    "'); ";

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

        public void Updatetpwtn_sub(string wtn_id, string bvstation, string routecode, string inspectiondate, string point, string diameter, string tavg, string tmin, string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " update tpwallthickness_sub set wtn_id = '" + wtn_id +
                "',bvstation = '" + bvstation +
                "',routecode = '" + routecode +
                "',inspectiondate = '" + inspectiondate +
                "',point = '" + point +
                "', " + " diameter = '" + diameter +
                "', " + " tavg = '" + tavg +
                "',tmin = '" + tmin +
                "' where id = '" + id + "'; " +

            "  update tblt_p_rep set status = 'In Process', wall_thick_status = 'In Process',update_date = getdate(),update_id = '" + wtn_id + "' where id = '" + wtn_id + "';  ";

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

        public void Deletetpwtn_sub(string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " delete tpwallthickness_sub where id = '" + id + "' ";

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


        public DataTable GetTPProject(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpproject where tp_rep_id =  '" + tp_id + "' ";

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

        public DataTable GetTPProject_sub(string project_id, string order_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpproject_sub where project_id = '" + project_id + "' AND " +
                "order_id = '" + order_id + "'";

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

        public DataTable Inserttpproject(string tp_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpproject(tp_rep_id) " +
                    " values('"

                    + tp_rep_id +
                    "'); select @@IDENTITY as id; ";

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

        public void Inserttpproject_sub(string project_id, string order_id, string projectname, string detail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpproject_sub(project_id,order_id,projectname,detail,opinion) " +
                    " values('" +

                    project_id + "','"
                    + order_id + "','"
                    + projectname + "','"
                    + detail + "','"
                    + opinion +

                    "'); ";

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

        public void Updatetpproject_sub(string project_id, string order_id, string projectname, string detail, string opinion, string id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " update tpproject_sub set project_id = '" + project_id +
                "',order_id = '" + order_id +
                "',projectname = '" + projectname +
                "',detail = '" + detail +
                "',opinion = '" + opinion +
                "' where id = '" + id + "' "+
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + project_id + "' where id = '" + project_id + "';  ";

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

        public void Deletetpproject_sub(string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " delete tpproject_sub where id = '" + id + "' ";

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

        public DataTable GetTPAppendixB(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpappendixb where tp_rep_id =  '" + tp_id + "' ";

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

        public DataTable GetTPAppendixB_sub(string appendixb_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpappendixb_sub where appendixb_id = '" + appendixb_id + "'";

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

        public DataTable InsertTPAppendixB(string tp_rep_id, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpappendixb(tp_rep_id, opinion) " +
                    " values('"

                    + tp_rep_id + "','"
                    + opinion +
                    "'); select @@IDENTITY as id; ";

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

        public void UpdateTPAppendixB(string tp_rep_id, string opinion, string id, string update_id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tpappendixb set opinion = '" + opinion +
                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; "+
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + tp_rep_id + "' where id = '" + tp_rep_id + "';  ";
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

        public void InsertTPAppendixB_sub(string appendixb_id, string routecode, string buildingwork, string scour, string label, string testpost, string trespass, string gasleak, string abnormal)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpappendixb_sub(appendixb_id,routecode,buildingwork,scour,label,testpost,trespass,gasleak,abnormal) " +
                    " values('" +

                    appendixb_id + "','"
                    + routecode + "','"
                    + buildingwork + "','"
                    + scour + "','"
                                        + label + "','"
                    + testpost + "','"
                    + trespass + "','"
                                        + gasleak + "','"
                    + abnormal +

                    "'); ";

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

        public void UpdateTPAppendixB_sub(string appendixb_id, string routecode, string buildingwork, string scour, string label, string testpost, string trespass, string gasleak, string abnormal, string id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " update tpappendixb_sub set appendixb_id = '" + appendixb_id +
                "',routecode = '" + routecode +
                "',buildingwork = '" + buildingwork +
                "',scour = '" + scour +
                "',label = '" + label +
                                "',testpost = '" + testpost +
                "',trespass = '" + trespass +
                "',gasleak = '" + gasleak +
                                "',abnormal = '" + abnormal +
                "' where id = '" + id + "' "+
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + appendixb_id + "' where id = '" + appendixb_id + "';  ";
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

        public void DeleteTPAppendixB_sub(string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " delete tpappendixb_sub where id = '" + id + "' ";

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


        public DataTable GetTPAppendixD(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpappendixd where tp_rep_id =  '" + tp_id + "' ";

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

        public DataTable GetTPAppendixD_sub(string appendixd_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpappendixd_sub where appendixd_id = '" + appendixd_id + "'";

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

        public DataTable InsertTPAppendixD(string tp_rep_id, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpappendixd(tp_rep_id, opinion) " +
                    " values('"

                    + tp_rep_id + "','"
                    + opinion +
                    "'); select @@IDENTITY as id; ";

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
        public void UpdateTPAppendixI(string tp_rep_id, string opinion, string id, string update_id, string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tpappendixd set opinion = '" + opinion +
                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; " +
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + tp_rep_id + "' where id = '" + tp_rep_id + "';  ";
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
        public void UpdateTPAppendixD(string tp_rep_id, string opinion, string id, string update_id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tpappendixd set opinion = '" + opinion +
                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; "+
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + tp_rep_id + "' where id = '" + tp_rep_id + "';  ";
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

        public void InsertTPAppendixD_sub(string appendixd_id, string routecode, string survey)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpappendixd_sub(appendixd_id,routecode,survey) " +
                    " values('" +

                    appendixd_id + "','"
                    + routecode + "','"
                    + survey +

                    "'); ";

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
        public void UpdateTPAppendixI_sub(string appendixd_id, string routecode, string survey, string id, string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " update tpappendixd_sub set appendixd_id = '" + appendixd_id +
                "',routecode = '" + routecode +
                "',survey = '" + survey +

                "' where id = '" + id + "' " +
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + appendixd_id + "' where id = '" + appendixd_id + "';  ";
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
        public void UpdateTPAppendixD_sub(string appendixd_id, string routecode, string survey, string id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " update tpappendixd_sub set appendixd_id = '" + appendixd_id +
                "',routecode = '" + routecode +
                "',survey = '" + survey +

                "' where id = '" + id + "' "+
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + appendixd_id + "' where id = '" + appendixd_id + "';  ";
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

        public void DeleteTPAppendixD_sub(string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " delete tpappendixd_sub where id = '" + id + "' ";

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

        public DataTable GetTPAppendixH(string tp_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpappendixh where tp_rep_id =  '" + tp_id + "' ";

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

        public DataTable GetTPAppendixH_sub(string appendixd_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tpappendixh_sub where appendixd_id = '" + appendixd_id + "'";

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

        public DataTable InsertTPAppendixH(string tp_rep_id, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpappendixh(tp_rep_id, opinion) " +
                    " values('"

                    + tp_rep_id + "','"
                    + opinion +
                    "'); select @@IDENTITY as id; ";

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

        public void UpdateTPAppendixH(string tp_rep_id, string opinion, string id, string update_id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tpappendixh set opinion = '" + opinion +
                "' " +
                " where tp_rep_id = '" + tp_rep_id + "' and id = '" + id + "'; "+
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + tp_rep_id + "' where id = '" + tp_rep_id + "';  ";
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

        public void InsertTPAppendixH_sub(string appendixd_id, string routecode, string secondhalfyear, string firsthalfyear)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tpappendixh_sub(appendixd_id,routecode,secondhalfyear,firsthalfyear) " +
                    " values('" +

                    appendixd_id + "','"
                    + routecode + "','"
                    + secondhalfyear + "','"
                    + firsthalfyear +

                    "'); ";

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

        public void UpdateTPAppendixH_sub(string appendixd_id, string routecode, string secondhalfyear, string firsthalfyear, string id,string f_status)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " update tpappendixh_sub set appendixd_id = '" + appendixd_id +
                "',routecode = '" + routecode +
                "',secondhalfyear = '" + secondhalfyear +
                "',firsthalfyear = '" + firsthalfyear +
                "' where id = '" + id + "' "+
            "  update tblt_p_rep set status = 'In Process', " + f_status + "= 'In Process',update_date = getdate(),update_id = '" + appendixd_id + "' where id = '" + appendixd_id + "';  ";
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

        public void DeleteTPAppendixH_sub(string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " delete tpappendixh_sub where id = '" + id + "' ";

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

        public DataTable GetHistoryLinkById(string id)
        {

            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select top(1) * from tbl_history_rep where t_p_rep_id = " + id + " order by version desc  ; ";

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