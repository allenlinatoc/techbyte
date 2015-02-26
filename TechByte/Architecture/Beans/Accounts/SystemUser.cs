using Guitar32;
using Guitar32.Database;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TechByte.Architecture;

namespace TechByte.Architecture.Beans.Accounts
{
    public class SystemUser : Model
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private String
            username,
            password
            ;
        private ProfileDetails
            profile
            ;
        private String status;
        private String power;

        public SystemUser(int id = -1) {
            this.setId(id);
            if (this.getId() >= 0) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblusers")
                    .Where("id", id);
                Dictionary<string, object> row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    ProfileDetails profileDetails = new ProfileDetails(int.Parse(row["profile_id"].ToString()));
                    this.setUsername(new SingleWordAlphaNumeric(row["username"].ToString()));
                    this.setStatus(new Validations.AccountStatus(row["status"].ToString()));
                    this.setProfile(profileDetails);
                }
            }
        }

        public String getPassword() {
            return this.password;
        }

        public String getPower() {
            return this.power;
        }

        public String getStatus() {
            return this.status;
        }

        public String getUsername() {
            return this.username;
        }

        public ProfileDetails getProfile() {
            return this.profile;
        }

        public void setPassword(Guitar32.Validations.Password password) {
            this.password = password.getValue();
        }

        public void setPower(TechByte.Architecture.Validations.UserPower userPower) {
            this.power = userPower.getValue();
        }

        public void setStatus(Architecture.Validations.AccountStatus status) {
            this.status = status.getValue();
        }

        public void setUsername(Guitar32.Validations.SingleWordAlphaNumeric username) {
            this.username = username.getValue();
        }

        public void setProfile(ProfileDetails profile) {
            this.profile = profile;
        }

    }
}