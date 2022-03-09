using System;

namespace OopValidationEngine.Library.ValidationRules
{
    public class StringStartsWithRule : ValidationRule
    {
        public StringStartsWithRule(
            string value,
            string startsWith,
            StringComparison stringComparison)
        {
            Value = value;
            StartsWith = startsWith;
            StringComparison = stringComparison;
        }

        public string Value { get; }

        public string StartsWith { get; }

        public StringComparison StringComparison { get; }

        public override bool Validate()
        {
            if (string.IsNullOrEmpty(Value) && string.IsNullOrEmpty(StartsWith))
            {
                // both are null or empty
                return true;
            }

            if (string.IsNullOrEmpty(Value) || string.IsNullOrEmpty(StartsWith))
            {
                // one is null or empty, while the other is not
                return false;
            }

            return Value.StartsWith(StartsWith, StringComparison);
        }
    }
}
