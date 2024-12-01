using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace OraEdge
{
    internal class OraConnect
    {
        StringBuilder OraConStr = null;
        public OracleConnection Ora_Connect()
        {
            OracleConnection OraCon = null;
            try
            {
                OraCon = new OracleConnection(); OraConStr = new StringBuilder();

                OraConStr.Append("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORA19)));User Id=system;Password=sa1234;persist security info=false;Connection Timeout=120;");
                OraCon.ConnectionString = OraConStr.ToString();

                OraCon.Open();
            }
            catch (Exception ex) {; }
            finally {; }
            return OraCon;
        }
    }
}
