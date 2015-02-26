using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

using Guitar32;
using TechByte.Views;

namespace TechByte
{
    static class Program
    {
        public const string REGISTRY_NAME = "TechByte";
        public static string[] ValueNames = new string[] {
            "mysqlauth"
        };
        public static RegistryKey RegistryKey;



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Startup();
            Application.Run(new Form1());
        }


        static void Startup() {
            // Check application data folder
            if (!File.Exists(TechByte.Values.FileSystem.ApplicationDataFolder)) {
                Directory.CreateDirectory(TechByte.Values.FileSystem.ApplicationDataFolder);
            }
        }
        
    }
}
