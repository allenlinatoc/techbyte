using Guitar32.Database;
using Guitar32.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Architecture.Beans.Warehouse
{
    public class WarehouseEntryItemList : List<WarehouseEntryItem>
    {

        public WarehouseEntryItemList()
            : base() { }
        public WarehouseEntryItemList(IEnumerable<WarehouseEntryItem> collection)
            : base(collection) { }

        /// <summary>
        /// Deletes all item entry in this list from database
        /// </summary>
        /// <returns>If success</returns>
        public bool DeleteAll() {
            QueryBuilder query = new QueryBuilder();
            foreach (WarehouseEntryItem item in this) {
                if (!item.Delete()) {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// Get the total cost (gross) of all items enlisted here
        /// </summary>
        /// <returns></returns>
        public float GetTotalCost() {
            float totalCost = 0;
            for (int i = 0; i < this.Count; i++) {
                if (this[i].exists()) {
                    totalCost += this[i].getTotalCost();
                }
            }
            return totalCost;
        }


        /// <summary>
        /// Get the remaining number of stocks of a certain good
        /// </summary>
        /// <param name="goodId">The ID of the specific good</param>
        /// <returns></returns>
        static public int CountStocks(int goodId) {
            int count = 0;
            int incoming,
                outgoing;

            DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
            Dictionary<object, object> conditions = new Dictionary<object, object>();
            conditions.Add("good_id", goodId);
            conditions.Add("greceipt_type", "\"INCOMING\"");
            QueryBuilder query = new QueryBuilder();
            query.Select("sum(warehouselist_quantity) AS count")
                .From("view_s_fullwarehouse")
                .Where(conditions);
            QueryResultRow row = dbConn.QuerySingle(query);
            incoming = row["count"].ToString().Length == 0 ? 0 : Math.Abs(Integer.Parse(row["count"]));

            conditions["greceipt_type"] = "\"OUTGOING\"";
            query = new QueryBuilder();
            query.Select("sum(warehouselist_quantity) AS count")
                .From("view_s_fullwarehouse")
                .Where(conditions);
            row = dbConn.QuerySingle(query);
            outgoing = row["count"].ToString().Length == 0 ? 0 : Math.Abs(Integer.Parse(row["count"])) * -1;

            count = incoming + outgoing;

            return count;
        }

    }
}
