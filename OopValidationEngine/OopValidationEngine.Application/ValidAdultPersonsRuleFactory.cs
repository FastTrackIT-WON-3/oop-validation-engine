using OopValidationEngine.Library;
using OopValidationEngine.Library.ValidationRules;
using System;

namespace OopValidationEngine.Application
{
    public class ValidAdultPersonsRuleFactory : PersonValidationRuleFactory
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
                    new OrRule(
                        /* Gender = Male */
                        new StringStartsWithAnyRule(
                            p.Cnp,
                            new[] { "1", "3", "5", "7" },
                            StringComparison.OrdinalIgnoreCase),
                        /* Gender = Female */
                        new StringStartsWithAnyRule(
                            p.Cnp,
                            new[] { "2", "4", "6", "8" },
                            StringComparison.OrdinalIgnoreCase)
                        ))
            };
        }
    }
}
