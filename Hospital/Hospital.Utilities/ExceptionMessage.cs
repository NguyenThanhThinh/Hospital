using System;

namespace Hospital.Utilities
{
    public class ExceptionMessage
    {
        private const string EMPTY_STRING = "{0} must have {1}!";
        private const string STRING_MORE_THAN_MAX_LENGTH = "{0} must be no more than {1} symbols!";
        private const string STRING_LESS_THAN_MIN_LENGTH = "{0} cannot be less than {1} symbols!";
        private const string NEGATIVE_NUMBER = "{0} cannot be less than zero!";
        private const string LESS_THAN_ONE = "Id must be greater than 0";

        public void StringExistenceValidation(string value, string objName, string propName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(EMPTY_STRING, nameof(objName), nameof(propName)));
            }
        }

        public void StringMaxLengthValidation(string value, int maxLength, string propName)
        {
            if (value != null && value.Length > maxLength)
            {
                throw new ArgumentException(string.Format(STRING_MORE_THAN_MAX_LENGTH, propName, maxLength));
            }
        }

        public void StringMinLengthValidation(string value, int minLength, string propName)
        {
            if (value != null && value.Length < minLength)
            {
                throw new ArgumentException(string.Format(STRING_LESS_THAN_MIN_LENGTH, propName, minLength));
            }
        }

        public void NummericNonNegativeValidation(double value, string propName)
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(NEGATIVE_NUMBER, nameof(propName)));
            }
        }

        public void NummericNonNegativeValidation(decimal value, string propName)
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(NEGATIVE_NUMBER, nameof(propName)));
            }
        }

        public void NummericNonNegativeValidation(int? value, string propName)
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(NEGATIVE_NUMBER, nameof(propName)));
            }
        }

        public void IdGreaterThanZeroValidation(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(LESS_THAN_ONE);
            }
        }
    }
}

