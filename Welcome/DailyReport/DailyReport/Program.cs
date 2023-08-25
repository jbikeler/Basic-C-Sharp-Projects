using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report"); //init program
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); //store as string
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine(); //store as string
            Console.WriteLine("What page number?");
            int page = Convert.ToInt16(Console.ReadLine()); //store as int
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            bool help = Convert.ToBoolean(Console.ReadLine()); //store as bool
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string xp = Console.ReadLine(); //store as string
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine(); //store as string
            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt16(Console.ReadLine()); //store as int
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
