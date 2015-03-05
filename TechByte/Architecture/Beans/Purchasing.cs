using Guitar32;
using Guitar32.Database;
using Guitar32.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture.Beans.Business;
using TechByte.Architecture.Beans.Goods;

namespace TechByte.Architecture.Beans
{
    public class Purchasing : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private Invoice invoice;



        public Purchasing(int id=-1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblpurchasings")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setInvoice(new Invoice(Integer.Parse(row["invoice_id"])));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        public Invoice getInvoice() {
            return this.invoice;
        }
        public void setInvoice(Invoice invoice) {
            this.invoice = invoice;
        }


        public bool CreateData() {
            if (!this.exists()) {
                if (!this.getInvoice().exists()) {
                    if (!this.getInvoice().CreateData()) {
                        Console.WriteLine("Failed to create child invoice instance");
                        return false;
                    }
                }
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblpurchasings", new string[] { "invoice_id" })
                    .Values(new object[] {
                        this.getInvoice().getId()
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
