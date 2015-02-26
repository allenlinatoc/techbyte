using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Values
{
    public class FileSystem
    {
        public static string ApplicationDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"\\TechByte";
        public static string DatabaseCredentialsFile = ApplicationDataFolder + "/DatabaseCredentials.dat";
    }
}
