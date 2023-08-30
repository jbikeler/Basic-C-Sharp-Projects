using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50) // ask weight
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); 
            }
            else // if package is 50 or under check the dimensions
            {
                Console.WriteLine("What is the width of your package?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of your package?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                int length = Convert.ToInt32(Console.ReadLine());
                if (width > 50 || height > 50 || length > 50) // is package small enough?
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else // if the package is small enough then offer quote
                {
                    float quote = (height * width * length) * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("c2"));
                    Console.WriteLine("Thank You!");
                }
            }
        }
    }
}
