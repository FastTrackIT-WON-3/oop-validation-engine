namespace OopValidationEngine.Library
{
    public class ValidationEngine
    {
        public ValidationEngine(params ValidationRule[] rules)
        {
            Rules = rules ?? new ValidationRule[0];
        }

        public ValidationRule[] Rules { get; }

        public bool Validate()
        {
            foreach (ValidationRule rule in Rules)
            {
                bool isValid = rule.Validate();
                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
