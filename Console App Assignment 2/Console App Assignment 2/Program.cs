using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Console_App_Assignment_2
{
    internal class Program
    {
        static void Main()
        {
            // Console App Assignment Part 1.

            // A one-dimensional array of strings.
            string[] stringArray = { "string 1 + ", "string 2 + ", "string 3 + " };
            // Ask the user to input some text.
            Console.WriteLine("Please enter some text");
            string input1 = Console.ReadLine();
            // A loop that iterates through each string in the array and adds the user's text input to the end of each string.
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += input1;
            }
            // Second loop that prints off each string in the array one at a time.
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // Console App Assignment Part 2

            //An infinite loop.
            bool boolVal = true; // Can be false.
            int counter1 = 0; // Added counter to exit loop.
            while (boolVal) // Made so value can be false.
            {
                counter1++;
                Console.WriteLine(Convert.ToString(counter1));
                if (counter1 >= 5) // Stops loop if counter >= 5.
                {
                    break;
                }
            }

            // Console App Assignment Part 3.

            // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            for (int i = -10; i < 1; i++)
            {
                Console.WriteLine(Convert.ToString(i));
            }
            // Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(Convert.ToString(i));
            }

            // Console App Assignment Part 4.

            // A list of strings where each item in the list is unique.
            List<string> stringList = new List<string>();
            stringList.Add("cat");
            stringList.Add("dog");
            stringList.Add("cow");
            stringList.Add("horse");
            // Ask the user to input text to search for in the list.
            Console.WriteLine("Enter the name of an animal");
            string input2 = Console.ReadLine();
            // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            int counter2 = 0;
            bool indexFound = false;
            foreach (string str in stringList)
            {
                if (str == input2)
                {
                    Console.WriteLine("The index is " + Convert.ToString(counter2) + " in stringList.");
                    indexFound = true;
                    break; // Add code that stops the loop from executing once a match has been found.
                }
                counter2++;
            }
            if (!indexFound) // Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
            {
                Console.WriteLine("Animal not found");
            }

            // Console App Assignment Part 5.

            // A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            stringList.Add("cow"); // Uses first list.
            Console.WriteLine("Enter the name of an animal.");
            string input3 = Console.ReadLine();
            // Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
            int counter3 = 0;
            indexFound = false;
            foreach (string str in stringList)
            {
                if (str == input3)
                {
                    Console.WriteLine("Your animal is at index " + Convert.ToString(counter3));
                    indexFound = true;
                }
                counter3++;
            }
            if (!indexFound) // Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
            {
                Console.WriteLine("Animal not found");
            }

            // Console App Assignment Part 6.

            // Create a list of strings that has at least two identical strings in the list.
            List<string> stringList2 = new List<string>();
            stringList2.Add("A");
            stringList2.Add("A");
            stringList2.Add("B");
            stringList2.Add("C");
            stringList2.Add("D");
            // Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            bool stringMatch; // For checking if strings match. 
            int indexString; // Used so an index is not checked with itself.
            foreach (string str in stringList2)
            {
                stringMatch = false; // A string has not been matched, default.
                indexString = stringList2.IndexOf(str); // Gets index of current string.

                for (int i = 0; i < stringList2.Count; i++)
                {
                    if ((str == stringList2[i]) && (indexString != i)) // If the strings match and they are not the same index.
                    {
                        stringMatch = true; // A match is found.
                    }
                }

                if (stringMatch == true)
                {
                    Console.WriteLine(str + " - this item is a duplicate."); // If a match is found.
                }
                else
                {
                    Console.WriteLine(str + " - this item is unique."); // If no match is found.
                }
            }
        }
    }
}
