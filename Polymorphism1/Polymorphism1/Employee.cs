using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism1
{
    class Employee : Person, IQuittable // Create another class called Employee and have it inherit from the Person class
    {
        public int Id; // Give the Employee class a property called Id with data type int

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // write the person's full name to the console
        }

        public void Quit()
        {
            Console.WriteLine("Livable wages or I'm outta here!");
        }
    }
}