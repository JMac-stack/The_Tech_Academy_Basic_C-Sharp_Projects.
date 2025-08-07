using System;

namespace Main_Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths mathsObject = new Maths();
            Console.WriteLine(mathsObject.MathsOp(5)); //In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen.

            Console.WriteLine(mathsObject.MathsOp(27.75m)); //call the second method, passing in a decimal. Display the result to the screen.

            Console.WriteLine(mathsObject.MathsOp("101")); // call the third method, passing in a string that equates to an integer. Display the result to the screen.
        }
    }
}
