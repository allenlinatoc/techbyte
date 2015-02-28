using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guitar32;
using Guitar32.Database;
using Guitar32.Validations;
using TechByte.Architecture;

namespace TechByte.Architecture.Beans.Profiles
{
    public class Fullname : Model
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        protected String firstName;
        protected String middleName;
        protected String lastName;


        public Fullname(int profileId = -1) {
            this.setId(profileId);
            if (this.getId() >= 0) {
                QueryBuilder query = new QueryBuilder();
                query.Select(new string[] { "fname", "mname", "lname" })
                    .From("tblprofiles")
                    .Where("id", profileId);
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setFirstName(new MultiWordAlpha(row["fname"].ToString()));
                    this.setMiddleName(new MultiWordAlpha(row["mname"].ToString()));
                    this.setLastName(new MultiWordAlpha(row["lname"].ToString()));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }


        public String getFirstName() {
            return this.firstName;
        }

        public String getMiddleName() {
            return this.middleName;
        }

        public String getLastName() {
            return this.lastName;
        }

        public void setFirstName(MultiWordAlpha firstName) {
            this.firstName = firstName.getValue();
        }

        public void setMiddleName(MultiWordAlpha middleName) {
            this.middleName = middleName.getValue();
        }

        public void setLastName(MultiWordAlpha lastName) {
            this.lastName = lastName.getValue();
        }
    }
}
