using System;

namespace DateTime_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
            Console.WriteLine("Enter in a number of your choosing.");
            TimeSpan userInput = new TimeSpan(Convert.ToInt32(Console.ReadLine()), 0, 0);
            DateTime newDate = rightNow.Add(userInput);
            Console.WriteLine($"{rightNow} + {userInput} hours = {newDate}");
        }
    }
}
