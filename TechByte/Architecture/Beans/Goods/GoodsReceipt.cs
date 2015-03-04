using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Warehouse;

namespace TechByte.Architecture.Beans.Goods
{
    public class GoodsReceipt : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        const string TABLE = "tblgreceipts";
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private SystemUser PIC;
        private WarehouseEntry warehouseEntry;
        private String created;
        private String type;

        public GoodsReceipt(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select().From(TABLE).Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setPIC(new SystemUser(Integer.Parse(row["user_id"])));
                    this.setWarehouseEntry(new WarehouseEntry(Integer.Parse(row["warehouse_id"])));
                    this.setCreationDate(new Guitar32.Validations.DateTime(row["created"].ToString()));
                    this.setType(new SingleWordAlpha(row["type"].ToString()));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        private SystemUser getPIC() {
            return this.PIC;
        }
        private WarehouseEntry getWarehouseEntry() {
            return this.warehouseEntry;
        }
        private String getCreationDate() {
            return this.created;
        }
        private String getType() {
            return this.type;
        }

        private void setPIC(SystemUser PIC) {
            this.PIC = PIC;
        }
        private void setWarehouseEntry(WarehouseEntry warehouseEntry) {
            this.warehouseEntry = warehouseEntry;
        }
        private void setCreationDate(Guitar32.Validations.DateTime created) {
            this.created = created.getValue();
        }
        private void setType(SingleWordAlpha type) {
            this.type = type.getValue();
        }



        public bool CreateData() {
            if (!this.exists() && this.getPIC().exists() && this.getWarehouseEntry().exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto(TABLE, new string[] { "user_id", "warehouse_id", "created", "type" })
                    .Values(new object[] {
                        this.getPIC().getId(),
                        this.getWarehouseEntry().getId(),
                        Strings.Surround(this.getCreationDate()),
                        Strings.Surround(this.getType())
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
