using Guitar32;
using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture.Beans;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Business;
using TechByte.Architecture.Beans.Goods;


namespace TechByte.Architecture.Beans
{
    public class GoodsReturn : Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private Company vendor;
        private Delivery delivery;
        private GoodsReceipt greceipt;
        private SystemUser user;
        private String description;


        public GoodsReturn(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblgreturns")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    Company vendor = new Company(Integer.Parse(row["vendor_id"]));
                    Delivery delivery = new Delivery(Integer.Parse(row["delivery_id"]));
                    GoodsReceipt greceipt = new GoodsReceipt(Integer.Parse(row["greceipt_id"]));
                    SystemUser user = new SystemUser(Integer.Parse(row["user_id"]));
                    this.setVendor(vendor);
                    this.setDelivery(delivery);
                    this.setGoodsReceipt(greceipt);
                    this.setUser(user);
                    this.setDescription(new MultiWord(row["description"].ToString()));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        public Company getVendor() {
            return this.vendor;
        }
        public Delivery getDelivery() {
            return this.delivery;
        }
        public GoodsReceipt getGoodsReceipt() {
            return this.greceipt;
        }
        public SystemUser getUser() {
            return this.user;
        }
        public String getDescription() {
            return this.description;
        }
        public void setVendor(Company vendor) {
            this.vendor = vendor;
        }
        public void setDelivery(Delivery delivery) {
            this.delivery = delivery;
        }
        public void setGoodsReceipt(GoodsReceipt greceipt) {
            this.greceipt = greceipt;
        }
        public void setUser(SystemUser user) {
            this.user = user;
        }
        public void setDescription(MultiWord description) {
            this.description = description.getValue();
        }



        public bool CreateData() {
            if (!this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblgreturns", new string[] { "vendor_id", "delivery_id", "greceipt_id", "user_id", "description" })
                    .Values(new object[] {
                        this.getVendor().getId(),
                        this.getDelivery().getId(),
                        this.getGoodsReceipt().getId(),
                        this.getUser().getId(),
                        Strings.Surround(this.getDescription())
                    });
                bool createSuccess = dbConn.Execute(query);
                if (createSuccess) {
                    this.setId(dbConn.GetLastInsertID());
                }
                return createSuccess;
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
