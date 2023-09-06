using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObj = new MyClass();
            Console.WriteLine("What number do you want to modify?"); // ask user for number input
            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine()); // make sure user enters an int
                Console.WriteLine("Thank you for the number.");
                Console.WriteLine(userNum + " + 2 = " + myObj.add2(userNum)); // use obj to add 2
                Console.WriteLine(userNum + " - 2 = " + myObj.sub2(userNum)); // use obj to subtract 2
                Console.WriteLine(userNum + " * 2 = " + myObj.times2(userNum)); // use obj to multiply by 2
            }
            catch (Exception e) // if not an int print error and end program
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
