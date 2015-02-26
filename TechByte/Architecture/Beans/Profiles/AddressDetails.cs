using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guitar32;
using Guitar32.Validations;

namespace TechByte.Architecture.Beans.Profiles
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

        public void setStreet(MultiWord street) {
            this.street = street.getValue();
        }

        public void setCity(MultiWordAlpha city) {
            this.city = city.getValue();
        }

        public void setRegion(MultiWordAlpha region) {
            this.region = region.getValue();
        }

        public void setCountry(MultiWordAlpha country) {
            this.country = country.getValue();
        }
    }
}
