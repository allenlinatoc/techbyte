using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TechByte.Architecture.Validations
{
    public sealed class TIN : Guitar32.Validator, Guitar32.Common.IStringDatatype
    {
        public static String expression = "^(\\d{3}\\-\\d{3}\\-\\d{3}\\-\\d{3})((N|V)?)$";
        public static String message = "TIN number valid format is XXX-XXX-XXX-XXX";
        private string value;


        public TIN(String value, bool throwException = false) {
            this.value = value;
            if (throwException) {
                if (!this.isValid()) {
                    throw new InvalidTINException();
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

    public class InvalidTINException : Exception {
        public InvalidTINException()
            : base("Value didn't comply to TIN number format") { }
    }
}
