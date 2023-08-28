using System;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance Approval Program");
            Console.WriteLine("What is your age?"); 
            int age = Convert.ToInt32(Console.ReadLine()); // get user age info and save it
            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine()); // does user have DUI?
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine()); // get amount of tickets given
            Console.WriteLine("Qualified? ");
            Console.WriteLine(Convert.ToString(age > 15 ^ DUI && tickets <= 3)); // if user age is over 15, they don't have a DUI and they have < 3 tickets then they qualify
        }
    }
}
