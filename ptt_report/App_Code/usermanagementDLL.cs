using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ptt_report.App_Code
{
    public class usermanagementDLL
    {
        public DataTable GetUserBASByUsername(string username)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select case when d.authorize1 is null then 'n' else d.authorize1 end authorize1, " +
                    " case when d.authorize2 is null then 'n' else d.authorize2 end authorize2, " +
                    " case when d.authorize3 is null then 'n' else d.authorize3 end authorize3, " +
                    " case when d.authorize4 is null then 'n' else d.authorize4 end authorize4, " +
                    " case when d.flag_active is null then 'y' else d.flag_active end flag_active, " +
                    " u.*,u.fname+' '+u.lname as employee " +
                    " from tbluser as u inner join tbldelete_user as d on u.userid = d.userid  " +
                    " where(d.flag_active <> 'n' or d.flag_active is null) and (u.username like '%" + username + "%' or u.fname like '%" + username + "%' or u.lname like '%" + username + "%' ) ";

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

        public DataTable GetUserBASByUsername2(string userid)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select case when d.authorize1 is null then 'n' else d.authorize1 end authorize1, " +
                    " case when d.authorize2 is null then 'n' else d.authorize2 end authorize2, " +
                    " case when d.authorize3 is null then 'n' else d.authorize3 end authorize3, " +
                    " case when d.authorize4 is null then 'n' else d.authorize4 end authorize4, " +
                    " case when d.flag_active is null then 'y' else d.flag_active end flag_active, " +
                    " u.*,u.fname+' '+u.lname as employee " +
                    " from tbluser as u left join tbldelete_user as d on u.userid = d.userid " +
                    " where  (u.userid = '" + userid + "') ";

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

        public DataTable GetDelUserByUsername(string userid)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbldelete_user where userid = '" + userid + "' ";

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

        public DataTable GetDelUserByUserid(string userid)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbldelete_user where userid = '" + userid + "' ";

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
        public void UpdateDelUser(string userid)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tbldelete_user set flag_active = 'n' where userid = '" + userid + "'";


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

        public void UpdateDelUserAll(string authorize1, string authorize2, string authorize3, string authorize4, string flag_active, string update_date, string update_id, string userid)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tbldelete_user set authorize1='" + authorize1 + "',authorize2 = '" + authorize2 + "', " +
                    " authorize3 = '" + authorize3 + "',authorize4 = '" + authorize4 + "',flag_active = '" + flag_active + "', " +
                    " update_date = '" + update_date + "',update_id = '" + update_id + "' " +
                    " where userid = '" + userid + "' ";


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

        public void UpdatePassword(string password, string userid)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tbluser set password = '" + password + "' where userid = '" + userid + "' ";


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

        public DataTable InsertUser(string fname, string lname, string username, string password, string email, string roleid, string create_date, string create_id,
            string update_date, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into tbluser(fname,lname,username,password,email,roleid,create_date,create_id,update_date,update_id) " +
                " values('" + fname + "','" + lname + "','" + username + "','" + password + "','" + email + "','" + roleid + "', " +
                " '" + create_date + "','" + create_id + "','" + update_date + "','" + update_id + "') ; select @@IDENTITY as id;  ";

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

        public void InsertDelUser(string username, string authorize1, string authorize2, string authorize3, string authorize4, string flag_active,
            string create_date, string create_id, string update_date, string update_id, string userid)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Insert into tbldelete_user(username,authorize1,authorize2,authorize3,authorize4,flag_active,create_date,create_id, " +
                    " update_date,update_id,userid) " +
                    " values('" + username + "','" + authorize1 + "','" + authorize2 + "','" + authorize3 + "','" + authorize4 + "','" + flag_active + "','" + create_date + "','" + create_id + "', " +
                    " '" + update_date + "','" + update_id + "','" + userid + "') ";


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
        public DataTable GetRole()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblrole where flag_active = 'y' ";

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

        public DataTable GetDepartment()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select unitcode,unitcode + ' ' +unitname +' ('+ unitabbr +')' as department from unit_key order by unitcode, unitname, unitabbr ";

            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["dbpttConnectionString"].ConnectionString;
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
        public DataTable GetUserPTT(string unitcode, string search)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select u.unitname,p.code,p.FNAME+' '+p.LNAME as name, po.t_name as POSNAME " +
                    " from personel_info p inner " +
                    " join unit_key u on p.UNITCODE = u.unitcode " +
                    " inner join position po on p.POSCODE = po.poscode  ";

            if (unitcode != "")
            {
                strSQL += " where (p.unitcode = '" + unitcode + "' and p.code like '%" + search + "%') " +
                    " or (p.unitcode = '" + unitcode + "' and p.FNAME like '%" + search + "%') " +
                    " or (p.unitcode = '" + unitcode + "' and p.LNAME like '%" + search + "%') " +
                    " or (p.unitcode = '" + unitcode + "' and po.t_name like '%" + search + "%' ) ";
            }
            else
            {
                strSQL += " where (p.code like '%" + search + "%' or p.FNAME like '%" + search + "%' " +
                   " or p.LNAME like '%" + search + "%' or po.t_name like '%" + search + "%' ) ";
            }

            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["dbpttConnectionString"].ConnectionString;
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
        public DataTable GetPtt_AuTho(string ptt_code)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblpttAutho where ptt_code = '" + ptt_code + "' ";

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
        public void InserttblpttAutho(string authorize1, string authorize2, string authorize3, string authorize4,
            string ptt_code, string updateid)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Insert into tblpttAutho(authorize1,authorize2,authorize3,authorize4,ptt_code,updateid) " +
                    " values('" + authorize1 + "','" + authorize2 + "','" + authorize3 + "','" + authorize4 + "','" + ptt_code + "','" + updateid + "') ";


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

        public void UpdatetblpttAutho(string authorize1, string authorize2, string authorize3, string authorize4,
           string ptt_code, string updateid)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Update tblpttAutho " +
                " set authorize1 = '" + authorize1 + "', authorize2 = '" + authorize2 + "', " +
                " authorize3 = '" + authorize3 + "', authorize4 = '" + authorize4 + "', updateid = '" + updateid + "' " +
                " where ptt_code = '" + ptt_code + "' ";


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

        public DataTable GetUserBASByEmail(string Email)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select top(1) * from tbluser where email = '" + Email + "' ";

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