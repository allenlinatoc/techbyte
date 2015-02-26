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
    public class Password : Validator, IStringDatatype
    {
        public static String expression = "^[A-Za-z0-9\\@\\+\\$\\!\\?\\*\\%\\^\\&\\#\\=\\~]+$";
        public static String message = "Only alphanumeric characters and @+$!?*%^&#=~ are allowed";
        private String value;

        public Password(String value, bool throwException = false) {
            this.value = value;
            if (throwException) {
                if (!this.isValid()) {
                    throw new InvalidPasswordException();
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
            return 5;
        }

        public String getValue() {
            return Guitar32.Cryptography.MD5Hash.Compute(this.value);
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            return Regex.IsMatch(this.getValue(), expression);
        }
    }


    public class InvalidPasswordException : Exception {
        public InvalidPasswordException()
            : base("Value didn't comply to standard Password format") { }
    }
}
