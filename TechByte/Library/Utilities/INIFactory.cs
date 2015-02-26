using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Guitar32.Utilities
{
    class INIFactory
    {

        /// <summary>
        /// Read an INI file
        /// </summary>
        /// <param name="path">The path to the INI file to be read</param>
        /// <returns>Pair of keys and values from the INI file</returns>
        public static Dictionary<String, String> readFile(String path) {
            Dictionary<String, String> configPairs = new Dictionary<string, string>();
            String contents = File.ReadAllText(path).Trim();
            String[] lines = contents.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (String line in lines) {
                string[] split = line.Split(new string[] {"="}, StringSplitOptions.RemoveEmptyEntries);
                if (split.Length != 2) {
                    continue;
                }
                String key = split[0].Trim();
                String value = split[1].Trim();
                configPairs.Add(key, value);
            }
            return configPairs;
        }



        /// <summary>
        /// Write the INI file to a path
        /// </summary>
        /// <param name="configPairs">Pair of keys and values to be written</param>
        /// <param name="path">Path to INI file where config values will be written. If file exists, it will be overwritten.</param>
        /// <returns>If write of file succeed</returns>
        public static bool writeFile(Dictionary<String, String> configPairs, String path) {
            StringBuilder output = new StringBuilder();
            foreach (String key in configPairs.Keys) {
                output.AppendLine(key.Trim() + " = " + configPairs[key].Trim());
            }
            try {
                File.WriteAllText(path, output.ToString().Trim(new char[] { '\n', '\r' }));
            }
            catch (Exception ex) {
                MessageBox.Show("Exception occured while creating an INI file:" + Environment.NewLine 
                    + ex.Message);
                return false;
            }
            return true;
        }

    }
}
