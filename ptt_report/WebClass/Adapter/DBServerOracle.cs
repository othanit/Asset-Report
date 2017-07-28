using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace ptt_report.WebClass.Adapter
{

    public class DBServerOracle {
        //OracleConnection objConn;
        //OracleCommand objCmd; 
        //OracleTransaction Trans;

        String DBConn = ConfigurationManager.ConnectionStrings["dbptt_oracle_BMAP"].ToString().Trim();
        public String connStr;

        public DBServerOracle() {
            connStr = "";
            connStr = DBConn;
        }

        public OracleDataReader QueryCommandDataReader(String strSQL) 
        { 
            OracleDataReader dtReader; 
            OracleCommand myCmd = new OracleCommand();
            OracleConnection myConn = new OracleConnection();

            try
            {
                myConn.ConnectionString = connStr;
                myConn.Open();

                myCmd.Connection = myConn;
                myCmd.CommandText = strSQL;
                myCmd.CommandType = CommandType.Text;

                dtReader = myCmd.ExecuteReader();
            }

            catch (OracleException oracleErr)
            {
                //Write the exception
                dtReader = null;
                throw new Exception(oracleErr.Message);
            }

            catch (Exception ex)
            {
                dtReader = null;
                throw ex;
            }
            
            finally 
            {
                myCmd.Dispose();
                myCmd = null;
                myConn.Close();
                myConn.Dispose();
                myConn = null;
            }

            return dtReader; //'*** Return DataReader ***'
        }

        public DataSet QueryCommandDataSet(string strSQL)
        {
            DataSet ds = new DataSet();
            OracleConnection myConn = new OracleConnection();
            OracleCommand myCmd = new OracleCommand();
            OracleDataAdapter dtAdapter = new OracleDataAdapter();
            
            try {
                myConn.ConnectionString = connStr;
                myConn.Open();
                
                myCmd.Connection = myConn;
                myCmd.CommandText = strSQL;
                myCmd.CommandType = CommandType.Text;
                
                dtAdapter.SelectCommand = myCmd;
                dtAdapter.Fill(ds);
            }

            catch (OracleException oracleErr)
            {
                //Write the exception
                ds = null;
                throw new Exception(oracleErr.Message);
            }

            catch (Exception ex)
            {
                ds = null;
                throw ex;
            }

            finally {
                dtAdapter.Dispose();
                dtAdapter = null;
                myCmd.Dispose();
                myCmd = null;
                myConn.Close();
                myConn.Dispose();
                myConn = null;
            }
            return ds;
            // *** Return DataSet ***'
        }

        public DataTable QueryCommandDataTable(string strSQL)
        {
            DataTable dt = new DataTable();
            OracleDataAdapter dtAdapter = new OracleDataAdapter();
            OracleCommand myCmd = new OracleCommand();
            OracleConnection myConn = new OracleConnection();
            
            try {
                myConn.ConnectionString = connStr;
                myConn.Open();
                
                myCmd.Connection = myConn;
                myCmd.CommandText = strSQL;
                myCmd.CommandType = CommandType.Text;
                
                dtAdapter.SelectCommand = myCmd;
                dtAdapter.Fill(dt);
            }

            catch (OracleException oracleErr)
            {
                //Write the exception
                dt = null;
                throw new Exception(oracleErr.Message);
            }

            catch (Exception ex)
            {
                dt = null;
                throw ex;
            }

            finally {
                dtAdapter.Dispose();
                dtAdapter = null;
                myCmd = null;
                myConn.Close();
                myConn.Dispose();
                myConn = null;
            }
            return dt;
            // *** Return DataTable ***'
        }

        public int QueryExecuteNonQuery(string strSQL)
        {
            int rs;
            OracleCommand myCmd = new OracleCommand();
            OracleConnection myConn = new OracleConnection();
            try
            {
                myConn.ConnectionString = connStr;
                myConn.Open();
                
                myCmd.Connection = myConn;
                myCmd.CommandText = strSQL;
                myCmd.CommandType = CommandType.Text;

                rs = myCmd.ExecuteNonQuery();
                // *** Return True ***'
            }

            catch (OracleException oracleErr)
            {
                //Write the exception
                rs = 0;
                throw new Exception(oracleErr.Message);
            }
            
            catch (Exception ex)
            {
                rs = 0;
                throw ex;
            }
            
            finally
            {
                myCmd.Dispose();
                myCmd = null;
                myConn.Close();
                myConn.Dispose();
                myConn = null;
            }
            return rs;
        }

        public object QueryExecuteScalar(string strSQL)
        {
            object myReturn;
            OracleCommand myCmd = new OracleCommand();
            OracleConnection myConn = new OracleConnection();
            try
            {
                myConn.ConnectionString = connStr;
                myConn.Open();

                myCmd.Connection = myConn;
                myCmd.CommandText = strSQL;
                myCmd.CommandType = CommandType.Text;

                myReturn = myCmd.ExecuteScalar();
                // *** Return Scalar ***'
            }

            catch (Exception ex) {
                myReturn = null;
                throw ex;
            }

            finally {
                myCmd.Dispose();
                myCmd = null;
                myConn.Close();
                myConn.Dispose();
                myConn = null;
            }
            return myReturn;
        }
    }
}