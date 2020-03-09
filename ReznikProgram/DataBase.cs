using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ReznikProgram
{
    class DataBase
    {
        protected SqlConnection connection;
        private ConnectionStringSettingsCollection settings;

        // If connection open - return null
        // If connection don't open - return error message
        public string openConnection()
        {
            string encryptConnectionStr = ToggleConfigEncryption("ReznikProgram.exe");

            if (encryptConnectionStr != null)
                return encryptConnectionStr + "\n" + "Encrypting error";

            connection = new SqlConnection(GetConnectionStringByName("DatabaseReznik"));

            try
            {
                connection.Open();
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Input - Database Name
        // Output - Connection String
        private string GetConnectionStringByName(string name)
        {
            string returnValue = null;

            ConnectionStringSettings settings =
                    ConfigurationManager.ConnectionStrings[name];

            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }

        // Encrypt Connection.config
        // Input - ExecuteEXEFileName. Example: "App.exe"
        // Output - if file protected -> null
        //          if error file protected -> error messsage
        private string ToggleConfigEncryption(string exeConfigName)
        {
            // Takes the executable file name without the
            // .config extension.
            try
            {
                // Open the configuration file and retrieve 
                // the connectionStrings section.
                Configuration config = ConfigurationManager.
                    OpenExeConfiguration(exeConfigName);

                ConnectionStringsSection section =
                    config.GetSection("connectionStrings")
                    as ConnectionStringsSection;

                if (!section.SectionInformation.IsProtected)
                {
                    // Encrypt the section.
                    section.SectionInformation.ProtectSection(
                        "DataProtectionConfigurationProvider");
                }

                // Save the current configuration.
                config.Save();

                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // If connection close -> return null
        // Else -> return error message
        public string closeConnection()
        {
            if (connection != null)
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    return null;
                }
                else
                    return "connection was close";
            else
                return "connection didn't use";
        }
    }
}
