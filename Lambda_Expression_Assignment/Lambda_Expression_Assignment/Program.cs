using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); // In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            Employee employee1 = new Employee(1, "John", "Smith");
            employees.Add(employee1);
            Employee employee2 = new Employee(2, "Joe", "Jones");
            employees.Add(employee2);
            Employee employee3 = new Employee(3, "Joe", "Davies");
            employees.Add(employee3);
            Employee employee4 = new Employee(4, "Susan", "Howarth");
            employees.Add(employee4);
            Employee employee5 = new Employee(5, "Ted", "Roberts");
            employees.Add(employee5);
            Employee employee6 = new Employee(6, "Daniel", "Mack");
            employees.Add(employee6);
            Employee employee7 = new Employee(7, "Rachel", "Edwards");
            employees.Add(employee7);
            Employee employee8 = new Employee(8, "Amanda", "Jones");
            employees.Add(employee8);
            Employee employee9 = new Employee(9, "Lauren", "Thomas");
            employees.Add(employee9);
            Employee employee10 = new Employee(10, "Brandon", "Stocks");
            employees.Add(employee10);

            List<Employee> joeEmployees = new List<Employee>();
            foreach (Employee employee in employees) // Using a foreach loop, create a new list of all employees with the first name “Joe”.
            {
                if (employee.FirstName == "Joe")
                {
                    joeEmployees.Add(employee);
                }
            }

            List<Employee> joeEmployees2 = employees.Where(e => e.FirstName == "Joe").ToList(); // Perform the same action again, but this time with a lambda expression.
        
            List<Employee> greatThan5Employees = employees.Where(e => e.Id > 5).ToList(); // Using a lambda expression, make a list of all employees with an Id number greater than 5.
        }
    }
}
