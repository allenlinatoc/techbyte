using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Guitar32;
using Guitar32.Common;
using Guitar32.Exceptions;
using Guitar32.Utilities;

namespace Guitar32.Validations
{
    public class DateTime : Validator, IStringDatatype
    {
        public static String expression = "^(([0-9]{2,4})-([0-1][0-9])-([0-3][0-9])(?:\\s(([0-1][0-9])|(2[0-3])):([0-5][0-9]):([0-5][0-9]))?)|((?:(([0-1][0-9])|(2[0-3])):([0-5][0-9]):([0-5][0-9]))?)$";
        public static String message = "Not a valid Date/Time, please check and try again";
        private String value;
        const int MIN_LENGTH = 10;
        const int MAX_LENGTH = 19;

        public DateTime(String value, bool throwException = false) {
            this.value = value;
            if (throwException) {
                if (!this.isValid()) {
                    throw new InvalidDateTimeException();
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
            return this.value;
        }

        public bool isWithinRange() {
            return this.getValue().Length >= this.getMinLength() && this.getValue().Length <= this.getMaxLength();
        }

        public override bool isValid() {
            return Regex.IsMatch(this.getValue(), expression, RegexOptions.IgnoreCase);
        }



        // <Begin::Static methods>
        
        /// <summary>
        /// Create a DateTime instance from a DateTimePicker control
        /// </summary>
        /// <param name="datetimePicker">The source DateTimePicker control</param>
        /// <param name="includeTime">(Optional) If time should also be included in the result</param>
        /// <returns>The resulting DateTime instance</returns>
        public static DateTime CreateFromDateTimePicker(System.Windows.Forms.DateTimePicker datetimePicker, bool includeTime=false) {
            DateTime datetime;
            System.DateTime value = datetimePicker.Value;
            string result = Strings.FormatInt(value.Year,4) + "-" 
                + Strings.FormatInt(value.Month, 2) + "-"
                + Strings.FormatInt(value.Day, 2);
            if (includeTime) {
                result += " " + Strings.FormatInt(value.Hour,2) + ":" + Strings.FormatInt(value.Minute,2) + ":" + Strings.FormatInt(value.Millisecond,2);
            }
            datetime = new DateTime(result);
            return datetime;
        }


        // <End::Static methods>
    }


    public class InvalidDateTimeException : Exception {
        public InvalidDateTimeException()
            : base("Value didn't comply to standard Date/Time format") { }
    }
}
