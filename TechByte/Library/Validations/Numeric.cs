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
    public class Numeric : Validator, INumericDatatype
    {
        public static String expression = "^(0|([1-9][0-9]*))$";
        public static String message = "Not a valid Numeric value, please check and try again";
        private String value;
        const int MIN_VALUE = 0;
        const int MAX_VALUE = 9999999;

        public Numeric(String value, bool throwException = false) {
            this.value = value;
            if (throwException && value != null) {
                if (!this.isValid()) {
                    throw new InvalidNumericException();
                }
                //if (this.getValue().ToString().Length > 0) {
                //    if (!this.isWithinRange()) {
                //        throw new Guitar32.Exceptions.OutOfRangeValueException();
                //    }
                //}
            }
        }

        public int getValue() {
            return int.Parse(this.value);
        }

        public bool isWithinRange() {
            float value = this.getValue();
            return value >= MIN_VALUE && value <= MAX_VALUE;
        }

        public override bool isValid() {
            return this.getValue().ToString().Length > 0 ?
                Regex.IsMatch(this.getValue().ToString(), expression, RegexOptions.IgnoreCase) : true;
        }

        public int getMaxValue() {
            return MAX_VALUE;
        }

        public int getMinValue() {
            return MIN_VALUE;
        }

    }


    public class InvalidNumericException : Exception {
        public InvalidNumericException()
            : base("Value didn't comply to standard Numeric format") { }
    }
}
