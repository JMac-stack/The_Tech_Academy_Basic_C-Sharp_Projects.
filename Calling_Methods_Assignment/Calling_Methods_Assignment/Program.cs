using System;
using System.ComponentModel;

namespace Calling_Methods_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adding numbers with method, get numbers from user.
            Console.WriteLine("Enter the first number to add.");
            int addNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number to add.");
            int addNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{addNum1} + {addNum2} = {Maths.Add(addNum1, addNum2)}"); // Add() Method is called with arguments.

            // Subtracting numbers with method, get numbers from user.
            Console.WriteLine("Enter the number to subtract from.");
            int subNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number to subtract.");
            int subNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{subNum1} - {subNum2} = {Maths.Subtract(subNum1, subNum2)}"); // Subtract() Method is called with arguments.

            // Multiplying numbers with method, get numbers from user.
            Console.WriteLine("Enter the first number to multiply.");
            int multNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number to multiply.");
            int multNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{multNum1} * {multNum2} = {Maths.Multiply(multNum1, multNum2)}"); // Multiply() Method is called with arguments.
        }
    }
}
