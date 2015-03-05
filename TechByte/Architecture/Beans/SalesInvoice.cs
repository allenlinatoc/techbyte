using Guitar32.Data;
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
    public class SalesInvoice : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private SystemUser user;
        private GoodsReturn greceipt;
        private float
            grossTotal,
            actualTotal,
            amountPaid,
            change;



        public SalesInvoice(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblsalesinvoice")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    SystemUser user = new SystemUser(Integer.Parse(row["user_id"]));
                    GoodsReturn greceipt = new GoodsReturn(Integer.Parse(row["greceipt_id"]));
                    this.setUser(user);
                    this.setGoodsReceipt(greceipt);
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




        public SystemUser getUser() {
            return this.user;
        }
        public GoodsReturn getGoodsReceipt() {
            return this.greceipt;
        }
        public float getGrossTotal() {
            return this.grossTotal;
        }
        public float getActualTotal() {
            return this.actualTotal;
        }
        public float getAmountPaid() {
            return this.amountPaid;
        }
        public float getChange() {
            return this.change;
        }


        public void setUser(SystemUser user) {
            this.user = user;
        }
        public void setGoodsReceipt(GoodsReturn greceipt) {
            this.greceipt = greceipt;
        }
        public void setGrossTotal(Currency grossTotal) {
            this.grossTotal = grossTotal.getValue();
        }
        public void setActualTotal(Currency actualTotal) {
            this.actualTotal = actualTotal.getValue();
        }
        public void setAmountPaid(Currency amountpaid) {
            this.amountPaid = amountpaid.getValue();
        }
        public void setChange(Currency change) {
            this.change = change.getValue();
        }



        public bool CreateData() {
            if (!this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblsalesinvoice", new string[] {
                    "user_id",
                    "greceipt_id",
                    "grosstotal",
                    "actualtotal",
                    "amountpaid",
                    "`change`"
                })
                    .Values(new object[] {
                        this.getUser().getId(),
                        this.getGoodsReceipt().getId(),
                        this.getGrossTotal(),
                        this.getActualTotal(),
                        this.getAmountPaid(),
                        this.getChange()
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
