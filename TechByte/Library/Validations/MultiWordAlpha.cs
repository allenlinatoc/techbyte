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
    public class MultiWordAlpha : Validator, IStringDatatype
    {
        public static String expression = "^(\\s?[A-Za-z]+)*$";
        public static String message = "Only alphabet characters and no double and excessive spacing";
        private String value;

        public MultiWordAlpha(String value, bool throwException = false) {
            this.value = value;
            if (throwException && value != null) {
                if (!this.isValid()) {
                    throw new InvalidMultiWordAlphaException();
                }
                //if (this.getValue().Length > 0) {
                //    if (!this.isWithinRange()) {
                //        throw new Guitar32.Exceptions.OutOfRangeLengthException();
                //    }
                //}
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
            return this.getValue().Length > 0 ? Regex.IsMatch(this.getValue(), expression) : true;
        }
    }


    public class InvalidMultiWordAlphaException : Exception
    {
        public InvalidMultiWordAlphaException()
            : base("Value didn't comply to MultiWord Alphabet format") { }
    }
}
