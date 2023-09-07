using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjs1
{
    class Person // create a class called Person
    {
        // give it two properties each of data type string
        public string FirstName;
        public string LastName;

        public void SayName() // Give this class a void method called SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // write the person's full name to the console
        }
    }
}
