using Ex04.Menus.Interfaces;
using Ex04.Menus.Test.InterfaceNestedClasses;

namespace Ex04.Menus.Test
{
    public class InterfacesTest
    {
        public static MainMenu InitMenu()
        {
            MainMenu menu = new MainMenu("Interface Main Menu");
            MenuItem versionAndCapitalItem = menu.AddSubItem("Version And Capitals");
            MenuItem dateAndTimeItem = menu.AddSubItem("Show Date/Time");
            ShowVersion showVersion = new ShowVersion(versionAndCapitalItem);
            CountCapitals countCapitals = new CountCapitals(versionAndCapitalItem);
            ShowTime showTime = new ShowTime(dateAndTimeItem);
            ShowDate showDate = new ShowDate(dateAndTimeItem);

            return menu;
        }
    }
}