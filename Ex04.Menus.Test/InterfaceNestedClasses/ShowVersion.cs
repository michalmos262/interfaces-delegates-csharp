using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.InterfaceNestedClasses
{
    public class ShowVersion : IMenuItemSelectedListener
    {
        private const string k_Title = "Show Version";
        private readonly MenuItem r_MenuItem;

        public ShowVersion(MenuItem i_Parent)
        {
            r_MenuItem = i_Parent.AddSubItem(k_Title);
            r_MenuItem.AddItemSelectedListener(this);
        }

        public void ReportItemSelectedInMenu()
        {
            TestMethods.ShowVersion();
        }
    }
}