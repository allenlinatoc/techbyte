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
    public class Fax : Validator, IStringDatatype
    {
        public static String expression = "^[\\w\\s\\!\\.\\?\\,]+$";
        public static String message = "Not a valid Fax number, please check and try again";
        private String value;
        const int MIN_LENGTH = 10;
        const int MAX_LENGTH = 200;

        public Fax(String value, bool throwException = false) {
            this.value = value;
            if (throwException) {
                if (!this.isValid()) {
                    throw new InvalidFaxException();
                }
                else if (!this.isWithinRange()) {
                    throw new OutOfRangeLengthException();
                }
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
            return Regex.IsMatch(this.getValue(), expression, RegexOptions.IgnoreCase);
        }

    }


    public class InvalidFaxException : Exception {
        public InvalidFaxException()
            : base("Value didn't comply to standard Fax format") { }
    }
}
