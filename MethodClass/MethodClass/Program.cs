using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObj = new MyClass(); // instantiate the class
            myObj.method1(2, 5); // Call the method in the class, passing in two numbers
            myObj.method1(intOne: 2, intTwo: 5); // Call the method in the class, specifying the parameters by name
        }
    }
}
