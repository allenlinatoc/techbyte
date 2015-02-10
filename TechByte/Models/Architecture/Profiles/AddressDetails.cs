using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models.Architecture.Profiles
{
    public class AddressDetails : Model
    {
        protected String
            street,
            city,
            region,
            country;



        public String getStreet() {
            return this.street;
        }

        public String getCity() {
            return this.city;
        }

        public String getRegion() {
            return this.region;
        }

        public String getCountry() {
            return this.country;
        }

        public void setStreet(String street) {
            this.street = street;
        }

        public void setCity(String city) {
            this.city = city;
        }

        public void setRegion(String region) {
            this.region = region;
        }

        public void setCountry(String country) {
            this.country = country;
        }
    }
}
