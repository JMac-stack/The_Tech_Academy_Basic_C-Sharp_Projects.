using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Expression_Assignment
{
    public class Employee // Create an Employee class.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee(int id, string firstName, string lastName )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
