using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; //set a to 0 by default
            while (a < 5)
            {
                Console.WriteLine("a is: " + a.ToString());
                a++; //if a is less than 5 increment a
            }
            Console.WriteLine("and");
            int b = 0; //set b to 0 by default
            do
            {
                Console.WriteLine("b is: " + b.ToString());
                b++; //if b is less than 10 increment b
            }
            while (b < 10);
        }
    }
}
