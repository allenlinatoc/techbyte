using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Guitar32;
using Guitar32.Database;

namespace TechByte.Architecture.Usecases
{
    public class UCSystemUserCollection : Guitar32.Model
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;

        public UCSystemUserCollection() : base() { }

        public UCSystemUserCollection Fetch() {
            QueryBuilder query = new QueryBuilder();

            Dictionary<object, object> conditions = new Dictionary<object, object>();
            conditions.Add("profile_user_id", "user_id");
            conditions.Add("profile_address_id", "address_id");
            conditions.Add("profile_contact_id", "contact_id");
            conditions.Add("user_power_id", "power_id");
            query.Select()
                .From("view_users, view_powers, view_profiles, view_contactdetails, view_addressdetails")
                .Where(conditions)
            ;
            QueryResult result = dbConn.Query(query);
            this.setResponse(new SystemResponse("00", "Fetch success", result));
            return this;
        }
    }
}
