using System;

namespace Struct_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 10m }; // In the Main() method, create an object of data type Number and assign an amount to it.
            Console.WriteLine(number.Amount.ToString()); // Print this amount to the console.
        }
    }

    public struct Number // Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
    {
        public decimal Amount { get; set; }
    }
}
