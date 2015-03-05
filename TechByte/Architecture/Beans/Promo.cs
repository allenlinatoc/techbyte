using Guitar32.Controllers;
using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture.Validations;


namespace TechByte.Architecture.Beans
{
    public class Promo : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private String name;
        private float discount;
        private String status;


        public Promo(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblpromos")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setName(new MultiWord(row["name"].ToString()));
                    this.setDiscount(float.Parse(row["discount"].ToString()));
                    this.setStatus(new AccountStatus(row["status"].ToString()));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        public String getName() {
            return this.name;
        }
        public float getDiscount() {
            return this.discount;
        }
        public String getStatus() {
            return this.status;
        }

        public void setName(MultiWord name) {
            this.name = name.getValue();
        }
        public void setDiscount(float discount) {
            this.discount = discount;
        }
        public void setStatus(AccountStatus status) {
            this.status = status.getValue().ToUpper();
        }


        public bool CreateData() {
            if (!this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblpromos", new string[] { "name", "discount", "status" })
                    .Values(new object[] {
                        Strings.Surround(this.getName()),
                        this.getDiscount(),
                        Strings.Surround(this.getStatus())
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
            if (this.exists()) {
                Dictionary<string, string> setPairs = new Dictionary<string, string>();
                setPairs.Add("name", Strings.Surround(this.getName()));
                setPairs.Add("discount", this.getDiscount().ToString());
                setPairs.Add("status", Strings.Surround(this.getStatus()));
                QueryBuilder query = new QueryBuilder();
                query.Update("tblpromos")
                    .Set(setPairs)
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }
    }
}
