using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> myEmployees = new List<Employee> // create a list of at least 10 employees
            {
                new Employee{ Id = 0, FirstName = "Joe", LastName = "Smith"},
                new Employee{ Id = 1, FirstName = "Joe", LastName = "Johnson"},
                new Employee{ Id = 2, FirstName = "Ethan", LastName = "Williams"},
                new Employee{ Id = 3,  FirstName = "Sophia", LastName = "Jones"},
                new Employee{ Id = 4, FirstName = "Liam", LastName = "Brown"},
                new Employee{ Id = 5, FirstName = "Ava", LastName = "Davis"},
                new Employee{ Id = 6, FirstName = "Jackson", LastName = "Miller"},
                new Employee{ Id = 7, FirstName = "Olivia", LastName = "Wilson"},
                new Employee{ Id = 8, FirstName = "Mason", LastName = "Moore"},
                new Employee{ Id = 9, FirstName = "Emma", LastName = "Taylor"},
            };

            List<Employee> JoeList = new List<Employee>(); // create new list to hold all the "Joe"s

            foreach (Employee person in myEmployees) // Using a foreach loop, create a new list of all employees with the first name “Joe”
            {
                if (person.FirstName == "Joe")
                {
                    JoeList.Add(person);
                }
            }
            Console.WriteLine("Results from for each (Name == Joe):");
            JoeList.ForEach(item => Console.WriteLine(item.FirstName + " " + item.LastName)); // print results with lambda
            Console.WriteLine("");

            List<Employee> JoeList2 = myEmployees.Where(x => x.FirstName == "Joe").ToList(); //Perform the same for each action again, but this time with a lambda expression

            Console.WriteLine("Results from Lambda (Name == Joe):");
            JoeList2.ForEach(item => Console.WriteLine(item.FirstName + " " + item.LastName)); // print results with lambda
            Console.WriteLine("");

            List<Employee> JoeList3 = myEmployees.Where(x => x.Id > 5).ToList(); //Perform the same for each action again, but this time with a lambda expression

            Console.WriteLine("Results from Lambda (Id > 5):");
            JoeList3.ForEach(item => Console.WriteLine(item.FirstName + " " + item.LastName)); // print results with lambda
            
        }
    }
}
