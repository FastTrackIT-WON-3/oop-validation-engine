namespace OopValidationEngine.Library
{
    public abstract class ValidationRuleFactory
    {
        public abstract ValidationRule[] CreateRulesFor(object value);
    }
}
