using System;
using System.Collections.Generic;
namespace Console_App_Array_Assignment
{
    internal class Program
    {
        static void Main()
        {
            // Arrays.
            string[] stringArray = { "String 1", "String 2", "String 3", "String 4", "String 5" };
            Console.WriteLine("Select an index from 0 to 4");
            int index1 = Convert.ToInt32(Console.ReadLine());
            if (index1 < 0 || index1 > 4)// index must exist.
            {
                Console.WriteLine("That index does not exist");
                return;
            }
            Console.WriteLine(stringArray[index1]);

            int[] numArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Select an index from 0 to 4");
            int index2 = Convert.ToInt32(Console.ReadLine());
            if (index2 < 0 || index2 > 4)
            {
                Console.WriteLine("That index does not exist");
                return;
            }
            Console.WriteLine(numArray[index2]);

            // List.
            List<string> stringList = new List<string>();
            stringList.Add("String 1");
            stringList.Add("String 2");
            stringList.Add("String 3");
            stringList.Add("String 4");
            stringList.Add("String 5");
            Console.WriteLine("Select an index from 0 to 4");
            int index3 = Convert.ToInt32(Console.ReadLine());
            if (index3 < 0 || index3 >= stringList.Count)// Count method used to account for adding indices.
            {
                Console.WriteLine("That index does not exist");
                return;
            }
            Console.WriteLine(stringList[index3]);
        }
    }
}
