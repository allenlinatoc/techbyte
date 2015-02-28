using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Profiles;
using TechByte.Architecture.Validations;

namespace TechByte.Architecture.Beans.Business
{
    public class Company : Guitar32.Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private String
            name,
            type;
        private AddressDetails addressDetails;
        private ContactDetails contactDetails;
        private String
            status;


        public Company(int companyId = -1) {
            this.setId(companyId);
            if (this.exists()) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblcompanies")
                    .Where("id", this.getId());
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setAddressDetails(new AddressDetails(Integer.Parse(row["address_id"])));
                    this.setContactDetails(new ContactDetails(Integer.Parse(row["contact_id"])));
                    this.setName(new MultiWord(row["name"].ToString()));
                    this.setType(new MultiWordAlpha(row["type"].ToString()));
                    this.setStatus(new AccountStatus(row["status"].ToString()));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }

        public String getName() {
            return this.name;
        }
        public String getType() {
            return this.type;
        }
        public AddressDetails getAddressDetails() {
            return this.addressDetails;
        }
        public ContactDetails getContactDetails() {
            return this.contactDetails;
        }
        public String getStatus() {
            return this.status;
        }

        public void setName(MultiWord name) {
            this.name = name.getValue();
        }
        public void setType(MultiWordAlpha type) {
            this.type = type.getValue();
        }
        public void setAddressDetails(AddressDetails addressDetails) {
            this.addressDetails = addressDetails;
        }
        public void setContactDetails(ContactDetails contactDetails) {
            this.contactDetails = contactDetails;
        }
        public void setStatus(AccountStatus status) {
            this.status = status.getValue();
        }



        public bool CreateData() {
            if (!this.exists()) {
                // Check child beans
                if (this.getAddressDetails().exists() || this.getContactDetails().exists()) {
                    throw new Guitar32.Exceptions.ChildBeanCreationException();
                }
                // Check for creation failure
                if (!this.getAddressDetails().CreateData() || !this.getContactDetails().CreateData()) {
                    return false;
                }
                // Proceed
                QueryBuilder query = new QueryBuilder();
                query.InsertInto("tblcompanies", new string[] {
                    "address_id", "contact_id",
                    "name",
                    "type"
                })
                    .Values(new object[] {
                        this.getAddressDetails().getId(), this.getContactDetails().getId(),
                        Strings.Surround(this.getName()),
                        Strings.Surround(this.getType())
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
            // Delete not allowed
            throw new NotImplementedException();
        }

        public bool Update() {
            if (this.exists()) {
                if (!this.getAddressDetails().Update() || !this.getContactDetails().Update()) {
                    throw new Guitar32.Exceptions.DataUpdateException();
                }

                Dictionary<string, string> setPairs = new Dictionary<string, string>();
                setPairs.Add("name", Strings.Surround(this.getName()));
                setPairs.Add("type", Strings.Surround(this.getType()));
                setPairs.Add("status", Strings.Surround(this.getStatus()));
                QueryBuilder query = new QueryBuilder();
                query.Update("tblcompanies")
                    .Set(setPairs)
                    .Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }
    }
}
