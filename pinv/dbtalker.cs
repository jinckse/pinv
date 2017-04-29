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

        private static DBTalker _instance = null;
        public static DBTalker Instance()
        {
            if (_instance == null)
            { 
                _instance = new DBTalker();
            }

            return _instance;
        }

        #region Database Connection Fields

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }
        
        private string databaseIP = string.Empty;
        public string DatabaseIP
        {
            get { return databaseIP; }
            set { databaseIP = value; }
        }
        
        private string databaseUID = string.Empty;
        public string DatabaseUID
        {
            get { return databaseUID; }
            set { databaseUID = value; }
        }
        
        private string databasePass = string.Empty;
        public string DatabasePass
        {
            get { return databasePass; }
            set { databasePass = value; }
        }

        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        #endregion Databse Connection Fields

        /// <summary>
        /// Check for a connection and return the status
        /// </summary>
        /// <returns>status</returns>
        public bool IsConnected()
        {
            bool result = true;

            if (Connection == null)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Connect to a remote database
        /// </summary>
        /// <returns>result</returns>
        public bool OpenConnection()
        {
            bool result = true;

            if (Connection == null)
            {
                try
                {
                    string connString = string.Format("Server={0}; database={1};" +
                        "UID={2}; password={3}", databaseIP, databaseName, databaseUID, databasePass);

                    connection = new MySqlConnection(connString);
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problem Connecting to database " + databaseName + ": " + ex);
                    connection = null;
                    result = false;
                }
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
