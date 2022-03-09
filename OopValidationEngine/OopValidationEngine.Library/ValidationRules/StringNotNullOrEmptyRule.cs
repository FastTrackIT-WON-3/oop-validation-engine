namespace OopValidationEngine.Library.ValidationRules
{
    public class StringNotNullOrEmptyRule : ValidationRule
    {
        public StringNotNullOrEmptyRule(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public override bool Validate()
        {
            return !string.IsNullOrEmpty(Value);
        }
    }
}
