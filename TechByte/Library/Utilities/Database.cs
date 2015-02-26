using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Guitar32.Utilities
{
    /// <summary>
    /// Static utility for Database connections
    /// </summary>
    public class Database
    {
        public static int port = 3306;
        public static String server = "localhost";
        public static String dbname = "techbytedb";
        public static String password = "root";
        public static MySqlConnectionStringBuilder connStrBuilder;
        public static MySqlConnection connection;

        public static void Initialize()
        {
            connStrBuilder = new MySqlConnectionStringBuilder();
            connStrBuilder.Server = server;
            connStrBuilder.Port = (uint)port;
            connStrBuilder.Database = dbname;
            connStrBuilder.Password = password;
            connection = new MySqlConnection(connStrBuilder.GetConnectionString(true));
        }

        public void Connect()
        {
            connection.Open();
        }

        public void Disconnect(Boolean isDispose=true)
        {
            connection.Close();
            if (isDispose)
            {
                connection.Dispose();
            }
        }

        public void Execute()
        {

        }
    }
}
