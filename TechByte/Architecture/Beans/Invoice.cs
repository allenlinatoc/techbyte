using Guitar32.Common;
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
using TechByte.Architecture.Beans.Warehouse;


namespace TechByte.Architecture.Beans
{
    public class Invoice : Guitar32.Model, IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private SystemUser user;
        private Company vendor;
        private Delivery delivery;
        private GoodsReceipt greceipt;
        private float
            grossTotal,
            actualTotal,
            amountpaid,
            change;
        private String type;

        public Invoice(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblinvoices")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    // Foreign keys
                    this.setUser(new SystemUser(Integer.Parse(row["user_id"])));
                    this.setVendor(new Company(Integer.Parse(row["vendor_id"])));
                    this.setDelivery(new Delivery(Integer.Parse(row["delivery_id"])));
                    this.setGoodsReceipt(new GoodsReceipt(Integer.Parse(row["greceipt_id"])));
                    // Setters
                    this.setGrossTotal(new Currency(row["grosstotal"].ToString()));
                    this.setActualTotal(new Currency(row["actualtotal"].ToString()));
                    this.setAmountPaid(new Currency(row["amountpaid"].ToString()));
                    this.setChange(new Currency(row["change"].ToString()));
                    this.setType(new SingleWordAlpha(row["type"].ToString()));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        public SystemUser getUser() {
            return this.user;
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
        public float getGrossTotal() {
            return this.grossTotal;
        }
        public float getActualTotal() {
            return this.actualTotal;
        }
        public float getAmountPaid() {
            return this.amountpaid;
        }
        public float getChange() {
            return this.change;
        }
        public String getType() {
            return this.type.ToUpper();
        }


        public void setUser(SystemUser user) {
            this.user = user;
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
        public void setGrossTotal(Currency grossTotal) {
            this.grossTotal = grossTotal.getValue();
        }
        public void setActualTotal(Currency actualTotal) {
            this.actualTotal = actualTotal.getValue();
        }
        public void setAmountPaid(Currency amountpaid) {
            this.amountpaid = amountpaid.getValue();
        }
        public void setChange(Currency change) {
            this.change = change.getValue();
        }
        public void setType(SingleWordAlpha type) {
            this.type = type.getValue().ToUpper();
        }



        public bool CreateData() {
            if (!this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblinvoices", new string[] {
                    "user_id", "vendor_id", "delivery_id", "greceipt_id",
                    "grosstotal",
                    "actualtotal",
                    "amountpaid",
                    "`change`",
                    "type"
                })
                    .Values(new object[] {
                        this.getUser().getId(), this.getVendor().getId(), this.getDelivery().getId(), this.getGoodsReceipt().getId(),
                        this.getGrossTotal(),
                        this.getActualTotal(),
                        this.getAmountPaid(),
                        this.getChange(),
                        Strings.Surround(this.getType()),
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
