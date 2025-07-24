using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            int weight;
            int width;
            int height;
            int length;

            try // Takes input.
            {
                Console.WriteLine("Please enter the package weight:");
                weight = Convert.ToInt32(Console.ReadLine());
                if (weight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    return;
                }
                Console.WriteLine("Please enter the package width:");
                width = Convert.ToInt32(Console.ReadLine());
                if (width > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    return;
                }
                Console.WriteLine("Please enter the package height:");
                height = Convert.ToInt32(Console.ReadLine());
                if (height > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    return;
                }
                Console.WriteLine("Please enter the package length:");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    return;
                }
            }
            catch // Ends program if error occurs.
            {
                Console.WriteLine("An error occured");
                return;
            }

            Package package1 = new Package(weight, width, height, length); // Creates package, calculates quote.

            Console.WriteLine($"Your estimated total for shipping this package is: ${package1.Shipping}\nThank you!"); //Prints Quote in template string.
            
        }
    }

    public class Package
    {
        public int Weight { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public float Shipping { get; set; }

        public Package(int weight, int width, int height, int length)
        {
            Weight = weight;
            Width = width;
            Height = height;
            Length = length;
            Shipping = (float)weight * (float)width * (float)height * (float)length / (float)100.00; //This is the Quote.
        }
    }
}
