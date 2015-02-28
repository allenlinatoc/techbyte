using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture.Beans.Accounts;

namespace TechByte.Architecture.Beans
{
    public class AuditTrail : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        protected SystemUser user;
        protected String created;
        protected String description;


        public AuditTrail(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblaudittrails")
                    .Where("id", id);
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setUser(new SystemUser(int.Parse(row["user_id"]+"")));
                    this.setCreationDate(new Guitar32.Validations.DateTime(row["created"]+""));
                    this.setDescription(new MultiWord(row["description"]+""));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }


        public SystemUser getUser() {
            return this.user;
        }

        public String getCreationDate() {
            return this.created;
        }

        public String getDescription() {
            return this.description;
        }

        public void setUser(SystemUser user) {
            this.user = user;
        }

        public void setCreationDate(Guitar32.Validations.DateTime created) {
            this.created = created.getValue();
        }

        public void setDescription(MultiWord description) {
            this.description = description.getValue();
        }




        public bool CreateData() {
            if (!this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblaudittrails", new string[] {
                    "user_id",
                    "created", "description"
                })
                    .Values(new object[] {
                        this.getUser().getId(),
                        Strings.Surround(this.getCreationDate()),
                        Strings.Surround(this.getDescription())
                    });
                bool success = dbConn.Execute(query);
                if (success) {
                    this.setId(dbConn.GetLastInsertID());
                }
                return success;
            }
            return false;
        }


        public bool Delete() {
            throw new NotImplementedException();
        }


        public bool Update() {
            throw new NotImplementedException();
        }

    }
}
