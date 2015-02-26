using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Guitar32;
using Guitar32.Common;
using Guitar32.Exceptions;

namespace Guitar32.Validations
{
    public class Email : Validator, IStringDatatype
    {
        public static String expression = "^[_A-Za-z0-9-\\+]+((\\.|_|\\-)[A-Za-z0-9]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$";
        public static String message = "Not a valid email address, please check and try again";
        private String value;
        const int MIN_LENGTH = 10;
        const int MAX_LENGTH = 75;

        public Email(String value, bool throwException = false) {
            this.value = value;
            if (throwException && value != null) {
                if (!this.isValid()) {
                    throw new InvalidEmailException();
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

        public String getValue() {
            return this.value;
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            return this.getValue().Length > 0 ?
                Regex.IsMatch(this.getValue(), expression, RegexOptions.IgnoreCase) : true;
        }

    }


    public class InvalidEmailException : Exception {
        public InvalidEmailException()
            : base("Value didn't comply to standard Email format") { }
    }
}
