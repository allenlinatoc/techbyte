using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

// MySQL
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

using Guitar32.Exceptions;
using Guitar32.Utilities;



namespace Guitar32.Database
{
    public class DatabaseConnection
    {
        protected DatabaseCredentials
            dbCredentials;
        protected DBMSTypes
            type;
        protected String
            characterSet;

        // Connection instances
        protected MySqlConnection
            mysql;


        /// <summary>
        /// Create an instance of DatabaseConnection
        /// </summary>
        /// <param name="credentials">The credentials object to be used to connect to server</param>
        /// <param name="characterSet">The character set to be used in the whole session</param>
        /// <param name="type">The DBMS server type (e.g. Oracle, MySQL, etc.), refer to <code>DBMSTypes</code> enum</param>
        public DatabaseConnection(DatabaseCredentials credentials, String characterSet = "utf8", DBMSTypes type = DBMSTypes.MySQL) {
            this.characterSet = characterSet;
            this.type = type;
            this.dbCredentials = credentials;
        }



        /// <summary>
        /// Start connecting to database
        /// </summary>
        /// <returns>If connection to database is success</returns>
        public bool Connect() {
            switch(this.type) {
                case DBMSTypes.MySQL: {
                    if (!this.IsConnected()) {
                        DatabaseCredentials creds = this.dbCredentials;
                        MySqlConnectionStringBuilder connStr = new MySqlConnectionStringBuilder();
                        connStr.Server = creds.getServer();
                        connStr.Port = creds.getPort();
                        connStr.UserID = creds.getUsername();
                        connStr.Password = creds.getPassword();
                        connStr.Database = creds.getDatabase();
                        connStr.CharacterSet = "utf8";
                        this.mysql = new MySqlConnection(connStr.GetConnectionString(true));
                        try {
                            this.mysql.Open();
                        }
                        catch (MySqlException ex) {
                            this.LogError(ex.Message);
                            Console.Write("Unable to connect to database: " + ex.Message);
                            return false;
                        }
                        return true;
                    }
                    else {
                        return true;
                    }
                    // END MySQL
                    }

                default: {
                    return false;
                    }
            }
        }


        /// <summary>
        /// Execute a non-scalar SQL query
        /// </summary>
        /// <param name="query">The query to be executed</param>
        /// <returns>If execution of the query is success</returns>
        public bool Execute(string query) {
            if (!this.IsConnected()) {
                DisconnectedException exception = new DisconnectedException();
                this.LogError(exception.Message);
                throw exception;
            }
            MySqlCommand cmd = new MySqlCommand(query, this.mysql);
            cmd.EnableCaching = true;
            try {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex) {
                this.LogError(ex.Message, ex.ErrorCode);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Execute a non-scalar SQL query
        /// </summary>
        /// <param name="query">The query to be executed</param>
        /// <returns>If execution of the query is success</returns>
        public bool Execute(QueryBuilder query) {
            return this.Execute(query.getQueryString());
        }




        /// <summary>
        /// Check if a query returns a row
        /// </summary>
        /// <param name="query">The query to be executed</param>
        /// <returns>If a query returns a row</returns>
        public bool Exists(string query) {
            if (!this.IsConnected()) {
                DisconnectedException exception = new DisconnectedException();
                this.LogError(exception.Message);
                throw exception;
            }

            Dictionary<string,object> result = this.QuerySingle(query);
            if (result != null) {
                return result.Count > 0;
            }
            return false;
        }
        /// <summary>
        /// Check if a query returns a row
        /// </summary>
        /// <param name="query">The query to be executed</param>
        /// <returns>If a query returns a row</returns>
        public bool Exists(QueryBuilder query) {
            return this.Exists(query.getQueryString());
        }




        /// <summary>
        /// Check if this Database connection instance is currently connected or not
        /// </summary>
        /// <returns>If this Database connection instance is currently connected or not</returns>
        public bool IsConnected() {
            switch (this.type) {

                // MySQL
                case DBMSTypes.MySQL: {
                    if (this.mysql == null) {
                        return false;
                    }
                    return this.mysql.State == System.Data.ConnectionState.Open
                        || this.mysql.State == System.Data.ConnectionState.Fetching
                        || this.mysql.State == System.Data.ConnectionState.Executing
                        || this.mysql.State == System.Data.ConnectionState.Connecting;
                    } // END of MySQL

                // Oracle
                case DBMSTypes.Oracle: {

                    return false;
                    } // END of Oracle

                // PostgreSQL
                case DBMSTypes.PostgreSQL: {

                    return false;
                    } // END of PostgreSQL

                default: {
                    return false;
                    }
            }
        }


        /// <summary>
        /// Execute query expecting multi-row result
        /// </summary>
        /// <param name="query">The query to be executed</param>
        /// <returns>The resulting QueryResult object</returns>
        public QueryResult Query(string query) {
            if (!this.IsConnected()) {
                DisconnectedException exception = new DisconnectedException();
                this.LogError(exception.Message);
                throw exception;
            }

            MySqlCommand cmd = new MySqlCommand(query, this.mysql);
            MySqlDataReader reader = null;
            try {
                reader = cmd.ExecuteReader();
            }
            catch (MySqlException ex) {
                this.LogError(ex.Message, ex.ErrorCode);
                throw ex;
            }

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            while (reader.Read()) {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++) {
                    if (reader.IsDBNull(i)) {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    else {
                        row.Add(reader.GetName(i), reader.GetString(i));
                    }
                }
                result.Add(row);
            }
            // Try to close the reader
            if (!reader.IsClosed) {
                reader.Close();
            }
            QueryResult queryResult = new QueryResult(result.ToArray());
            return queryResult;
        }
        /// <summary>
        /// Execute query expecting multi-row result
        /// </summary>
        /// <param name="query">The query to be executed</param>
        /// <returns>The resulting QueryResult object</returns>
        public QueryResult Query(QueryBuilder query) {
            return this.Query(query.getQueryString());
        }



        /// <summary>
        /// Execute query expecting single-row result, otherwise, null
        /// </summary>
        /// <param name="query">The query to be executed</param>
        /// <returns>The resulting row of result, an array of columnar field values, otherwise, null</returns>
        public Dictionary<string, object> QuerySingle(string query) {
            if (!this.IsConnected()) {
                DisconnectedException exception = new DisconnectedException();
                this.LogError(exception.Message);
                throw exception;
            }

            MySqlCommand cmd = new MySqlCommand(query, this.mysql);
            MySqlDataReader reader = null;
            try {
                reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);
            }
            catch (MySqlException ex) {
                this.LogError(ex.Message, ex.ErrorCode);
                throw ex;
            }

            Dictionary<string, object> result = new Dictionary<string, object>();
            // Check if result returned a row
            if (!reader.HasRows) {
                if (!reader.IsClosed) {
                    reader.Close();
                }
                return null;
            }
            // Continue retrieving result
            if (reader.Read()) {
                for (int i=0; i<reader.FieldCount; i++) {
                    if (reader.IsDBNull(i)) {
                        result.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    else {
                        result.Add(reader.GetName(i), reader.GetString(i));
                    }
                }
            }
            // Try to close the reader
            if (!reader.IsClosed) {
                reader.Close();
            }
            return result;
        }

        /// <summary>
        /// Execute query expecting single-row result, otherwise, null
        /// </summary>
        /// <param name="query">The query to be executed</param>
        /// <returns>The resulting row of result, an array of columnar field values, otherwise, null</returns>
        public Dictionary<string, object> QuerySingle(QueryBuilder query) {
            return this.QuerySingle(query.getQueryString());
        }



        // <Begin::Getters and Setters>
        public string[][] GetLastResult() {
            return null;
        }
        // <End::Getters and Setters>




        // <Begin::Private>
        private void LogError(String message, int errorCode=-1) {
            Guitar32.Utilities.Diagnostics diagLog = new Guitar32.Utilities.Diagnostics();
            diagLog.LogEntry(message + (errorCode > -1 ? " (error code: "+errorCode+")" : "")
                , EventLogEntryType.Error);
        }
        // <End::Private>


    }



    /// <summary>
    /// List of common DBMS Types
    /// </summary>
    public enum DBMSTypes
    {
        Oracle, MySQL, MicrosoftSQL, PostgreSQL
    }
    
}
