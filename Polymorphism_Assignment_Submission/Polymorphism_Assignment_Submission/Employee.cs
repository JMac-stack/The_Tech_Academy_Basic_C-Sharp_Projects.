using Polymorphism_Assignment_Submission;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public class Employee : Person, IQuittable// Inherited class + Interface.
    {
        public override void SayName() // Overrides abstract method.
        {
            Console.WriteLine("Employee Name: {0} {1}", FirstName, LastName);
        }

        public void Quit() // Implementation of interface method.
        {
            throw new NotImplementedException();
        }
    }
}
