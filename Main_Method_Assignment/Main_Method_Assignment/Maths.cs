using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Main_Method_Assignment
{
    internal class Maths // Create a class.
    {

        public int MathsOp(int x) // In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer.
        {
            return x + 2;
        }

        public decimal MathsOp(decimal x) // Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.
        {
            return x - 2.5m;
        }

        public int MathsOp(string x)
        {
            return Convert.ToInt32(x) * 5; //Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.
        }
    }
}
