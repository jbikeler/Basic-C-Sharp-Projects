using System;

namespace Operators1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myFirstEmployee = new Employee(); //instantiate Employee class and assign values to properties
            myFirstEmployee.Id = 0;
            myFirstEmployee.FirstName = "Bob";
            myFirstEmployee.LastName = "Johnson";

            Employee mySecondEmployee = new Employee(); //instantiate second Employee class and assign values to properties
            myFirstEmployee.Id = 1; // make sure id is incremented
            myFirstEmployee.FirstName = "Sue";
            myFirstEmployee.LastName = "Smith";

            Console.WriteLine("Is employee 1 the same as employee 2?");
            Console.WriteLine(myFirstEmployee == mySecondEmployee);  // print to screen if the ids are the same
        }
    }
}
