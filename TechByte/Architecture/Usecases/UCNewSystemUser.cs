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
    public class UCNewSystemUser : TechByte.Architecture.Beans.Accounts.SystemUser
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;

        public UCNewSystemUser() { }


        public void Register() {
            QueryBuilder query = new QueryBuilder();
            int powerId,
                addressId,
                contactId,
                profileId
            ;

            // Check if already exists
            query.Select()
                .From("tblusers")
                .Where("upper(username) = " + Strings.Surround(this.getUsername().ToUpper()));
            QueryResultRow rowMatched = dbConn.QuerySingle(query);
            if (rowMatched != null && rowMatched.Count > 0) {
                this.setResponse(CODES.USERNAME_ALREADY_TAKEN);
                return;
            }

            // Get PowerID
            query.Select("id")
                .From("tblpowers")
                .Where("lower(name) = " + Guitar32.Utilities.Strings.Surround(this.getPower().ToLower()))
                ;
            // Check for database error
            try {
                QueryResultRow row = dbConn.QuerySingle(query);
                powerId = int.Parse(row["id"].ToString());
            }
            catch (Exception ex) {
                Console.WriteLine(query.getQueryString());
                this.setResponse(TechByte.Values.CODES.DATABASE_ERROR);
                return;
            }

            // {{ BLOCK for Contact details creation
            TechByte.Architecture.Beans.Profiles.ContactDetails
                contactDetails = this.getProfile().getContactDetails();
            query.InsertInto("tblcontactdetails", new string[] { "email", "mobile", "landline", "fax" })
                .Values(new object[] {
                    Strings.Surround(contactDetails.getEmail()),
                    Strings.Surround(contactDetails.getMobile()),
                    Strings.Surround(contactDetails.getLandline()),
                    Strings.Surround(contactDetails.getFax())
                });
            // Check for database error
            if (!dbConn.Execute(query)) {
                this.setResponse(TechByte.Values.CODES.DATABASE_ERROR);
                return;
            }
            // Save Contact ID
            query.Select("last_insert_id() AS id");
            contactId = int.Parse(dbConn.QuerySingle(query)["id"]+"");
            // }}
            // {{ BLOCK for Address details creation
            TechByte.Architecture.Beans.Profiles.AddressDetails
                addressDetails = this.getProfile().getAddressDetails();
            query.InsertInto("tbladdressdetails", new string[] { "street", "city", "region", "country" })
                .Values(new object[] {
                    Strings.Surround(addressDetails.getStreet()),
                    Strings.Surround(addressDetails.getCity()),
                    Strings.Surround(addressDetails.getRegion()),
                    Strings.Surround(addressDetails.getCountry())
                });
            // Check for database error
            if (!dbConn.Execute(query)) {
                this.setResponse(TechByte.Values.CODES.DATABASE_ERROR);
                return;
            }
            // Save Address ID
            query.Select("last_insert_id() AS id");
            addressId = int.Parse(dbConn.QuerySingle(query)["id"] + "");
            // }}
            // {{ BLOCK for Profile details
            TechByte.Architecture.Beans.Accounts.ProfileDetails
                profileDetails = this.getProfile();
            query.InsertInto("tblprofiles", new string[] { "address_id", "contact_id", "fname", "mname", "lname", "gender", "birthdate", "birthplace", "nationality", "tin", "sss", "pagibig" })
                .Values(new object[] {
                    addressId,
                    contactId,
                    Strings.Surround(profileDetails.getFullname().getFirstName()),
                    Strings.Surround(profileDetails.getFullname().getMiddleName()),
                    Strings.Surround(profileDetails.getFullname().getLastName()),
                    Strings.Surround(profileDetails.getGender()),
                    Strings.Surround(profileDetails.getBirthDate()),
                    Strings.Surround(profileDetails.getBirthPlace()),
                    Strings.Surround(profileDetails.getNationality()),
                    Strings.Surround(profileDetails.getTIN()),
                    Strings.Surround(profileDetails.getSSS()),
                    Strings.Surround(profileDetails.getPAGIBIG())
                });
            if (!dbConn.Execute(query)) {
                this.setResponse(TechByte.Values.CODES.DATABASE_ERROR);
                return;
            }
            // Save User ID
            query.Select("last_insert_id() AS id");
            profileId = int.Parse(dbConn.QuerySingle(query)["id"] + "");
            // }}
            // {{ BLOCK for User account creation
            query.InsertInto("tblusers", new string[] { "power_id", "profile_id", "username", "password", "status" })
                .Values(new object[] {
                    powerId,
                    profileId,
                    Strings.Surround(this.getUsername()),
                    Strings.Surround(this.getPassword()),
                    Strings.Surround(this.getStatus())
                });
            // Check for database error
            if (!dbConn.Execute(query)) {
                this.setResponse(TechByte.Values.CODES.DATABASE_ERROR);
                return;
            }
            // }}

            // Success!
            this.setResponse(new SystemResponse("00", "Account has been succcessfully created!"));
        }


    }
}
