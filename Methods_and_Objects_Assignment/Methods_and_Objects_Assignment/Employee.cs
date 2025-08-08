using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects_Assignment
{
    public class Employee : Person // Inherits from person class.
    {
        int Id { get; set; }
        public Employee(string firstName, string lastName, int id) : base(firstName, lastName) // Constructor uses person class instructor + new property.
        {
            this.Id = id;
        }
    }
}
