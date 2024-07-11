using Ex04.Menus.Interfaces;
using Ex04.Menus.Test.InterfaceNestedClasses;

namespace Ex04.Menus.Test
{
    public class InterfacesTest
    {
        public static MainMenu InitMenu()
        {
            MainMenu menu = new MainMenu("Interface Main Menu");
            MenuItem versionAndCapitalsItem = menu.AddSubItem("Version And Capitals");
            MenuItem dateAndTimeItem = menu.AddSubItem("Show Date/Time");
            ShowVersion showVersion = new ShowVersion(versionAndCapitalsItem);
            CountCapitals countCapitals = new CountCapitals(versionAndCapitalsItem);
            ShowTime showTime = new ShowTime(dateAndTimeItem);
            ShowDate showDate = new ShowDate(dateAndTimeItem);

            return menu;
        }
    }
}