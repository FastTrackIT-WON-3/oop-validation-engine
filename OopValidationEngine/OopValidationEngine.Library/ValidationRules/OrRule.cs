using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopValidationEngine.Library.ValidationRules
{
    public class OrRule : ValidationRule
    {
        public OrRule(params ValidationRule[] rules)
        {
            Rules = rules;
        }

        public ValidationRule[] Rules { get; }

        public override bool Validate()
        {
            bool isValid = false;
            foreach (ValidationRule rule in Rules)
            {
                isValid = isValid || rule.Validate();
            }

            return isValid;
        }
    }
}
