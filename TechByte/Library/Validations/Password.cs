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
            if (throwException && value != null) {
                if (!this.isValid()) {
                    throw new InvalidPasswordException();
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
            return 5;
        }

        public String getRawValue() {
            return this.value;
        }

        public String getValue() {
            return Guitar32.Cryptography.MD5Hash.Compute(this.value);
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            return this.getValue().Length > 0 ? Regex.IsMatch(this.getValue(), expression) : true;
        }
    }


    public class InvalidPasswordException : Exception {
        public InvalidPasswordException()
            : base("Value didn't comply to standard Password format") { }
    }
}
