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


namespace TechByte.Architecture
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
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        private SystemUser getUser() {
            return this.user;
        }
        private Company getVendor() {
            return this.vendor;
        }
        private Delivery getDelivery() {
            return this.delivery;
        }
        private GoodsReceipt getGoodsReceipt() {
            return this.greceipt;
        }
        private float getGrossTotal() {
            return this.grossTotal;
        }
        private float getActualTotal() {
            return this.actualTotal;
        }
        private float getAmountPaid() {
            return this.amountpaid;
        }
        private float getChange() {
            return this.change;
        }
        private String getType() {
            return this.type.ToUpper();
        }


        private void setUser(SystemUser user) {
            this.user = user;
        }
        private void setVendor(Company vendor) {
            this.vendor = vendor;
        }
        private void setDelivery(Delivery delivery) {
            this.delivery = delivery;
        }
        private void setGoodsReceipt(GoodsReceipt greceipt) {
            this.greceipt = greceipt;
        }
        private void setGrossTotal(Currency grossTotal) {
            this.grossTotal = grossTotal.getValue();
        }
        private void setActualTotal(Currency actualTotal) {
            this.actualTotal = actualTotal.getValue();
        }
        private void setAmountPaid(Currency amountpaid) {
            this.amountpaid = amountpaid.getValue();
        }
        private void setChange(Currency change) {
            this.change = change.getValue();
        }
        private void setType(SingleWordAlpha type) {
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
                    "change",
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
