using Guitar32.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TechByte.Architecture.Validations
{
    public sealed class UserPower : Guitar32.Validator, Guitar32.Common.IStringDatatype
    {
        public static String message = "Power does not exist";
        private string value;
        const int MIN_LENGTH = 1;
        const int MAX_LENGTH = 50;
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private int powerId;


        public UserPower(int powerId, bool throwException = false) {
            this.powerId = powerId;
            Boolean valid = this.isValid();
            if (!valid && throwException) {
                if (!valid) {
                    throw new InvalidUserPowerException();
                }
                //if (this.getValue().Length > 0) {
                //    if (!this.isWithinRange()) {
                //        throw new Guitar32.Exceptions.OutOfRangeLengthException();
                //    }
                //}
            }
        }
        public UserPower(String powerName, bool throwException = false) {
            this.value = powerName;
            Boolean valid = this.isValid();
            if (!valid && throwException) {
                if (!valid) {
                    throw new InvalidUserPowerException();
                }
                if (!this.isWithinRange()) {
                    throw new Guitar32.Exceptions.OutOfRangeLengthException();
                }
            }
        }


        public int getMaxLength() {
            return MAX_LENGTH;
        }

        public int getMinLength() {
            return MIN_LENGTH;
        }

        public int getPowerId() {
            return this.powerId;
        }

        public string getValue() {
            return this.value;
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            // Check string length
            if (this.getValue().Length == 0) {
                return true;
            }

            // Lookup in database
            if (this.value == null) {
                String powerName = this.LookupName();
                if (powerName != null) {
                    this.value = powerName.ToUpper();
                }
                return powerName != null;
            }
            else {
                int powerId = this.LookupId();
                if (powerId != null) {
                    this.powerId = powerId;
                }
                return powerId != null;
            }
        }

        /// <summary>
        /// Lookup the integer in database
        /// </summary>
        /// <returns>The resulting name of power, otherwise, null</returns>
        private String LookupName() {
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tblpowers")
                .Where("id=" + this.powerId);
            Dictionary<string, object> row = dbConn.QuerySingle(query);
            if (row == null) {
                return null;
            }
            else {
                return row["name"].ToString();
            }
        }

        private int LookupId() {
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tblpowers")
                .Where("name = " + Guitar32.Utilities.Strings.Surround(this.value))
            ;
            Dictionary<string, object> row = dbConn.QuerySingle(query);
            if (row == null) {
                return -1;
            }
            else {
                return int.Parse(row["id"].ToString());
            }
        }
    }

    public class InvalidUserPowerException : Exception {
        public InvalidUserPowerException()
            : base("Value didn't comply to UserPower number format") { }
    }
}
