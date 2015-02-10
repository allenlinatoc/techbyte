using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models.Architecture.Profiles
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



        public void setEmail(String email) {
            this.email = email;
        }

        public void setFax(String fax) {
            this.fax = fax;
        }

        public void setLandline(String landline) {
            this.landline = landline;
        }

        public void setMobile(String mobile) {
            this.mobile = mobile;
        }
    }
}
