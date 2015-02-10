using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models.Architecture.Profiles
{
    public class Fullname
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

        public void setFirstName(String firstName) {
            this.firstName = firstName;
        }

        public void setMiddleName(String middleName) {
            this.middleName = middleName;
        }

        public void setLastName(String lastName) {
            this.lastName = lastName;
        }
    }
}
