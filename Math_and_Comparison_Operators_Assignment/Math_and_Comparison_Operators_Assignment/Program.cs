using System;

namespace Math_and_Comparison_Operators_Assignment
{
    internal class Program
    {
        static void Main()
        {
            //Person 1 Details.
            Console.WriteLine("Anonymous Income Comparison Program.");
            Console.WriteLine("Person 1.");
            Console.WriteLine("Enter hourly rate.");
            float person1Rate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week.");
            float person1Hours = Convert.ToSingle(Console.ReadLine());

            //Person 2 Details.
            Console.WriteLine("Person 2.");
            Console.WriteLine("Enter hourly rate.");
            float person2Rate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week.");
            float person2Hours = Convert.ToSingle(Console.ReadLine());

            //Comparison.
            float person1Salary = 52 * person1Hours * person1Rate;
            float person2Salary = 52 * person2Hours * person2Rate;

            Console.WriteLine("Annual salary of Person 1:\n" + person1Salary.ToString());
            Console.WriteLine("Annual salary of Person 2:\n" + person2Salary.ToString());

            Console.WriteLine("Person 1 makes more money than Person 2.");
            Console.WriteLine(person1Salary >  person2Salary);
        }
    }
}
