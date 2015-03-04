using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture.Beans.Goods;

namespace TechByte.Architecture.Beans.Warehouse
{
    public class WarehouseEntryItem : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        const string TABLE = "tblwarehouselist";
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private Good good;
        private WarehouseEntry parentWarehouseEntry;
        private int quantity;


        public WarehouseEntryItem(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select().From(TABLE).Where("id", id);
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setGood(new Good(Integer.Parse(row["good_id"])));
                    this.setQuantity(Integer.Parse(row["quantity"]));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        public Good getGood() {
            return this.good;
        }
        public WarehouseEntry getParentWarehouseEntry() {
            return this.parentWarehouseEntry;
        }
        public int getQuantity() {
            return this.quantity;
        }

        public void setGood(Good good) {
            this.good = good;
        }
        public void setParentWarehouseEntry(WarehouseEntry warehouseEntry) {
            this.parentWarehouseEntry = warehouseEntry;
        }
        public void setQuantity(int quantity) {
            this.quantity = quantity;
        }




        public bool CreateData() {
            if (!this.exists() && this.getGood().exists() && this.getParentWarehouseEntry().exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto(TABLE, new string[] { "good_id", "warehouse_id", "quantity" })
                    .Values(new object[] {
                        this.getGood().getId(),
                        this.getParentWarehouseEntry().getId(),
                        this.getQuantity()
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
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.DeleteFrom(TABLE)
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }

        public bool Update() {
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                Dictionary<string, string> setPairs = new Dictionary<string, string>();
                setPairs.Add("good_id", this.getGood().getId().ToString());
                setPairs.Add("warehouse_id", this.getParentWarehouseEntry().getId().ToString());
                setPairs.Add("quantity", this.getQuantity().ToString());
                query.Update(TABLE)
                    .Set(setPairs)
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }

    }
}
