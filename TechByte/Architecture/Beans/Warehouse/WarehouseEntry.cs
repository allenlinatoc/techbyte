using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Architecture.Beans.Warehouse
{
    public class WarehouseEntry : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        const string TABLE = "tblwarehouse";
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private int key;
        private String created;

        // Generated field
        private WarehouseEntryItemList itemList;


        public WarehouseEntry(int id = -1) {
            this.setId(id);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select().From(TABLE).Where("id", this.getId());
                QueryResultRow myRow = dbConn.QuerySingle(query);
                if (myRow != null && myRow.Count > 0) {
                    this.setCreationDate(new Guitar32.Validations.DateTime(myRow["created"].ToString()));
                    // Fetch list
                    WarehouseEntryItemList itemList = new WarehouseEntryItemList();
                    query.Select()
                        .From("tblwarehouselist")
                        .Where("warehouse_id", this.getId());
                    QueryResult result = dbConn.Query(query);
                    for (int i = 0; i < result.RowCount(); i++) {
                        QueryResultRow row = result.GetSingle(i);
                        WarehouseEntryItem item = new WarehouseEntryItem(Integer.Parse(row["id"]));
                        item.setParentWarehouseEntry(this);
                        itemList.Add(item);
                    }
                    this.itemList = itemList;
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        public String getCreationDate() {
            return this.created;
        }
        public WarehouseEntryItem[] getItemList() {
            return this.itemList.ToArray();
        }
        public WarehouseEntryItemList getItemListObject() {
            return this.itemList;
        }

        public void setCreationDate(Guitar32.Validations.DateTime created) {
            this.created = created.getValue();
        }
        public void setItemList(WarehouseEntryItemList itemList) {
            this.itemList = itemList;
        }




        public bool CreateData() {
            if (!this.exists()) {
                if (this.getItemList() == null || this.getItemList().Length == 0) {
                    return false;
                }
                QueryBuilder query = new QueryBuilder();
                query.InsertInto(TABLE, new string[] { "created" })
                    .Values(new object[] {
                        Strings.Surround(this.getCreationDate())
                    });
                bool success = dbConn.Execute(query);
                if (success) {
                    Console.WriteLine("Success!");
                    this.setId(dbConn.GetLastInsertID());
                }

                WarehouseEntryItem[] list = this.getItemList();
                foreach (WarehouseEntryItem item in list) {
                    if (!item.CreateData()) {
                        this.itemList.DeleteAll();
                        return false;
                    }
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
