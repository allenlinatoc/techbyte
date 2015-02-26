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
    public class Currency : Validator
    {
        public static String expression = "^\\d{0,15}(\\.\\d{1,2})?$";
        public static String message = "Not a valid currency value, please check and try again";
        private String value;
        const float MIN_VALUE = 10;
        const float MAX_VALUE = 75;

        public Currency(String value, bool throwException = false) {
            this.value = value;
            if (throwException) {
                if (!this.isValid()) {
                    throw new InvalidCurrencyException();
                }
                else if (!this.isWithinRange()) {
                    throw new OutOfRangeValueException();
                }
            }
        }

        public float getValue() {
            return float.Parse(this.value);
        }

        public bool isWithinRange() {
            float value = this.getValue();
            return value >= MIN_VALUE && value <= MAX_VALUE;
        }

        public override bool isValid() {
            return Regex.IsMatch(this.getValue().ToString(), expression, RegexOptions.IgnoreCase);
        }

        public float getMaxValue() {
            return MAX_VALUE;
        }

        public float getMinValue() {
            return MIN_VALUE;
        }

    }


    public class InvalidCurrencyException : Exception {
        public InvalidCurrencyException()
            : base("Value didn't comply to standard Currency format") { }
    }
}
