using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TechByte.Architecture.Validations
{
    public class MobileNumber : Guitar32.Validator, Guitar32.Common.IStringDatatype
    {
        public static String expression = "^(09|\\+639|00639|9|639)([0-9]{2})([0-9]{7})$";
        public static String message = "Valid mobile number is 09xxxxxxxxx/+639xxxxxxxxx";
        private string value;


        public MobileNumber(String value, bool throwException = false) {
            this.value = value;
            if (throwException) {
                if (!this.isValid()) {
                    throw new InvalidMobileNumberException();
                }
                if (!this.isWithinRange()) {
                    throw new Guitar32.Exceptions.OutOfRangeLengthException();
                }
            }
        }


        public int getMaxLength() {
            return 16;
        }

        public int getMinLength() {
            return 15;
        }

        public string getValue() {
            return this.value;
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            return Regex.IsMatch(this.getValue(), expression);
        }
    }

    public class InvalidMobileNumberException : Exception {
        public InvalidMobileNumberException()
            : base("Value didn't comply to MobileNumber number format") { }
    }
}
