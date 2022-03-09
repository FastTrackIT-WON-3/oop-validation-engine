namespace OopValidationEngine.Library.ValidationRules
{
    public class AndRule : ValidationRule
    {
        public AndRule(params ValidationRule[] rules)
        {
            Rules = rules;
        }

        public ValidationRule[] Rules { get; }

        public override bool Validate()
        {
            foreach (ValidationRule rule in Rules)
            {
                if (!rule.Validate())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
