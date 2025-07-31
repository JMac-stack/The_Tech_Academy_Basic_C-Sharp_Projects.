using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Responses to questions are stored in the appropriate data type.
            Console.WriteLine("Academy of Learning Career College \nStudent Daily Report \nWhat is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string studentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int studentPageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool studentNeedHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string studentPosExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide ? Please be specific.");
            string studentFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studentHoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly.Have a great day!");
        }
    }
}
