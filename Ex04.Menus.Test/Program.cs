namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu interfaceMenu = InterfacesTest.InitMenu();
            Events.MainMenu eventsMenu = EventsTest.InitMenu();

            interfaceMenu.Show();
            eventsMenu.Show();
        }
    }
}