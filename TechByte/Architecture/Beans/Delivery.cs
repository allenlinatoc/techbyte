using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Business;
using TechByte.Architecture.Beans.Goods;
using TechByte.Architecture.Beans.Warehouse;


namespace TechByte.Architecture.Beans
{
    public class Delivery : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private SystemUser user;
        private Company logistic;
        private GoodsReceipt greceipt;
        private String created;


        public Delivery(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tbldeliveries")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setUser(new SystemUser(Integer.Parse(row["user_id"])));
                    this.setLogistic(new Company(Integer.Parse(row["logistic_id"])));
                    this.setGoodsReceipt(new GoodsReceipt(Integer.Parse(row["greceipt_id"])));
                    this.setCreationDate(new Guitar32.Validations.DateTime(row["created"].ToString()));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }


        public SystemUser getUser() {
            return this.user;
        }
        public Company getLogistic() {
            return this.logistic;
        }
        public GoodsReceipt getGoodsReceipt() {
            return this.greceipt;
        }
        public String getCreationDate() {
            return this.created;
        }

        public void setUser(SystemUser user) {
            this.user = user;
        }
        public void setLogistic(Company logistic) {
            this.logistic = logistic;
        }
        public void setGoodsReceipt(GoodsReceipt greceipt) {
            this.greceipt = greceipt;
        }
        public void setCreationDate(Guitar32.Validations.DateTime created) {
            this.created = created.getValue();
        }




        public bool CreateData() {
            if (!this.exists()) {
                if (!this.getUser().exists()) {
                    this.getUser().CreateData();
                }
                if (!this.getLogistic().exists()) {
                    this.getLogistic().CreateData();
                }
                if (!this.getGoodsReceipt().exists()) {
                    this.getGoodsReceipt().CreateData();
                }
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tbldeliveries", new string[] {
                    "user_id",
                    "logistic_id",
                    "greceipt_id",
                    "created"
                })
                    .Values(new object[] {
                        this.getUser().getId(),
                        this.getLogistic().getId(),
                        this.getGoodsReceipt().getId(),
                        this.getCreationDate()
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
