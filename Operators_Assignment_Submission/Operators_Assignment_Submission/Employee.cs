using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects_Assignment
{
    public class Employee : Person // Inherited class.
    {
        int Id { get; set; }

        // Compares Id of each object when == or != operators (Pair needed) used on two objects. Returns bool.
        public static bool operator == (Employee left, Employee right) // Overloads == operator.
        {
            return left.Id == right.Id;
        }
        public static bool operator != (Employee left, Employee right) // Overloads != operator.
        {
            return left.Id != right.Id;
        }
        public Employee(string firstName, string lastName, int id) : base(firstName, lastName) // Constructor uses person class instructor + new property.
        {
            this.Id = id;
        }
    }
}
