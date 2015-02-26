using Guitar32.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TechByte.Configs
{
    public class AppConfig
    {
        static public Boolean
            IsSystemLockdown;
        static public int
            TaxRate;
        static public UI
            UI;
        static public String[]
            Modules;
        static private Boolean __initialized = false;
        static private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;

        static public Boolean Initialize() {
            QueryBuilder query = new QueryBuilder();
            if (!__initialized) {
                // Fetch modules
                query.Select()
                    .From("tblmodules");
                QueryResult qsModules = dbConn.Query(query);
                List<String> modules = new List<string>();
                for (int i = 0; i < qsModules.RowCount(); i++) {
                    String
                        key = qsModules.GetSingle(i)["key"].ToString().ToUpper(),
                        status = qsModules.GetSingle(i)["status"].ToString().ToUpper();
                    if (status.Equals("ACTIVE")) {
                        modules.Add(key);
                    }
                }
                Modules = modules.ToArray();

                // Initialize UI config object
                UI = new Configs.UI();
                // Fetch configuration hive
                query.Select()
                    .From("tblconfiguration");
                QueryResult qsConfiguration = dbConn.Query(query);
                for (int i = 0; i < qsConfiguration.RowCount(); i++) {
                    String key = qsConfiguration.GetSingle(i)["key"].ToString().ToUpper();
                    String value = qsConfiguration.GetSingle(i)["value"].ToString().ToUpper();
                    if (key.Equals("UI_BACKCOLOR")) {
                        UI.DashboardBackColor = Color.FromArgb(int.Parse(value));
                    }
                    else if (key.Equals("GR_TAX")) {
                        TaxRate = int.Parse(value);
                    }
                    else if (key.Equals("SYS_LOCKDOWN")) {
                        IsSystemLockdown = value.Equals("ON");
                    }
                }

                __initialized = true;
            }

            return true;
        }

        static public Boolean Reinitialize() {
            Reset();
            return Initialize();
        }

        static private void Reset() {
            if (__initialized) {
                TaxRate = 0;
                IsSystemLockdown = true;
                UI = null;
                Modules = null;
                __initialized = false;
            }
        }

    }

    public class UI
    {
        public Color 
            DashboardBackColor;

        public UI() { }
    }
}
