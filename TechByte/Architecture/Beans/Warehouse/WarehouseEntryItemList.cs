using Guitar32.Database;
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

    }
}
