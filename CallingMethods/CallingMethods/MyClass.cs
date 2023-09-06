using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class MyClass
    {
        public int add2(int number) // methods adds 2 to input and returns result
        {
            int newInt = number + 2;
            return newInt;
        }

        public int sub2(int number) // methods subtracts 2 from input and returns result
        {
            int newInt = number - 2;
            return newInt;
        }

        public int times2(int number) // methods multiplies 2 with input and returns result
        {
            int newInt = number * 2;
            return newInt;
        }
    }
}
