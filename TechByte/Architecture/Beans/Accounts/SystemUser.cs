using Guitar32;
using Guitar32.Database;
using Guitar32.Exceptions;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TechByte.Architecture;

namespace TechByte.Architecture.Beans.Accounts
{
    public class SystemUser : Model, Guitar32.Common.IDatabaseEntity
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
        private TechByte.Architecture.Validations.UserPower userPower;

        public SystemUser(int id = -1) {
            this.setId(id);
            if (this.getId() >= 0) {
                QueryBuilder query = new QueryBuilder();
                Dictionary<object, object> conditions = new Dictionary<object, object>();
                conditions.Add("user_id", id);
                conditions.Add("user_power_id", "power_id");
                query.Select()
                    .From("view_users, view_powers")
                    .Where(conditions);
                Dictionary<string, object> row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    ProfileDetails profileDetails = new ProfileDetails(int.Parse(row["user_profile_id"].ToString()));
                    this.setUsername(new SingleWordAlphaNumeric(row["user_username"].ToString()));
                    this.setStatus(new Validations.AccountStatus(row["user_status"].ToString()));
                    this.setPower(new Validations.UserPower(int.Parse(row["power_id"].ToString())));
                    this.setProfile(profileDetails);
                }
                else {
                    throw new BeanDataNotFoundException();
                }
            }
        }

        public String getPassword() {
            return this.password;
        }

        public String getPower() {
            return this.userPower.getValue();
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
            this.userPower = userPower;
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


        public bool CreateData() {
            if (!this.getProfile().exists()) {
                Boolean profileCreateSuccess = this.getProfile().CreateData();
                if (!profileCreateSuccess) {
                    return false;
                }
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblusers", new string[] {
                    "power_id", "profile_id",
                    "username", "password"
                })
                    .Values(new object[] {
                        this.userPower.getPowerId(),
                        this.getProfile().getId(),
                        Strings.Surround(this.getUsername()),
                        Strings.Surround(this.getPassword())
                    });
                Boolean success = dbConn.Execute(query);
                if (success) {
                    this.setId(dbConn.GetLastInsertID());
                }
                return success;
            }
            return false;
        }


        public bool Delete() {
            if (this.exists() && this.getProfile().exists()) {
                Boolean profileDeleteSuccess = this.getProfile().Delete();
                // If profile deletion is success,
                //  this instance will also be cascadely deleted from database
                return profileDeleteSuccess;
            }
            return false;
        }


        public bool Update() {
            if (this.exists()) {
                Dictionary<string, string> setPairs = new Dictionary<string, string>();
                setPairs.Add("username", Strings.Surround(this.getUsername()));
                setPairs.Add("status", Strings.Surround(this.getStatus()));

                QueryBuilder query = new QueryBuilder();
                query.Update("tblusers")
                    .Set(setPairs)
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }


        public bool UpdatePassword() {
            if (this.exists() && this.getPassword()!=null && this.getPassword().Length > 0) {
                QueryBuilder query = new QueryBuilder();
                query.Update("tblusers")
                    .Set("password", Strings.Surround(this.getPassword()))
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }

    }
}