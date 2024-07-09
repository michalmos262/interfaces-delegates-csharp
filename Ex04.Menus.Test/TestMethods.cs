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
            //TODO - count capitals
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