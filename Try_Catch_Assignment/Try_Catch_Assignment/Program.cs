using System;

namespace Try_Catch_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            bool validInput = false;
            int age = 0;
            try
            {
                Console.WriteLine("What is your age?"); // Ask the user for their age.
                validInput = int.TryParse(Console.ReadLine(), out age);

                if (age <= 0) throw new MinusOrZeroException();
                else if (!validInput) throw new Exception();

                int yearOfBirth = currentTime.Year - age;

                Console.WriteLine("You were born in {0} or {1}", yearOfBirth, yearOfBirth - 1);
            }
            catch (MinusOrZeroException)
            {
                Console.WriteLine("Please don't enter 0 or minus numbers."); // Display appropriate error messages if the user enters zero or negative numbers.
                Console.ReadLine();
                return;
            }
            catch
            {
                Console.WriteLine("Something you entered was wrong."); // Display a general message if an exception was caused by anything else.
                Console.ReadLine();
                return;
            }
        }
    }

    public class MinusOrZeroException : Exception
    {
        public MinusOrZeroException()
            : base() { }
        public MinusOrZeroException(string message)
            : base(message) { }
    }
}
