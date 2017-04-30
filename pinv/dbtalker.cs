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

        private string _databaseName = string.Empty;
        public string DatabaseName
        {
            get { return _databaseName; }
            set { _databaseName = value; }
        }
        
        private string _databaseIP = string.Empty;
        public string DatabaseIP
        {
            get { return _databaseIP; }
            set { _databaseIP = value; }
        }
        
        private string _databaseUID = string.Empty;
        public string DatabaseUID
        {
            get { return _databaseUID; }
            set { _databaseUID = value; }
        }
        
        private string _databasePass = string.Empty;
        public string DatabasePass
        {
            get { return _databasePass; }
            set { _databasePass = value; }
        }

        private MySqlConnection _connection = null;
        public MySqlConnection Connection
        {
            get { return _connection; }
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
                        "UID={2}; password={3}", _databaseIP, _databaseName, _databaseUID, _databasePass);

                    _connection = new MySqlConnection(connString);
                    _connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problem Connecting to database " + _databaseName + ": " + ex);
                    _connection = null;
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
            _connection.Close();
        } 
    }
}
