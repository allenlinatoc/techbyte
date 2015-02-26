using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guitar32.Database
{
    /// <summary>
    /// Class for storing result from a database query
    /// </summary>
    public class QueryResult
    {
        private Dictionary<string, object>[] data;

        /// <summary>
        /// Instantiate an instance of QueryResult
        /// </summary>
        /// <param name="data">The database result to be passed</param>
        public QueryResult(Dictionary<string, object>[] data) {
            this.data = data;
        }


        /// <summary>
        /// Instantiate an instance of QueryResult
        /// </summary>
        /// <param name="data">The database row to be passed</param>
        public QueryResult(Dictionary<string, object> data) {
            List<Dictionary<string, object>> newList = new List<Dictionary<string, object>>();
            newList.Add(data);
            this.data = newList.ToArray();
        }


        /// <summary>
        /// Get a single row from the result
        /// </summary>
        /// <param name="index">The index of row from the result</param>
        /// <returns>The row from the result</returns>
        public Dictionary<string, object> GetSingle(int index = -9999) {
            if (this.data.Length == 0) {
                throw new EmptyQueryResultException();
            }
            if (index == -9999) {
                return this.data[0];
            }
            else {
                return this.data[index];
            }
        }


        /// <summary>
        /// Check if result is empty
        /// </summary>
        /// <returns></returns>
        public Boolean IsEmpty() {
            return this.data == null || this.data.Length==0;
        }


        /// <summary>
        /// Get the row count from this result
        /// </summary>
        /// <returns>The number of count from the result</returns>
        public int RowCount() {
            return this.data.Length;
        }

    }


    /// <summary>
    /// Exception throw if tried to get a row from an empty QueryResult
    /// </summary>
    public class EmptyQueryResultException : Exception
    {
        public EmptyQueryResultException()
            : base("Trying to get a row from an empty QueryResult instance") { }
    }
}
