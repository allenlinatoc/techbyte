using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guitar32;

using TechByte.Architecture;

namespace TechByte.Architecture.Beans.Profiles
{
    public class ContactDetails : Model
    {
        protected String
            email,
            mobile,
            landline,
            fax;

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
    }
}
