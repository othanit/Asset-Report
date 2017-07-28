using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ptt_report.WebClass.Adapter;
using ptt_report.WebClass.MappingTable;

namespace ptt_report.WebClass.SQLService
{
    public class BMAPServiceSelect
    {
        private string mySQL;
        private DBServerOracle dbServerCls = ClassFactory.getInstance().getDBServerOracle();

        public List<BMAP_LICENSE_TO_OPERATE> Select_BMAP_License_To_Operate(BMAP_LICENSE_TO_OPERATE inKey)
        {
            List<BMAP_LICENSE_TO_OPERATE> myReturn = new List<BMAP_LICENSE_TO_OPERATE>();
            BMAP_LICENSE_TO_OPERATE myData;
            DataSet myDS;
            int iRow;

            try
            {
                mySQL = "";
                mySQL += " SELECT objectid ";
                mySQL += " ,license_no ";
                mySQL += " ,license_name ";
                mySQL += " FROM license_to_operate ";

                mySQL += " WHERE objectid IS NOT NULL ";
                if (!string.IsNullOrEmpty(inKey.lng_object_id))
                {
                    mySQL += " AND objectid " + inKey.lng_object_id;
                }
                if (!string.IsNullOrEmpty(inKey.str_license_no))
                {
                    mySQL += " AND license_no " + inKey.str_license_no;
                }
                if (!string.IsNullOrEmpty(inKey.str_license_name))
                {
                    mySQL += " AND license_name " + inKey.str_license_name;
                }

                myDS = dbServerCls.QueryCommandDataSet(mySQL);

                if (myDS != null)
                {
                    if (myDS.Tables.Count > 0)
                    {
                        for (iRow = 0; iRow < myDS.Tables[0].Rows.Count; iRow++)
                        {
                            myData = new BMAP_LICENSE_TO_OPERATE();
                            if (!DBNull.Value.Equals(myDS.Tables[0].Rows[iRow]["objectid"]))
                            {
                                myData.lng_object_id = myDS.Tables[0].Rows[iRow]["objectid"].ToString().Trim();
                            }
                            if (!DBNull.Value.Equals(myDS.Tables[0].Rows[iRow]["license_no"]))
                            {
                                myData.str_license_no = myDS.Tables[0].Rows[iRow]["license_no"].ToString().Trim();
                            }
                            if (!DBNull.Value.Equals(myDS.Tables[0].Rows[iRow]["license_name"]))
                            {
                                myData.str_license_name = myDS.Tables[0].Rows[iRow]["license_name"].ToString().Trim();
                            }

                            myReturn.Add(myData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myReturn;
        }
    }
}