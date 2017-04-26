using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// The PINV Inventory System
/// </summary>
namespace PINV
{
    /// <summary>
    /// The DBTalker class establishes a connection with the database.
    /// </summary>
    public class DBTalker
    {
        /* Constructor */
        private DBTalker()
        {

        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }

        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBTalker _instance = null;
        public static DBTalker Instance()
        {
            if (_instance == null)
            { 
                _instance = new DBTalker();
            }

            return _instance;
        }
        
        /// <summary>
        /// Check for a connection. If not create a new one
        /// </summary>
        /// <returns>result</returns>
        public bool IsConnected()
        {
            bool result = true;

            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                {
                    result = false;
                }

                string connString = string.Format("Server=104.185.154.255; database={0};" +
                    "UID=guest; password=cse3330", databaseName);

                connection = new MySqlConnection(connString);
                connection.Open();
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Close the database connection
        /// </summary>
        public void Close()
        {
            connection.Close();
        } 
    }
}
