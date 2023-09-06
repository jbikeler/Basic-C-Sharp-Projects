using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    public class MyClass
    {
        public int method1(int number)
        {
            int newInt = number + 2; // add 2 to int
            return newInt;
        }

        public int method1(decimal number)
        {
            int newInt = Convert.ToInt32(number) + 2; // add 2 to decimal after it is converted to an int
            return newInt;
        }

        public int method1(string strNumber)
        {
            int newInt = Convert.ToInt32(strNumber) - 2; // add 2 to string after it is converted to an int
            return newInt;
        }
    }
}
