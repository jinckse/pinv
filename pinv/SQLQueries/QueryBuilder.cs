using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinv.SQLQueries
{
    class QueryBuilder
    {
        /* Constructor */
        public QueryBuilder()
        {

        }

        #region fields

        /// <summary>
        /// Gather the basic parts of an SQL query
        /// </summary>
        private string _selectStr;
        public string SelectStr {get; set;}

        private string _fromStr;
        public string FromStr { get; set; }

        private string _joinOpsStr;
        public string JoinOpsStr { get; set; }

        private string _whereStr;
        public string WhereStr { get; set; }

        private string _aggregateOpsStr;
        public string AggregateOpsStr { get; set; }

        #endregion fields

        #region methods

        /// <summary>
        /// TODO: At this point this is the only method used in this class, until overloaded methods are utilized
        /// View an item in the inventory system based on user query
        /// </summary>
        public string BuildViewItemQuery()
        {
            string query;

            // Connect query parts
            query = SelectStr + " "
                + FromStr + " "
                + JoinOpsStr + " "
                + WhereStr + " "
                + AggregateOpsStr;

            // Return result
            return query;

        }

        /// <summary>
        /// Locate an item in the inventory system based on user query
        /// </summary>
        /// <returns>query</returns>
        public string BuildLocateItemQuery()
        {
            string query;

            // Connect query parts
            query = SelectStr + " "
                + FromStr + " "
                + JoinOpsStr + " "
                + WhereStr + " "
                + AggregateOpsStr;

            // Return result
            return query;
        }

        /// <summary>
        /// TODO: Not yet implemented
        /// Add an item in the inventory system based on user query
        /// </summary>
        public void BuildAddItemQuery()
        {

        }

        /// <summary>
        /// TODO: Not yet implemented
        /// Delete an item in the inventory system based on user query
        /// </summary>
        public void BuildDeleteItemQuery()
        {

        }

        #endregion methods
    }
}

