using System;

namespace Abstract_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; // New employee object with names.
            employee.SayName(); // Called method.
        }
    }
}
