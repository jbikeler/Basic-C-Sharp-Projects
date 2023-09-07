using System;

namespace MethodsAndObjs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmp = new Employee(); // instantiate and init an Employee object
            newEmp.FirstName = "Sample";
            newEmp.LastName = "Student";
            newEmp.SayName(); // Call the superclass method SayName()
        }
    }
}
