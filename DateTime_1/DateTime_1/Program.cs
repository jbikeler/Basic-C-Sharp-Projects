using System;

namespace DateTime_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now; // Create an object to date time with the value of now 
            Console.WriteLine(rightNow); // Print that to the user 
            Console.WriteLine("Enter in a number of your choosing. This number will represent hours."); // Ask the user to choose an amount of hours 
            TimeSpan userInput = new TimeSpan(Convert.ToInt32(Console.ReadLine()), 0, 0); // Convert the users input to a timespan object 
            DateTime newDate = rightNow.Add(userInput); // Add the users input to the current date 
            Console.WriteLine($"{rightNow} + {userInput} hours = {newDate}"); // Print the results for the user to see 
        }
    }
}
