using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models.Architecture.Accounts
{
    public class Userprofile : Model
    {
        public Profiles.AddressDetails
            addressDetails;
        public Profiles.ContactDetails
            contactDetails;
        public Profiles.Fullname
            fullname;
        public Type
            type;
        public Gender
            gender;
        protected String
            birthDate;
        protected String
            birthPlace;
        protected String
            nationality;
        protected String
            TIN;


        public Profiles.AddressDetails getAddressDetails() {
            return this.addressDetails;
        }

        public Profiles.ContactDetails getContactDetails() {
            return this.contactDetails;
        }

        public Profiles.Fullname getFullname() {
            return this.fullname;
        }

        public Type getType() {
            return this.type;
        }

        public Gender getGender() {
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


        public void setAddressDetails(Profiles.AddressDetails addressDetails) {
            this.addressDetails = addressDetails;
        }

        public void setContactDetails(Profiles.ContactDetails contactDetails) {
            this.contactDetails = contactDetails;
        }

        public void setFullname(Profiles.Fullname fullname) {
            this.fullname = fullname;
        }

        public void setType(Type type) {
            this.type = type;
        }

        public void setGender(Gender gender) {
            this.gender = gender;
        }

        public void setBirthDate(String birthDate) {
            this.birthDate = birthDate;
        }

        public void setBirthPlace(String birthPlace) {
            this.birthPlace = birthPlace;
        }

        public void setNationality(String nationality) {
            this.nationality = nationality;
        }

        public void setTIN(String TIN) {
            this.TIN = TIN;
        }




        /// <summary>
        /// Profile's gender
        /// </summary>
        public enum Gender
        {
            FEMALE,
            MALE
        }

        /// <summary>
        /// Profile's type
        /// </summary>
        public enum Type
        {
            ADMIN,
            CUSTOMER,
            EMPLOYEE,
            VENDOR
        }
    }
}
