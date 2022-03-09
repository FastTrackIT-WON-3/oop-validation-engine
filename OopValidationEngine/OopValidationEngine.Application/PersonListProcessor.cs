using System;
using OopValidationEngine.Library;

namespace OopValidationEngine.Application
{
    public class PersonListProcessor
    {
        public PersonListProcessor(params Person[] persons)
        {
            Persons = persons ?? new Person[0];
        }

        public Person[] Persons { get; }

        public void Process(ValidationRuleFactory rulesFactory)
        {
            foreach (Person p in Persons)
            {
                string label = $"Person {p.FirstName} {p.LastName}, CNP: {p.Cnp}, Age: {p.Age}";
                ValidationRule[] rules = rulesFactory.CreateRulesFor(p);
                if (rules is not null)
                {
                    ValidationEngine engine = new ValidationEngine(rules);
                    bool isValidPerson = engine.Validate();

                    if (isValidPerson)
                    {
                        Console.WriteLine($"{label} - PASSES validation");
                    }
                    else
                    {
                        Console.WriteLine($"{label} - FAILS validation");
                    }
                }
                else
                {
                    Console.WriteLine($"{label} - UNABLE to validate");
                }
            }
        }
    }
}
