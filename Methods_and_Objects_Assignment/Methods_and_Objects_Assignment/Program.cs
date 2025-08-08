using System;

namespace Methods_and_Objects_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Smith"); // Instantiates person object with names.
            Employee employee = new Employee("Sample", "Student", 1); // Instantiates employee object with names and id.
            person.SayName();
            employee.SayName(); // Superclass method is called.
        }
    }
}
