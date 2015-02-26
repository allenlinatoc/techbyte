using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guitar32;
using Guitar32.Database;
using Guitar32.Validations;

namespace TechByte.Architecture.Beans.Profiles
{
    public class AddressDetails : Model
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        protected String
            street,
            city,
            region,
            country;


        public AddressDetails(int id = -1) {
            this.setId(id);
            if (this.getId() >= 0) {
                // Fetch data
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tbladdressdetails")
                    .Where("id", id);
                Dictionary<string, object> row = dbConn.QuerySingle(query);
                if (row != null && row.Count > 0) {
                    this.setStreet(new MultiWord(row["street"].ToString()));
                    this.setCity(new MultiWordAlpha(row["city"].ToString()));
                    this.setRegion(new MultiWordAlpha(row["region"].ToString()));
                    this.setCountry(new MultiWordAlpha(row["country"].ToString()));
                }
                else {
                    throw new Guitar32.Exceptions.BeanDataNotFoundException();
                }
            }
        }


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
