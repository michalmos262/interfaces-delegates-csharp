using System;
using System.Collections.Generic;


namespace Ex04.Menus.Interfaces
{
    internal class MenuItem
    {
        private readonly string r_Name;
        private readonly MenuItem r_Parent;
        private List<MenuItem> m_SubItems;
        private const char k_GoToParentItemButton = '0';
        private const string k_ItemSymbol = "->";
        private const string k_GoToParentItemMessage = "Back";
        private const string k_ExitMessage = "Exit";

        public MenuItem(string i_Name, MenuItem i_Parent = null)
        {
            r_Name = i_Name;
            if (i_Parent != this)
            {
                r_Parent = i_Parent;
            }
            else
            {
                throw new ArgumentException("Can not make an item a parent of itself");
            }
        }

        public string Name
        {
            get 
            { 
                return r_Name; 
            }
        }

        public void Show()
        {
            string title = r_Parent == null ? r_Name : r_Parent.Name;
            string goToParentMessage = r_Parent == null ? k_ExitMessage : k_GoToParentItemMessage;

            Console.Clear();
            Console.WriteLine(title);
            showSubItemsNames();
            Console.WriteLine(goToParentMessage);
        }

        public void AddSubItem(MenuItem i_SubItem)
        {
            m_SubItems.Add(i_SubItem);
        }

        private void showSubItemsNames()
        {
            for (int i = 0; i < m_SubItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {k_ItemSymbol} {m_SubItems[i].r_Name}");
            }
        }
    }
}
