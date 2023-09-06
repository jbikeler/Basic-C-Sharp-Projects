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

            // Method Assignment - Making an optional parameter
            Console.WriteLine("Enter in a number.");
            int userNum1 = Convert.ToInt32(Console.ReadLine()); // get first number form user and convert to int
            Console.WriteLine("Enter another number. (If you do not want to enter another number, hit enter.)");
            string userNum2 = Console.ReadLine(); // get second number if entered but leave it as a string
            if (userNum2 != "") // if it's not an empty string
            {
                result = myObj.method2(userNum1, Convert.ToInt32(userNum2)); // convert it to an int
                Console.WriteLine(userNum1 + " * " + userNum2 + " = " + result); // print result
            }
            else // if the string is empty
            {
                result = myObj.method2(userNum1); // use default second number which is 1
                Console.WriteLine(userNum1 + " * " + "1(default)" + " = " + result); // print result
            }
        }
    }
}
