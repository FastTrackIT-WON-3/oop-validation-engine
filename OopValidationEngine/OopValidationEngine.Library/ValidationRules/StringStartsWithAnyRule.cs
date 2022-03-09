using System;

namespace OopValidationEngine.Library.ValidationRules
{
    public class StringStartsWithAnyRule : OrRule
    {
        public StringStartsWithAnyRule(
            string value, string[] startsWithAny, StringComparison comparison)
            : base(CreateRules(value, startsWithAny, comparison))
        {
        }

        private static StringStartsWithRule[] CreateRules(string value, string[] startsWithAny, StringComparison comparison)
        {
            if (startsWithAny is null || startsWithAny.Length == 0)
            {
                return new[]
                {
                    new StringStartsWithRule(value, string.Empty, comparison)
                };
            }

            StringStartsWithRule[] result = new StringStartsWithRule[startsWithAny.Length];
            for (int i = 0; i < startsWithAny.Length; i++)
            {
                result[i] = new StringStartsWithRule(value, startsWithAny[i], comparison);
            }

            return result;
        }


    }
}
