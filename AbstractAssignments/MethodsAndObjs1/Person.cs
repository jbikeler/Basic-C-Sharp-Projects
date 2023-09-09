using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAssignments
{
    public abstract class Person // create an abstract class called Person
    {
        // give it two properties each of data type string
        public string FirstName;
        public string LastName;

        public abstract void SayName(); // Give this class a void method called SayName()

    }
}
