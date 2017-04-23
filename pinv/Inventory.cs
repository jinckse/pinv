﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
        public List<string> RetrieveRecords()
        {
            var dbCon = DBTalker.Instance();
            dbCon.DatabaseName = "PINV";

            if (dbCon.IsConnected())
            {
                string query = SQLQueries.Queries.q5;
                List<string> list = new List<string>();

                StringBuilder result = new StringBuilder();

                var cmd = new MySqlCommand(query, dbCon.Connection);
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

                return list;
            }
            else
            {
                return null;
            }


        }
        #endregion methods

    }
}
