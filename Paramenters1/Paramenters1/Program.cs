using System;
using System.Collections.Generic;

namespace Paramenters1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> intEmployee = new Employee<string>(); // Instantiate an Employee object with type “string”
            intEmployee.things = new List<string>() {"one", "two", "three"};
            foreach (string item in intEmployee.things) //print strings in List
            {
                Console.WriteLine(item);
            }
            
            Employee<int> StrEmployee = new Employee<int>(); // Instantiate new Employee object with type “int”
            StrEmployee.things = new List<int>() {1, 2, 3};
            foreach (int item in StrEmployee.things) //print ints in List
            {
                Console.WriteLine(item);
            }
        }
    }
}
