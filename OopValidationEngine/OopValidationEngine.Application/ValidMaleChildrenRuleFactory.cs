using OopValidationEngine.Library;
using OopValidationEngine.Library.ValidationRules;
using System;

namespace OopValidationEngine.Application
{
    public class ValidMaleChildrenRuleFactory : PersonValidationRuleFactory
    {
        protected override ValidationRule[] CreateRulesForPerson(Person p)
        {
            return new ValidationRule[]
            {
                new AndRule(
                    new StringNotNullOrEmptyRule(p.FirstName),
                    new StringNotNullOrEmptyRule(p.LastName),
                    new StringNotNullOrEmptyRule(p.Cnp),
                    new StringRepresentsNumberRule(p.Cnp),
                    /* Gender = Male */
                    new StringStartsWithAnyRule(
                        p.Cnp,
                        new[] { "1", "3", "5", "7" },
                        StringComparison.OrdinalIgnoreCase),
                    /* Age between 0 and 18 */
                    new StringRepresentsNumberInIntervalRule(
                        p.Age.ToString(),
                        0,
                        18))
            };
        }
    }
}
