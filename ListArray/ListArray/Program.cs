using System;
using System.Collections.Generic;

namespace ListArray
{
    class Program
    {
        static void Main()
        {
            
            //Create a one - dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            string[] names = { "sean", "gus", "jules", "carlton", "karen" }; //create array
            Console.WriteLine("Choose a name. (Type 0-4)"); //ask user for input
            int myName = Convert.ToInt32(Console.ReadLine()); //get input
            if (myName < names.Length && myName >= 0) //check input is valid
            {
                Console.WriteLine("Your name is: " + names[myName]); //print name
            }
            else
            {
                Console.WriteLine("Input is not a valid option."); //Add in a message that displays when the user selects an index that doesn’t exist.
            }

            //Create a one - dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] numbers = { 5, 98, 8, 40, 82 }; //create array
            Console.WriteLine("Choose a number. (Type 0-4)"); //ask user for input
            int myNum = Convert.ToInt32(Console.ReadLine()); //get input
            if (myNum < names.Length && myNum >= 0) //check input is valid
            {
                Console.WriteLine("Your number is: " + numbers[myNum]); //print number
            }
            else
            {
                Console.WriteLine("Input is not a valid option."); //Add in a message that displays when the user selects an index that doesn’t exist.
            }

            //Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
            List<string> myList = new List<string>();
            myList.Add("One");
            myList.Add("Two");
            myList.Add("Three");
            myList.Add("Four");
            myList.Add("Five");
            Console.WriteLine("Choose another number. (Type 0-4)"); //ask user for input
            int myInput = Convert.ToInt32(Console.ReadLine()); //get input
            if (myInput < names.Length && myInput >= 0) //check input is valid
            {
                Console.WriteLine("Your number is: " + myList[myInput]); //print string
            }
            else
            {
                Console.WriteLine("Input is not a valid option."); //Add in a message that displays when the user selects an index that doesn’t exist.
            }
        }
    }
}
