using System;
using System.Collections.Generic;
using System.Text;

namespace Operators1
{
    class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;

        public static bool operator == (Employee emp1, Employee emp2) // overload the “==” operator so it checks if two Employee objects are equal
        {
            if (emp1.Id == emp2.Id) // check if the Ids are equal
            {
                return true; // if they are euqal return true
            }
            else
            {
                return false; // if they are not euqal return false
            }
        }

        public static bool operator != (Employee emp1, Employee emp2) // overload the “!=” operator so it checks if two Employee objects are equal because we need the pair
        {
            if (emp1.Id != emp2.Id)  // check if the Ids not are equal
            {
                return false; // if they are not euqal return false
            }
            else
            {
                return true; // if they are euqal return true
            }
        }
    }
}
