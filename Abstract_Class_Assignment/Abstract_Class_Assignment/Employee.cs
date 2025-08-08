using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public class Employee : Person // Inherited class.
    {
        public override void SayName() // Overrides abstract method.
        {
            Console.WriteLine("Employee Name: {0} {1}", FirstName, LastName);
        }
    }
}
