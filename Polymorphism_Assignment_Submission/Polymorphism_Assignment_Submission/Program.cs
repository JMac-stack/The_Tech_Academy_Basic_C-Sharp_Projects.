using Abstract_Class_Assignment;
using System;

namespace Polymorphism_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee(); // Use polymorphism to create an object of type IQuittable.
            employee.Quit(); // Call the Quit() method on it
        }
    }
}
