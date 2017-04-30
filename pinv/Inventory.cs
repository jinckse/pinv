using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace PINV
{
    class Inventory
    {
        /* Constructor */
        public Inventory()
        {

        }

        # region fields
        private static Inventory _instance = null;
        public static Inventory Instance()
        {
            if (_instance == null)
            {
                _instance = new Inventory();
            }

            return _instance;
        }
        #endregion fields

        #region methods

        /// <summary>
        /// Retrieve records from PINV system
        /// </summary>
        /// <returns></returns>
        public List<string> RetrieveRecords(DBTalker conn, string query, bool debug)
        {
            if (conn.IsConnected())
            {
                List<string> list = new List<string>();

                StringBuilder result = new StringBuilder();

                var cmd = new MySqlCommand(query, conn.Connection);

                try
                {
                    var reader = cmd.ExecuteReader();

                    list.Add("\n");
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        list.Add(reader.GetName(i));
                    }
                    list.Add("\n");

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        list.Add("-------");
                    }
                    list.Add("\n");
                    
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            list.Add(reader[i] + "");
                        }
                        list.Add("\n");
                    }

                    reader.Close();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("ERROR: " + ex);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("ERROR: " + ex);
                }

                return list;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Retrieve records from PINV system
        /// </summary>
        /// <returns></returns>
        public List<string> RetrieveRecords(DBTalker conn, string query)
        {
            if (conn.IsConnected())
            {
                List<string> list = new List<string>();

                StringBuilder result = new StringBuilder();

                var cmd = new MySqlCommand(query, conn.Connection);

                try
                {
                    var reader = cmd.ExecuteReader();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        list.Add(reader.GetName(i));
                    }

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            list.Add(reader[i].ToString());
                        }
                    }

                    reader.Close();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("ERROR: " + ex);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("ERROR: " + ex);
                }

                return list;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Returns a list of sample queries for use in combobox
        /// </summary>
        /// <returns></returns>
        public static List<string> GetExampleQueries()
        {
            List<string> exampleQueryList = new List<string>();

            exampleQueryList.Add(SQLQueries.Queries.q1);
            exampleQueryList.Add(SQLQueries.Queries.q2);
            exampleQueryList.Add(SQLQueries.Queries.q3);
            exampleQueryList.Add(SQLQueries.Queries.q4);
            exampleQueryList.Add(SQLQueries.Queries.q5);
            exampleQueryList.Add(SQLQueries.Queries.q6);

            return exampleQueryList;
        }

        #endregion methods

    }
}
