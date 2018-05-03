using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAV.Data.Common
{
    public class Cn
    {
        public static string cnxOracle;
        static Cn()
        {
            cnxOracle = ConfigurationManager.ConnectionStrings["cnx"].ToString();
        }

        public static OracleConnection OracleCn() => new OracleConnection(cnxOracle);

    }
}
