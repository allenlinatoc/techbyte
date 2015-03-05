using Guitar32.Controllers;
using Guitar32.Data;
using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Architecture.Beans
{
    public class Sales : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private SalesInvoice salesInvoice;


        public Sales(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblsales")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    SalesInvoice salesInvoice = new SalesInvoice(Integer.Parse(row["salesinvoice_id"]));
                    this.setSalesInvoice(salesInvoice);
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }


        public SalesInvoice getSalesInvoice() {
            return this.salesInvoice;
        }
        public void setSalesInvoice(SalesInvoice salesInvoice) {
            this.salesInvoice = salesInvoice;
        }



        public bool CreateData() {
            if (!this.exists()) {
                if (!this.getSalesInvoice().exists()) {
                    if (!this.getSalesInvoice().CreateData()) {
                        Console.WriteLine("Unable to create child Sales Invoice of Sales");
                        return false;
                    }
                }
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblsales", new string[] { "salesinvoice_id" })
                    .Values(new object[] {
                        this.getSalesInvoice().getId()
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
