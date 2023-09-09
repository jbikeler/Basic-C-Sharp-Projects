using System;

namespace Polymorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employer: \nName your demands.");
            Employee myEmployee = new Employee();
            Console.WriteLine("Employee:");
            myEmployee.Quit();
        }
    }
}
