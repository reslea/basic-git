using System;

namespace BasicGit
{
    class Program
    {
        static void Main()
        {
            // some comment
            var person = new Person
            {
                Name = "John", 
                Address = new Address
                {
                    Street = "Ivy str.",
                }
            };
            Console.WriteLine($"{person.Name} lives in {person.Address.Street}");
        }
    }
}
