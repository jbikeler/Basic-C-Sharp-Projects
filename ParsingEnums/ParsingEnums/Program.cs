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
            EDaysOfWeek myDay;
            try //Wrap statement in a try/catch block
            {
                Console.WriteLine("Please enter the day of the week.\nYour options are:\nMonday\nTuesday\nWednesday\nThursday\nFriday\nSaturday\nSunday"); 
                string userInput = Console.ReadLine(); // Prompt the user to enter the current day of the week
                string[] days = Enum.GetNames(typeof(EDaysOfWeek)); //convert enum to array of strings
                bool bFound = false; //create bool to check if program found entry
                for (int i = 0; i < days.Length; i++)
                {
                    if (days[i] == userInput)
                    {
                        Console.WriteLine("Got it!!");
                        bFound = true;
                        myDay = (EDaysOfWeek)i; // Assign the value to a variable of that enum data type you just created (EDaysOfWeek)
                    }
                }
                if (!bFound)
                {
                    throw new NotImplementedException(); // throw an error
                }
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week."); // print "Please enter an actual day of the week.” to the console if an error occurs
            }
        }
    }
}
