using OopValidationEngine.Library;
using OopValidationEngine.Library.ValidationRules;

namespace OopValidationEngine.Application
{
    public abstract class PersonValidationRuleFactory : ValidationRuleFactory
    {
        public override sealed ValidationRule[] CreateRulesFor(object value)
        {
            if (value is not Person person)
            {
                return null;
            }

            return CreateRulesForPerson(person);
        }

        protected abstract ValidationRule[] CreateRulesForPerson(Person p);
    }
}
