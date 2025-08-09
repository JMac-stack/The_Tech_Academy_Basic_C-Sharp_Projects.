using System;

namespace Methods_and_Objects_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.
            Employee<string> employeeWithStrings = new Employee<string>("Test", "String", 1);
            employeeWithStrings.Things.Add("string1");
            employeeWithStrings.Things.Add("string2");
            employeeWithStrings.Things.Add("string3");

            // Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
            Employee<int> employeeWithInts = new Employee<int>("Test", "Int", 2);
            employeeWithInts.Things.Add(1);
            employeeWithInts.Things.Add(3);
            employeeWithInts.Things.Add(5);
            employeeWithInts.Things.Add(7);

            // Create a loop that prints all of the Things to the Console.
            foreach (string str in employeeWithStrings.Things)
            {
                Console.WriteLine(str);
            }
            foreach (int i in employeeWithInts.Things)
            {
                Console.WriteLine(i);
            }
        }
    }
}
