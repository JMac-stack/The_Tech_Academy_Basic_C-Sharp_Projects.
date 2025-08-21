using System;

namespace Constructor_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string constVariable = "Please enter a number"; // Create a const variable.
            bool isANumber = false;
            while (!isANumber)
            {
                Console.WriteLine(constVariable);
                var input = Console.ReadLine(); // Create a variable using the keyword “var”.
                if (int.TryParse(input, out int result))
                {
                    ChainConstrutor chainConstructor = new ChainConstrutor(result);
                    Console.WriteLine(chainConstructor.String + chainConstructor.Number);
                    isANumber = true;
                }
            }



        }


    }

    public class ChainConstrutor // Chain two constructors together.
    {
        public ChainConstrutor(int num) : this("Is this your number? \n", num)
        {

        }
        public ChainConstrutor(string word, int num)
        {
            this.String = word;
            this.Number = num;
        }

        public string String { get; set; }
        public int Number { get; set; }
    }
}
