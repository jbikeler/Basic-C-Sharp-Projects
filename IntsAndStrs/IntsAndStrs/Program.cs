using System;
using System.Collections.Generic;

namespace IntsAndStrs
{
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>{5, 168, 659, 89, 56}; // create list of ints
            Console.WriteLine("Choose a dividend.");
            
            try // try to get a dividend from user
            {
                int myDividend = Convert.ToInt32(Console.ReadLine()); // convert str to int
                foreach (int number in intList)
                {
                    int answer = number / myDividend; // cast to float and divide
                    Console.WriteLine(answer); // print answer
                }
            }
            catch(Exception e) // if the try fails get messsge and print to console
            {
                Console.WriteLine(e.Message);
            }
            finally // be sure to let user knokw they are leaving the try/catch block
            {
                Console.WriteLine("We are out of the try/catch.");
            }
        }
    }
}
