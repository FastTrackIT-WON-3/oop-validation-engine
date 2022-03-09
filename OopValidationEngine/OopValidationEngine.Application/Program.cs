using System;

namespace OopValidationEngine.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonListProcessor processor = new PersonListProcessor(
                new Person
                {
                    FirstName = "FirstName1",
                    LastName = "LastName1",
                    Cnp = "1800312017574",
                    Age = 42
                },
                new Person
                {
                    FirstName = "FirstName2",
                    LastName = "LastName2",
                    Cnp = "2870617057040",
                    Age = 35
                },
                new Person
                {
                    FirstName = "FirstName3",
                    LastName = "LastName3",
                    Cnp = "1920910085474",
                    Age = 30
                },
                new Person
                {
                    FirstName = "FirstName4",
                    LastName = "LastName4",
                    Cnp = "2971023408554",
                    Age = 25
                },
                new Person
                {
                    FirstName = "FirstName5",
                    LastName = "LastName5",
                    Cnp = "5030211126456",
                    Age = 19
                },
                new Person
                {
                    FirstName = "FirstName6",
                    LastName = "LastName6",
                    Cnp = "6040512128023",
                    Age = 18
                },
                new Person
                {
                    FirstName = "FirstName7",
                    LastName = "LastName7",
                    Cnp = "5100616126894",
                    Age = 12
                },
                new Person
                {
                    FirstName = "FirstName8",
                    LastName = "LastName8",
                    Cnp = "6100812286284",
                    Age = 12
                });

            Console.WriteLine("***** Run 1 *****");
            Console.WriteLine();

            processor.Process(new ValidAdultPersonsRuleFactory());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***** Run 2 *****");
            Console.WriteLine();
            processor.Process(new ValidMaleChildrenRuleFactory());
        }
    }
}
