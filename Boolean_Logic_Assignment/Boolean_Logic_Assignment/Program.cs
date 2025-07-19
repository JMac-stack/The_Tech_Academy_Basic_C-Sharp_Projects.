using System;
using System.Reflection.Metadata.Ecma335;

namespace Boolean_Logic_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Car insurance Application Questions.\n");

            int age;
            bool hasDUI;
            int speedTicketNum;
            bool qualified;

            //Question 1 age.
            void questionAge()
            {
                Console.WriteLine("What is your age? Use numerals.");
                try //Only works if numerals used.
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch 
                {
                    questionAge();
                }
            }

            //Question 2 DUI.
            void questionDUI() 
            {
                Console.WriteLine("Have you ever had a DUI? yes/no.");
                string answerDUI = Console.ReadLine();
                if (answerDUI == "yes") //Only takes "yes" or "no".
                {
                    hasDUI = true;
                }
                else if (answerDUI == "no")
                {
                    hasDUI = false;
                }
                else
                {
                    questionDUI();
                }
            }

            //Qustion 3 speeding tickets.
            void questionSpeeding()
            {
                Console.WriteLine("How many speeding tickets do you have? Use numerals.");
                try //Only works if numerals used.
                {
                    speedTicketNum = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    questionSpeeding();
                }
                
            }
            
            void qualificationCheck()//Checks if they can have insurance.
            {
                if (age > 15 && !hasDUI && speedTicketNum <= 3)
                {
                    qualified = true;
                }
                else
                {
                    qualified = false;
                }
            }

            void result()//Prints results.
            {
                Console.WriteLine("What is your age?\n" + age.ToString() + "\nHave you ever had a DUI?\n" + hasDUI.ToString() + "\nHow many speeding tickets do you have?\n" + speedTicketNum.ToString() + "\nQualified?\n" + qualified.ToString());
            }

            void repeatQuestions()
            {
                Console.WriteLine("Repeat questions? yes/no.");
                string repeatAnswer = Console.ReadLine();
                if (repeatAnswer == "yes")
                {
                    Main();
                }
                else if(repeatAnswer == "no")
                {
                    Console.WriteLine("Okay.");
                }
                else
                {
                    repeatQuestions();
                }
            }

            questionAge();
            questionDUI();
            questionSpeeding();
            qualificationCheck();
            result();
            repeatQuestions();




        }
    }
}
