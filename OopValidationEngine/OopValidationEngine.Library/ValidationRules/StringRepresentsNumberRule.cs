namespace OopValidationEngine.Library.ValidationRules
{
    public class StringRepresentsNumberRule : ValidationRule
    {
        public StringRepresentsNumberRule(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public override bool Validate()
        {
            // TODO: susceptible to return false due overflow!
            return long.TryParse(Value, out long result);
        }
    }
}
