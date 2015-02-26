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
    public class Gender : Validator, IStringDatatype
    {
        public static String expression = "^(MALE|FEMALE|male|female|Male|Female)$";
        public static String message = "Only \"Male\" and \"Female\" are allowed values";
        private String value;
        const int MIN_LENGTH = 4;
        const int MAX_LENGTH = 6;

        public Gender(String value, bool throwException = false) {
            this.value = value;
            if (throwException) {
                if (!this.isValid()) {
                    throw new InvalidGenderException();
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
            return Guitar32.Cryptography.MD5Hash.Compute(this.value);
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            return Regex.IsMatch(this.getValue(), expression, RegexOptions.IgnoreCase);
        }

    }


    public class InvalidGenderException : Exception {
        public InvalidGenderException()
            : base("Value didn't comply to standard Gender format") { }
    }
}
