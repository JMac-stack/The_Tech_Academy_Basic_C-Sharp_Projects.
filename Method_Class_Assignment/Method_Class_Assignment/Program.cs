using System;

namespace Method_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Method_Class_Assignment methodObject = new Method_Class_Assignment(); // Instantiate the class.
            methodObject.takeTwoInt(5, 10); // Call the method in the class, passing in two numbers.
            methodObject.takeTwoInt(firstNum: 33, secondNum: 55); // Call the method in the class, specifying the parameters by name.
        }
    }
}
