using System;

namespace Datetime_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime nowTime = DateTime.Now;
            Console.WriteLine("The time is now: {0}",nowTime); // Prints the current date and time to the console.
            Console.WriteLine("Please enter a number."); // Asks the user for a number.
            int num = Convert.ToInt32(Console.ReadLine());
            TimeSpan hours = new TimeSpan(num,0,0);
            Console.WriteLine("In {0} hours it will be {1}",hours.Hours,(nowTime.Add(hours))); // Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
        }
    }
}
