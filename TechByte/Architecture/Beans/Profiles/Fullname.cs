using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechByte.Architecture;
using Guitar32;
using Guitar32.Validations;

namespace TechByte.Architecture.Beans.Profiles
{
    public class Fullname : Model
    {
        protected String firstName;
        protected String middleName;
        protected String lastName;



        public String getFirstName() {
            return this.firstName;
        }

        public String getMiddleName() {
            return this.middleName;
        }

        public String getLastName() {
            return this.lastName;
        }

        public void setFirstName(MultiWordAlpha firstName) {
            this.firstName = firstName.getValue();
        }

        public void setMiddleName(MultiWordAlpha middleName) {
            this.middleName = middleName.getValue();
        }

        public void setLastName(MultiWordAlpha lastName) {
            this.lastName = lastName.getValue();
        }
    }
}
