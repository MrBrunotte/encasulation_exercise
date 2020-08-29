using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            // white text is a field and light blue is a paramater!
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            // this is a field
            get { return this.firstName; }
        }

        public string LastName
        {
            // this is a field
            get { return this.lastName; }
        }

        public int Age
        {
            // this is a field
            get { return this.age; }
        }
        public override string ToString()
        {
            // att ToUpper() method 
            // Hover over each 
            return $"{this.FirstName.ToUpper()} {this.LastName} is {this.Age} years old!";
        }
    }
}
