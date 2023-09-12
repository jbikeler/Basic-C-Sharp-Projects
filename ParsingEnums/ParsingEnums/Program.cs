using System;

namespace ParsingEnums
{
    class Program
    {

        public enum EDaysOfWeek // Create an enum for the days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
        static void Main(string[] args)
        {

            try //Wrap statement in a try/catch block
            {
                Console.WriteLine("Please enter the day of the week.\nYour options are:\nMonday\nTuesday\nWednesday\nThursday\nFriday\nSaturday\nSunday"); 
                string userInput = Console.ReadLine(); // Prompt the user to enter the current day of the week
                EDaysOfWeek day = (EDaysOfWeek) Enum.Parse(typeof(EDaysOfWeek), userInput);
                Console.WriteLine($"You chose {day}");
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week."); // print "Please enter an actual day of the week.” to the console if an error occurs
            }
        }
    }
}
