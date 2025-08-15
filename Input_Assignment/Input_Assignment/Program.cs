using System;
using System.IO;

namespace Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number"); // Asks the user for a number.
            string num = Console.ReadLine(); // Taking number as string as convert not needed.
            string filePath = @".\log.txt";
            File.WriteAllText(filePath, num); // Logs that number to a text file.
            string numRead = File.ReadAllText(filePath);
            Console.WriteLine("Is this your number:\n" + numRead); // Prints the text file back to the user.
            Console.Read();
        }
    }
}
