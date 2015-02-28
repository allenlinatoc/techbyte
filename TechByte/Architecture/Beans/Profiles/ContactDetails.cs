using Guitar32;
using Guitar32.Database;
using Guitar32.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TechByte.Architecture;

namespace TechByte.Architecture.Beans.Profiles
{
    public class ContactDetails : Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        protected String
            email,
            mobile,
            landline,
            fax;

        public ContactDetails(int id = -1) {
            this.setId(id);
            if (this.getId() >= 0) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblcontactdetails")
                    .Where("id", id);
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setEmail(new Guitar32.Validations.Email(row["email"].ToString()));
                    this.setMobile(new TechByte.Architecture.Validations.MobileNumber(row["mobile"].ToString()));
                    this.setLandline(row["landline"].ToString());
                    this.setFax(row["fax"].ToString());
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }


        public String getEmail() {
            return this.email;
        }

        public String getFax() {
            return this.fax;
        }

        public String getLandline() {
            return this.landline;
        }

        public String getMobile() {
            return this.mobile;
        }



        public void setEmail(Guitar32.Validations.Email email) {
            this.email = email.getValue();
        }

        public void setFax(String fax) {
            this.fax = fax;
        }

        public void setLandline(String landline) {
            this.landline = landline;
        }

        public void setMobile(Architecture.Validations.MobileNumber mobile) {
            this.mobile = mobile.getValue();
        }

        public bool CreateData() {
            if (!this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblcontactdetails", new string[] { "email", "mobile", "landline", "fax" })
                    .Values(new object[] {
                    Strings.Surround(this.getEmail()),
                    Strings.Surround(this.getMobile()),
                    Strings.Surround(this.getLandline()),
                    Strings.Surround(this.getFax())
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
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.DeleteFrom("tblcontactdetails")
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }

        public bool Update() {
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                Dictionary<string, string> setPairs = new Dictionary<string, string>();
                setPairs.Add("email", Strings.Surround(this.getEmail()));
                setPairs.Add("mobile", Strings.Surround(this.getMobile()));
                setPairs.Add("landline", Strings.Surround(this.getLandline()));
                setPairs.Add("fax", Strings.Surround(this.getFax()));
                query.Update("tblcontactdetails")
                    .Set(setPairs)
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }
    }
}
