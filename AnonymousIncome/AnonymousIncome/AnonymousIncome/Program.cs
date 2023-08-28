using System;

namespace AnonymousIncome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            // get user input info and save it
            Console.WriteLine("Enter Person 1 hourly rate: ");
            int p1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person 1 hours worked per week: ");
            int p1Hours= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person 2 hourly rate: ");
            int p2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person 2 hours worked per week: ");
            int p2Hours = Convert.ToInt32(Console.ReadLine());
            int p1Salary = p1Hours * p1Rate * 4 * 12; // find Person 1 Salary
            Console.WriteLine("Annual salary of Person 1: " + Convert.ToString(p1Salary));
            int p2Salary = p2Hours * p2Rate * 4 * 12; // find Person 2 Salary
            Console.WriteLine("Annual salary of Person 2: " + Convert.ToString(p2Salary));
            Console.WriteLine("Does Person 1 make more money than Person 2? " + Convert.ToString(p1Salary > p2Salary)); // get Person 1 salary is greater than Person 2
        }
    }
}
