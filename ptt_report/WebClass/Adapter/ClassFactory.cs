using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ptt_report.WebClass.SQLService;

namespace ptt_report.WebClass.Adapter
{
    public class ClassFactory
    {
        private static volatile ClassFactory clsFactory;
        private DBServerOracle dbServerOracle;

        public static ClassFactory getInstance()
        {
            if ((clsFactory == null))
            {
                clsFactory = new ClassFactory();
            }
            return clsFactory;
        }
        public DBServerOracle getDBServerOracle()
        {
            if ((dbServerOracle == null))
            {
                dbServerOracle = new DBServerOracle();
            }
            return dbServerOracle;
        }
    }
}