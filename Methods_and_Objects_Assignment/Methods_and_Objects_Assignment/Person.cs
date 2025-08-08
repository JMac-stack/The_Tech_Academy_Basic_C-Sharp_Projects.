using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects_Assignment
{
    public class Person // Superclass. Will be inherited.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName() // Superclass method.
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName); 
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
