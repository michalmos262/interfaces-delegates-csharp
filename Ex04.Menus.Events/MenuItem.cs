using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private readonly string r_Title;
        private readonly MenuItem r_Parent;
        private readonly List<MenuItem> r_SubItems = new List<MenuItem>();
        public event Action Selected;
        private const char k_ExitButton = '0';
        private const string k_ItemSymbol = "->";
        private const string k_LineSeparator = "----------------------";

        public MenuItem(string iTitle, MenuItem i_Parent = null)
        {
            r_Title = iTitle;
            if (i_Parent != this)
            {
                r_Parent = i_Parent;
            }
            else
            {
                throw new ArgumentException("Can not make an item a parent of itself");
            }
        }

        public int SubItemsCount
        {
            get
            {
                return r_SubItems.Count;
            }
        }

        public char ExitButton
        {
            get
            {
                return k_ExitButton;
            }
        }

        public MenuItem Parent
        {
            get
            {
                return r_Parent;
            }
        }

        private void printMenu(string i_ExitMessage)
        {
            Console.WriteLine($"**{r_Title}**");
            Console.WriteLine(k_LineSeparator);
            for (int i = 0; i < r_SubItems.Count; i++)
            {
                Console.WriteLine($"{i + 1} {k_ItemSymbol} {r_SubItems[i].r_Title}");
            }

            Console.WriteLine($"{k_ExitButton} {k_ItemSymbol} {i_ExitMessage}");
            Console.WriteLine(k_LineSeparator);
            Console.WriteLine("Please enter menu option (1 to {0} or press '{1}' to {2}):",
                r_SubItems.Count, k_ExitButton, i_ExitMessage);
        }

        public void Show(string i_ExitMenu)
        {
            Console.Clear();
            if (r_SubItems.Count > 0)
            {
                printMenu(i_ExitMenu);
            }
        }

        public MenuItem AddSubItem(string i_SubItemTitle)
        {
            MenuItem subItem = new MenuItem(i_SubItemTitle, this);
            r_SubItems.Add(subItem);

            return subItem;
        }

        protected virtual void OnSelected()
        {
            Selected?.Invoke();
        }

        public MenuItem GetSubItemByIndex(int i_SubItemIndex)
        {
            return r_SubItems[i_SubItemIndex];
        }

        public void SelectItem()
        {
            Console.Clear();
            OnSelected();
            Console.WriteLine("Please enter any key to go back to menu...");
            Console.ReadKey();
        }
    }
}