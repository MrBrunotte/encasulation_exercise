using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation
{
    class Program
    {
        public static void Main()
        {
            var lines = 5;
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("Type a first name, last name and age: ");
                var commandLineArguments = Console.ReadLine().Split();
                var person = new Person(commandLineArguments[0], commandLineArguments[1], int.Parse(commandLineArguments[2]));
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                   .ThenBy(p => p.Age)
                   .ToList()
                   .ForEach(p => Console.WriteLine(p.ToString()));

        }

            
    }
}
