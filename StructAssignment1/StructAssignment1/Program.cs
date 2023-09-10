using System;

namespace StructAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNum = new Number();
            Console.WriteLine(myNum.Amount);
        }

        public struct Number
        {
            public decimal Amount;
        }
    }
}
