using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Guitar32.Exceptions;
using Guitar32.Common;

namespace Guitar32.Validations
{
    public class SingleWordAlpha : Validator, IStringDatatype
    {
        public static String expression = "^[A-Za-z]+$";
        public static String message = "Only alphabet characters and no spaces";
        private String value;

        public SingleWordAlpha(String value, bool throwException = false) {
            this.value = value;
            if (throwException) {
                if (!this.isValid()) {
                    throw new InvalidSingleWordAlphaException();
                }
                else if (!this.isWithinRange()) {
                    throw new OutOfRangeLengthException();
                }
            }
        }

        public int getMaxLength() {
            return 99999;
        }

        public int getMinLength() {
            return 1;
        }

        public String getValue() {
            return this.value;
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            return Regex.IsMatch(this.getValue(), expression);
        }
    }

    public class InvalidSingleWordAlphaException : Exception {
        public InvalidSingleWordAlphaException()
            : base("Value didn't comply to Single Word Alphabet format")
        { }
    }
}