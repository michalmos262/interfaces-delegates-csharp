using System;

namespace Ex04.Menus.Test
{
    public class TestMethods
    {
        public static void ShowVersion()
        {
            Console.WriteLine("Version: 24.2.4.9504");
        }

        public static void CountCapitals()
        {
            Console.WriteLine("Please enter a sentence:");
            string input = Console.ReadLine();
            int capitalCount = 0;
            
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    capitalCount++;
                }
            }

            if (capitalCount == 1)
            {
                Console.WriteLine("There is 1 capital letter in your sentence.");
            }
            else
            {
                Console.WriteLine($"There are {capitalCount} capital letters in your sentence.");
            }
        }

        public static void ShowTime()
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            Console.WriteLine($"The current time is: {currentTime}");
        }

        public static void ShowDate()
        {
            string currentDate = DateTime.UtcNow.ToString("yyyy-MM-dd");

            Console.WriteLine($"The current date is: {currentDate}");
        }
    }
}