using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects_Assignment
{
    public class Employee<T> : Person // Inherits from person class + generic parameter..
    {
        public int Id { get; set; }
        public List<T> Things { get; set; } // Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class.
        public Employee(string firstName, string lastName, int id) : base(firstName, lastName) // Constructor uses person class instructor + new property.
        {
            this.Id = id;
            this.Things = new List<T>(); // Instantiates List, matches generic type of class.
        }
    }
}
