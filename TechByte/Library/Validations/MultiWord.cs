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
    public class MultiWord : Validator, IStringDatatype
    {
        public static String expression = "^(\\s?[\\w\\S]{1,}){0,}$";
        public static String message = "No double and excessive spacing";
        private String value;

        public MultiWord(String value, bool throwException = false) {
            this.value = value;
            if (throwException) {
                if (!this.isValid()) {
                    throw new InvalidMultiWordException();
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
            return this.getValue();
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            return Regex.IsMatch(this.getValue(), expression);
        }
    }


    public class InvalidMultiWordException : Exception {
        public InvalidMultiWordException()
            : base("Value didn't comply to MultiWord format") { }
    }
}
