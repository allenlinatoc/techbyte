using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guitar32.Database
{

    /// <summary>
    /// Lets you build database queries
    /// </summary>
    public class QueryBuilder
    {
        private String queryString;


        /// <summary>
        /// Instantiate an instance of QueryBuilder
        /// </summary>
        /// <param name="queryString">(Optional) Existing query string to be incorporated inside this query builder</param>
        public QueryBuilder(String queryString="")
        {
            this.queryString = queryString;
        }



        /// <summary>
        /// From what table/s shall the query be executed?
        /// </summary>
        /// <param name="table">Name/s of table. Separate by commas if more than one is specified</param>
        /// <returns>Current instance</returns>
        public QueryBuilder From(String table = "") {
            this.queryString += "FROM " + (table.Trim().Length > 0 ? table : "*");
            this.padQuery(true);
            return this;
        }
        /// <summary>
        /// From what table/s shall the query be executed?
        /// </summary>
        /// <param name="queryInstance">The queryBuilder instance where source of data will come from</param>
        /// <returns>Current instance</returns>
        public QueryBuilder From(QueryBuilder queryInstance) {
            this.queryString += "FROM (" + queryInstance.getQueryString() + ")";
            this.padQuery(true);
            return this;
        }


        /// <summary>
        /// Insert expression
        /// </summary>
        /// <param name="tablename">The name of the target table</param>
        /// <param name="columns">(Optional) Array of column names</param>
        /// <returns>Current instance</returns>
        public QueryBuilder InsertInto(String tablename, String[] columns = null) {
            this.queryString = "INSERT INTO `" + tablename + "`" 
                + (columns!=null ? "("+String.Join(",", columns)+")" : "");
            this.padQuery(true);
            return this;
        }



        /// <summary>
        /// Select a portion from table
        /// </summary>
        /// <param name="columns">Array of column names</param>
        /// <returns>Current instance</returns>
        public QueryBuilder Select(string[] columns = null)
        {
            if (columns != null) {
                for (int i = 0; i < columns.Length; i++) {
                    columns[i] = columns[i].Trim();
                }
                this.queryString = this.queryString = "SELECT " + String.Join(",", columns);
            }
            else {
                this.queryString = "SELECT *";
            }
            this.padQuery(true);
            return this;
        }
        /// <summary>
        /// Select a column from table
        /// </summary>
        /// <param name="column">The column to be selected</param>
        /// <returns>Current instance</returns>
        public QueryBuilder Select(string column) {
            this.queryString = "SELECT " + column.Trim();
            this.padQuery(true);
            return this;
        }



        /// <summary>
        /// SET syntax to set column values in UPDATE operations
        /// </summary>
        /// <param name="setPairs">The pair of columns and its corresponding values</param>
        /// <returns>Current instance</returns>
        public QueryBuilder Set(Dictionary<string, string> setPairs) {
            List<string> lSetPairs = new List<string>();
            string strSetPairs;
            foreach (KeyValuePair<string, string> kv in setPairs) {
                lSetPairs.Add(kv.Key + " = " + kv.Value);
            }
            strSetPairs = String.Join(",", lSetPairs.ToArray());
            this.queryString += "SET " + strSetPairs;
            this.padQuery(true);
            return this;
        }
        /// <summary>
        /// SET syntax to set column values in UPDATE operations
        /// </summary>
        /// <param name="key">The key as column name</param>
        /// <param name="value">The value of the specified column</param>
        /// <returns>Current instance</returns>
        public QueryBuilder Set(string key, string value) {
            this.queryString += "SET " + key + " = " + value;
            this.padQuery(true);
            return this;
        }



        /// <summary>
        /// Update the table
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public QueryBuilder Update(String tablename) {
            this.queryString = "UPDATE " + tablename;
            this.padQuery(true);
            return this;
        }



        /// <summary>
        /// Insert an array of values
        /// </summary>
        /// <param name="values">Array of values</param>
        /// <returns>Current instance</returns>
        public QueryBuilder Values(object[] values) {
            this.queryString += "VALUES(" + String.Join(",", values) + ")";
            this.padQuery(true);
            return this;
        }



        /// <summary>
        /// Attach condition to your query
        /// </summary>
        /// <param name="conditions">Condition string to be attached</param>
        /// <returns>Current instance</returns>
        public QueryBuilder Where(String conditions)
        {
            this.queryString += "WHERE " + conditions;
            this.padQuery(true);
            return this;
        }
        /// <summary>
        /// Attach conditions to your query separated by logical operand "AND"
        /// </summary>
        /// <param name="conditions">Associative list of conditions</param>
        /// <returns>Current instance</returns>
        public QueryBuilder Where(Dictionary<object, object> conditions) {
            string conditionStr = "";
            foreach (KeyValuePair<object, object> condition in conditions) {
                conditionStr += (conditionStr.Length > 0 ? "AND " : "") + condition.Key + "=" + condition.Value + " ";
            }
            if (conditionStr.Trim().Length == 0) {
                throw new ArgumentNullException(conditionStr);
            }
            return this.Where(conditionStr.Trim());
        }




        // <Begin::Getters and Setters>

        /// <summary>
        /// Get current query string
        /// </summary>
        /// <returns></returns>
        public String getQueryString() {
            return this.queryString;
        }

        // <End::Getters and Setters>



        private void padQuery(bool isNewLine = false)
        {
            this.queryString = Utilities.Strings.RightTrim(this.queryString)
                + (isNewLine ? "\n" : " ");
        }
    }
}
