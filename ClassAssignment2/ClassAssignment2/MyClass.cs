using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment2
{
    class MyClass
    {
        public void method1(out int intOne, int userNum) // create a void method that outputs an integer
        {
            intOne = userNum / 2; // user input / 2 will become the output of this function
        }

        public void getStrings(out string strOne, out string strTwo) // Create a method with output parameters
        {
            strOne = "Hey!";
            strTwo = "This is the getStrings method with 2 output parameters.";
        }

        public void getStrings(out string strOne) // Overload a method
        {
            strOne = "This is the getStrings overloaded method.";
        }
    }
}
