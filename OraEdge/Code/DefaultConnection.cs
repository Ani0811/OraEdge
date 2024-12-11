using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OraEdge
{
    public class DefaultConnection
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Instance { get; set; }
        public string Database { get; set; }
        public string ErrorMessage { get; private set; }
        public bool IsLoaded { get; private set; }

        private string Get_FilePath
        {
            get
            {
                string currentDir = Directory.GetCurrentDirectory();
                DirectoryInfo parentDir = Directory.GetParent(currentDir);
                return Path.Combine(parentDir.FullName.Replace("\\bin", "\\Connections\\"), "DefaultConnection.xml");
            }
        }
        public void Get_DefaultConnection()
        {
            try
            {
                if(!File.Exists(Get_FilePath))
                {
                    ErrorMessage = "XML file not found. Please check the connection path.";
                    IsLoaded = false;
                    return;
                }

                XDocument doc = XDocument.Load(Get_FilePath);
                var defaultConnElement = doc.Element("Connections")?.Element("DefaultConnection");

                if (defaultConnElement == null)
                {
                    ErrorMessage = "Default connection details are missing in the XML file.";
                    IsLoaded = false;
                    return;
                }

                Username = defaultConnElement.Element("Username")?.Value;
                Password = defaultConnElement.Element("Password")?.Value;
                Instance = defaultConnElement.Element("Instance")?.Value;
                Database = defaultConnElement.Element("Database")?.Value;

                if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) ||
                string.IsNullOrEmpty(Instance) || string.IsNullOrEmpty(Database))
                {
                    ErrorMessage = "One or more required connection details are missing in the XML file.";
                    IsLoaded = false;
                    return;
                }
                IsLoaded = true;
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Error parsing XML: {ex.Message}";
                IsLoaded = false;
            }
        }
    }
}
