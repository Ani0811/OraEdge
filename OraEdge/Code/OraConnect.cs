using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace OraEdge
{
    internal class OraConnect
    {   
        public OracleConnection Ora_Connect()
        {
            OracleConnection OraCon = null;
            //StringBuilder OraConStr = null;
            try
            {
                String connStr = Load_ConnectionString(Get_FilePath());
                

                OraCon = new OracleConnection(connStr); //OraConStr = new StringBuilder();

                /*OraConStr.Append("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORA19)));User Id=system;Password=sa1234;persist security info=false;Connection Timeout=120;");
                OraCon.ConnectionString = OraConStr.ToString();*/

                OraCon.Open();
            }
            catch (Exception ex) {; }
            finally {; }
            return OraCon;
        }
        public String Load_ConnectionString(String filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("Configuration file not found.");
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                XmlNode node = xmlDoc.SelectSingleNode("//CONNECTIONSTRING");
                if (node != null && !String.IsNullOrWhiteSpace(node.InnerText))
                {
                    return node.InnerText.Trim();
                }
                else
                {
                    throw new Exception("Connection string not found in the configuration file.");
                }
            }
            catch (Exception ex) { return null; }
            finally {; }
        }
        public String Get_FilePath()
        {
            String currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo DI = Directory.GetParent(Directory.GetCurrentDirectory());
            currentDir = DI.FullName.Replace("\\bin", "\\Files\\");
            String  filePath = Path.Combine(currentDir, "ConnectionString.xml");
            return filePath;
        }
    }
}
