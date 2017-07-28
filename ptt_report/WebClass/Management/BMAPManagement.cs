using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ptt_report.WebClass.MappingTable;
using ptt_report.WebClass.SQLService;

namespace ptt_report.WebClass.Management
{
    public class BMAPManagement
    {
        private BMAPServiceSelect bmapSrvSelCls = new BMAPServiceSelect();
        public List<BMAP_LICENSE_TO_OPERATE> Sel_BMAP_License_To_Operate(BMAP_LICENSE_TO_OPERATE inKey)
        {
            List<BMAP_LICENSE_TO_OPERATE> myReturn = new List<BMAP_LICENSE_TO_OPERATE>();

            if (inKey == null)
            {
                throw new Exception("Object is null");
            }

            try
            {
                myReturn = bmapSrvSelCls.Select_BMAP_License_To_Operate(inKey);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return myReturn;
        }
    }
}