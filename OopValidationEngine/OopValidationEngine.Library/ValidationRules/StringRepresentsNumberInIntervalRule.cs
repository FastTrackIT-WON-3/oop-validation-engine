using System;

namespace OopValidationEngine.Library.ValidationRules
{
    public class StringRepresentsNumberInIntervalRule : ValidationRule
    {
        public StringRepresentsNumberInIntervalRule(
            string value,
            int from,
            int to)
        {
            Value = value;
            From = Math.Min(from, to);
            To = Math.Max(from, to);
        }

        public string Value { get; }

        public int From { get; }

        public int To { get; }

        public override bool Validate()
        {
            if(!int.TryParse(Value, out int valueAsNumber))
            {
                return false;
            }

            return (From <= valueAsNumber) &&
                   (valueAsNumber <= To);
        }
    }
}
