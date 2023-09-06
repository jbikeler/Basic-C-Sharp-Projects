using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will use the integer 5."); // inform user of operation
            MyClass myObj = new MyClass(); // instantiate my class
            int result = myObj.method1(5); // call method1 with an int
            Console.WriteLine("5 + 2 is " + result); // print result

            Console.WriteLine("We will use the decimal 5.0m."); // inform user of operation
            result = myObj.method1(5.0m); // call method1 with a decimal
            Console.WriteLine("5.0m + 2 is " + result); // print result

            Console.WriteLine("We will use the string 5."); // inform user of operation
            result = myObj.method1("5"); // call method1 with a string
            Console.WriteLine("'5' - 2 is " + result); // print result
        }
    }
}
