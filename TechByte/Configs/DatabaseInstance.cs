using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Guitar32.Database;



namespace TechByte.Configs
{
    public class DatabaseInstance
    {
        public static DatabaseConnection databaseConnection = null;

        public DatabaseConnection Get() {
            if (databaseConnection == null) {
                if (DatabaseCredentialsFile.Load()) {
                    databaseConnection = new DatabaseConnection(DatabaseCredentialsFile.databaseCredentials);
                }
                else {
                    MessageBox.Show("Unable to load file!");
                }
            }
            return databaseConnection;
        }

    }
}
