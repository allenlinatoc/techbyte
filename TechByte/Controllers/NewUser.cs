using Guitar32.Database;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture;
using TechByte.Architecture.Beans;
using TechByte.Architecture.Common;
using TechByte.Architecture.Validations;
using System.Windows.Forms;

namespace TechByte.Controllers
{
    public class NewUser : Guitar32.Model, INewSystemUser
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;

        public NewUser() { }



        public void Register(String position, string username, string password1, string password2, string firstName, string middleName, string lastName, string gender, string birthdate, string birthplace, string nationality, string TINnum, string SSS, string PAGIBIG, string email, string mobile, string landline, string fax, string street, string city, string region, string country) {

            // Check if passwords confirmed match
            if (!password1.Equals(password2)) {
                this.setResponse(TechByte.Values.CODES.REG_ERR_PASSWORDS);
                return;
            }

            try {
                QueryBuilder query = new QueryBuilder();

                // Create contact entry
                TechByte.Architecture.Beans.Profiles.ContactDetails
                    contactDetails = new Architecture.Beans.Profiles.ContactDetails();
                contactDetails.setEmail(new Email(email, true));
                contactDetails.setMobile(new MobileNumber(mobile, true));
                contactDetails.setFax(fax);
                contactDetails.setLandline(landline);
                // Create address entry
                TechByte.Architecture.Beans.Profiles.AddressDetails
                    addressDetails = new Architecture.Beans.Profiles.AddressDetails();
                addressDetails.setStreet(new MultiWord(street, true));
                addressDetails.setCity(new MultiWordAlpha(city, true));
                addressDetails.setRegion(new MultiWordAlpha(region, true));
                addressDetails.setCountry(new MultiWordAlpha(country, true));
                // Create profile entry
                TechByte.Architecture.Beans.Accounts.ProfileDetails
                    profileDetails = new Architecture.Beans.Accounts.ProfileDetails();
                TechByte.Architecture.Beans.Profiles.Fullname
                    fullName = new Architecture.Beans.Profiles.Fullname();
                fullName.setFirstName(new MultiWordAlpha(firstName, true));
                fullName.setMiddleName(new MultiWordAlpha(middleName, true));
                fullName.setLastName(new MultiWordAlpha(lastName, true));
                profileDetails.setFullname(fullName);
                profileDetails.setContactDetails(contactDetails);
                profileDetails.setAddressDetails(addressDetails);
                profileDetails.setGender(new Gender(gender, true));
                profileDetails.setNationality(new MultiWordAlpha(nationality, true));
                profileDetails.setBirthDate(new Guitar32.Validations.DateTime(birthdate, true));
                profileDetails.setBirthPlace(new MultiWord(birthplace, true));
                profileDetails.setTIN(new TIN(TINnum, true));
                profileDetails.setSSS(SSS);
                profileDetails.setPAGIBIG(PAGIBIG);
                // Create User entry
                TechByte.Architecture.Usecases.UCNewSystemUser
                    ucNewSystemUser = new Architecture.Usecases.UCNewSystemUser();
                ucNewSystemUser.setUsername(new SingleWordAlphaNumeric(username, true));
                ucNewSystemUser.setPassword(new Password(password1, true));
                ucNewSystemUser.setStatus(new AccountStatus("ACTIVE", true));
                ucNewSystemUser.setPower(new UserPower(position, true));
                ucNewSystemUser.setProfile(profileDetails);
                ucNewSystemUser.Register();
                this.setResponse(ucNewSystemUser.getResponse());
            }
            catch (Exception ex) {
                this.setResponse(TechByte.Values.CODES.INVALID_FORMAT);
                return;
            }
        }
    }
}
