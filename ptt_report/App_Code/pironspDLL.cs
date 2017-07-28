using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ptt_report.App_Code
{
    public class pironspDLL
    {

        public DataTable GetExistRep(string master_rep_id)
        {
            return null;
        }

        public DataTable GetPIROnSPPipeline(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_pipeline where pir_id =  '" + pir_id + "' ";

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

        public DataTable Insertpironsp_pipeline(string pir_id, string startupyear, string designpresure, string station, string maop, string length, string wallthickness, string olc, string materialspec, string designlife, string externalcoating, string cathodicprotection, string op, string ot, string gfr, string lastilipig, string crusedforrem, string proboffailure, string assessmentdate, string overallremainlife, string remainlife, string overalldesignlife, string inspectionyear, string b31gpsi, string burstpressure, string erf, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_pipeline(pir_id,startupyear,designpresure,station,maop,length,wallthickness,olc, materialspec, designlife,externalcoating,cathodicprotection,op,ot,gfr,lastilipig,crusedforrem,     proboffailure, assessmentdate,overallremainlife,remainlife,overalldesignlife,inspectionyear,b31gpsi,burstpressure,erf,opinion) " +
                " values('" +

                pir_id + "','"
                + startupyear + "','"
                + designpresure + "','"
                + station + "','"
                + maop + "','"
                + length + "','"
                + wallthickness + "','"
                + olc + "','"
                + materialspec + "','"
                + designlife + "','"
                + externalcoating + "','"
                + cathodicprotection + "','"
                + op + "','"
                + ot + "','"
                + gfr + "','"
                + lastilipig + "','"
                + crusedforrem + "','"
                + proboffailure + "','"
                + assessmentdate + "','"
                + overallremainlife + "','"
                + remainlife + "','"
                + overalldesignlife + "','"
                + inspectionyear + "','"
                + b31gpsi + "','"
                + burstpressure + "','"
                + erf + "','"
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

        public void Updatepironsp_pipeline(string pir_id, string startupyear, string designpresure, string station, string maop, string length, string wallthickness, string olc,string materialspec, string designlife, string externalcoating, string cathodicprotection, string op, string ot, string gfr, string lastilipig, string crusedforrem, string proboffailure, string assessmentdate, string overallremainlife, string remainlife, string overalldesignlife, string inspectionyear, string b31gpsi, string burstpressure, string erf, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_pipeline set startupyear = '" + startupyear +
                "',designpresure = '" + designpresure +
                "',station = '" + station +
                "',maop = '" + maop +
                "',length = '" + length +
                "',wallthickness = '" + wallthickness +
                "',olc = '" + olc +
                "',materialspec = '" + materialspec +
                "',designlife = '" + designlife +
                "',externalcoating = '" + externalcoating +
                "',cathodicprotection = '" + cathodicprotection +
                "',op = '" + op +
                "',ot = '" + ot +
                "',gfr = '" + gfr +


                "',lastilipig = '" + lastilipig +
                "',crusedforrem = '" + crusedforrem +
                "',proboffailure = '" + proboffailure +
                "',assessmentdate = '" + assessmentdate +
                "',overallremainlife = '" + overallremainlife +
                "',remainlife = '" + remainlife +
                "',overalldesignlife = '" + overalldesignlife +
                "',inspectionyear = '" + inspectionyear +
                "',b31gpsi = '" + b31gpsi +
                "',burstpressure = '" + burstpressure +
                "',erf = '" + erf +



                "',opinion = '" + opinion +
                "' " +
                " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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

        public DataTable GetPIROnSPInternelCorrosionControlSystem(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_iccs where pir_id =  '" + pir_id + "' ";

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

        public DataTable Insertpironsp_iccs(string pir_id, string ci,  string cc, string cp, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_iccs(pir_id,ci,cc,cp, opinion) " +
                    " values('" +

                    pir_id + "','"
                    + ci + "','"

                    + cc + "','"

                    + cp + "','"

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


        public void Updatepironsp_iccs(string pir_id, string ci, string cc,  string cp,  string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_iccs set ci = '" + ci +

                "',cc = '" + cc +

                "',cp = '" + cp +

                "',opinion = '" + opinion +
                "' " +
                " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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


        public DataTable GetPIROnSPLastestMaintainanceActivity(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_lma where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsp_lma(string pir_id, string yearofcips, string yearofmfl, string yearofgeo, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_lma(pir_id,yearofcips,yearofmfl,yearofgeo,opinion) " +
                    " values('" +

                    pir_id + "','"
                    + yearofcips + "','"
                    + yearofmfl + "','"
                    + yearofgeo + "','"
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



        public void Updatepironsp_lma(string pir_id, string yearofcips, string yearofmfl, string yearofgeo, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            string strSQL = null;

            strSQL = " update pironsp_lma set yearofcips = '" + yearofcips +
                "',yearofmfl = '" + yearofmfl +
                "',yearofgeo = '" + yearofgeo +
                "',opinion = '" + opinion +
                "' " +
                " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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



        public DataTable GetPIROnSP_ecra(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_ecra where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsp_ecra(string pir_id, string sumresult, string cp, string ecdmp, string ecrp, string detail, string mflpresult, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_ecra(pir_id,sumresult,cp,ecdmp,ecrp, detail,opinion) " +
                    " values('" +

                    pir_id + "','"
                    + sumresult + "','"
                    + cp + "','"
                    + ecdmp + "','"
                    + ecrp + "','"
                    + detail + "','"
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


        public void Updatepironsp_ecra(string pir_id, string sumresult, string cp, string nscp, string cds, string ac, string ecdmp, string ecrp, string detail, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_ecra set sumresult = '" + sumresult +
                "',cp = '" + cp +
                                "',nscp = '" + nscp +
                                                "',cds = '" + cds +
                                                                "',ac = '" + ac +
                "',ecdmp = '" + ecdmp +
                "',ecrp = '" + ecrp +
                "',detail = '" + detail +
                "',opinion = '" + opinion +
                "' " +
                " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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

        public DataTable GetPIRonSP_icra(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_icra where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsp_icra(string pir_id, string sumresult, string wcm, string dew, string co2, string h2s, string isdmp, string icrp, string detail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_icra(pir_id,sumresult,wcm,dew,co2,h2s,isdmp, icrp,detail,opinion) " +
                    " values('" +

                    pir_id + "','"
                    + sumresult + "','"
                    + wcm + "','"
                    + dew + "','"
                    + co2 + "','"
                    + h2s + "','"
                    + isdmp + "','"
                    + icrp + "','"
                    + detail + "','"
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

        public void Updatepironsp_icra(string pir_id, string sumresult, string wcm, string dew, string co2, string h2s, string isdmp, string icrp, string detail, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_icra set sumresult = '" + sumresult +
                "',wcm = '" + wcm +
                "',dew = '" + dew +
                "',co2 = '" + co2 +
                "',h2s = '" + h2s +
                "',isdmp = '" + isdmp +
                "',icrp = '" + opinion +
                "',detail = '" + detail +
                "',opinion = '" + opinion +
                "' " +
                " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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


        public DataTable GetPIRonSPMechanical(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_md where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsu_md(string pir_id, string sumresult, string ccd, string dent, string al, string rowcondition, string detail, string manualdetail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_md(pir_id,sumresult,ccd,dent,al,rowcondition,detail, manualdetail,opinion) " +
                    " values('" +

                    pir_id + "','"
                    + sumresult + "','"
                    + ccd + "','"
                    + dent + "','"
                    + al + "','"
                    + rowcondition + "','"
                    + detail + "','"
                    + manualdetail + "','"
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


        public void Updatepironsp_md(string pir_id, string sumresult, string ccd, string dent, string al, string rowcondition, string detail, string manualdetail, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_md set sumresult = '" + sumresult +
                "',ccd = '" + ccd +
                "',dent = '" + dent +
                "',al = '" + al +
                "',rowcondition = '" + rowcondition +
                "',detail = '" + detail +
                "',manualdetail = '" + manualdetail +
                "',opinion = '" + opinion +
                "' " +
                " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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



        public DataTable GetPIRonSP_fsra(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_fsra where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsp_fsra(string pir_id, string sumresult, string detail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_fsra(pir_id,sumresult,eps,detail, opinion) " +
                                 " values('" +

                                 pir_id + "','"
                                 + sumresult + "','"
                                 + detail + "','"
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


        public void Updatepironsp_fsra(string pir_id, string sumresult, string detail, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_fsra set sumresult = '" + sumresult +
                             "',detail = '" + detail +
                             "',opinion = '" + opinion +
                             "' " +
                             " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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


        public DataTable GetPIRonLeakage(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_leakage where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsp_leakage(string pir_id, string sumresult, string lsp, string lplem, string llr, string detail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_leakage(pir_id,sumresult, lsp, lplem, llr,detail, opinion) " +
                                 " values('" +

                                 pir_id + "','"
                                 + sumresult + "','"
                                 +lsp + "','"
                                 +lplem + "','"
                                 +llr + "','"
                                 + detail + "','"
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


        public void Updatepironsp_leakage(string pir_id, string sumresult, string lsp, string lplem, string llr, string detail, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsu_prh set sumresult = '" + sumresult +
                        "',lsp = '" + lsp +
                        "',lplem = '" + lplem +
                        "',llr = '" + llr +
                        "',detail = '" + detail +
                        "',opinion = '" + opinion +
                        "' " +
                            " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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


        public DataTable GetPIRonprh(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_prh where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsp_prh(string pir_id, string sumresult,string detail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_prh(pir_id,sumresult,detail, opinion) " +
                                 " values('" +

                                 pir_id + "','"
                                 + sumresult + "','"
                                 + detail + "','"
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


        public void Updatepironsp_prh(string pir_id, string sumresult, string detail, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_prh set sumresult = '" + sumresult +
                        "',detail = '" + detail +
                        "',opinion = '" + opinion +
                        "' " +
                            " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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

        public DataTable GetPIRonSPRecommedation(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_comment where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsp_comment(string pir_id, string detail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_comment(pir_id,detail, opinion) " +
                    " values('" +

                    pir_id + "','"
                    + detail + "','"
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


        public void Updatepironsp_comment(string pir_id, string detail, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_comment set detail = '" + detail +
                "',opinion = '" + opinion +
                "' " +
                " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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


        public DataTable GetPIRonSP_tip(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_tpi where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsp_tpi(string pir_id, string sumresult, string detail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_tpi(pir_id,sumresult,eps,detail, opinion) " +
                                 " values('" +

                                 pir_id + "','"
                                 + sumresult + "','"
                                 + detail + "','"
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


        public void Updatepironsp_tip(string pir_id, string sumresult, string detail, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_tpi set sumresult = '" + sumresult +
                             "',detail = '" + detail +
                             "',opinion = '" + opinion +
                             "' " +
                             " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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


        public DataTable GetPIRonSP_lgs(string pir_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from pironsp_lgs where pir_id =  '" + pir_id + "' ";

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


        public DataTable Insertpironsp_lgs(string pir_id, string sumresult, string eps, string fs, string ss, string detail, string opinion)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " insert into pironsp_lgs(pir_id,sumresult,eps,fs,ss,detail, opinion) " +
                                 " values('" +

                                 pir_id + "','"
                                 + sumresult + "','"
                                 + eps + "','"
                                 + fs + "','"
                                 + ss + "','"
                                 + detail + "','"
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


        public void Updatepironsp_lgs(string pir_id, string sumresult, string eps, string fs, string ss, string detail, string opinion, string id, string update_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " update pironsp_lgs set sumresult = '" + sumresult +
                                             "',eps = '" + eps +
                             "',fs = '" + fs +
                             "',ss = '" + ss +
                             "',detail = '" + detail +
                             "',opinion = '" + opinion +
                             "' " +
                             " where pir_id = '" + pir_id + "' and id = '" + id + "'; ";

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

            strSQL = " select top(1) * from tbl_history_rep where rep_type ='4' order by version desc  ; ";

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

        ///////////// save version //////////////
        public DataTable GetTempRep()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " select * from tbl_tem_file where flag_active =  'y' and report_type = '4' ";

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

        public DataTable InsertHistory(string last_update, string createid, string filename, string uri, string rep_type, string version, string quarter_rep_id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Insert into tbl_history_rep(last_update,createid,filename,uri,rep_type,version,quarter_rep_id) " +
                    " values('" + last_update + "', '" + createid + "', '" + filename + "', '" + uri + "', '" + rep_type + "', '" + version + "', '"+ quarter_rep_id + "'); select @@IDENTITY as id; ";

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

        public void UpdateHistory(string version, string filename, string id)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
            string strSQL = null;

            strSQL = " Update tbl_history_rep set version = '" + version + "',filename = '" + filename + "' " +
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


    }
}