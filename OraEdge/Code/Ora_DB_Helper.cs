using System.Data;

namespace OraEdge
{
    internal class Ora_DB_Helper : OraDAL
    {  
        public DataTable get_DBA_Users()
        {
            return get_OraData("DBA_USERS");
        }
        public DataTable get_Oracle_Instances()
        {
            return get_OraData("INSTANCE_NAME");
        }
    }
}
