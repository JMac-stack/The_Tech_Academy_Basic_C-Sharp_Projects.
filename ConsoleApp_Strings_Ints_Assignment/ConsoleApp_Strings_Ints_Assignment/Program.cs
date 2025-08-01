using System;
using System.Collections.Generic;

namespace ConsoleApp_Strings_Ints_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 100, 54, 90, 50, 200, 10 }; // Create a list of integers.

            try
            {
                Console.WriteLine("Please enter a number to divide by.");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                int outputNumber;
                foreach (int number in numbers) // Loop to divide numbers by input.
                {
                    outputNumber = number / inputNumber;
                    Console.WriteLine($"{number} divided by {inputNumber} equals {outputNumber}");
                }
            }
            catch (DivideByZeroException ex) // Catches divide by zero exceptions.
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (FormatException ex) // Catches when wrong format entered.
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a whole number.");
            }
            catch (Exception ex) // Generic Exception.
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("Try/catch Complete."); // Code to run after try/catch block
        }
    }
}
