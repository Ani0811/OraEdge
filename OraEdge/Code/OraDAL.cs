using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OraEdge
{
    internal class OraDAL : OraConnect
    {
        public DataTable get_OraData(String queryType)
        {
            String query = String.Empty;

            switch (queryType)
            {
                case "DBA_USERS":
                    query = "SELECT USERNAME, USER_ID FROM DBA_USERS";
                    break;
                case "INSTANCE_NAME":
                    query = "SELECT INSTANCE_NAME FROM V$INSTANCE";
                    break;
                default:
                    throw new ArgumentException("Invalid query type");
            }
            return exec_OraData(query);
        }
        public DataTable exec_OraData(String query)
        {
            DataSet Ds = null;
            OracleConnection oOraCon = null;
            OracleDataAdapter Ora_DA = null;
            OracleCommandBuilder OraCmdBldr = null;

            StringBuilder sSQL = null;

            try
            { 
                oOraCon = Ora_Connect();

                if(oOraCon.State == ConnectionState.Open)
                {
                    sSQL = new StringBuilder();
                    sSQL.Append(query);

                    Ora_DA = new OracleDataAdapter();
                    Ora_DA.SelectCommand = new OracleCommand(sSQL.ToString(), oOraCon);
                    OraCmdBldr = new OracleCommandBuilder(Ora_DA);

                    Ds = new DataSet();
                    Ora_DA.Fill(Ds);
                }
                else
                {
                    throw new InvalidOperationException("Database connection is not open.");
                }
            }
            catch (Exception ex) {; }
            finally 
            {
                if (oOraCon != null) { oOraCon.Close(); oOraCon.Dispose(); } 
                Ora_DA = null; OraCmdBldr = null; sSQL = null;
            }
            return Ds.Tables[0];
        }
        public int exec_NonQuery(String query)
        {
            OracleConnection oOraCon = null;
            OracleCommand OraCmd = null;
            int iRowsAffected = 0;

            try
            {
                oOraCon = Ora_Connect();
                if(oOraCon.State == ConnectionState.Open)
                {
                    OraCmd = new OracleCommand(query, oOraCon);
                    iRowsAffected = OraCmd.ExecuteNonQuery();
                }
                else
                {
                    throw new InvalidOperationException("Database connection is not open.");
                }
            }
            catch (Exception ex) {; }
            finally 
            {
                if (oOraCon != null) { oOraCon.Close(); oOraCon.Dispose(); }
                OraCmd = null;
            }
            return iRowsAffected;
        }
    }
}
