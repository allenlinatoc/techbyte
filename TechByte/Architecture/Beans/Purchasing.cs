using Guitar32;
using Guitar32.Database;
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
        private Company vendor;



        public Purchasing(int id=-1) {
            this.setId(id);
            if (this.exists()) {

            }
        }


        public bool CreateData() {
            throw new NotImplementedException();
        }

        public bool Delete() {
            throw new NotImplementedException();
        }

        public bool Update() {
            throw new NotImplementedException();
        }
    }
}
