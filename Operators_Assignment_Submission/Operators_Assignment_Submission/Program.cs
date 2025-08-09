using System;

namespace Methods_and_Objects_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 3 objects of class employee to compare.
            Employee employee1 = new Employee("Dave","Smith",1);
            Employee employee2 = new Employee("Susan", "Williams", 2);
            Employee employee3 = new Employee("Dan", "Smyth", 1); //employee3 id matchs employee1 id.

            // Compare using overloaded operators.
            // employee1.Id = 1 employee2.Id = 2.
            Console.WriteLine(employee1 == employee2); // False.
            Console.WriteLine(employee1 != employee2); // True.
            // employee1.Id = 1 employee3.Id = 1.
            Console.WriteLine(employee1 == employee3); // True.
            Console.WriteLine(employee1 != employee3); // False.
        }
    }
}
