using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlServerCe;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace at.ac.tuwien.infosys.dsg.RIFramework.RMod {
    public static class RModDB {

        public static string connectionString;
        public static SqlConnection sqlConnection;

        static RModDB() {
            connectionString = Properties.Settings.Default.DatabaseConnectionString;
            sqlConnection = new SqlConnection(connectionString);

        }

        public static void checkRModDBExists() {
            //todo: check if db exists

        }

        public static void executeSQLScript(string scriptPath) {

            checkRModDBExists();

            string script = "";

            try {
                script = File.ReadAllText(scriptPath);
            } catch (Exception e) {
                System.Console.WriteLine(e.ToString());
                return;
            }

            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, "^\\s*GO\\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);

            sqlConnection.Open();
            foreach (string commandString in commandStrings) {
                if (commandString.Trim() != "") {
                    new SqlCommand(commandString, sqlConnection).ExecuteNonQuery();
                    }
                }
            sqlConnection.Close();
        }
        
        public class Scripts {
            public static string SQLScript_DB_CREATE;
            public static string SQLScript_DB_DROP;
            public static string basePath;
            public static string scriptsPath;


            static Scripts() { //static constructor. Initializes paths to the scripts
                basePath = System.IO.Path.GetFullPath("..\\..\\"); //path of the RMod project;
                scriptsPath = basePath + "\\" + Properties.Settings.Default.DBScriptsPath;


                SQLScript_DB_CREATE = scriptsPath + "\\" + Properties.Settings.Default.DBCreateScript;
                SQLScript_DB_DROP = scriptsPath + "\\" + Properties.Settings.Default.DBDropScript;
                //add more here...
            }

        }//end inner class RModDB.Scripts
    
    }//end class RModDB



}
