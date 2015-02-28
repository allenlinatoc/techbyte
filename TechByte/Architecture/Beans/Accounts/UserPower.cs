using Guitar32.Database;
using Guitar32.Exceptions;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Architecture.Beans.Accounts
{
    public class UserPower : Guitar32.Model
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private String name;
        private List<string> modules;


        public UserPower(int powerId = -1) {
            this.setId(powerId);
            if (this.getId() >= 0) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblpowers")
                    .Where("id", powerId);
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setName(new SingleWordAlphaNumeric(row["name"] + ""));
                    this.setModules(row["modules"].ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries));
                }
                else {
                    throw new BeanDataNotFoundException();
                }
            }
        }


        public string[] getModules() {
            return this.modules.ToArray();
        }

        public String getName() {
            return this.name;
        }

        public void setModules(string[] modules) {
            this.modules = new List<string>();
            foreach (string module in modules) {
                this.modules.Add(module);
            }
        }

        public void setName(SingleWordAlphaNumeric name) {
            this.name = name.getValue();
        }

    }
}
