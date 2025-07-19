using System;

namespace Console_Application_Maths_Assignment
{
    internal class Program
    {
        static void Main()
        {
            //Multiplies input by 50, prints to console.
            Console.WriteLine("Enter a number.");
            int multBy50 = 50 * Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number multiplied by 50 is " + multBy50.ToString());

            //Adds 25 to input, prints to console.
            Console.WriteLine("Enter a number.");
            int add25 = 25 + Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number plus 25 is " + add25.ToString());

            //Divides input by 12.5, prints to console.
            Console.WriteLine("Enter a number.");
            float divideByNum = Convert.ToSingle(Console.ReadLine()) / 12.5f;
            Console.WriteLine("Your number divided by 12.5 is " + divideByNum.ToString());

            //Checks if input is greater than 50, prints true/false.
            Console.WriteLine("Enter a number.");
            bool greaterThan50 = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine(greaterThan50);

            //Divides input by 7, prints remainder.
            Console.WriteLine("Enter a number.");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of " + remainder.ToString());
        }
    }
}
