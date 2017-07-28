using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.DirectoryServices;


namespace ptt_report.App_Code
{
    public class defaultDLL
    {
        public DataTable GetUserByUsernamePassword(string username, string password)
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
                    " u.* " +
                    " from tbluser as u left join tbldelete_user as d on u.userid = d.userid " +
                    " where u.username = '" + username + "' and password = '" + password + "'  ";

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

        public DataTable GetUserByEmail(string email)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select top(1)* from tbluser where email = '" + email + "'  ";

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

        public void UpdatePassword(string username, string password_new)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update tbluser set password = '" + password_new + "' where username = '" + username + "'  ";


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

        //================ PTT Login =============

        public DataTable GetUserPTT_info(string usercode)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select u.unitname,p.* from personel_info p inner join unit_key u on p.UNITCODE = u.unitcode " +
                        " where code = '"+ usercode.Replace("sp","") + "'  ";

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

        public DataTable GetUserPTT_autho(string usercode)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tblpttAutho " +
                        " where ptt_code = '" + usercode.Replace("sp", "") + "'  ";

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
        public bool SetupSession(string username, string password)
        {
            string strUsername = "";
            string strRealName = "";
            bool bRet = false;
            string myDomain = "PTT";
            //string myDomain = "PTTGRP";

            strUsername = HttpContext.Current.User.Identity.Name;

            //string str = string.Format("LDAP://{0}", myDomain);
            //string str2 = string.Format((@"{0}\" + username), myDomain);

            string domainName = "LDAP://ldap.ptt.corp"; //แนะนำให้ใช้เก็บค่า web.config
            //string str = "LDAP://ldap.pttgrp.corp";

            var Entry = new DirectoryEntry(domainName, username, password);
            var Searcher = new DirectorySearcher(Entry);
            Searcher.Filter = "(&(ObjectClass=user)(SAMAccountName=" + username + "))";
            SearchResultCollection results;
            try
            {
                results = Searcher.FindAll();
                if (results.Count > 0)
                {
                    bRet = true;
                }
            }
            catch (Exception ex)
            {
                bRet = false;
            }
            //SetupSession = bRet;
            return bRet;
        }

        public bool CheckPasswordPTT(string sUserID, string sPassword)
        {
            bool bRet = false;

            if (SetupSession(sUserID, sPassword) == true)
            {
                bRet = true;
            }
            return bRet;
        }





    }
}