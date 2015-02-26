using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TechByte.Architecture.Validations
{
    public sealed class AccountStatus : Guitar32.Validator, Guitar32.Common.IStringDatatype
    {
        public static String expression = "^(ACTIVE|INACTIVE|PENDING)$";
        public static String message = "Only ACTIVE, INACTIVE and PENDING are allowed values";
        private string value;
        const int MIN_LENGTH = 6;
        const int MAX_LENGTH = 8;


        public AccountStatus(String value, bool throwException = false) {
            this.value = value;
            if (throwException && value != null) {
                if (!this.isValid()) {
                    throw new InvalidAccountStatusException();
                }
                //if (this.getValue().Length > 0) {
                //    if (!this.isWithinRange()) {
                //        throw new Guitar32.Exceptions.OutOfRangeLengthException();
                //    }
                //}
            }
        }


        public int getMaxLength() {
            return MAX_LENGTH;
        }

        public int getMinLength() {
            return MIN_LENGTH;
        }

        public string getValue() {
            return this.value;
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            return this.getValue().Length > 0 ? Regex.IsMatch(this.getValue(), expression) : true;
        }
    }

    public class InvalidAccountStatusException : Exception {
        public InvalidAccountStatusException()
            : base("Value didn't comply to AccountStatus number format") { }
    }
}
