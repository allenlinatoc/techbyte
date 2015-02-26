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
    public class IPAddress : Validator, IStringDatatype
    {
        public static String expression = "^(([1-9]?\\d|1\\d\\d|2[0-5][0-5]|2[0-4]\\d)\\.){3}([1-9]?\\d|1\\d\\d|2[0-5][0-5]|2[0-4]\\d)$";
        public static String message = "Not a valid IP address, please check and try again";
        private String value;
        const int MIN_LENGTH = 1;
        const int MAX_LENGTH = 15;

        public IPAddress(String value, bool throwException = false) {
            this.value = value;
            if (throwException && value != null) {
                if (!this.isValid()) {
                    throw new InvalidIPAddressException();
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


    public class InvalidIPAddressException : Exception {
        public InvalidIPAddressException()
            : base("Value didn't comply to standard IP address format") { }
    }
}
