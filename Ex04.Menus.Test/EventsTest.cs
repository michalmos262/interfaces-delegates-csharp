using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    public class EventsTest
    {
        public static MainMenu InitMenu()
        {
            MainMenu delegateMenu = new MainMenu("Delegates Main Menu");
            MenuItem versionCapitalMenu = delegateMenu.AddSubItem("Version And Capitals");
            MenuItem countCapitals = versionCapitalMenu.AddSubItem("Count Capitals");
            MenuItem showVersion = versionCapitalMenu.AddSubItem("Show Version");
            MenuItem dateTimeMenu = delegateMenu.AddSubItem("Show Date/Time");
            MenuItem showDate = dateTimeMenu.AddSubItem("Show Date");
            MenuItem showTime = dateTimeMenu.AddSubItem("Show Time");

            showVersion.Selected += showVersion_Select;
            countCapitals.Selected += countCapitals_Select;
            showDate.Selected += showDate_Select;
            showTime.Selected += showTime_Select;

            return delegateMenu;
        }

        private static void showVersion_Select()
        {
            TestMethods.ShowVersion();
        }

        private static void countCapitals_Select()
        {
            TestMethods.CountCapitals();
        }

        private static void showDate_Select()
        {
            TestMethods.ShowDate();
        }

        private static void showTime_Select()
        {
            TestMethods.ShowTime();
        }
    }
}
