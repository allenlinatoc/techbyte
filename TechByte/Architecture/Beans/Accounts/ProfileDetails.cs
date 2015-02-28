using Guitar32;
using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture;

namespace TechByte.Architecture.Beans.Accounts
{
    public class ProfileDetails : Model, Guitar32.Common.IDatabaseEntity
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        public Profiles.AddressDetails
            addressDetails;
        public Profiles.ContactDetails
            contactDetails;
        public Profiles.Fullname
            fullname;
        protected String
            birthDate,
            birthPlace,
            gender,
            nationality,
            TIN,
            SSS,
            PAGIBIG
        ;

        public ProfileDetails(int id = -1) {
            if (id >= 0) {
                // Fetch data
                this.setId(id);
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblprofiles")
                    .Where("id", id);
                QueryResultRow row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    Profiles.AddressDetails addressDetails = new Profiles.AddressDetails(int.Parse(row["address_id"] + ""));
                    Profiles.ContactDetails contactDetails = new Profiles.ContactDetails(int.Parse(row["contact_id"] + ""));
                    Profiles.Fullname fullName = new Profiles.Fullname();
                    fullName.setFirstName(new MultiWordAlpha(row["fname"].ToString()));
                    fullName.setMiddleName(new MultiWordAlpha(row["mname"].ToString()));
                    fullName.setLastName(new MultiWordAlpha(row["lname"].ToString()));
                    this.setFullname(fullName);
                    this.setAddressDetails(addressDetails);
                    this.setContactDetails(contactDetails);
                    this.setGender(new Gender(row["gender"].ToString()));
                    this.setBirthDate(Guitar32.Validations.DateTime.CreateFromNativeDateTime(System.DateTime.Parse(row["birthdate"].ToString())));
                    this.setBirthPlace(new MultiWord(row["birthplace"].ToString()));
                    this.setNationality(new MultiWordAlpha(row["nationality"].ToString()));
                    this.setTIN(new Validations.TIN(row["tin"].ToString()));
                    this.setSSS(row["sss"].ToString());
                    this.setPAGIBIG(row["pagibig"].ToString());
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }


        public Profiles.AddressDetails getAddressDetails() {
            return this.addressDetails;
        }

        public Profiles.ContactDetails getContactDetails() {
            return this.contactDetails;
        }

        public Profiles.Fullname getFullname() {
            return this.fullname;
        }

        public String getGender() {
            return this.gender;
        }

        public String getBirthDate() {
            return this.birthDate;
        }

        public String getBirthPlace() {
            return this.birthPlace;
        }

        public String getNationality() {
            return this.nationality;
        }

        public String getTIN() {
            return this.TIN;
        }

        public String getSSS() {
            return this.SSS;
        }

        public String getPAGIBIG() {
            return this.PAGIBIG;
        }


        public void setAddressDetails(Profiles.AddressDetails addressDetails) {
            this.addressDetails = addressDetails;
        }

        public void setContactDetails(Profiles.ContactDetails contactDetails) {
            this.contactDetails = contactDetails;
        }

        public void setFullname(Profiles.Fullname fullname) {
            this.fullname = fullname;
        }

        public void setGender(Guitar32.Validations.Gender gender) {
            this.gender = gender.getValue().ToUpper();
        }

        public void setBirthDate(Guitar32.Validations.DateTime birthDate) {
            this.birthDate = birthDate.getValue();
        }

        public void setBirthPlace(Guitar32.Validations.MultiWord birthPlace) {
            this.birthPlace = birthPlace.getValue();
        }

        public void setNationality(Guitar32.Validations.MultiWordAlpha nationality) {
            this.nationality = nationality.getValue();
        }

        public void setTIN(Architecture.Validations.TIN TIN) {
            this.TIN = TIN.getValue();
        }

        public void setSSS(String SSS) {
            this.SSS = SSS;
        }

        public void setPAGIBIG(String PAGIBIG) {
            this.PAGIBIG = PAGIBIG;
        }



        public bool CreateData() {
            if (!this.exists() && !this.getContactDetails().exists() && !this.getAddressDetails().exists()) {
                bool contactCreateSuccess = this.getContactDetails().CreateData();
                bool addressCreateSuccess = this.getAddressDetails().CreateData();
                if (contactCreateSuccess && addressCreateSuccess) {
                    int
                        contactId = this.getContactDetails().getId(),
                        addressId = this.getAddressDetails().getId()
                    ;

                    QueryBuilder query = new QueryBuilder();
                    query.InsertInto("tblprofiles", new string[] {
                        "address_id", "contact_id",
                        "fname", "mname", "lname", "gender", "birthdate", "birthplace", "nationality", "tin", "sss", "pagibig"
                    })
                        .Values(new object[] {
                            addressId,
                            contactId,
                            Strings.Surround(this.getFullname().getFirstName()),
                            Strings.Surround(this.getFullname().getMiddleName()),
                            Strings.Surround(this.getFullname().getLastName()),
                            Strings.Surround(this.getGender()),
                            Strings.Surround(this.getBirthDate()),
                            Strings.Surround(this.getBirthPlace()),
                            Strings.Surround(this.getNationality()),
                            Strings.Surround(this.getTIN()),
                            Strings.Surround(this.getSSS()),
                            Strings.Surround(this.getPAGIBIG())
                        });
                    Boolean success = dbConn.Execute(query);
                    if (success) {
                        this.setId(dbConn.GetLastInsertID());
                    }
                    return success;
                }
            }
            return false;
        }

        public bool Delete() {
            if (this.exists()) {
                Boolean addressDeleteSuccess = this.getAddressDetails().Delete();
                Boolean contactDeleteSuccess = this.getContactDetails().Delete();
                if (addressDeleteSuccess && contactDeleteSuccess) {
                    // Once both address and contact were deleted,
                    //  this profile detail will also be cascaded
                    return true;
                }
            }
            return false;
        }

        public bool Update() {
            if (this.exists()) {
                // Try to update child beans first
                if (!this.getAddressDetails().Update() || !this.getContactDetails().Update()) {
                    return false;
                }
                // Proceed with update
                Dictionary<string, string> setPairs = new Dictionary<string, string>();
                setPairs.Add("fname", Strings.Surround(this.getFullname().getFirstName()));
                setPairs.Add("mname", Strings.Surround(this.getFullname().getMiddleName()));
                setPairs.Add("lname", Strings.Surround(this.getFullname().getLastName()));
                setPairs.Add("gender", Strings.Surround(this.getGender()));
                setPairs.Add("birthdate", Strings.Surround(this.getBirthDate()));
                setPairs.Add("birthplace", Strings.Surround(this.getBirthPlace()));
                setPairs.Add("nationality", Strings.Surround(this.getNationality()));
                setPairs.Add("tin", Strings.Surround(this.getTIN()));
                setPairs.Add("sss", Strings.Surround(this.getSSS()));
                setPairs.Add("pagibig", Strings.Surround(this.getPAGIBIG()));

                QueryBuilder query = new QueryBuilder();
                query.Update("tblprofiles").Set(setPairs).Where("id", this.getId());
                return dbConn.Execute(query);
            }
            return false;
        }
    }
}
