using System;

namespace Parsing_Enums_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the name of a day of the week."); // Prompt the user to enter the current day of the week.
            try
            {
                DaysOfTheWeek weekDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());// Assign the value to a variable of that enum data type you just created.
                if (!Enum.IsDefined(typeof(DaysOfTheWeek), weekDay)) // Read as "If not defined" or "If number bigger then 6".
                {
                    Console.WriteLine("{0} is too big, please enter a number from 0 to 6 or the name of a day of the week.", weekDay);
                    return;
                }
                Console.WriteLine("You entered: {0}", weekDay);
            }
            catch (ArgumentException) // Catches if wrong string entered. For wrong int see IsDefined method in try block.
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }

        public enum DaysOfTheWeek // Create an enum for the days of the week.
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
