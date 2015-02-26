using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Guitar32;
using Guitar32.Database;
using Guitar32.Utilities;
using TechByte.Configs;
using TechByte.Values;


namespace TechByte.Architecture.Usecases
{
    public class UCSystemUser : TechByte.Architecture.Beans.Accounts.SystemUser
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;

        public UCSystemUser() { }


        public UCSystemUser Authenticate(string username, string password) {
            QueryBuilder query = new QueryBuilder();
            Dictionary<object,object> conditions = new Dictionary<object,object>();
            conditions.Add("username", Strings.Surround(username));
            conditions.Add("password", Strings.Surround(password));

            // Check for matches
            query.Select()
                .From("tblusers")
                .Where(conditions);
            if (DatabaseInstance.databaseConnection.Exists(query)) {
                this.setResponse(SystemResponse.Success);
                return this;
            }

            // Otherwise, invalid user
            this.setResponse(CODES.INVALID_LOGIN);
            return this;
        }


        public UCSystemUser Exists(string username) {
            QueryBuilder query = new QueryBuilder();

            Dictionary<object, object> conditions = new Dictionary<object, object>();
            conditions.Add("profile_user_id", "user_id");
            conditions.Add("profile_address_id", "address_id");
            conditions.Add("profile_contact_id", "contact_id");
            conditions.Add("user_power_id", "power_id");
            conditions.Add("user_username", Guitar32.Utilities.Strings.Surround(username));
            conditions.Add("limit", 1);
            query.Select()
                .From("view_users, view_powers, view_profiles, view_contactdetails, view_addressdetails")
                .Where(conditions);
            Dictionary<string, object> result;
            // Check for database error
            try {
                result = dbConn.QuerySingle(query);
                this.setResponse(new SystemResponse("00", "User exists", result));
            }
            catch (Exception ex) {
                this.setResponse(TechByte.Values.CODES.DATABASE_ERROR);
            }
            return this;
        }

    }
}
