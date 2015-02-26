using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guitar32;
using TechByte.Architecture;

namespace TechByte.Architecture.Beans.Accounts
{
    public class Userprofile : Model
    {
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
        

    }
}
