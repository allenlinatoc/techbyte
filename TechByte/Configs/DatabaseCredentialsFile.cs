using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Guitar32.Database;
using TechByte;


namespace TechByte.Configs
{
    public class DatabaseCredentialsFile
    {
        public static DatabaseCredentials databaseCredentials;


        /// <summary>
        /// Create a new database credentials and load it to current instance
        /// </summary>
        /// <param name="creds">The new DatabaseCredentials object to be created and loaded</param>
        /// <returns>If creation and loading is success</returns>
        public static bool CreateNew(DatabaseCredentials creds) {
            if (File.Exists(TechByte.Values.FileSystem.DatabaseCredentialsFile)) {
                File.Delete(TechByte.Values.FileSystem.DatabaseCredentialsFile);
            }
            bool isSuccess = creds.Dump(TechByte.Values.FileSystem.DatabaseCredentialsFile);
            if (isSuccess) {
                isSuccess = Load();
            }
            return isSuccess;
        }


        public static bool Exists() {
            // Check if Database credentials file exists
            bool dbCredentialsExist = true;
            if (!File.Exists(TechByte.Values.FileSystem.DatabaseCredentialsFile)) {
                dbCredentialsExist = false;
            }
            else {
                // Verify validity of file
                Console.WriteLine(TechByte.Values.FileSystem.DatabaseCredentialsFile);
                FileStream fs = new FileStream(TechByte.Values.FileSystem.DatabaseCredentialsFile, FileMode.OpenOrCreate);
                BinaryReader binReader = new BinaryReader(fs);
                byte[] contents = new byte[fs.Length];
                binReader.Read(contents, 0, (int)fs.Length);
                binReader.Close();
                fs.Close();
                try {
                    DatabaseCredentials.Deserialize(contents);
                }
                catch (InvalidCredentialsFileException exception) {
                    File.Delete(TechByte.Values.FileSystem.DatabaseCredentialsFile);
                    dbCredentialsExist = false;
                }
            }
            return dbCredentialsExist;
        }


        public static bool Load() {
            if (Exists()) {
                String path = TechByte.Values.FileSystem.DatabaseCredentialsFile;
                databaseCredentials = new DatabaseCredentials(path);
                // Set `dbtechbyte` as default database
                databaseCredentials.setDatabase("dbtechbyte");
                return true;
            }
            else {
                return false;
            }
        }


    }
}
