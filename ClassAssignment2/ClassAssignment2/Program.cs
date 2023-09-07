using System;

namespace ClassAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a muber to be divided by 2.");
            int userInput = Convert.ToInt32(Console.ReadLine()); // user enter a number
            MyClass myObj = new MyClass(); // instantiate MyClass class
            int result; // create output var in memory
            myObj.method1(out result, userInput); // call method1 on user number
            Console.WriteLine(userInput + " / 2 = " + result); // Display the output to the screen
            string partOne;
            string partTwo;
            myObj.getStrings(out partOne, out partTwo);
            Console.WriteLine(partOne + " " + partTwo);
            myObj.getStrings(out partOne);
            Console.WriteLine(partOne);
        }
    }
}
