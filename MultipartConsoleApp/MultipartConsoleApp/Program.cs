using System;
using System.Collections.Generic;

namespace MultipartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1
            // Create a one dimensional array of strings
            string[] oneDim = { "apple", "orange", "kiwi" };
            Console.WriteLine("Type characters to add to the end of strings");
            string endString = Console.ReadLine();
            for (int i = 0; i < oneDim.Length; i++)
            {
                oneDim[i] += endString;
            }
            // Print the updated array
            foreach (string str in oneDim)
            {
                Console.WriteLine(str);
            }

            // Assignment 2
            // Create an infinite loop and fix
            // You can do this with a while loop
            int check = 0;
            while (check < 10) // Ideally this should only occur 10 times printing 0-9
            {
                Console.WriteLine(check);
                check++; // Initially we leave out the increment of 'check' => 'check' is always < 10 therefore causing it to loop instantly. It is fixed by adding this line and allowing 'check' to increment at the end of each code block.
            }

            // Assignment 3
            // loop using < comparison
            check = 0; // reset var check
            while (check < 10) // loop 10 times printing 0-9
            {
                Console.WriteLine(check);
                check++;
            }
            check = 0; // reset var check
            // loop using <= comparison
            while (check <= 10) // loop 11 times printing 0-10
            {
                Console.WriteLine(check);
                check++;
            }

            // Assignment 4
            // List search
            List<string> uniqueList = new List<string> { "apple", "orange", "kiwi", "banana", "lemon" }; //create a list
            Console.WriteLine("Enter text to search for in list."); // ask user for input
            int myIndex = 0; // use int to keep track of index
            bool foundTxt = false; // use bool to check whether or not we found the text
            string searchTxt = Console.ReadLine(); // user input
            foreach (string item in uniqueList) // loop through list items
            {
                if (item.Contains(searchTxt)) // check if each item contains search text. If found break and set foundTxt = true
                {
                    Console.WriteLine("Your index is " + Convert.ToInt32(myIndex));
                    foundTxt = true;
                    break;
                }
                else // if not found increment index
                {
                    myIndex++;
                }
            }
            if (foundTxt == false) // if we did not find the text, let user know
            {
                Console.WriteLine("Your text was not found.");
            }

            // Assignment 5
            // List search part 2
            List<string> repeatList = new List<string> { "apple", "orange", "orange", "banana", "lemon" }; //create a list
            Console.WriteLine("Enter text to search for in list."); // ask user for input
            myIndex = 0; // reset myIndex from Assignment 4
            foundTxt = false; // reset foundTxt from Assignment 4
            string searchTxt2 = Console.ReadLine(); // user input
            foreach (string item in repeatList) // loop through list items
            {
                if (item.Contains(searchTxt2)) // check if each item contains search text. If found break and set foundTxt = true
                {
                    Console.WriteLine("Your index is " + Convert.ToInt32(myIndex));
                    foundTxt = true;
                }
                myIndex++;
            }
            if (foundTxt == false) // if we did not find the text, let user know
            {
                Console.WriteLine("Your text was not found.");
            }

            // Assignment 6
            // List search for duplicates
            List<string> repeatList2 = new List<string> { "apple", "orange", "orange", "banana", "lemon" }; //create a list
            List<string> tempList = new List<string>(); //create a list to hold previous items
            bool foundItem; // set bool to check for found items
            foreach (string item in repeatList2) // loop through list items
            {
                foundItem = false;
                foreach (string str in tempList)
                {
                    if (item == str) // check if each item is previously used. If found print tell user and stop looping.
                    {
                        foundItem = true;
                        break;
                    }
                }
                if(foundItem) // if we found item print duplicate
                {
                    Console.WriteLine(item + "- this item is a duplicate");
                }
                else // if we did not find the item print unique
                {
                    Console.WriteLine(item + "- this item is unique");
                }
                tempList.Add(item); // add item to temp list to keep track of previous items
            }
        }
    }
}
