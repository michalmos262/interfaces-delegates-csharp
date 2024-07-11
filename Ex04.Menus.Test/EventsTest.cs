using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    public class EventsTest
    {
        public static MainMenu InitMenu()
        {
            MainMenu menu = new MainMenu("Delegates Main Menu");
            MenuItem versionAndCapitalsItem = menu.AddSubItem("Version And Capitals");
            MenuItem countCapitalsItem = versionAndCapitalsItem.AddSubItem("Count Capitals");
            MenuItem showVersionItem = versionAndCapitalsItem.AddSubItem("Show Version");
            MenuItem dateAndTimeItem = menu.AddSubItem("Show Date/Time");
            MenuItem showDateItem = dateAndTimeItem.AddSubItem("Show Date");
            MenuItem showTimeItem = dateAndTimeItem.AddSubItem("Show Time");

            showVersionItem.Selected += showVersion_Select;
            countCapitalsItem.Selected += countCapitals_Select;
            showDateItem.Selected += showDate_Select;
            showTimeItem.Selected += showTime_Select;

            return menu;
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
